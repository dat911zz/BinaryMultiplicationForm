
namespace BinaryMultiplicationForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBinary = new System.Windows.Forms.Label();
            this.aBinary = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nhapa = new System.Windows.Forms.TextBox();
            this.nhapb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showCalculation = new System.Windows.Forms.Panel();
            this.multiplication = new System.Windows.Forms.Label();
            this.soB = new System.Windows.Forms.Label();
            this.soA = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ketqua = new System.Windows.Forms.Label();
            this.btn_runVisualization = new System.Windows.Forms.Button();
            this.btn_clearVisualization = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.showCalculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bBinary);
            this.panel1.Controls.Add(this.aBinary);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(352, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 75);
            this.panel1.TabIndex = 0;
            // 
            // bBinary
            // 
            this.bBinary.AutoSize = true;
            this.bBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBinary.ForeColor = System.Drawing.Color.Lime;
            this.bBinary.Location = new System.Drawing.Point(18, 43);
            this.bBinary.Name = "bBinary";
            this.bBinary.Size = new System.Drawing.Size(16, 17);
            this.bBinary.TabIndex = 2;
            this.bBinary.Text = "0";
            // 
            // aBinary
            // 
            this.aBinary.AutoSize = true;
            this.aBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBinary.ForeColor = System.Drawing.Color.Lime;
            this.aBinary.Location = new System.Drawing.Point(18, 14);
            this.aBinary.Name = "aBinary";
            this.aBinary.Size = new System.Drawing.Size(16, 17);
            this.aBinary.TabIndex = 1;
            this.aBinary.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(3, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 23);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 24);
            this.panel3.TabIndex = 10;
            // 
            // nhapa
            // 
            this.nhapa.Location = new System.Drawing.Point(161, 82);
            this.nhapa.Name = "nhapa";
            this.nhapa.Size = new System.Drawing.Size(155, 22);
            this.nhapa.TabIndex = 1;
            this.nhapa.TextChanged += new System.EventHandler(this.textChange_aBinary);
            // 
            // nhapb
            // 
            this.nhapb.Location = new System.Drawing.Point(161, 112);
            this.nhapb.Name = "nhapb";
            this.nhapb.Size = new System.Drawing.Size(155, 22);
            this.nhapb.TabIndex = 2;
            this.nhapb.TextChanged += new System.EventHandler(this.textChange_bBinary);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chương Trình Tính phép nhân nhị phân không dấu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập số nguyên a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập số nguyên b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chuyển sang hệ nhị phân";
            // 
            // showCalculation
            // 
            this.showCalculation.AutoScroll = true;
            this.showCalculation.AutoScrollMargin = new System.Drawing.Size(100, 800);
            this.showCalculation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showCalculation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showCalculation.Controls.Add(this.multiplication);
            this.showCalculation.Controls.Add(this.soB);
            this.showCalculation.Controls.Add(this.soA);
            this.showCalculation.Controls.Add(this.line);
            this.showCalculation.Location = new System.Drawing.Point(1, 235);
            this.showCalculation.Name = "showCalculation";
            this.showCalculation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showCalculation.Size = new System.Drawing.Size(805, 227);
            this.showCalculation.TabIndex = 9;
            this.showCalculation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            // 
            // multiplication
            // 
            this.multiplication.AutoSize = true;
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(257, 17);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(17, 20);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "x";
            // 
            // soB
            // 
            this.soB.Location = new System.Drawing.Point(275, 32);
            this.soB.Name = "soB";
            this.soB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.soB.Size = new System.Drawing.Size(143, 17);
            this.soB.TabIndex = 1;
            this.soB.Text = "0";
            this.soB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // soA
            // 
            this.soA.Location = new System.Drawing.Point(275, 10);
            this.soA.Name = "soA";
            this.soA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.soA.Size = new System.Drawing.Size(143, 17);
            this.soA.TabIndex = 0;
            this.soA.Text = "0";
            this.soA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(253, 43);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(171, 20);
            this.line.TabIndex = 3;
            this.line.Text = "___________________";
            this.line.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(161, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Chạy";
            this.toolTip1.SetToolTip(this.button1, "Bấm vào để chạy kết quả");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Enter += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            this.label4.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Minh họa";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Chương trình code bởi dat911zz";
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Location = new System.Drawing.Point(356, 155);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(16, 17);
            this.ketqua.TabIndex = 13;
            this.ketqua.Text = "0";
            // 
            // btn_runVisualization
            // 
            this.btn_runVisualization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_runVisualization.Location = new System.Drawing.Point(352, 187);
            this.btn_runVisualization.Name = "btn_runVisualization";
            this.btn_runVisualization.Size = new System.Drawing.Size(156, 42);
            this.btn_runVisualization.TabIndex = 14;
            this.btn_runVisualization.Text = "Chạy minh họa";
            this.btn_runVisualization.UseVisualStyleBackColor = true;
            this.btn_runVisualization.Click += new System.EventHandler(this.btn_runVisualization_Click);
            // 
            // btn_clearVisualization
            // 
            this.btn_clearVisualization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearVisualization.Location = new System.Drawing.Point(532, 186);
            this.btn_clearVisualization.Name = "btn_clearVisualization";
            this.btn_clearVisualization.Size = new System.Drawing.Size(165, 43);
            this.btn_clearVisualization.TabIndex = 4;
            this.btn_clearVisualization.Text = "Xoá minh họa";
            this.btn_clearVisualization.UseVisualStyleBackColor = true;
            this.btn_clearVisualization.Click += new System.EventHandler(this.btn_clearVisualization_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(161, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(155, 28);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(352, 149);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(345, 28);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kết Quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 468);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clearVisualization);
            this.Controls.Add(this.btn_runVisualization);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showCalculation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nhapb);
            this.Controls.Add(this.nhapa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "J2Team";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.showCalculation.ResumeLayout(false);
            this.showCalculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nhapa;
        private System.Windows.Forms.TextBox nhapb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aBinary;
        private System.Windows.Forms.Label bBinary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel showCalculation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label soB;
        private System.Windows.Forms.Label soA;
        private System.Windows.Forms.Label multiplication;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Button btn_runVisualization;
        private System.Windows.Forms.Button btn_clearVisualization;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

