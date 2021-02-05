using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class Ejercicio02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string errorMessage = "Ocurrio un problema al convertir un numero, asegurese de ingresar solo numeros y que no este vacio";
            double[] elementos = new double[10];
            if (!Double.TryParse(this.TextBox1.Text,out elementos[0]))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox2.Text, out elementos[1]))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox3.Text, out elementos[2]))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox4.Text, out elementos[3]))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox5.Text, out elementos[4]))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox6.Text, out elementos[5]))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox7.Text, out elementos[6]))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox8.Text, out elementos[7]))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox9.Text, out elementos[8]))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            if (!Double.TryParse(this.TextBox10.Text, out elementos[9]))
            {
                this.Label11.CssClass += " text-danger";
                this.Label11.Text = errorMessage;
                return;
            }
            double total=0;
            foreach (var item in elementos)
            {
                total += item;
            }
            double promedio = total / 10;
            this.Label11.CssClass = "";
            this.Label11.Text = "El promedio es "+promedio;
        }
    }
}