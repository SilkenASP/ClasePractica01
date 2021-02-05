using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class Ejercicio04 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double ingreso;
            string errorMessage = "Ocurrio un problema al convertir un numero, asegurese de ingresar solo numeros y que no este vacio";
            if (!Double.TryParse(this.TextBox1.Text, out ingreso))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            double impuesto = ingreso - 1000;
            impuesto *= 0.05;
            this.Label11.CssClass = "";
            this.Label11.Text = "El impuesto local a pagar es: $"+impuesto;
        }
    }
}