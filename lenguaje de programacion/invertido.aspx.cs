using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vectorinvertido
{
    public partial class invertido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btningresar_Click(object sender, EventArgs e)
        {
            int tamano;
            string aux = "", aux2 = "";
            tamano = Convert.ToInt32(Txttamano.Text);
            string[] vector = new string[tamano];
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("Ingrese datos alfa-numericos" + i));
                aux = aux + ","+ vector[i];
                Lblelementos.Text = aux;
                    }
            for (int i = vector.Length; i == 0; i --)
            {
                aux2 = aux2 + "," + vector[i];
                Lblinvertido.Text = aux2;
            }
        }
    }
}