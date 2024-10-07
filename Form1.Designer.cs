namespace OOP_ThiThu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHangXe = new TextBox();
            txtBienSo = new TextBox();
            txtGiaBan = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimeNSX = new DateTimePicker();
            label5 = new Label();
            txtBC = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtHangXe
            // 
            txtHangXe.Location = new Point(116, 20);
            txtHangXe.Name = "txtHangXe";
            txtHangXe.Size = new Size(200, 23);
            txtHangXe.TabIndex = 0;
            // 
            // txtBienSo
            // 
            txtBienSo.Location = new Point(116, 52);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.Size = new Size(200, 23);
            txtBienSo.TabIndex = 1;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(116, 90);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(200, 23);
            txtGiaBan.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 28);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 4;
            label1.Text = "Hang Xe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 60);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Bien So";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 98);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Gia Ban";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 136);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "NSX";
            // 
            // dateTimeNSX
            // 
            dateTimeNSX.Location = new Point(116, 130);
            dateTimeNSX.Name = "dateTimeNSX";
            dateTimeNSX.Size = new Size(200, 23);
            dateTimeNSX.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 176);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 9;
            label5.Text = "BC";
            // 
            // txtBC
            // 
            txtBC.Location = new Point(116, 168);
            txtBC.Name = "txtBC";
            txtBC.Size = new Size(198, 23);
            txtBC.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(413, 51);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 11;
            btnThem.Text = "Them Xe";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(413, 112);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xoa Xe";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(721, 230);
            dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtBC);
            Controls.Add(label5);
            Controls.Add(dateTimeNSX);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGiaBan);
            Controls.Add(txtBienSo);
            Controls.Add(txtHangXe);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHangXe;
        private TextBox txtBienSo;
        private TextBox txtGiaBan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimeNSX;
        private Label label5;
        private TextBox txtBC;
        private Button btnThem;
        private Button btnXoa;
        private DataGridView dataGridView1;
    }
}
