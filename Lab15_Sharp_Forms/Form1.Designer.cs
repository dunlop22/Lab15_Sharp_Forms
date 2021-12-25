
namespace Lab15_Sharp_Forms
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
            this.Motor_Name = new System.Windows.Forms.TextBox();
            this.Motor_Rab_Obem = new System.Windows.Forms.TextBox();
            this.Motor_Koni = new System.Windows.Forms.TextBox();
            this.Motor_Cilindr = new System.Windows.Forms.TextBox();
            this.Motor_Rasxod = new System.Windows.Forms.TextBox();
            this.Motor_Name_Label = new System.Windows.Forms.Label();
            this.Motor_Rab_obem_Label = new System.Windows.Forms.Label();
            this.Motor_Koni_Label = new System.Windows.Forms.Label();
            this.Motor_Cilindr_Label = new System.Windows.Forms.Label();
            this.Motor_Rasxod_Label = new System.Windows.Forms.Label();
            this.Motor_KWT_Label = new System.Windows.Forms.Label();
            this.Motor_KWT = new System.Windows.Forms.TextBox();
            this.Motor_MAX_KWT = new System.Windows.Forms.TextBox();
            this.Motor_MAX_KWT_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Koleso_Shirina = new System.Windows.Forms.TextBox();
            this.Koleso_Visota = new System.Windows.Forms.TextBox();
            this.Koleso_Diametr = new System.Windows.Forms.TextBox();
            this.Koleso_Tip_diska = new System.Windows.Forms.TextBox();
            this.Koleso_Shirina_Label = new System.Windows.Forms.Label();
            this.Koleso_Visota_Label = new System.Windows.Forms.Label();
            this.Koleso_Diametr_Label = new System.Windows.Forms.Label();
            this.Koleso_Tip_diska_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Koleso_Obem_Label = new System.Windows.Forms.Label();
            this.Koleso_Perimetr_Label = new System.Windows.Forms.Label();
            this.Koleso_Obem = new System.Windows.Forms.TextBox();
            this.Koleso_perimetr = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Motor_Name
            // 
            this.Motor_Name.Location = new System.Drawing.Point(165, 33);
            this.Motor_Name.Name = "Motor_Name";
            this.Motor_Name.Size = new System.Drawing.Size(100, 23);
            this.Motor_Name.TabIndex = 0;
            // 
            // Motor_Rab_Obem
            // 
            this.Motor_Rab_Obem.Location = new System.Drawing.Point(165, 76);
            this.Motor_Rab_Obem.Name = "Motor_Rab_Obem";
            this.Motor_Rab_Obem.Size = new System.Drawing.Size(100, 23);
            this.Motor_Rab_Obem.TabIndex = 1;
            this.Motor_Rab_Obem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Motor_Rab_Obem_KeyPress);
            // 
            // Motor_Koni
            // 
            this.Motor_Koni.Location = new System.Drawing.Point(165, 121);
            this.Motor_Koni.Name = "Motor_Koni";
            this.Motor_Koni.Size = new System.Drawing.Size(100, 23);
            this.Motor_Koni.TabIndex = 2;
            this.Motor_Koni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Motor_Koni_KeyPress);
            // 
            // Motor_Cilindr
            // 
            this.Motor_Cilindr.Location = new System.Drawing.Point(165, 165);
            this.Motor_Cilindr.Name = "Motor_Cilindr";
            this.Motor_Cilindr.Size = new System.Drawing.Size(100, 23);
            this.Motor_Cilindr.TabIndex = 3;
            this.Motor_Cilindr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Motor_Cilindr_KeyPress);
            // 
            // Motor_Rasxod
            // 
            this.Motor_Rasxod.Location = new System.Drawing.Point(165, 217);
            this.Motor_Rasxod.Name = "Motor_Rasxod";
            this.Motor_Rasxod.Size = new System.Drawing.Size(100, 23);
            this.Motor_Rasxod.TabIndex = 4;
            this.Motor_Rasxod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Motor_Rasxod_KeyPress);
            // 
            // Motor_Name_Label
            // 
            this.Motor_Name_Label.AutoSize = true;
            this.Motor_Name_Label.Location = new System.Drawing.Point(55, 36);
            this.Motor_Name_Label.Name = "Motor_Name_Label";
            this.Motor_Name_Label.Size = new System.Drawing.Size(65, 15);
            this.Motor_Name_Label.TabIndex = 6;
            this.Motor_Name_Label.Text = "Название: ";
            // 
            // Motor_Rab_obem_Label
            // 
            this.Motor_Rab_obem_Label.AutoSize = true;
            this.Motor_Rab_obem_Label.Location = new System.Drawing.Point(23, 79);
            this.Motor_Rab_obem_Label.Name = "Motor_Rab_obem_Label";
            this.Motor_Rab_obem_Label.Size = new System.Drawing.Size(97, 15);
            this.Motor_Rab_obem_Label.TabIndex = 7;
            this.Motor_Rab_obem_Label.Text = "Рабочий объем:";
            // 
            // Motor_Koni_Label
            // 
            this.Motor_Koni_Label.AutoSize = true;
            this.Motor_Koni_Label.Location = new System.Drawing.Point(17, 124);
            this.Motor_Koni_Label.Name = "Motor_Koni_Label";
            this.Motor_Koni_Label.Size = new System.Drawing.Size(103, 15);
            this.Motor_Koni_Label.TabIndex = 8;
            this.Motor_Koni_Label.Text = "Мощность (л.с.): ";
            // 
            // Motor_Cilindr_Label
            // 
            this.Motor_Cilindr_Label.AutoSize = true;
            this.Motor_Cilindr_Label.Location = new System.Drawing.Point(4, 168);
            this.Motor_Cilindr_Label.Name = "Motor_Cilindr_Label";
            this.Motor_Cilindr_Label.Size = new System.Drawing.Size(116, 15);
            this.Motor_Cilindr_Label.TabIndex = 9;
            this.Motor_Cilindr_Label.Text = "Кол-во цилиндров: ";
            // 
            // Motor_Rasxod_Label
            // 
            this.Motor_Rasxod_Label.AutoSize = true;
            this.Motor_Rasxod_Label.Location = new System.Drawing.Point(6, 220);
            this.Motor_Rasxod_Label.Name = "Motor_Rasxod_Label";
            this.Motor_Rasxod_Label.Size = new System.Drawing.Size(106, 15);
            this.Motor_Rasxod_Label.TabIndex = 10;
            this.Motor_Rasxod_Label.Text = "Расход (л/100км): ";
            // 
            // Motor_KWT_Label
            // 
            this.Motor_KWT_Label.AutoSize = true;
            this.Motor_KWT_Label.Location = new System.Drawing.Point(10, 318);
            this.Motor_KWT_Label.Name = "Motor_KWT_Label";
            this.Motor_KWT_Label.Size = new System.Drawing.Size(102, 15);
            this.Motor_KWT_Label.TabIndex = 11;
            this.Motor_KWT_Label.Text = "Мощность (кВт): ";
            // 
            // Motor_KWT
            // 
            this.Motor_KWT.Location = new System.Drawing.Point(165, 315);
            this.Motor_KWT.Name = "Motor_KWT";
            this.Motor_KWT.ReadOnly = true;
            this.Motor_KWT.Size = new System.Drawing.Size(100, 23);
            this.Motor_KWT.TabIndex = 12;
            // 
            // Motor_MAX_KWT
            // 
            this.Motor_MAX_KWT.Location = new System.Drawing.Point(165, 363);
            this.Motor_MAX_KWT.Name = "Motor_MAX_KWT";
            this.Motor_MAX_KWT.ReadOnly = true;
            this.Motor_MAX_KWT.Size = new System.Drawing.Size(100, 23);
            this.Motor_MAX_KWT.TabIndex = 13;
            // 
            // Motor_MAX_KWT_Label
            // 
            this.Motor_MAX_KWT_Label.AutoSize = true;
            this.Motor_MAX_KWT_Label.Location = new System.Drawing.Point(6, 371);
            this.Motor_MAX_KWT_Label.Name = "Motor_MAX_KWT_Label";
            this.Motor_MAX_KWT_Label.Size = new System.Drawing.Size(132, 15);
            this.Motor_MAX_KWT_Label.TabIndex = 14;
            this.Motor_MAX_KWT_Label.Text = "Макс мощность (кВт): ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "UpGrade!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Koleso_Shirina
            // 
            this.Koleso_Shirina.Location = new System.Drawing.Point(200, 33);
            this.Koleso_Shirina.Name = "Koleso_Shirina";
            this.Koleso_Shirina.Size = new System.Drawing.Size(100, 23);
            this.Koleso_Shirina.TabIndex = 16;
            this.Koleso_Shirina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Koleso_Shirina_KeyPress);
            // 
            // Koleso_Visota
            // 
            this.Koleso_Visota.Location = new System.Drawing.Point(200, 76);
            this.Koleso_Visota.Name = "Koleso_Visota";
            this.Koleso_Visota.Size = new System.Drawing.Size(100, 23);
            this.Koleso_Visota.TabIndex = 17;
            this.Koleso_Visota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Koleso_Visota_KeyPress);
            // 
            // Koleso_Diametr
            // 
            this.Koleso_Diametr.Location = new System.Drawing.Point(200, 121);
            this.Koleso_Diametr.Name = "Koleso_Diametr";
            this.Koleso_Diametr.Size = new System.Drawing.Size(100, 23);
            this.Koleso_Diametr.TabIndex = 18;
            this.Koleso_Diametr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Koleso_Diametr_KeyPress);
            // 
            // Koleso_Tip_diska
            // 
            this.Koleso_Tip_diska.Location = new System.Drawing.Point(200, 165);
            this.Koleso_Tip_diska.Name = "Koleso_Tip_diska";
            this.Koleso_Tip_diska.Size = new System.Drawing.Size(100, 23);
            this.Koleso_Tip_diska.TabIndex = 19;
            // 
            // Koleso_Shirina_Label
            // 
            this.Koleso_Shirina_Label.AutoSize = true;
            this.Koleso_Shirina_Label.Location = new System.Drawing.Point(90, 36);
            this.Koleso_Shirina_Label.Name = "Koleso_Shirina_Label";
            this.Koleso_Shirina_Label.Size = new System.Drawing.Size(55, 15);
            this.Koleso_Shirina_Label.TabIndex = 21;
            this.Koleso_Shirina_Label.Text = "Ширина:";
            // 
            // Koleso_Visota_Label
            // 
            this.Koleso_Visota_Label.AutoSize = true;
            this.Koleso_Visota_Label.Location = new System.Drawing.Point(95, 79);
            this.Koleso_Visota_Label.Name = "Koleso_Visota_Label";
            this.Koleso_Visota_Label.Size = new System.Drawing.Size(50, 15);
            this.Koleso_Visota_Label.TabIndex = 22;
            this.Koleso_Visota_Label.Text = "Высота:";
            // 
            // Koleso_Diametr_Label
            // 
            this.Koleso_Diametr_Label.AutoSize = true;
            this.Koleso_Diametr_Label.Location = new System.Drawing.Point(87, 124);
            this.Koleso_Diametr_Label.Name = "Koleso_Diametr_Label";
            this.Koleso_Diametr_Label.Size = new System.Drawing.Size(58, 15);
            this.Koleso_Diametr_Label.TabIndex = 23;
            this.Koleso_Diametr_Label.Text = "Диаметр:";
            // 
            // Koleso_Tip_diska_Label
            // 
            this.Koleso_Tip_diska_Label.AutoSize = true;
            this.Koleso_Tip_diska_Label.Location = new System.Drawing.Point(80, 168);
            this.Koleso_Tip_diska_Label.Name = "Koleso_Tip_diska_Label";
            this.Koleso_Tip_diska_Label.Size = new System.Drawing.Size(65, 15);
            this.Koleso_Tip_diska_Label.TabIndex = 24;
            this.Koleso_Tip_diska_Label.Text = "Тип диска:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Motor_Name);
            this.groupBox1.Controls.Add(this.Motor_Rab_Obem);
            this.groupBox1.Controls.Add(this.Motor_Koni);
            this.groupBox1.Controls.Add(this.Motor_Cilindr);
            this.groupBox1.Controls.Add(this.Motor_Rasxod);
            this.groupBox1.Controls.Add(this.Motor_Name_Label);
            this.groupBox1.Controls.Add(this.Motor_Rab_obem_Label);
            this.groupBox1.Controls.Add(this.Motor_Koni_Label);
            this.groupBox1.Controls.Add(this.Motor_Cilindr_Label);
            this.groupBox1.Controls.Add(this.Motor_Rasxod_Label);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Motor_KWT_Label);
            this.groupBox1.Controls.Add(this.Motor_MAX_KWT_Label);
            this.groupBox1.Controls.Add(this.Motor_KWT);
            this.groupBox1.Controls.Add(this.Motor_MAX_KWT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 434);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Двигатель";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Koleso_Obem_Label);
            this.groupBox2.Controls.Add(this.Koleso_Perimetr_Label);
            this.groupBox2.Controls.Add(this.Koleso_Obem);
            this.groupBox2.Controls.Add(this.Koleso_perimetr);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Koleso_Shirina);
            this.groupBox2.Controls.Add(this.Koleso_Visota);
            this.groupBox2.Controls.Add(this.Koleso_Tip_diska_Label);
            this.groupBox2.Controls.Add(this.Koleso_Diametr);
            this.groupBox2.Controls.Add(this.Koleso_Diametr_Label);
            this.groupBox2.Controls.Add(this.Koleso_Tip_diska);
            this.groupBox2.Controls.Add(this.Koleso_Visota_Label);
            this.groupBox2.Controls.Add(this.Koleso_Shirina_Label);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 434);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Колесо";
            // 
            // Koleso_Obem_Label
            // 
            this.Koleso_Obem_Label.AutoSize = true;
            this.Koleso_Obem_Label.Location = new System.Drawing.Point(97, 371);
            this.Koleso_Obem_Label.Name = "Koleso_Obem_Label";
            this.Koleso_Obem_Label.Size = new System.Drawing.Size(48, 15);
            this.Koleso_Obem_Label.TabIndex = 29;
            this.Koleso_Obem_Label.Text = "Объем:";
            // 
            // Koleso_Perimetr_Label
            // 
            this.Koleso_Perimetr_Label.AutoSize = true;
            this.Koleso_Perimetr_Label.Location = new System.Drawing.Point(79, 318);
            this.Koleso_Perimetr_Label.Name = "Koleso_Perimetr_Label";
            this.Koleso_Perimetr_Label.Size = new System.Drawing.Size(66, 15);
            this.Koleso_Perimetr_Label.TabIndex = 28;
            this.Koleso_Perimetr_Label.Text = "Периметр:";
            // 
            // Koleso_Obem
            // 
            this.Koleso_Obem.Location = new System.Drawing.Point(200, 368);
            this.Koleso_Obem.Name = "Koleso_Obem";
            this.Koleso_Obem.ReadOnly = true;
            this.Koleso_Obem.Size = new System.Drawing.Size(100, 23);
            this.Koleso_Obem.TabIndex = 27;
            // 
            // Koleso_perimetr
            // 
            this.Koleso_perimetr.Location = new System.Drawing.Point(200, 315);
            this.Koleso_perimetr.Name = "Koleso_perimetr";
            this.Koleso_perimetr.ReadOnly = true;
            this.Koleso_perimetr.Size = new System.Drawing.Size(100, 23);
            this.Koleso_perimetr.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Расчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1811, 828);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox Motor_Name;
        public System.Windows.Forms.TextBox Motor_Rab_Obem;
        public System.Windows.Forms.TextBox Motor_Koni;
        public System.Windows.Forms.TextBox Motor_Cilindr;
        public System.Windows.Forms.TextBox Motor_Rasxod;
        private System.Windows.Forms.Label Motor_Name_Label;
        private System.Windows.Forms.Label Motor_Rab_obem_Label;
        private System.Windows.Forms.Label Motor_Koni_Label;
        private System.Windows.Forms.Label Motor_Cilindr_Label;
        private System.Windows.Forms.Label Motor_Rasxod_Label;
        private System.Windows.Forms.Label Motor_KWT_Label;
        public System.Windows.Forms.TextBox Motor_KWT;
        public System.Windows.Forms.TextBox Motor_MAX_KWT;
        private System.Windows.Forms.Label Motor_MAX_KWT_Label;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Koleso_Shirina;
        public System.Windows.Forms.TextBox Koleso_Visota;
        public System.Windows.Forms.TextBox Koleso_Diametr;
        public System.Windows.Forms.TextBox Koleso_Tip_diska;
        private System.Windows.Forms.Label Koleso_Shirina_Label;
        private System.Windows.Forms.Label Koleso_Visota_Label;
        private System.Windows.Forms.Label Koleso_Diametr_Label;
        private System.Windows.Forms.Label Koleso_Tip_diska_Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Koleso_Obem_Label;
        private System.Windows.Forms.Label Koleso_Perimetr_Label;
        public System.Windows.Forms.TextBox Koleso_Obem;
        public System.Windows.Forms.TextBox Koleso_perimetr;
        private System.Windows.Forms.Button button2;
    }
}

