using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class Ejercicio08 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = this.Calendar1.SelectedDate;
            double NumeroTarot = fecha.Day + fecha.Month + fecha.Year;
            while (NumeroTarot.ToString().Length>1)
            {
                double acumTemp = 0;
                for (int i = 0; i < NumeroTarot.ToString().Length; i++)
                {
                    acumTemp += Convert.ToDouble(NumeroTarot.ToString()[i].ToString());
                }
                NumeroTarot = acumTemp;
            }
            this.Label11.Text = "Su numero del tarot es: "+NumeroTarot;
        }
    }
}