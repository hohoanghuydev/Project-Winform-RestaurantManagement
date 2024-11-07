using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectRestaurantManagement.EF;
namespace ProjectRestaurantManagement.Models
{
    public class ClassLoaiMonAn
    {
        RestaurantManagementDatabaseEntities1 db = new RestaurantManagementDatabaseEntities1 ();
        
        public LoaiMonAn getItem(string maLoaiMonAn)
        {
            return db.LoaiMonAns.FirstOrDefault(r => r.MaLoaiMonAn == maLoaiMonAn);
        }

        public List<LoaiMonAn> getList()
        {
            return db.LoaiMonAns.Where(r => r.TenLoaiMonAn != "Remove").ToList();
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
            List<LoaiMonAn> lstLMA = db.LoaiMonAns.ToList();
            if (lstLMA.Count == 0)
            {
                return "LMA001";
            }
            string maBan = lstLMA.LastOrDefault().MaLoaiMonAn.ToString();
            if (maBan == null)
            {
                maBan = "LMA000";
            }
            int numMaBan = int.Parse(maBan.Substring(3, 3));
            numMaBan += 1;
            maBan = maBan.Substring(0, 3);
            int chuoiLayDu = 3 - kiemTraChuSo(numMaBan);
            if (chuoiLayDu == 0)
                maBan += numMaBan.ToString();
            else if (chuoiLayDu == 1)
                maBan += ("0" + numMaBan.ToString());
            else
                maBan += ("00" + numMaBan.ToString());
            return maBan;
        }
        public LoaiMonAn add(LoaiMonAn l)
        {
            try
            {
                db.LoaiMonAns.Add(l);
                db.SaveChanges();
                return l;
            }catch (Exception ex) 
            {
                throw new Exception("Lỗi !!" + ex.Message);
            }
        }
        public LoaiMonAn update(LoaiMonAn l)
        {
            try
            {
                var newLMA = db.LoaiMonAns.FirstOrDefault(r => r.MaLoaiMonAn == l.MaLoaiMonAn);
                newLMA.TenLoaiMonAn = l.TenLoaiMonAn;
                db.SaveChanges();
                return l;
            }catch(Exception ex) 
            {
                throw new Exception("Lỗi !!" + ex.Message);
            }
        }

        public LoaiMonAn delete(LoaiMonAn l)
        {
            try
            {
                var newLMA = db.LoaiMonAns.FirstOrDefault(r => r.MaLoaiMonAn == l.MaLoaiMonAn);
                newLMA.TenLoaiMonAn = "Remove";
                db.SaveChanges();
                return newLMA;  
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi !!" + ex.Message);
            }
        }
    }
}
