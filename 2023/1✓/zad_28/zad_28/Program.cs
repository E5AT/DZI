using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_28
{
    abstract class Furniture
    {
        private string typeProduct;
        private double productionPrice;

        public string TypeProduct
        {
            get { return typeProduct; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Type product empty or null");
                else typeProduct = value;
            }
        }

        public double ProductionPrice
        {
            get { return productionPrice; }
            set
            {
                if (value > 0) productionPrice = value;
                else throw new Exception("Price must be greater than 0");
            }
        }
        public abstract double PriceClient();

        public Furniture(string typeProduct, double productionPrice)
        {
            this.typeProduct = typeProduct;
            this.productionPrice = productionPrice;
        }
    }

    class Table : Furniture
    {
        public override double PriceClient()
        {
            return ProductionPrice + (ProductionPrice * 0.2);
        }

        public override string ToString()
        {
            return $"The table costs {PriceClient():f2} lv";
        }

        public Table(string typeProduct, double productionPrice) : base(typeProduct, productionPrice) { }
    }

    class Cabinet : Furniture
    {
        private int numberOfHinges;

        public override double PriceClient()
        {
            return ProductionPrice + (ProductionPrice * 0.15) + (4.50 * numberOfHinges);
        }

        public override string ToString()
        {
            return $"The cabinet costs {PriceClient():f2} lv.";
        }

        public Cabinet(string typeProduct, double productionPrice, int numberOfHinges) : base(typeProduct, productionPrice)
        {
            this.numberOfHinges = numberOfHinges;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitures = new List<Furniture>();
            while (true)
            {

                string answer = Console.ReadLine();
                if (answer == "END") break;
                else
                {
                    string[] answerElements = answer.Split(' ');
                    if (answerElements.Length == 2)
                        furnitures.Add(new Table(answerElements[0], double.Parse(answerElements[1])));
                    else furnitures.Add(new Cabinet(answerElements[0], double.Parse(answerElements[1]), int.Parse(answerElements[2])));
                }
            }

            Console.WriteLine("All tables:");
            foreach(Furniture furniture in furnitures)
            {
                if(furniture is Table)
                    Console.WriteLine(furniture.ToString());
            }

            Console.WriteLine("All cabines:");
            foreach (Furniture furniture in furnitures)
            {
                if (furniture is Cabinet)
                    Console.WriteLine(furniture.ToString());
            }
        }
    }
}
