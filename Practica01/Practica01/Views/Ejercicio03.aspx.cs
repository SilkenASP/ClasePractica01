using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class Ejercicio03 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string errorMessage = "Ocurrio un problema al convertir un numero, asegurese de ingresar solo numeros y que no este vacio";
            double anios, meses,totalmeses;
            if (!Double.TryParse(this.TextBox1.Text, out anios))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox2.Text, out meses))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            totalmeses = anios * 12 + meses;
            this.Label11.CssClass = "";
            this.Label11.Text = "Usted tiene " + totalmeses +" meses de edad";
        }
    }
}