using Microsoft.Build.Tasks;
using System.Collections.Generic;

namespace ShoppingLibrary
{
    public class DataAccess
    {
        interface IProductDetails
        {
            string ProductNameAndPrice();
            
        }
        class FirstProduct : IProductDetails
        {
           public string ProductNameAndPrice()
            {
                return "Soroci BB Cream 30ML" + "26.99";
            }
           
        }

        class SecondProduct : IProductDetails
        {
            public string ProductNameAndPrice()
            {
                return "Thank You Farmer CC Cream 40ML" + "30.99";
            }

        }
        class ThrdProduct : IProductDetails
        {
            public string ProductNameAndPrice()
            {
                return "Thank you Farmer Primer 40ML" + "25.99";
            }

        }
        class FourProduct : IProductDetails
        {
            public string ProductNameAndPrice()
            {
                return "Thank you Farmer BB Cream 40ML" + "27.99";
            }

        }

        static class Factory
        {
            /// <summary>
            /// This is the Factory method
            /// </summary>
            public static IProductDetails Get(int id)
            {
                switch (id)
                {
                    case 0:
                        return new FirstProduct();
                    case 1:
                        return new SecondProduct();
                    case 2:
                        return new ThrdProduct();
                    case 3:
                        return new FourProduct();
                    default:
                        return null;
                }
            }

        }
    }
}
  
