using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class Ejercicio09 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string errorMessage = "Ocurrio un problema al convertir un numero, asegurese de ingresar solo numeros y que no este vacio";
            double a, b, c;
            if (!Double.TryParse(this.TextBox1.Text, out a))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox2.Text, out b))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox3.Text, out c))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            double sqrtpart = (b * b) - (4 * a * c);

            double x, x1, x2;

            if (sqrtpart > 0)
            {

                x1 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);

                x2 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
                this.Label11.CssClass = "";
                this.Label11.Text = "Las raices son: " + x1 + " , "+x2;
            }
            else if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                x = -b / (2 * a);
                this.Label11.Text = "Las raiz es: " + x;
            }
            else
            {
                x = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                this.Label11.Text = "Las raiz es: " + x;
            }
        }
    }
}