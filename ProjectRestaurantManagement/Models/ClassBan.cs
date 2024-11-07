using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ProjectRestaurantManagement.EF;
namespace ProjectRestaurantManagement.Models
{
    public class ClassBan
    {
        RestaurantManagementDatabaseEntities1 db = new RestaurantManagementDatabaseEntities1();
        
        public Ban getItem(string maBan)
        {
            return db.Bans.FirstOrDefault(r => r.MaBan == maBan);
        }
        
        int kiemTraChuSo(int n)
        {
            int count = 1;
            while (n >= 10)
            {
                n /= 10;
                count += 1;
            }
            return count;
        }
        public string lastCode()
        {
            List<Ban> lstBan = db.Bans.ToList();
            if (lstBan.Count == 0)
            {
                return "B001";
            }
            string maBan = lstBan.LastOrDefault().MaBan.ToString();
            if (maBan == null)
            {
                maBan = "B000";
            }
            int numMaBan = int.Parse(maBan.Substring(1, 3));
            numMaBan += 1;
            maBan = maBan.Substring(0,1);
            int chuoiLayDu = 3 - kiemTraChuSo(numMaBan);
            if (chuoiLayDu == 0)
                maBan += numMaBan.ToString();
            else if (chuoiLayDu == 1)
                maBan += ("0" + numMaBan.ToString());
            else
                maBan += ("00" + numMaBan.ToString());
            return maBan;
        }
        public List<Ban> getList()
        {
            return db.Bans.Where(r => r.TenBan != "Remove")
                .ToList();
        }

        public Ban add(Ban b)
        {
            try
            {
                db.Bans.Add(b);
                db.SaveChanges();
                return b;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi !!" + ex.Message);
            }
        }
        public Ban update(Ban b)
        {
            try
            {
                var newBan = db.Bans.FirstOrDefault(r => r.MaBan == b.MaBan);
                newBan.TenBan = b.TenBan;
                db.SaveChanges();
                return b;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi !!" + ex.Message);
            }
        }

        public Ban delete(Ban b)
        {
            try
            {
                var newBan = db.Bans.FirstOrDefault(r => r.MaBan == b.MaBan);
                newBan.TenBan = "Remove";
                db.SaveChanges();
                return newBan;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi !!" + ex.Message);
            }
        }
    }
}
