using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Enum_Ornek2
{
    public static class SanalDatabase
    {
        static ArrayList db=new ArrayList();
        public static CustomerRetunValue CustomerAdd(Customer customer)
        {
            //kontoller yapılcak
            db.Add(customer);
            return CustomerRetunValue.KayıtBaşarılı;
        }
    }
}
