using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class Respuesta : System.Web.UI.Page
    {
        double valor1, valor2;
        protected void Page_Load(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Request.QueryString["valor1"].ToString());
            valor2 = Convert.ToDouble(Request.QueryString["valor2"].ToString());
            this.lblValor1.Text=Request.QueryString["valor1"].ToString();
            this.lblValor2.Text=Request.QueryString["valor2"].ToString();
            this.lblRespuesta.Text = valor1.ToString() + " + " + valor2.ToString() + " = " + (valor1 + valor2).ToString();
        }
    }
}