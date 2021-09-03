using System;
using System.Windows.Forms;
using System.Drawing;

namespace BinaryMultiplicationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //=======================================================================================
        //Phần tính toán
        public void Calculator(string Q, string M, ref string KQ)
        {
            char[] So_Nhan_Q, So_Bi_Nhan_M;
            int so_nhan, so_bi_nhan;

            long Max_Bit_Out = 2147483648;//2^31 32 bit
            int Max_Bit_In = 32768; // 16 bit

            Int32.TryParse(Q, out so_nhan);
            Int32.TryParse(M, out so_bi_nhan);
            // chuyen so nhi phan cua So_Nhan
            Chuyen_Nhi_Phan(so_nhan, out So_Nhan_Q);
            // chuyen so nhi phan cua So_Bi_Nhan
            Chuyen_Nhi_Phan(so_bi_nhan, out So_Bi_Nhan_M);

            // Count so buoc thuc hien bang do dai bit cua Q
            int Count = Real_Lenght(So_Nhan_Q);
            Dua_Ve_4_8_16_bit(So_Nhan_Q, ref Count);

            // khoi tao chuoi A
            char[] A = new char[17];

            char C = '0'; // bit dau


            // lay do dai thuc
            int DoDai_Q = Real_Lenght(So_Nhan_Q);// cap nhat lai DoDai_Q

            // lay do dai cua So_Bi_Nhan
            int DoDai_M = Real_Lenght(So_Bi_Nhan_M);

            // them bit '0' vao dua ve bit 4,8,16
            Dua_Ve_4_8_16_bit(So_Bi_Nhan_M, ref DoDai_M);

            // Gan bit '0' ban dau cho A, va do dai A = DoDai_M
            for (int i = 0; i < DoDai_M; i++)
                A[i] = '0';
            A[DoDai_M] = '\0';
            int DoDai_A = Real_Lenght(A);

            // thuc thi chuong trinh
            while (Count != 0)
            {
                if (So_Nhan_Q[DoDai_Q - 1] == '1')// neu Q0 = '1'
                {
                    char Nho = '0';
                    for (int i = DoDai_M - 1; i >= 0; i--)
                    {
                        if (A[i] == '1' && So_Bi_Nhan_M[i] == '1')
                        {
                            if (Nho == '0')
                            {
                                A[i] = '0';
                                Nho = '1';
                            }
                            else// 1 + 1 = 0 + Nho = 1, Nho tiep tuc ve 1
                            {
                                A[i] = '1';
                                Nho = '1';
                            }
                        }
                        else if (A[i] == '0' && So_Bi_Nhan_M[i] == '0')
                        {
                            A[i] = Nho;
                            Nho = '0';
                        }
                        else// A != M ( 1 0 || 0 1 )
                        {
                            if (Nho == '1')
                            {
                                A[i] = '0';
                                Nho = '1';
                            }
                            else
                            {
                                A[i] = '1';
                            }
                        }
                    }
                    if (Nho == '1')
                        C = Nho;
                }// neu Q0 != '1' van dich phai


                // dich Q -> A -> C

                // dich phai Q
                So_Nhan_Q[DoDai_Q - 1] = '\0';
                Them_Ky_Tu_Vao_Dau(So_Nhan_Q, A[DoDai_A - 1]);
                // dich phai A
                A[DoDai_A - 1] = '\0';
                Them_Ky_Tu_Vao_Dau(A, C);
                // dich phai C
                C = '0';

                // cap nhat Count
                Count--;

            }
            char[] KetQua = new char[33];
            Chuoi_KQ(KetQua, A, DoDai_A, So_Nhan_Q, DoDai_Q);

            // lay do dai thuc cua chuoi KetQua
            int DoDai_KQ = Real_Lenght(KetQua);
            while (DoDai_KQ < 32)// them vao dau chuoi KetQua '0' cho du 32 bit thi dung
            {
                Them_Ky_Tu_Vao_Dau(KetQua, '0');
                DoDai_KQ++;
            }
            CatSoThuaTrongChuoiKQ(KetQua, ref DoDai_KQ);
            ChuyenMangCharThanhString(KetQua,ref KQ, DoDai_KQ);
            //KQ = KetQua.ToString(); <-- Lỗi không thể chuyển từ Char[] -> String
            long kq = Tinh_Ket_Qua_Tu_Nhi_Phan(KetQua, DoDai_KQ);
            label4.Text = kq.ToString();
        }
        static void ChuyenMangCharThanhString(char[] x, ref string y, int DoDai)
        {
            y = "";
            for (int i = 0; i < DoDai; i++)
            {
                y = y.Insert(0, x[i].ToString());
            }
            y = ReverseString(y);
        }
        static string ReverseString(string s)
        {
            // Convert to char array, then call Array.Reverse.
            // ... Finally use string constructor on array.
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static void CatSoThuaTrongChuoiKQ(char[] x, ref int DoDai)
        {
            while (x[0] == '0' && DoDai > 4)
            {
                XoaKTVTK(x, 0, ref DoDai);
            }
        }

        static void XoaKTVTK(char[] str, int k, ref int DoDai)
        {
            for (int i = k + 1; i < DoDai; i++)
            {
                str[i - 1] = str[i];
            }
            str[DoDai - 1] = '\0';
            DoDai--;
        }
        // them bit '0' vao dau dua ve 4,8,16 bit
        static void Dua_Ve_4_8_16_bit(char[] Chuoi, ref int DoDai)
        {
            if (DoDai <= 4)
            {
                while (DoDai < 4)
                {
                    Them_Ky_Tu_Vao_Dau(Chuoi, '0');
                    DoDai++;
                }
            }
            else if (DoDai <= 8)
            {
                while (DoDai < 8)
                {
                    Them_Ky_Tu_Vao_Dau(Chuoi, '0');
                    DoDai++;
                }
            }
            else if (DoDai <= 16)
            {
                while (DoDai < 16)
                {
                    Them_Ky_Tu_Vao_Dau(Chuoi, '0');
                    DoDai++;
                }
            }
        }

        // noi chuoi AQ = chuoi KetQua
        static void Chuoi_KQ(char[] KetQua, char[] A, int DoDai_A, char[] So_Nhan_Q, int DoDai_Q)
        {
            int vtKQ = 0;

            for (int i = 0; i < DoDai_A; i++)
            {
                KetQua[vtKQ++] = A[i];
            }
            for (int i = 0; i < DoDai_Q; i++)
            {
                KetQua[vtKQ++] = So_Nhan_Q[i];
            }
        }

        // tinh ket qua theo chuoi nhi phan
        static long Tinh_Ket_Qua_Tu_Nhi_Phan(char[] Chuoi, int DoDai)
        {
            long kq = 0;
            int mu = 0;
            for (int i = DoDai - 1; i >= 0; i--)
            {
                if (Chuoi[i] == '1')
                {
                    kq += Tinh_Luy_Thua(2, mu);
                }
                mu++;
            }
            return kq;
        }

        // tinh x luy thua y
        static long Tinh_Luy_Thua(int x, int y)
        {
            long kq = 1;
            for (int i = 1; i <= y; i++)
            {
                kq *= x;
            }
            return kq;
        }

        // them ky tu c vao dau Chuoi
        static void Them_Ky_Tu_Vao_Dau(char[] Chuoi, char c)
        {
            int dodai = Chuoi.Length;
            for (int i = dodai - 1; i > 0; i--)
            {
                Chuoi[i] = Chuoi[i - 1];
            }
            Chuoi[0] = c;
        }

        // chuyen So_Nguyen ve Chuoi_Nhi_Phan
        static void Chuyen_Nhi_Phan(int So_Nguyen, out char[] Chuoi_Nhi_Phan)
        {
            Chuoi_Nhi_Phan = new char[17];//16 bit
            while (So_Nguyen != 0)
            {
                int du = So_Nguyen % 2;
                So_Nguyen /= 2;
                if (du == 0)
                {
                    Them_Ky_Tu_Vao_Dau(Chuoi_Nhi_Phan, '0');
                }
                else Them_Ky_Tu_Vao_Dau(Chuoi_Nhi_Phan, '1');
            }
        }

        static int Real_Lenght(char[] chuoi)
        {
            int dodai = 0;
            int vt = 0;
            while (chuoi[vt] != '\0')
            {
                dodai++;
                vt++;
            }
            return dodai;
        }
 


        //=======================================================================================
        //Phần giao diện 
        public void duongthang(int trai, int doc, int dai, int rong)
        {
            Graphics g = showCalculation.CreateGraphics();
            g.DrawLine(Pens.Red, trai, doc, dai, rong);// sử dụng drawLine để vẽ đường
        }
        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            showCalculation.Update();
        }
        private String ConvertDecimalToBinary(string input)
        {
            int x;
            if (int.TryParse(input, out x))
            {
                if (x > 32768)
                {
                    return "Vượt quá giới hạn 16 bit!";
                }
                return Convert.ToString(x, 2);
            }
            else
            {
                return "-";
            }
        }
        private void textChange_aBinary(object sender, EventArgs e)
        {
            aBinary.Text = ConvertDecimalToBinary(nhapa.Text);
        }
        private void textChange_bBinary(object sender, EventArgs e)
        {
            bBinary.Text = ConvertDecimalToBinary(nhapb.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;
            showCalculation.Controls.Clear();
            showCalculation.Refresh();
            //Show error provider
            if (Int32.TryParse(nhapa.Text, out num1))
            {
                errorProvider1.SetError(nhapa, "");
            }
            else
            {
                errorProvider1.SetError(nhapa, "Chỉ được nhập số");
            }
            if (Int32.TryParse(nhapb.Text, out num2))
            {
                errorProvider2.SetError(nhapb, "");
            }
            else
            {
                errorProvider2.SetError(nhapb, "Chỉ được nhập số");
            }
            //Checking error and running functions
            if (Int32.TryParse(nhapa.Text, out num1) && Int32.TryParse(nhapb.Text, out num2) && aBinary.Text != "Vượt quá giới hạn 16 bit!" && bBinary.Text != "Vượt quá giới hạn 16 bit!")
            {
                string KQ = "";
                aBinary.Text = ConvertDecimalToBinary(nhapa.Text);
                bBinary.Text = ConvertDecimalToBinary(nhapb.Text);

                //-------------Phần tính toán tại đây--------------//
                /**/ Calculator(nhapa.Text, nhapb.Text, ref KQ); /**/
                //-------------------------------------------------//

                ketqua.Text = KQ;               
                //Đưa 2 số vào phần minh họa
                soA.Text = aBinary.Text;
                soB.Text = bBinary.Text;
            }
            else
            {
                string message = "Vui lòng nhập lại!";
                string title = "ERROR!";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }
        private void calculatingVisualization(string[] a)
        {
            char[] str = bBinary.Text.ToCharArray();
            char[] tmp = new char[100];
            int idx = 0;
            int n = bBinary.Text.Length;

            for (int i = n - 1; i >= 0; i--) 
            {
                if (str[i] == '0')
                {
                    for (int j = 0; j < aBinary.Text.Length; j++)
                    {
                        tmp[j] = '0';
                    }
                    tmp[aBinary.Text.Length] = '\0';
                    ChuyenMangCharThanhString(tmp, ref a[idx++], Real_Lenght(tmp));
                }
                else
                {
                    a[idx++] = aBinary.Text;
                }
            }
        }
        private void btn_clearVisualization_Click(object sender, EventArgs e)
        {
            showCalculation.Controls.Clear();
            this.Refresh();
        }

        private void btn_runVisualization_Click(object sender, EventArgs e)
        {
            int X = 163, Y = 50;
            string[] a = new string[50];
            
            showCalculation.Update();//For smooth scrool                   
            int LengthOfMultiplier = bBinary.Text.Length;
            //=============================
            //Generating string
            calculatingVisualization(a);
            //=============================
            //Show hidden label
            showCalculation.Controls.Add(multiplication);
            showCalculation.Controls.Add(soA);
            showCalculation.Controls.Add(soB);
            showCalculation.Controls.Add(line);
            //=============================
            //Multiplicand
            soA.Visible = true;

            //=============================
            //Multiplier
            soB.Visible = true;

            //=============================
            //Multiplication sign
            multiplication.Visible = true;

            //=============================
            //Show line           
            line.Visible = true;

            //=============================
            //Drawing elements

            for (int i = 0; i < LengthOfMultiplier; i++)
            {
                Label tx = new Label();
                tx.Location = new Point(X - i * 5, Y + i * 20);
                tx.Name = string.Format("txt {0}", i);
                tx.Tag = string.Format("[{0}]", i);
                tx.Text = string.Format("{0}", a[i]);
                tx.AutoSize = false;
                tx.Margin = new Padding(0, 0, 0, 0);
                tx.TextAlign = ContentAlignment.MiddleRight;
                tx.Size = new Size(150, 20);
                showCalculation.Controls.Add(tx);

            }
            //=============================
            //Drawing dynamic line 
            Label linekq = new Label();
            linekq.Location = new Point(X - 50  , Y + (LengthOfMultiplier * 20) - 10);
            linekq.Text = "__________________________";
            linekq.AutoSize = false;
            linekq.Margin = new Padding(0, 0, 0, 0);
            linekq.TextAlign = ContentAlignment.MiddleRight;
            linekq.Size = new Size(200, 20);
            showCalculation.Controls.Add(linekq);
            //=============================
            //Drawing Result
            Label kq = new Label();
            kq.Location = new Point(X , Y + (LengthOfMultiplier * 20) + 8);
            kq.Text = string.Format("{0}", ketqua.Text);
            kq.AutoSize = false;
            kq.Margin = new Padding(0, 0, 0, 0);
            kq.TextAlign = ContentAlignment.MiddleRight;
            kq.Size = new Size(150, 20);
            showCalculation.Controls.Add(kq);
            //Show drawing
            Controls.Add(showCalculation);
            //End
            showCalculation.SuspendLayout();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            soA.Visible = false;
            soB.Visible = false;
            multiplication.Visible = false;
            line.Visible = false;
            this.Refresh();
        }
    }
}
