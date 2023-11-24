using ProjectDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBL
{
  
    
        public class OwnerCrud
        {
            static ProjectDBContext dBContext = new ProjectDBContext();
            public static void Add(int fNumber ,string pName, string pNo)
            {
              dBContext.FlatOwner.Add(new Owner() {
                FlatNumber = fNumber, 
                Name =pName ,
                PhoneNumber= pNo
            
            }); 
            dBContext.SaveChanges();
            }
            public static void Update(string pname, string upName ,string pNo)
            {
                var toBeUpdated = dBContext.FlatOwner.ToList()
           .Where( o=> o.Name == pname)
           .FirstOrDefault();
                toBeUpdated.Name = upName;
            toBeUpdated.PhoneNumber = pNo;
                dBContext.SaveChanges();
            }

            public static void Delete(string pname, string tbdelted)
            {
                var toBedeletedd = dBContext.FlatOwner.ToList()
            .Where(parent => parent.Name == pname)
            .FirstOrDefault();
                dBContext.FlatOwner.Remove(toBedeletedd);
                dBContext.SaveChanges();

            }
            public static List<Owner> Get()
            {

                return dBContext.FlatOwner.ToList() ;
            }
        public static Owner? SearchOne(string pname)
        {


            var result = dBContext.FlatOwner
                    .ToList()
                    .Where(p => p.Name == pname)
                    .FirstOrDefault();

            return result;
        }


        }
    }


