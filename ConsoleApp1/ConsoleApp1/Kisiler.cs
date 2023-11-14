using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kisiler
    {

        
            public void kisilistesi(string adsoyad, int yaş, string meslek)
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine(adsoyad + yaş + meslek);
                }

            }
        }
    }

