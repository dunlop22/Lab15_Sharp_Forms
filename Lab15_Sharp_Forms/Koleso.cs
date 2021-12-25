using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_Sharp_Forms
{
    class Koleso
    {
        public void obem(Form1 form1)
        {
            if (form1.Koleso_Diametr.Text != string.Empty && form1.Koleso_Shirina.Text != string.Empty)
            { 
                double duim = 25.375;
                form1.Koleso_Obem.Text = Convert.ToString(Math.Round(Math.PI * Convert.ToDouble(form1.Koleso_Diametr.Text) * duim / 1000 * (Convert.ToDouble(form1.Koleso_Diametr.Text) * duim / 1000) * Convert.ToDouble(form1.Koleso_Shirina.Text) / 1000));
            }
            else
            {
                form1.Koleso_Obem.Text = "Данных недостаточно!";
            }
}

        public void perimetr(Form1 form1)
        {
            if (form1.Koleso_Diametr.Text != string.Empty && form1.Koleso_Diametr.Text != string.Empty && form1.Koleso_Shirina.Text != string.Empty )
            {
                double duim = 25.375;
                form1.Koleso_perimetr.Text = Convert.ToString(Math.Round((Convert.ToDouble(form1.Koleso_Diametr.Text) / 2 * duim + Convert.ToDouble(form1.Koleso_Diametr.Text) * Convert.ToDouble(form1.Koleso_Shirina.Text) / 100) * 2 * Math.PI));
            }
            else
            {
                form1.Koleso_perimetr.Text = "Данных недостаточно!";
            }
        }
    }
}
