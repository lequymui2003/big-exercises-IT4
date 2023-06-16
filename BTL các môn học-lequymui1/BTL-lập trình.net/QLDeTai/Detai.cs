using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDeTai
{
    class Detai
    {
        private string _TenDT;
        private string _MaDT;
        private string _gioihan;

        public Detai()
        {
        }

        public Detai(string tenDT, string maDT, string gioihan)
        {
            _TenDT = tenDT;
            _MaDT = maDT;
            _gioihan = gioihan;
        }

        public string TenDT { get => _TenDT; set => _TenDT = value; }
        public string MaDT { get => _MaDT; set => _MaDT = value; }
        public string Gioihan { get => _gioihan; set => _gioihan = value; }
    }
}
