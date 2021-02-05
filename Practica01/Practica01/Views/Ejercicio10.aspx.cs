using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class Ejercicio10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string errorMessage = "Ocurrio un problema al convertir un numero, asegurese de ingresar solo numeros y que no este vacio";
            double x;
            if (!Double.TryParse(this.TextBox1.Text, out x))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            double resultado = (3 * Math.Pow(x, 5)) + (5 * Math.Pow(x, 3)) + (2 * x) - 7;
            this.Label1.CssClass = "";
            this.Label11.Text = "Para x= "+x+" , 3x^5+5x^3+2x-7 = "+resultado;
        }
    }
}