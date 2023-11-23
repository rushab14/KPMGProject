using ProjectDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBL
{
    public class FacilityCrud
    {
        static ProjectDBContext dBContext = new ProjectDBContext();
        public static void Add(int Fid, bool Favail, string FName)
        {
            dBContext.Facilities.Add(new Facility()
            {
                FacilityId = Fid ,
                isAvailable = Favail,
                FacilityName = FName 
                 

            });;
            dBContext.SaveChanges();
        }
        public static void Update(string Fname, bool Favail)
        {
            var toBeUpdated = dBContext.Facilities.ToList()
       .Where(o => o.FacilityName == Fname)
       .FirstOrDefault();
            toBeUpdated.isAvailable = Favail ;
           
            dBContext.SaveChanges();
        }

        public static void Delete(string Fname, string tbdelted)
        {
            var toBedeletedd = dBContext.Facilities.ToList()
        .Where(Facility => Facility.FacilityName == Fname)
        .FirstOrDefault();
            dBContext.Facilities.Remove(toBedeletedd);
            dBContext.SaveChanges();

        }
        public static List<Facility> Get()
        {

            return dBContext.Facilities.ToList();
        }
        public static Facility? SearchOne(string pname)
        {


            var result = dBContext.Facilities
                    .ToList()
                    .Where(p => p.FacilityName == pname)
                    .FirstOrDefault();

            return result;
        }



    }
}
    

