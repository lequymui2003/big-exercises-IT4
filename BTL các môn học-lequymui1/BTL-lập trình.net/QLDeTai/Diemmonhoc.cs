using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDeTai
{
    class Diemmonhoc
    {
        private string _Masv;
        private string _MaMH;
        private float _Diemkt;
        private float _Diemcc;
        private float _Diemck;

        public Diemmonhoc()
        {
        }

        public Diemmonhoc(string masv, string maMH, float diemkt, float diemcc, float diemck)
        {
            _Masv = masv;
            _MaMH = maMH;
            _Diemkt = diemkt;
            _Diemcc = diemcc;
            _Diemck = diemck;
        }

        public string Masv { get => _Masv; set => _Masv = value; }
        public string MaMH { get => _MaMH; set => _MaMH = value; }
        public float Diemkt { get => _Diemkt; set => _Diemkt = value; }
        public float Diemcc { get => _Diemcc; set => _Diemcc = value; }
        public float Diemck { get => _Diemck; set => _Diemck = value; }

        
    }
}
