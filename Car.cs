using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ThiThu
{
    public class Car
    {
        private string hangXe;
        private string bienSo;
        private DateTime namSX;
        private int giaBan;

        public string HangXe { get => hangXe; set => hangXe = value; }
        public string BienSo { get => bienSo; set => bienSo = value; }
        public DateTime NamSX { get => namSX; set => namSX = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }

        public Car() { }
        public Car(string hangXe, string bienSo, DateTime namSX, int giaBan)
        {
            HangXe = hangXe;
            BienSo = bienSo;
            NamSX = namSX;
            GiaBan = giaBan;
        }
    }
}
