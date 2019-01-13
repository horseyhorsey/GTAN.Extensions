using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace GTAN.Data
{    
    /// <summary>
    /// The dictionaries in this static class are created when instantiated. Json should be in bridge folder
    /// </summary>
    public static class MpOutFitDicts
    {
        static MpOutFitDicts()
        {
            MaleOutfits = new Dictionary<int, OutfitValues>();
            FemaleOutfits = new Dictionary<int, OutfitValues>();
            using (var stringReader = File.OpenText("bridge//male_mp_outfits.json"))
            {
                var rootObject = JsonConvert.DeserializeObject<MpOutfit>(stringReader.ReadToEnd());
                for (int i = 0; i < rootObject.OutFits.Count; i++)
                {
                    MaleOutfits.Add(i, rootObject.OutFits[i]);
                }
            }

            using (var stringReader = File.OpenText("bridge//female_mp_outfits.json"))
            {
                var rootObject = JsonConvert.DeserializeObject<MpOutfit>(stringReader.ReadToEnd());
                for (int i = 0; i < rootObject.OutFits.Count; i++)
                {
                    FemaleOutfits.Add(i, rootObject.OutFits[i]);
                }
            }
        }

        public static Dictionary<int, OutfitValues> MaleOutfits { get; private set; }
        public static Dictionary<int, OutfitValues> FemaleOutfits { get; private set; }
    }
}
