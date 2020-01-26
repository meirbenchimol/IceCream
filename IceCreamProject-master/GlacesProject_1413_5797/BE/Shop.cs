using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace BE
{
    public class Shop
    {
        [Key , Column(Order=0)]
        public int ID { get; set; }
        [Key, Column(Order = 1)]
        public string Password { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }


        private List<IceCream> products= new List<IceCream>();

        public List<IceCream> Products
        {
            get { return products; }
        }

    }
}
