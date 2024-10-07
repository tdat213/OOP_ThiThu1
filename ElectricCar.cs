using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ThiThu
{
    public class ElectricCar : Car
    {
        private int batCa;

        public int BatCa { get => batCa; set => batCa = value; }

        public ElectricCar() : base () { }
        public ElectricCar(string hangXe, string bienSo, DateTime namSX, int giaBan, int batCa) : base(hangXe, bienSo, namSX, giaBan) 
        {
            BatCa = batCa;
        }
            
    }
}
