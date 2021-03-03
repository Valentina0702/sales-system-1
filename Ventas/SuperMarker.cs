using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    class SuperMarker
    {
        SellerWoman[] SellersWoman = new SellerWoman[20];
        int sellerCount = 0;

        Product[] Products = new Product[20];
        int productCount = 0;

        Sale[] Sales = new Sale[20];
        int saleCount = 0;

        public void AddSellerWoman(SellerWoman newSellerWoman)
        {
            SellersWoman[sellerCount] = newSellerWoman;
            sellerCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }

        public void AddSale(Sale newSale)
        {
            Sales[saleCount] = newSale;
            saleCount++;
        }

        //More economical product

        public void saleCheapest()
        {
            int salevaluetemp = this.Sales[0].value;
            string salenametemp = this.Sales[0].SellerWoman;

            for (int i = 0; i < this.Sales.Length; i++)
            {
                if (this.Sales[i] != null)
                {
                    if (this.Sales[i].value < salevaluetemp)
                    {
                        salevaluetemp = this.Sales[i].value;
                        salenametemp = this.Sales[i].SellerWoman;
                    }
                }
            }

            Console.WriteLine("the seller who sold the cheapest product was " + salenametemp);

        }

        // Average value of products

        public void averageValue()
        {
            int sumaryvaluetemp = 0;
            int amountvaluetemp = 0;

            for (int i = 0; i < this.Products.Length; i++)
            {
                if (this.Products[i] != null)
                {
                    sumaryvaluetemp = sumaryvaluetemp + this.Products[i].Cost;
                    amountvaluetemp++;

                }
            }

            Console.WriteLine("the average price is " + (sumaryvaluetemp / amountvaluetemp));
        }

        // Number of units
        public void productUnit(string nameProduct)
        {
            int countTemp = 0;

            for (int i = 0; i < this.Sales.Length; i++)
            {
                if (this.Sales[i] != null)
                {
                    if (this.Sales[i].Product == nameProduct)
                    {
                        countTemp++;

                    }
                }
            }

            Console.WriteLine("the product " + nameProduct + " has been sold " + countTemp);
        }

        public void expensiveProduct()
        {
            int productvaluetemp = this.Products[0].Cost;
            string productnametemp = this.Products[0].Name;

            for (int i = 0; i < this.Products.Length; i++)
            {
                if (this.Products[i] != null)
                {
                    if (this.Products[i].Cost > productvaluetemp)
                    {
                        productvaluetemp = this.Products[i].Cost;
                        productnametemp = this.Products[i].Name;
                    }
                }
            }

            Console.WriteLine("the most expensive product was " + productnametemp + " worth " + productvaluetemp);

        }
    }
}
