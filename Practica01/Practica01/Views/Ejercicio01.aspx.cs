using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class Ejercicio01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvertir_Click(object sender, EventArgs e)
        {
            double pulgadas;
            var conver = double.TryParse(this.pulgadas.Text, out pulgadas);
            if (!conver)
            {
                this.Respuesta.Text = "Ocurrio un problema al convertir, asegurese que el valor en el textbox sean numeros y no este vacio";
                return;
            }
            double conversion = pulgadas * 2.54;
            this.Respuesta.Text= pulgadas + " plg equivale a " + conversion + " cm";
        }
    }
}