using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class LogicLayerClass
    {
        public void InsertProduct(string productName, int quantity, decimal price, decimal stock)
        {
            DataLayerClass dl =  new DataLayerClass();
            dl.InsertProduct(productName,quantity,price,stock);
            Console.WriteLine("");
        }
        public void UpdateProduct(string productName, int quantity,decimal price,decimal stock)
        {
            DataLayerClass dl = new DataLayerClass();
            dl.UpdateProduct(productName,quantity,price,stock);
        }
        public void DeleteProduct(string productName)
        {
            DataLayerClass dl = new DataLayerClass();
            dl.DeleteProduct(productName);
        }
        public DataTable DisplayOnGrid()
        {
            DataLayerClass dl = new DataLayerClass();
           return dl.ShowGrid();
        }
    
    }
}
