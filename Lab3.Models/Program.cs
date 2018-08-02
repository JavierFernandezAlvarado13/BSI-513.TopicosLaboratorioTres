using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            var contex = new AdventureWorks2012Entities();
            Address NewAddress = new Address()
            {
                AddressLine1 = "",
                City = "Home",
                StateProvinceID = 10,
                PostalCode = "",
                ModifiedDate = DateTime.Now,
                rowguid = Guid.NewGuid()
        };
            contex.Addresses.Add(NewAddress);
            contex.SaveChanges();
        }
    }
}
