using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public static class TotalAmount
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }


      

        public static double TotalPriceOfaProduct(double x, double y)
        {
            return x * y;
        }
        public static bool TotalAmountBigger(double x)
        {
            
            if (x> 10)
            {
                
                return true;
               
            }
            else
                return false;
            
        }
       public static double RemoveItem(double x, double y)
        {
            return x - y;
        }

        public static decimal DicountCalc(decimal x, decimal y)
        {
            decimal a = x;
            decimal t;
            t = y / 100;
            decimal z = t * a;

            return x - z;
        }

    }
    }

