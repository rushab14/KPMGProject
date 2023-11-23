using ProjectBL;
using ProjectDAL;
using System.ComponentModel.DataAnnotations;

namespace ProjectWeb.Models
{
    
    public class FacilityOperations{

        static List<Facility> facilities = new List<Facility>();



    public static List<Facility> GetFacilities()
    {
        return FacilityCrud.Get();
    }

    public static void CreateFacility(Facility f)
    {

        FacilityCrud.Add(f.FacilityId,f.isAvailable, f.FacilityName);

    }
        public static bool DeleteFacility(int FId)
        {

            var found = GetFacilities().Where(p => p.FacilityId == FId).FirstOrDefault();
            if (found != null)
            {
                GetFacilities().Remove(found);
                return true;
            }
            else
                throw new Exception("No Facility is found with this Id");


        }
    }
}

