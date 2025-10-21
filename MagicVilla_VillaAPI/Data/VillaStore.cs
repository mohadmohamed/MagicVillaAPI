using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO { Id = 1, Name = "Pool View" , Occupancy=100, Sqft = 2},
            new VillaDTO { Id = 2, Name = "Beach View", Sqft=3 , Occupancy=200},
       
        };
    }
}
