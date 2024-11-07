using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ProjectRestaurantManagement.EF;

namespace ProjectRestaurantManagement.Models
{
    public class ClassNhanVien
    {
        RestaurantManagementDatabaseEntities1 db = new RestaurantManagementDatabaseEntities1();
        public NhanVien getItem(string maNV)
        {
            return db.NhanViens.FirstOrDefault(r => r.MaNV == maNV);
        }
        public List<NhanVien> getList()
        {
            return db.NhanViens
                .Where(r => r.ChucVu != "Remove")
                .AsEnumerable()
                .Select(r => new NhanVien
                {
                    MaNV = r.MaNV,
                    TenNV = r.TenNV,
                    ChucVu = r.ChucVu,
                    Luong = r.Luong,

                })
                .ToList();
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
            List<NhanVien> lstNV = db.NhanViens.ToList();
            if (lstNV.Count == 0)
            {
                return "NV001";
            }
            string maBan = lstNV.LastOrDefault().MaNV.ToString();
            if (maBan == null)
            {
                maBan = "NV000";
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
        public NhanVien add(NhanVien nv)
        {
                db.NhanViens.Add(nv);
                db.SaveChanges();
                return nv;
            
        }
        public NhanVien update(NhanVien nv)
        {
                var newNV = db.NhanViens.Find(nv.MaNV);
                newNV.TenNV = nv.TenNV;
                newNV.ChucVu = nv.ChucVu;
                newNV.Luong = nv.Luong;
                db.SaveChanges();
                return nv;
        }

        public NhanVien delete(NhanVien nv)
        {

            try
            {
                var newNV = db.NhanViens.FirstOrDefault(r => r.MaNV == nv.MaNV);
                newNV.ChucVu = "Remove";
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Loiii" + ex.Message);
            }
        }
        public bool dangNhap(string userName, string passWord)
        {
            var user = db.NhanViens.FirstOrDefault(r => r.MaNV==userName && r.MatKhau == passWord && r.ChucVu !="Remove");
            if (user != null)
            {
                return true;
            }
            return false;
        }
        public void doiMatKhau(string userName,string newPassword)
        {
            NhanVien n = db.NhanViens.Find(userName);
            n.MatKhau = newPassword;
            db.SaveChanges();
            
        }
    }
}
