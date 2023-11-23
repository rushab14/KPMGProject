using Microsoft.AspNetCore.Mvc;
using ProjectBL;
using ProjectDAL;
using System.ComponentModel.DataAnnotations;

namespace ProjectWeb.Models
{

    public class OwnerOperations
    {
        static List<Owner> owners = new List<Owner>();
        
           

        public static List<Owner> GetPeople()
        {
            return OwnerCrud.Get();
        }

        public static void CreateOwner(Owner o)
        {

            OwnerCrud.Add(o.FlatNumber, o.Name, o.PhoneNumber);
            
        }
        public static bool DeleteOwner(int flatId)
        {
            
                var found = GetPeople().Where(p => p.FlatNumber == flatId).FirstOrDefault();
                if (found != null)
                {
                    GetPeople().Remove(found);
                     return true;
                }
                else
                    throw new Exception("No owner found with flat id");
            
        }
    }
    
}
