using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.Views
{
    public partial class Ejercicio07 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            String palabras="";
            string palabra = this.TextBox1.Text;
            palabras += palabra;
            for (int i = 0; i < palabra.Length; i++)
            {
                palabra = palabra.Insert(0,palabra[palabra.Length-1].ToString());
                palabra = palabra.Remove(palabra.Length-1);
                palabras += ", " + palabra;
            }
            this.Label11.Text = palabras;
        }
    }
}