using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class EjercicioExtr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int numero;
            if (!Int32.TryParse(this.TextBox1.Text,out numero))
            {
                return;
            }
            string valor="";
            for (int i = 1; i <= 10; i++)
            {
                valor += numero + " x " + i + " = " + "<span class=text-danger>" + (numero * i).ToString() + "</span><br>";
            }
            this.Label11.Text = valor;
        }
    }
}