using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication
{
    class Shop
    {
       public string shopName;

       public string shopAddress;

       private string forBox = "";

       public Dictionary<string,int> productDictionary = new Dictionary<string, int>();


        public void InsertProduct(string productName, int productQuantity)
        {
            foreach (KeyValuePair<string, int> keyValuePair in productDictionary)
            {
                productDictionary.Add(keyValuePair.Key,keyValuePair.Value);
            }
   
            
        }

        public string ShowProduct()
        {
            foreach (KeyValuePair<string, int> keyValuePair in productDictionary)
            {
                forBox = keyValuePair.Key + " - " + keyValuePair.Value;
            }
            return forBox;
        }


    }
}
