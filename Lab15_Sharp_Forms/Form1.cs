using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab15_Sharp_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int u = 0; u < 20; u++)
            {
                Kol_Sklad[u] = new Koleso();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Motor mot;
            mot = new Motor();
            mot.Max_KWT(this);
            mot.KWT(this);
        }

        private void Motor_Rab_Obem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void Motor_Cilindr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Motor_Rasxod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void Motor_Koni_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Koleso_Shirina_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Koleso_Visota_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Koleso_Diametr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koleso kol = new Koleso();
            kol.perimetr(this);
            kol.obem(this);
        }

        private void Zapaska_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Zapaska_check.Checked)
            {
                Zapaska_Diametr.ReadOnly = true;
                Zapaska_Shirina.ReadOnly = true;
                Zapaska_Tip_diska.ReadOnly = true;
                Zapaska_Visota.ReadOnly = true;

                Zapaska_Diametr.Text = Koleso_Diametr.Text;
                Zapaska_Visota.Text = Koleso_Visota.Text;
                Zapaska_Shirina.Text = Koleso_Shirina.Text;
                Zapaska_Tip_diska.Text = Koleso_Tip_diska.Text;
                Zapaska_Perimetr.Text = Koleso_perimetr.Text;
                Zapaska_obem.Text = Koleso_Obem.Text;
                
            }
            else
            {
                Zapaska_Diametr.ReadOnly = false;
                Zapaska_Shirina.ReadOnly = false;
                Zapaska_Tip_diska.ReadOnly = false;
                Zapaska_Visota.ReadOnly = false;

                Zapaska_Diametr.Text = "";
                Zapaska_Visota.Text = "";
                Zapaska_Shirina.Text = "";
                Zapaska_Tip_diska.Text = "";
                Zapaska_Perimetr.Text = "";
                Zapaska_obem.Text = "";
            }

        }
        
        public void Clean_Table_func()
        {
            do
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView1.Rows.Count > 1);
        }

        private void Koleso_ADD_Click(object sender, EventArgs e)
        {
            
            if (Koleso_Shirina.Text != string.Empty && Koleso_Visota.Text != string.Empty && Koleso_Diametr.Text != string.Empty && kolvo_koles_sklad < 19)
            {
                Kol_Sklad[kolvo_koles_sklad].shirina = Convert.ToDouble(Koleso_Shirina.Text);
                Kol_Sklad[kolvo_koles_sklad].visota = Convert.ToDouble(Koleso_Visota.Text);
                Kol_Sklad[kolvo_koles_sklad].diametr = Convert.ToDouble(Koleso_Diametr.Text);
                Kol_Sklad[kolvo_koles_sklad].tip_diska = Koleso_Tip_diska.Text;
                kolvo_koles_sklad++;

                List_Table();
            }
        }
        public int kolvo_koles_sklad = 0;
        Koleso[] Kol_Sklad = new Koleso[20];

        private void Clean_Kolesa_Click(object sender, EventArgs e)
        {
            Clean_Table_func();
            for (int u = 0; u < 20; u++)
            {
                Kol_Sklad[u] = new Koleso();
            }
            kolvo_koles_sklad = 0;
        }

        public void List_Table()
        {
            Clean_Table_func();
            for (int i = 0; i < kolvo_koles_sklad; i++)
            {
                List_Table_func(i);
            }
        }

        public void List_Table_func(int number)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[number].Cells[0].Value = number + 1;
            dataGridView1.Rows[number].Cells[1].Value = Kol_Sklad[number].diametr;
            dataGridView1.Rows[number].Cells[2].Value = Kol_Sklad[number].shirina;
            dataGridView1.Rows[number].Cells[3].Value = Kol_Sklad[number].visota;
            dataGridView1.Rows[number].Cells[4].Value = Kol_Sklad[number].tip_diska;
        }
        public void List_Table_Search(int num, int row_num)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[row_num].Cells[0].Value = row_num + 1;
            dataGridView1.Rows[row_num].Cells[1].Value = Kol_Sklad[num].diametr;
            dataGridView1.Rows[row_num].Cells[2].Value = Kol_Sklad[num].shirina;
            dataGridView1.Rows[row_num].Cells[3].Value = Kol_Sklad[num].visota;
            dataGridView1.Rows[row_num].Cells[4].Value = Kol_Sklad[num].tip_diska;
        }


        private void Clean_Table_Click(object sender, EventArgs e)
        {
            List_Table();
            Koleso_Search_Diametr.Text = "";
            Koleso_Search_Visota.Text = "";
            Koleso_Search_Shirina.Text = "";
        }

        private void Koleso_Search_Clean_Click(object sender, EventArgs e)
        {
            Koleso_Search_Diametr.Text = "";
            Koleso_Search_Visota.Text = "";
            Koleso_Search_Shirina.Text = "";
            List_Table();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int[] good = new int[20];
            for (int y = 0; y < 20; y++)
            {
                good[y] = -55;
            }
            for (int i = 0; i < kolvo_koles_sklad; i++)
            {
                if (Koleso_Search_Diametr.Text != string.Empty)
                {
                    if (Kol_Sklad[i].diametr == Convert.ToDouble(Koleso_Search_Diametr.Text))
                    {
                        if (good[i] != -20)
                        {
                            good[i] = i;
                        }
                    }
                    else
                    {
                        good[i] = -20;
                    }
                }
                if (Koleso_Search_Shirina.Text != string.Empty)
                {
                    if (Kol_Sklad[i].shirina == Convert.ToDouble(Koleso_Search_Shirina.Text))
                    {
                        if (good[i] != -20)
                        {
                            good[i] = i;
                        }
                    }
                    else
                    {
                        good[i] = -20;
                    }
                }
                if (Koleso_Search_Visota.Text != string.Empty)
                {
                    if (Kol_Sklad[i].visota == Convert.ToDouble(Koleso_Search_Visota.Text))
                    {
                        if (good[i] != -20)
                        {
                            good[i] = i;
                        }
                    }
                    else
                    {
                        good[i] = -20;
                    }
                }
            }
            int j = 0;
            Clean_Table_func();
            for (int u = 0; u < 20; u++)
            {
                
                if (good[u] >= 0)
                {
                    List_Table_Search(u, j);
                    j++;
                }
            }
        }
    }
}
