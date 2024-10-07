using System.Diagnostics;

namespace OOP_ThiThu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Car> li_car = new List<Car>();


        private void btnThem_Click(object sender, EventArgs e)
        {

            Car car = new Car(txtHangXe.Text, txtBienSo.Text, dateTimeNSX.Value, Convert.ToInt32(txtGiaBan.Text), Convert.ToInt32(txtBC.Text));
            li_car.Add(car);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_car;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (Car i in li_car)
            {
                if (i.HangXe == txtHangXe.Text)
                {
                    li_car.Remove(i);
                    break;
                }
            } 
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_car;

        }
    }
}
