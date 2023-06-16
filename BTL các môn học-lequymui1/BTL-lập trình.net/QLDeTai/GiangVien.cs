using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDeTai
{
     class GiangVien 
    {
        private string _hoten;
        private string _magv;
        private int _sdt;
        private string _mamh;
        private string _sex;

        public GiangVien()
        {
        }

        public GiangVien(string hoten, string magv, int sdt, string mamh, string sex)
        {
            _hoten = hoten;
            _magv = magv;
            _sdt = sdt;
            _mamh = mamh;
            _sex = sex;
        }

        public string Hoten { get => _hoten; set => _hoten = value; }
        public string Magv { get => _magv; set => _magv = value; }
        public int Sdt { get => _sdt; set => _sdt = value; }
        public string Mamh { get => _mamh; set => _mamh = value; }
        public string Sex { get => _sex; set => _sex = value; }
    }
}
