using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDeTai
{
     class MonHoc
    {
        private string _TenMH;
        private string _MaMH;
        private int _STC;
        private double _Giatien;

        public MonHoc()
        {
        }

        public MonHoc(string tenMH, string maMH, int sTC, double giatien)
        {
            _TenMH = tenMH;
            _MaMH = maMH;
            _STC = sTC;
            _Giatien = giatien;
        }

        public string TenMH { get => _TenMH; set => _TenMH = value; }
        public string MaMH { get => _MaMH; set => _MaMH = value; }
        public int STC { get => _STC; set => _STC = value; }
        public double Giatien { get => _Giatien; set => _Giatien = value; }

        public double Tongtien()
        {
            return STC * Giatien;
        }
    }
}
