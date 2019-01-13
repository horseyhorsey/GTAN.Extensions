using GTAN.Data;
using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GTAN.Extensions
{
    public static class ClientExtensions
    {
        static int maxChatItemLength = 6;

        /// <summary>
        /// Changes the multiplayer outfit for the player
        /// </summary>
        /// <param name="client"></param>
        /// <param name="outfitId"></param>
        /// <param name="male"></param>
        public static void ChangeOutfit(this Client client, int outfitId, bool male = true)
        {
            OutfitValues outFit = null;
            if (!male)
                outFit = MpOutFitDicts.FemaleOutfits[outfitId];
            else
                outFit = MpOutFitDicts.MaleOutfits[outfitId];

            //set clothes
            for (int i = 0; i < outFit.ComponentDrawables.Count; i++)
            {
                client.SetClothes(i, outFit.ComponentDrawables[i], outFit.ComponentTextures[i]);
            }
            //set props
            for (int i = 0; i < outFit.PropIndices.Count; i++)
            {
                client.SetAccessories(i, outFit.PropTextures[i], outFit.PropTextures[i]);
            }
            //Set tattoos
            for (int i = 0; i < outFit.TattooHashes.Count; i++)
            {
                client.SetDecoration(new Decoration() { Overlay = (uint)outFit.TattooHashes[i] });
            }
        }

        /// <summary>
        /// Moves the player to an interior. Requests the IPL if not loaded.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="iplName"></param>
        public static void MoveToInterior(this Client client, string iplName)
        {
            if (Interiors.InteriorsIPL.ContainsKey(iplName))
            {
                try
                {
                    Interior dictInterior = Interiors.InteriorsIPL[iplName];

                    if (PoolsExtensions.LoadedIpls.Contains(dictInterior))
                    {
                        client.Position = dictInterior.Position;
                    }
                    else // Load interior
                    {
                        NAPI.Task.Run(() =>
                        {                            
                            NAPI.World.RequestIpl(dictInterior.IplName);
                            PoolsExtensions.LoadedIpls.Add(dictInterior);
                            client.Position = dictInterior.Position;
                        }, 500);
                    }
                    
                }
                catch (Exception ex)
                {
                    ex.Data.Add("Move To Interior", ex);
                    throw;
                }
            }
            else
            {
                throw new NullReferenceException($"No IPL found for {iplName}");
            }
        }

        /// <summary>
        /// Moves the player to an interior without needed to load a IPL. Requests the IPL if not loaded.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="iplName"></param>
        public static void MoveToInteriorNoIpl(this Client client, string iplName)
        {
            if (Interiors.InteriorsNoIPL.ContainsKey(iplName))
            {
                try
                {
                    Interior dictInterior = Interiors.InteriorsNoIPL[iplName];

                    //Add to pools if not there
                    if (!PoolsExtensions.LoadedIpls.Contains(dictInterior))
                    {                    
                        PoolsExtensions.LoadedIpls.Add(dictInterior);
                    }

                    client.Position = dictInterior.Position;
                }
                catch (Exception ex)
                {
                    ex.Data.Add("Move To InteriorNoIpl", ex);
                    throw;
                }
            }
            else
            {
                throw new NullReferenceException($"No IPL found for {iplName}");
            }
        }

        /// <summary>
        /// Moves the player to an interior that needs to load multiple IPLs.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="iplName"></param>
        public static void MoveToInteriorMultiIpl(this Client client, string iplName)
        {
            if (Interiors.InteriorsIPL.ContainsKey(iplName))
            {
                try
                {
                    MultiInterior dictInterior = Interiors.InteriorsMulti[iplName];

                    if (!PoolsExtensions.LoadedMultiIpls.Contains(dictInterior))
                    {                        
                        NAPI.Task.Run(() =>
                        {
                            for (int i = 0; i < dictInterior.Ipls.Length; i++)
                            {                                
                                NAPI.World.RequestIpl(dictInterior.Ipls[i]);
                                PoolsExtensions.LoadedMultiIpls.Add(dictInterior);
                            }

                        }, 500);
                    }

                }
                catch (Exception ex)
                {
                    ex.Data.Add("Move To Interior MultiIpl", ex);
                    throw;
                }
            }
            else
            {
                throw new NullReferenceException($"No IPL found for {iplName}");
            }
        }

        /// <summary>
        /// Sends a chat message to the player from a list of strings. Used to make the chat fit on one line when printing commands, vehicles etc
        /// </summary>
        /// <param name="client">Who to send chat to</param>
        /// <param name="values">array of values to print</param>
        /// <param name="maxItemLength">Condense items to make sure sentance fits in default chat</param>
        public static void SendChatMessage(this Client client, IEnumerable<string> items, int maxItemLength = 5)
        {
            maxChatItemLength = maxItemLength;
            string msg = string.Empty;
            int i = 0;
            int cnt = 0;
            int itemCount = items.Count();            
            foreach (var value in items)
            {
                msg += $"{value}|";
                if (i == maxChatItemLength)
                {
                    client.SendChatMessage($"~y~{msg}");
                    msg = string.Empty;
                    i = 0;
                }

                i++;
                cnt++;

                if (cnt == itemCount)
                    client.SendChatMessage($"~y~{msg}");
            }
        }
    }
}
