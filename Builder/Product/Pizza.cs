using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    public class Pizza
    {
        private List<object> Additive = new List<object>();

        public void Add(string additive)
        {
            this.Additive.Add(additive);
        }

        public string ListAdditive()
        {
            string str = string.Empty;
            for (int i = 0; i < this.Additive.Count; i++)
            {
                if(this.Additive != null)
                {
                    str += this.Additive[i] + ", ";
                }
               
            }
            str = str.Remove(str.Length - 2);

            return " содержит :  " + str;
        }
    }
}
