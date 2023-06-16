using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDeTai
{
     class SinhVien 
    {

        private string _Masv;
        private string _Name;
        private string _Sex;
        private int Age;
        private string _Address;
        private string _Class;
        private int _Phonenumber;

        public SinhVien()
        {
        }

        public SinhVien(string masv, string name, string sex, int age, string address, string @class, int phonenumber)
        {
            _Masv = masv;
            _Name = name;
            _Sex = sex;
            Age = age;
            _Address = address;
            _Class = @class;
            _Phonenumber = phonenumber;
        }

        public string Masv { get => _Masv; set => _Masv = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Sex { get => _Sex; set => _Sex = value; }
        public int Age1 { get => Age; set => Age = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Class { get => _Class; set => _Class = value; }
        public int Phonenumber { get => _Phonenumber; set => _Phonenumber = value; }
    }
}
