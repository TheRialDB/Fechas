using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fechas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            //limpieza del error provider
            epvTextos.Clear();

            //validacion para llenar los campos
            if (ValidarLlenado())
            {

            }
            else
            {
                //valores traidos de los textboxs
                int dia = Convert.ToInt32(txtDia.Text);
                int mes = Convert.ToInt32(txtMes.Text);
                int anual = Convert.ToInt32(txtAnual.Text);
                
                if (ValidarDatos())
                {

                }
                else
                {

                    //Variable de año bisiesto
                    bool anualTipo = false;
                    if (anual%4 == 0)
                    {
                        anualTipo = true;
                    }


                    switch (mes)
                    {
                        case 1:
                            if (dia==31)
                            {
                                lblRespuesta.Text = "1 de Febrero de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia+1 + " de Enero de " + anual;
                                break;
                            }
                        case 2:
                            if (dia == 31 || dia ==30 )
                            {
                                epvTextos.SetError(txtDia, "Febrero no tiene " + dia + " dias");
                                break;
                            }
                            else if (anualTipo && dia == 29)
                            {
                                lblRespuesta.Text = "1 de Marzo de " + anual;
                                break;
                            }
                            else if (!anualTipo && dia == 29)
                            {
                                epvTextos.SetError(txtDia, "Febrero este año no tiene 29 dias");
                                break;
                            }
                            else if (!anualTipo && dia == 28)
                            {
                                lblRespuesta.Text = "1 de Marzo de " + anual;
                                break;
                            }
                            else if (anualTipo && dia == 28)
                            {
                                lblRespuesta.Text = "29 de Febrero de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Febrero de " + anual;
                                break;
                            }
                        case 3:
                            if (dia == 31)
                            {
                                lblRespuesta.Text = "1 de Abril de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Marzo de " + anual;
                                break;
                            }

                        case 4:
                            if (dia == 31)
                            {
                                epvTextos.SetError(txtDia, "Abril tiene 30 dias");
                                break;
                            }
                            else if (dia == 30)
                            {
                                lblRespuesta.Text = "1 de Mayo de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Abril de " + anual;
                                break;
                            }
                        case 5:
                            if (dia == 31)
                            {
                                lblRespuesta.Text = "1 de Junio de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Mayo de " + anual;
                                break;
                            }
                        case 6:
                            if (dia == 31)
                            {
                                epvTextos.SetError(txtDia, "Junio tiene 30 dias");
                                break;
                            }
                            else if (dia == 30)
                            {
                                lblRespuesta.Text = "1 de Julio de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Junio de " + anual;
                                break;
                            }
                        case 7:
                            if (dia == 31)
                            {
                                lblRespuesta.Text = "1 de Agosto de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Julio de " + anual;
                                break;
                            }
                        case 8:
                            if (dia == 31)
                            {
                                lblRespuesta.Text = "1 de Septiembre de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Agosto de " + anual;
                                break;
                            }
                        case 9:
                            if (dia == 31)
                            {
                                epvTextos.SetError(txtDia, "Septiembre tiene 30 dias");
                                break;
                            }
                            else if (dia == 30)
                            {
                                lblRespuesta.Text = "1 de Octubre de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Septiembre de " + anual;
                                break;
                            }
                        case 10:
                            if (dia == 31)
                            {
                                lblRespuesta.Text = "1 de Noviembre de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Octubre de " + anual;
                                break;
                            }
                        case 11:
                            if (dia == 31)
                            {
                                epvTextos.SetError(txtDia, "Noviembre tiene 30 dias");
                                break;
                            }
                            else if (dia == 30)
                            {
                                lblRespuesta.Text = "1 de Diciembre de " + anual;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Noviembre de " + anual;
                                break;
                            }
                        case 12:
                            if (dia == 31)
                            {
                                lblRespuesta.Text = "1 de Enero de " + (anual+1);
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = dia + 1 + " de Diciembre de " + anual;
                                break;
                            }
                    }
                }
            }
        }

        //metodo para tener que llenar los campos
        private bool ValidarLlenado()
        {
            bool validar = false;

            if (txtDia.Text == "")
            {
                epvTextos.SetError(txtDia, "llenar campo");
                validar = true;
            }
            if (txtMes.Text == "")
            {
                epvTextos.SetError(txtMes, "llenar campo");
                validar = true;
            }
            if (txtAnual.Text == "")
            {
                epvTextos.SetError(txtAnual, "llenar campo");
                validar = true;
            }
            return validar;
        }

        private bool ValidarDatos()
        {
            bool validar = false;

            if (Convert.ToInt32(txtDia.Text) < 1 || Convert.ToInt32(txtDia.Text) > 31)
            {
                epvTextos.SetError(txtDia, "Los días van de 1 a 31");
                validar = true;
            }
            if (Convert.ToInt32(txtMes.Text) < 1 || Convert.ToInt32(txtMes.Text) > 12)
            {
                epvTextos.SetError(txtMes, "Los meses van de 1 a 12");
                validar = true;
            }
            return validar;
        }

        //Validacion para solo cargar numeros 
        private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtAnual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
