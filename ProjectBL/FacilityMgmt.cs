using ProjectDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBL
{
    public  class FacilityMgmt
    {
        static  ProjectDBContext dBContext = new ProjectDBContext();

        public static void BookFacility(string FacName ,int flatId)
        {
            // dBContext.Facilities.ToList()
            //     .ForEach((fac =>
            //     {
            //         var avail = fac.isAvailable && fac.FacilityName == FacName;
            //         if (avail)

            //         {
            //             var fac1 = dBContext.Facilities.Where(f => f.FacilityName == FacName).FirstOrDefault();
            //             var booker = dBContext.FlatOwner.ToList()
            //             .Where(owner => owner.FlatNumber == flatId).FirstOrDefault();

            //             fac.isAvailable = false;
            //             //booker.facilities.Add(fac1);
            //             dBContext.SaveChanges();

            //         }
            //         else

            //             throw new Exception("Cant book");

            //     }

            //));


            //return true;
            var facility = dBContext.Facilities.Where(f => f.isAvailable && f.FacilityName == FacName).FirstOrDefault();
            var booker = dBContext.FlatOwner.Where(o => o.FlatNumber == flatId).FirstOrDefault();
            if (facility != null)
            {
                facility.isAvailable = false;
                booker.facilities = facility.FacilityName;
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("hello");
            }
        }

        public static void FreeFacility(string FacName, int flatId)
        {
            var facility = dBContext.Facilities.Where(f => f.isAvailable && f.FacilityName == FacName).FirstOrDefault();
            var booker = dBContext.FlatOwner.Where(o => o.FlatNumber == flatId).FirstOrDefault();
            if (facility != null)
            {
                facility.isAvailable = true;
                booker.facilities = null;
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("hello");
            }
        }
    }
}
