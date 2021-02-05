using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class Ejercicio05 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            string errorMessage = "Ocurrio un problema al convertir un numero, asegurese de ingresar solo numeros y que no este vacio";
            if (!Double.TryParse(this.TextBox1.Text, out valor1))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox2.Text, out valor2))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            string nombre = (sender as Button).ID;
            string operacion="";
            double resultado=0;
            if (nombre.Equals("btnSumar"))
            {
                resultado = valor1 + valor2;
                operacion = " + ";
            }
            else if (nombre.Equals("btnRestar"))
            {
                resultado = valor1 - valor2;
                operacion = " - ";
            }
            else if (nombre.Equals("btnMultiplicar"))
            {
                resultado = valor1 * valor2;
                operacion = " * ";
            }
            else if (nombre.Equals("btnDividir"))
            {
                resultado = valor1 / valor2;
                operacion = " / ";
            }
            this.Label11.CssClass = "";
            this.Label11.Text = valor1.ToString() + operacion + valor2.ToString() + " = " + resultado.ToString();
        }
    }
}