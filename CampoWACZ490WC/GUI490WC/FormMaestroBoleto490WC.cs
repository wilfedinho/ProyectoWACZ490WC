using BE490WC;
using BLL490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI490WC
{
    public partial class FormMaestroBoleto490WC : Form
    {
        public FormMaestroBoleto490WC()
        {
            InitializeComponent();
            Mostrar490WC();
            ActivarModoModificar490WC(false);
            HabilitarCalendarios490WC();
        }

        public void Mostrar490WC()
        {
            dgvBoleto490WC.Rows.Clear();
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            foreach (Boleto490WC bole490WC in gestorBoleto490WC.ObtenerTodosLosBoletos490WC())
            {
                if (bole490WC is BoletoIDA490WC boletoIDA490WC)
                {
                    dgvBoleto490WC.Rows.Add(boletoIDA490WC.IDBoleto490WC, "IDA", boletoIDA490WC.Origen490WC, boletoIDA490WC.Destino490WC, boletoIDA490WC.FechaPartida490WC.ToShortDateString(), boletoIDA490WC.FechaLlegada490WC.ToShortDateString(), null, null, boletoIDA490WC.ClaseBoleto490WC, boletoIDA490WC.EquipajePermitido490WC, boletoIDA490WC.Precio490WC, boletoIDA490WC.NumeroAsiento490WC);
                }

                if (bole490WC is BoletoIDAVUELTA490WC boletoIDAVUELTA490WC)
                {
                    dgvBoleto490WC.Rows.Add(boletoIDAVUELTA490WC.IDBoleto490WC, "IDA & VUELTA", boletoIDAVUELTA490WC.Origen490WC, boletoIDAVUELTA490WC.Destino490WC, boletoIDAVUELTA490WC.FechaPartida490WC.ToShortDateString(), boletoIDAVUELTA490WC.FechaLlegada490WC.ToShortDateString(), boletoIDAVUELTA490WC.FechaPartidaVUELTA490WC.ToShortDateString(), boletoIDAVUELTA490WC.FechaLlegadaVUELTA490WC.ToShortDateString(), boletoIDAVUELTA490WC.ClaseBoleto490WC, boletoIDAVUELTA490WC.EquipajePermitido490WC, boletoIDAVUELTA490WC.Precio490WC, boletoIDAVUELTA490WC.NumeroAsiento490WC);
                }
            }
        }

        public void LimpiarCampos490WC()
        {
            foreach (Control cl in this.Controls)
            {
                if (cl is TextBox tb)
                {
                    tb.Clear();
                }
            }

            CB_CLASEBOLETO490WC.SelectedIndex = -1;

            calendarioFECHAPARTIDA_IDA490WC.SelectionStart = DateTime.Now;
            calendarioFECHALLEGADA_IDA490WC.SelectionStart = DateTime.Now;
            calendarioFECHAPARTIDA_VUELTA490WC.SelectionStart = DateTime.Now;
            calendarioFECHALLEGADA_VUELTA490WC.SelectionStart = DateTime.Now;

        }

        public void ActivarModoModificar490WC(bool IsActivo)
        {
            if (IsActivo == true)
            {
                BT_SALIR490WC.Enabled = false;
                BT_ALTA490WC.Enabled = false;
                BT_BAJA490WC.Enabled = false;
                BT_MODIFICAR490WC.Enabled = false;
                BT_APLICAR490WC.Enabled = true;
                BT_CANCELAR490WC.Enabled = true;
                TB_ORIGEN490WC.Text = dgvBoleto490WC.SelectedRows[0].Cells["ColumnaOrigen"].Value.ToString();
                TB_DESTINO490WC.Text = dgvBoleto490WC.SelectedRows[0].Cells["ColumnaDestino"].Value.ToString();
                TB_PESOEQUIPAJE490WC.Text = dgvBoleto490WC.SelectedRows[0].Cells["ColumnaPesoEquipajePermitido"].Value.ToString();
                TB_PRECIO490WC.Text = dgvBoleto490WC.SelectedRows[0].Cells["ColumnaPrecio"].Value.ToString();
                TB_ASIENTO490WC.Text = dgvBoleto490WC.SelectedRows[0].Cells["ColumnaNumeroAsiento"].Value.ToString();
                CB_CLASEBOLETO490WC.Text = dgvBoleto490WC.SelectedRows[0].Cells["ColumnaClaseBoleto"].Value.ToString();



                calendarioFECHAPARTIDA_IDA490WC.SelectionStart = Convert.ToDateTime(dgvBoleto490WC.SelectedRows[0].Cells["ColumnaFechaPartidaIDA"].Value.ToString());
                calendarioFECHALLEGADA_IDA490WC.SelectionStart = Convert.ToDateTime(dgvBoleto490WC.SelectedRows[0].Cells["ColumnaFechaLlegadaIDA"].Value.ToString());



                GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
                Boleto490WC BoletoModificado490WC = gestorBoleto490WC.ObtenerBoletoPorID490WC(dgvBoleto490WC.SelectedRows[0].Cells["ColumnaID"].Value.ToString());

                if (BoletoModificado490WC is BoletoIDA490WC)
                {
                    RBIDA490WC.Checked = true;
                    RBIDA490WC.Enabled = false;
                    RBIDAVUELTA490WC.Enabled = false;
                }
                else
                {
                    calendarioFECHAPARTIDA_VUELTA490WC.SelectionStart = Convert.ToDateTime(dgvBoleto490WC.SelectedRows[0].Cells["ColumnaFechaPartidaVUELTA"].Value.ToString());
                    calendarioFECHALLEGADA_VUELTA490WC.SelectionStart = Convert.ToDateTime(dgvBoleto490WC.SelectedRows[0].Cells["ColumnaFechaLlegadaVUELTA"].Value.ToString());
                    RBIDAVUELTA490WC.Checked = true;
                    RBIDA490WC.Enabled = false;
                    RBIDAVUELTA490WC.Enabled = false;
                }
            }
            else
            {
                BT_SALIR490WC.Enabled = true;
                BT_ALTA490WC.Enabled = true;
                BT_BAJA490WC.Enabled = true;
                BT_MODIFICAR490WC.Enabled = true;
                BT_APLICAR490WC.Enabled = false;
                BT_CANCELAR490WC.Enabled = false;

                RBIDA490WC.Enabled = true;
                RBIDAVUELTA490WC.Enabled = true;
                LimpiarCampos490WC();
            }
        }

        private void HabilitarCalendarios490WC()
        {
            bool esSoloIda = RBIDA490WC.Checked;

            calendarioFECHAPARTIDA_IDA490WC.Enabled = true;
            calendarioFECHALLEGADA_IDA490WC.Enabled = true;

            calendarioFECHAPARTIDA_VUELTA490WC.Enabled = !esSoloIda;
            calendarioFECHALLEGADA_VUELTA490WC.Enabled = !esSoloIda;
        }


        private void BT_ALTA490WC_Click(object sender, EventArgs e)
        {
            Boleto490WC BoletoAlta490WC;
            //Cliente490WC cliente490WC = new Cliente490WC("Sistema", null, null, null, 0, null);
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            string id490WC = (gestorBoleto490WC.ObtenerTodosLosBoletos490WC().Count + 1).ToString();
            string origen490WC = TB_ORIGEN490WC.Text;
            string destino490WC = TB_DESTINO490WC.Text;
            DateTime fechaPartidaIDA490WC = calendarioFECHAPARTIDA_IDA490WC.SelectionStart;
            DateTime fechaLlegadaIDA490WC = calendarioFECHALLEGADA_IDA490WC.SelectionStart;
            bool isVendido490WC = false;
            string asiento490WC = TB_ASIENTO490WC.Text;
            if (gestorBoleto490WC.VerificarFormatoAsiento490WC(asiento490WC))
            {
                if (CB_CLASEBOLETO490WC.SelectedItem != null)
                {
                    string claseBoleto490WC = CB_CLASEBOLETO490WC.SelectedItem.ToString();
                    if (!string.IsNullOrEmpty(origen490WC))
                    {
                        if (!string.IsNullOrEmpty(destino490WC))
                        {

                            if (float.TryParse(TB_PESOEQUIPAJE490WC.Text, out float PesoEquipajePermitido490WC) && PesoEquipajePermitido490WC > 0)
                            {
                                if (float.TryParse(TB_PRECIO490WC.Text, out float Precio490WC) && Precio490WC > 0)
                                {
                                    if (RBIDA490WC.Checked)
                                    {
                                        if (fechaPartidaIDA490WC <= fechaLlegadaIDA490WC)
                                        {
                                            //BoletoAlta490WC = new BoletoIDA490WC(id490WC, origen490WC, destino490WC, fechaPartidaIDA490WC, fechaLlegadaIDA490WC, isVendido490WC, PesoEquipajePermitido490WC, claseBoleto490WC, Precio490WC, cliente490WC, asiento490WC);

                                          /*  if (!gestorBoleto490WC.ExisteBoletoEnAsiento490WC(BoletoAlta490WC))
                                            {
                                                gestorBoleto490WC.Alta490WC(BoletoAlta490WC);
                                                Mostrar490WC();
                                                ActivarModoModificar490WC(false);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Ya existe un Boleto cargado en el sistema con exactamente las mismas caracteristicas!!");
                                                ActivarModoModificar490WC(false);
                                            }
                                          */
                                        }
                                        else
                                        {
                                            MessageBox.Show("La fecha de partida no puede ser posterior a la fecha de llegada. Por favor, verifique las fechas.");
                                            ActivarModoModificar490WC(false);
                                        }
                                    }
                                    else
                                    {
                                        DateTime fechaPartidaVUELTA490WC = calendarioFECHAPARTIDA_VUELTA490WC.SelectionStart;
                                        DateTime fechaLlegadaVUELTA490WC = calendarioFECHALLEGADA_VUELTA490WC.SelectionStart;
                                        if (fechaPartidaIDA490WC <= fechaLlegadaIDA490WC && fechaLlegadaIDA490WC < fechaPartidaVUELTA490WC && fechaPartidaVUELTA490WC <= fechaLlegadaVUELTA490WC)
                                        {
                                           /* BoletoAlta490WC = new BoletoIDAVUELTA490WC(id490WC, origen490WC, destino490WC, fechaPartidaIDA490WC, fechaLlegadaIDA490WC, fechaPartidaVUELTA490WC, fechaLlegadaVUELTA490WC, isVendido490WC, PesoEquipajePermitido490WC, claseBoleto490WC, Precio490WC, cliente490WC, asiento490WC);
                                            if (!gestorBoleto490WC.ExisteBoletoEnAsiento490WC(BoletoAlta490WC))
                                            {
                                                gestorBoleto490WC.Alta490WC(BoletoAlta490WC);
                                                Mostrar490WC();
                                                ActivarModoModificar490WC(false);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Ya existe un Boleto cargado en el sistema con exactamente las mismas caracteristicas!!");
                                                ActivarModoModificar490WC(false);
                                            }
                                           */
                                        }
                                        else
                                        {
                                            MessageBox.Show("Las fechas de IDA no pueden ser posteriores a las fechas de VUELTA. Por favor, verifique las fechas.");
                                            ActivarModoModificar490WC(false);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El precio ingresado no es válido. Por favor, ingrese un número válido.");
                                    ActivarModoModificar490WC(false);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El peso de equipaje ingresado no es válido. Por favor, ingrese un número válido.");
                                ActivarModoModificar490WC(false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El destino no puede estar vacío. Por favor, ingrese un destino válido.");
                            ActivarModoModificar490WC(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El origen no puede estar vacío. Por favor, ingrese un origen válido.");
                        ActivarModoModificar490WC(false);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una clase de boleto. Por favor, seleccione una clase válida.");
                    ActivarModoModificar490WC(false);
                }

            }
            else
            {
                MessageBox.Show("Ingrese el numero de asiento con el formato 'A111' correcto!! ");
                ActivarModoModificar490WC(false);
            }
        }

        private void BT_BAJA490WC_Click(object sender, EventArgs e)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            string idBoleto490WC = dgvBoleto490WC.SelectedRows[0].Cells["ColumnaID"].Value.ToString();
            gestorBoleto490WC.Baja490WC(idBoleto490WC);
            Mostrar490WC();
            ActivarModoModificar490WC(false);
        }

        private void BT_MODIFICAR490WC_Click(object sender, EventArgs e)
        {
            ActivarModoModificar490WC(true);
        }

        private void BT_APLICAR490WC_Click(object sender, EventArgs e)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            Boleto490WC BoletoModificado490WC = gestorBoleto490WC.ObtenerBoletoPorID490WC(dgvBoleto490WC.SelectedRows[0].Cells["ColumnaID"].Value.ToString());
          //  Cliente490WC cliente490WC = new Cliente490WC("Sistema", null, null, null, 0, null);
            string origen490WC = TB_ORIGEN490WC.Text;
            string destino490WC = TB_DESTINO490WC.Text;
            string asiento490WC = TB_ASIENTO490WC.Text;
            DateTime fechaPartidaIDA490WC = calendarioFECHAPARTIDA_IDA490WC.SelectionStart;
            DateTime fechaLlegadaIDA490WC = calendarioFECHALLEGADA_IDA490WC.SelectionStart;

            if (gestorBoleto490WC.VerificarFormatoAsiento490WC(asiento490WC))
            {
                if (CB_CLASEBOLETO490WC.SelectedItem != null)
                {
                    string claseBoleto490WC = CB_CLASEBOLETO490WC.SelectedItem.ToString();
                    if (!string.IsNullOrEmpty(origen490WC))
                    {
                        if (!string.IsNullOrEmpty(destino490WC))
                        {
                            if (float.TryParse(TB_PESOEQUIPAJE490WC.Text, out float PesoEquipajePermitido490WC) && PesoEquipajePermitido490WC > 0)
                            {
                                if (float.TryParse(TB_PRECIO490WC.Text, out float Precio490WC) && Precio490WC > 0)
                                {
                                    if (RBIDA490WC.Checked)
                                    {
                                        if (fechaPartidaIDA490WC <= fechaLlegadaIDA490WC)
                                        {
                                            BoletoModificado490WC.Origen490WC = origen490WC;
                                            BoletoModificado490WC.Destino490WC = destino490WC;
                                            BoletoModificado490WC.FechaPartida490WC = fechaPartidaIDA490WC;
                                            BoletoModificado490WC.FechaLlegada490WC = fechaLlegadaIDA490WC;
                                            BoletoModificado490WC.EquipajePermitido490WC = PesoEquipajePermitido490WC;
                                            BoletoModificado490WC.ClaseBoleto490WC = claseBoleto490WC;
                                            BoletoModificado490WC.Precio490WC = Precio490WC;
                                          //  BoletoModificado490WC.Titular490WC = cliente490WC;
                                            BoletoModificado490WC.NumeroAsiento490WC = asiento490WC;
                                            if (!gestorBoleto490WC.ExisteBoletoEnAsientoParaModificar490WC(BoletoModificado490WC))
                                            {
                                                gestorBoleto490WC.Modificar490WC(BoletoModificado490WC);
                                                Mostrar490WC();
                                                ActivarModoModificar490WC(false);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Ya existe un Boleto cargado en el sistema con exactamente las mismas caracteristicas!!!");
                                                ActivarModoModificar490WC(false);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("La fecha de partida no puede ser posterior a la fecha de llegada. Por favor, verifique las fechas.");
                                            ActivarModoModificar490WC(false);
                                        }
                                    }
                                    else
                                    {
                                        DateTime fechaPartidaVUELTA490WC = calendarioFECHAPARTIDA_VUELTA490WC.SelectionStart;
                                        DateTime fechaLlegadaVUELTA490WC = calendarioFECHALLEGADA_VUELTA490WC.SelectionStart;
                                        if (fechaPartidaIDA490WC <= fechaLlegadaIDA490WC && fechaLlegadaIDA490WC < fechaPartidaVUELTA490WC && fechaPartidaVUELTA490WC <= fechaLlegadaVUELTA490WC)
                                        {
                                            BoletoModificado490WC.Origen490WC = origen490WC;
                                            BoletoModificado490WC.Destino490WC = destino490WC;
                                            BoletoModificado490WC.FechaPartida490WC = fechaPartidaIDA490WC;
                                            (BoletoModificado490WC as BoletoIDAVUELTA490WC).FechaPartidaVUELTA490WC = fechaPartidaVUELTA490WC;
                                            BoletoModificado490WC.FechaLlegada490WC = fechaLlegadaIDA490WC;
                                            (BoletoModificado490WC as BoletoIDAVUELTA490WC).FechaLlegadaVUELTA490WC = fechaLlegadaVUELTA490WC;
                                            BoletoModificado490WC.EquipajePermitido490WC = PesoEquipajePermitido490WC;
                                            BoletoModificado490WC.ClaseBoleto490WC = claseBoleto490WC;
                                            BoletoModificado490WC.Precio490WC = Precio490WC;
                                          //  BoletoModificado490WC.Titular490WC = cliente490WC;
                                            BoletoModificado490WC.NumeroAsiento490WC = asiento490WC;
                                            if (!gestorBoleto490WC.ExisteBoletoEnAsientoParaModificar490WC(BoletoModificado490WC))
                                            {
                                                gestorBoleto490WC.Modificar490WC(BoletoModificado490WC);
                                                Mostrar490WC();
                                                ActivarModoModificar490WC(false);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Ya existe un Boleto cargado en el sistema con exactamente las mismas caracteristicas!!!");
                                                ActivarModoModificar490WC(false);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Las fechas de IDA no pueden ser posteriores a las fechas de VUELTA. Por favor, verifique las fechas.");
                                            ActivarModoModificar490WC(false);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El precio ingresado no es válido. Por favor, ingrese un número válido.");
                                    ActivarModoModificar490WC(false);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El peso de equipaje ingresado no es válido. Por favor, ingrese un número válido.");
                                ActivarModoModificar490WC(false);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El destino no puede estar vacío. Por favor, ingrese un destino válido.");
                            ActivarModoModificar490WC(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El origen no puede estar vacío. Por favor, ingrese un origen válido.");
                        ActivarModoModificar490WC(false);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una clase de boleto. Por favor, seleccione una clase válida.");
                    ActivarModoModificar490WC(false);
                }

            }
            else
            {
                MessageBox.Show("Ingrese el numero de asiento con el formato 'A111' correcto!! ");
                ActivarModoModificar490WC(false);
            }

        }

        private void BT_CANCELAR490WC_Click(object sender, EventArgs e)
        {
            ActivarModoModificar490WC(false);

        }

        private void BT_SALIR490WC_Click(object sender, EventArgs e)
        {
            ActivarModoModificar490WC(false);
            this.Close();
        }

        private void RBIDA490WC_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCalendarios490WC();
        }

        private void FormMaestroBoleto490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActivarModoModificar490WC(false);
            this.Close();
        }
    }
}
