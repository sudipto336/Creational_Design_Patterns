using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Burger_YT
{
    internal class Burger
    {
        public string Size { get; }
        public bool Mayonese { get; }
        public bool ExtraCheese { get; }
        public bool Sauce { get; }
        public bool Lettuce { get; }
        public bool Onion { get; }

        private Burger(BurgerBuilder builder)
        {
            this.Onion = builder.GetOnion();
            this.Lettuce = builder.GetLettuce();
            this.Sauce = builder.GetSauce();
            this.Onion = builder.GetOnion();
            this.Size = builder.GetSize();
            this.ExtraCheese = builder.GetExtraCheese();
        }

        internal class BurgerBuilder
        {
            private string size;
            private bool mayonese;
            private bool extraCheese;
            private bool sauce;
            private bool lettuce;
            private bool onion;

            public BurgerBuilder SetSize(string size)
            {
                this.size = size;
                return this;
            }

            public BurgerBuilder SetMayonese(bool mayonese)
            {
                this.mayonese = mayonese;
                return this;
            }

            public BurgerBuilder SetExtraCheese(bool extraCheese)
            {
                this.extraCheese = extraCheese;
                return this;
            }

            public BurgerBuilder SetSauce(bool sauce)
            {
                this.sauce = sauce;
                return this;
            }

            public BurgerBuilder SetLettuce(bool lettuce)
            {
                this.lettuce = lettuce;
                return this;
            }

            public BurgerBuilder SetOnion(bool onion)
            {
                this.onion = onion;
                return this;
            }

            public string GetSize()
            {
                return this.size;
            }

            public bool GetMayonese()
            {
                return this.mayonese;
            }

            public bool GetSauce()
            {
                return this.sauce;
            }

            public bool GetLettuce()
            {
                return this.lettuce;
            }

            public bool GetOnion()
            {
                return this.onion;
            }

            public bool GetExtraCheese()
            {
                return this.extraCheese;
            }

            public Burger BuildBurger()
            {
                return new Burger(this);
            }
        }
    }
}
