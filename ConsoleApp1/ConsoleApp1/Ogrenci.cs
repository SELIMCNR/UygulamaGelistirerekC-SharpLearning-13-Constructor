using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

   public class Ogrenci
    {
        string bilgi;

       public string yazdir
        {
            get { return bilgi; }
            set { bilgi = value; }
        }

        public Ogrenci(string bilgi)
        {
            bilgi = "";
        
        }
       
    

        
    }
}
