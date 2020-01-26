using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Drawing;
using BE;

namespace BE

{
    

    public class IceCream
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        [Key, Column(Order =1)]
        public int ShopId { get; set; }

        public Taste Taste { get; set; }


        public string Image { get; set; }


        public float? Energy { get; set; }

        public float?  Proteins { get; set; }

        public float? Calories { get; set; }


    }
}
