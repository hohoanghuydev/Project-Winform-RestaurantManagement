using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectRestaurantManagement.EF;

namespace ProjectRestaurantManagement.Models
{
    public class ClassMonAn
    {
        RestaurantManagementDatabaseEntities1 db = new RestaurantManagementDatabaseEntities1();
        public MonAn getItem(string maMonAn)
        {
            return db.MonAns.FirstOrDefault(r => r.MaMonAn == maMonAn);
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
            List<MonAn> lstMon = db.MonAns.ToList();
            if (lstMon.Count == 0)
            {
                return "MA001";
            }
            string maBan = lstMon.LastOrDefault().MaMonAn.ToString();
            if (maBan == null)
            {
                maBan = "MA000";
            }
            int numMaBan = int.Parse(maBan.Substring(2, 3));
            numMaBan += 1;
            maBan = maBan.Substring(0, 2);
            int chuoiLayDu = 3 - kiemTraChuSo(numMaBan);
            if (chuoiLayDu == 0)
                maBan += numMaBan.ToString();
            else if (chuoiLayDu == 1)
                maBan += ("0" + numMaBan.ToString());
            else
                maBan += ("00" + numMaBan.ToString());
            return maBan;
        }
        public List<MonAn> getList()
        {
            return db.MonAns.Where(r => r.TenMonAn != "Remove").ToList();
        }

        public MonAn add(MonAn m)
        {
            try
            {
                db.MonAns.Add(m);
                db.SaveChanges();
                return m;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi !!" + ex.Message);
            }
        }
        public MonAn update(MonAn m)
        {
            MonAn newMA = db.MonAns.Find(m.MaMonAn);
            newMA.TenMonAn = m.TenMonAn;
            newMA.DonGia = m.DonGia;
            newMA.MaLoaiMonAn = m.MaLoaiMonAn;
            db.SaveChanges();
            return m;

        }

        public MonAn delete(MonAn m)
        {
            try
            {
                var newMA = db.MonAns.FirstOrDefault(r => r.MaMonAn == m.MaMonAn);
                newMA.TenMonAn = "Remove";
                db.SaveChanges();
                return newMA;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi !!" + ex.Message);
            }
        }
    }
}
