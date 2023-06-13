using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_PersistentData__CSVs
{
    public class Wallet
    {
        //fields
        public string color;
        public int width;
        public int height;
        public int numberOfPockets;
        public int numberOfZippers;
        public string logo;
        public string name;
        public string material;
        public string style;

        //properties
        public string Color { get => color; set => color = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public int NumberOfPockets { get => numberOfPockets; set => numberOfPockets = value; }
        public int NumberOfZippers { get => numberOfZippers; set => numberOfZippers = value; }
        public string Logo { get => logo; set => logo = value; }
        public string Name { get => name; set => name = value; }
        public string Material { get => material; set => material = value; }
        public string Style { get => style; set => style = value; }

        //default constructor
        public Wallet()
        {

        }

        //constructor
        public Wallet(string color, int width, int height, int numberOfPockets, int numberOfZippers, string logo, string name, string material, string style)
        {
            this.Color = color;
            this.Width = width;
            this.Height = height;
            this.NumberOfPockets = numberOfPockets;
            this.NumberOfZippers = numberOfZippers;
            this.Logo = logo;
            this.Name = name;
            this.Material = material;
            this.Style = style;
        }

        //override to string
        public override string ToString()
        {
            return $"A {Color} wallet with dimensions {Width} (width) X {Height} (height) " +
                $"and {NumberOfPockets} pockets and {NumberOfZippers} zippers. \n" +
                $"{Name} brand with {Logo} logo, made of {Material}, in {Style} style.\n";
        }
    }
}
