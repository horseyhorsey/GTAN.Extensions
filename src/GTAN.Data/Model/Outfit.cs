using System.Collections.Generic;

namespace GTAN.Data
{
    /// <summary>
    /// For deserializing json outfits
    /// </summary>
    public class MpOutfit
    {
        public List<OutfitValues> OutFits { get; set; }
    }

    public class OutfitValues
    {
        public List<int> ComponentDrawables { get; set; }
        public List<int> ComponentTextures { get; set; }
        public List<int> PropIndices { get; set; }
        public List<int> PropTextures { get; set; }
        public List<int> TattooHashes { get; set; }
    }
}
