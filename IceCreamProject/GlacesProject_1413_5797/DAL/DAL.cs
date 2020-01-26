using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DAL
    {

        #region IceCream




        #endregion


        #region Shop



        public bool CheckShop(int id,string password)
        {



            using (var db = new IceCreamDB())
            {
                var query = from m in db.Shops
                            where (m.ID == id && m.Password == password)
                            select m;
                foreach (var item in query)
                {
                    return true;//if we entered here there are items in query,user exist
                }
                return false;
                

            }

            
        }


        public void SaveShop(Shop s)
        {



            using (var db = new IceCreamDB())
            {
                db.Shops.Add(s);
                db.SaveChanges();
            }


        }


        #endregion
    }
}
