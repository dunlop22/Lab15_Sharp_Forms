using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_Sharp_Forms
{
    class Motor
    {
        public Motor()
        {

        }

        public void Max_KWT(Form1 form1)	//вывод максимально возможной мощности (в квтч) после апгрейда
        {
            if (form1.Motor_Koni.Text != string.Empty)
            {
                if (Convert.ToDouble(form1.Motor_Rab_Obem.Text) >= 2.0)
                {
                    form1.Motor_MAX_KWT.Text = Convert.ToString(Math.Round(Convert.ToDouble(form1.Motor_Koni.Text) * 1.2 / 1.3596));
                }
                else
                {
                    form1.Motor_MAX_KWT.Text = Convert.ToString(Math.Round(Convert.ToDouble(form1.Motor_Koni.Text) * 1.1 / 1.3596));
                }
            }
            else
            {
                form1.Motor_MAX_KWT.Text = "Данных недостаточно!";
            }
        }
        public void KWT(Form1 form1) //вывод текущей мощности (в квтч)
        {
            if (form1.Motor_Koni.Text != string.Empty)
            {
                form1.Motor_KWT.Text = Convert.ToString(Math.Round(Convert.ToDouble(form1.Motor_Koni.Text) / 1.3596));
            }
            else
            {
                form1.Motor_KWT.Text = "Данных недостаточно!";
            }
        }
    }

}
