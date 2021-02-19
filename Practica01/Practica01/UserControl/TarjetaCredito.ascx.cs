using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica01.UserControl
{
    public partial class TarjetaCredito : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string NumeroTarjeta = this.txtNumeroTarjeta.Text;
            string cvv = this.txtCVV.Text;
            string NuevoNumero = "";
            string Marca = "";
            NumeroTarjeta = NumeroTarjeta.Replace("-", "");
            NumeroTarjeta = NumeroTarjeta.Replace(" ", "");
            if (String.IsNullOrEmpty(NumeroTarjeta))
            {
                this.lblError.CssClass = "text-danger";
                this.lblError.Text = "El numero de tarjeta no puede ir vacio";
                return;
            }
            int month = this.DropDownList1.SelectedIndex+1;
            int year = int.Parse(this.TextBox1.Text);
            DateTime fechaVencimiento = new DateTime(year,month,DateTime.Now.Day);

            if (DateTime.Now>fechaVencimiento)
            {
                this.lblError.CssClass = "text-danger";
                this.lblError.Text = "La tarjeta esta vencida";
                return;
            }
            if (NumeroTarjeta[0]!='3' && NumeroTarjeta[0] != '4' && NumeroTarjeta[0] != '5' && NumeroTarjeta[0] != '6')
            {
                this.lblError.CssClass = "text-danger";
                this.lblError.Text = "La tarjeta es invalida";
                return;
            }
            switch (NumeroTarjeta[0])
            {
                case '3':
                    Marca = "American Express";
                    break;
                case '4':
                    Marca = "Visa";
                    break;
                case '5':
                    Marca = " MasterCard";
                    break;
                case '6':
                    Marca = " Discover";
                    break;
                default:
                    break;
            }
            for (int i = 0; i < NumeroTarjeta.Length; i++)
            {
                double temp;
                temp = Convert.ToDouble(NumeroTarjeta[i].ToString());
                if (i%2==0)
                {
                    temp *= 2;
                    if (temp>9)
                    {
                        temp -= 9;
                    }
                }
                NuevoNumero += temp.ToString();
            }
            double total=0;
            foreach (var item in NuevoNumero)
            {
                total += Double.Parse(item.ToString());
            }
            if (total%10==0 && total<=150)
            {
                this.lblError.CssClass = "text-success";
                this.lblError.Text = "La tarjeta es valida";
                this.lblMarca.CssClass = "text-success";
                this.lblMarca.Text = "Su tarjeta es marca: "+ Marca;
                return;
            }
            this.lblError.CssClass = "text-danger";
            this.lblError.Text = "La tarjeta es invalida";
        }
    }
}