using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDeTai
{
     class BangDiem
    {
        private string _MaDT;
        private string _MaSV;
        private float _Diemlan1;
        private float _Diemlan2;
        private string _Nhanxet;

        public BangDiem()
        {
        }

        public BangDiem(string maDT, string maSV, float diemlan1, float diemlan2, string nhanxet)
        {
            _MaDT = maDT;
            _MaSV = maSV;
            _Diemlan1 = diemlan1;
            _Diemlan2 = diemlan2;
            _Nhanxet = nhanxet;
        }

        public string MaDT { get => _MaDT; set => _MaDT = value; }
        public string MaSV { get => _MaSV; set => _MaSV = value; }
        public float Diemlan1 { get => _Diemlan1; set => _Diemlan1 = value; }
        public float Diemlan2 { get => _Diemlan2; set => _Diemlan2 = value; }
        public string Nhanxet { get => _Nhanxet; set => _Nhanxet = value; }
    }
}
