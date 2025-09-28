using BE490WC;
using BLL490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace GUI490WC
{
    public partial class FormAplicarCambiosBoleto490WC : Form, iObserverLenguaje490WC
    {
        Boleto490WC boletoOriginal490WC;
        Cliente490WC clienteOriginal490WC;
        FormSeleccionarBeneficio490WC formSeleccionarBeneficio490WC;
        Timer timer;
        Random random;
        bool booleanoRandom;
        public FormAplicarCambiosBoleto490WC()
        {
            InitializeComponent();
            Mostrar();
            HabilitarOpcionesModificar();
            //TB_CARTELERACAMBIOS490WC.Text = $"Recargos En Base Al Precio Del Boleto {Environment.NewLine} Modificar Fechas ===> 30% {Environment.NewLine} Modificar Beneficio ===> 20% {Environment.NewLine} Modificar Clase Boleto ===> 40% {Environment.NewLine} Modificar Asiento ===> 20% {Environment.NewLine} Modificar Peso del Equipaje ===> 13% {Environment.NewLine} Modificar Titular ===> 60%";
            random = new Random();
            timer = new Timer();
            booleanoRandom = false;
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }

        private void FormAplicarCambiosBoleto490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }

        private void FormAplicarCambiosBoleto490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Desuscribir490WC(this);
        }

        public void ActualizarLenguaje490WC()
        {
            RecorrerControles490WC(this);
        }

        public void RecorrerControles490WC(Control control490WC)
        {
            foreach (Control c490WC in control490WC.Controls)
            {
                if ((c490WC is TextBox tb490WC) == false)
                {

                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);


                    if (c490WC.HasChildren)
                    {
                        RecorrerControles490WC(c490WC);
                    }
                    if (c490WC is DataGridView dgv490WC)
                    {
                        foreach (DataGridViewColumn columna490WC in dgv490WC.Columns)
                        {
                            columna490WC.HeaderText = Traductor490WC.TraductorSG490WC.Traducir490WC(columna490WC.Name);
                        }
                    }
                }
                else if (c490WC is TextBox)
                {
                    if (c490WC.Name == "TB_CARTELERACAMBIOS490WC")
                    {
                        string texto490WC = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                        texto490WC = texto490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TB_CARTELERACAMBIOS490WC.Text = texto490WC;
                    }
                }
            }
        }

        private string ConstruirTextoBoleto490WC()
        {
            var sb = new StringBuilder();
            string textoNumeroBoleto490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("NumeroBoleto490WC");
            textoNumeroBoleto490WC = textoNumeroBoleto490WC.Replace("{boletoOriginal490WC.IDBoleto490WC}", $"{boletoOriginal490WC.IDBoleto490WC}");
            sb.AppendLine(textoNumeroBoleto490WC);
            string textoOrigen490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("Origen490WC");
            textoOrigen490WC = textoOrigen490WC.Replace("{boletoOriginal490WC.Origen490WC}", $"{boletoOriginal490WC.Origen490WC}");
            sb.AppendLine(textoOrigen490WC);
            string textoDestino490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("Destino490WC");
            textoDestino490WC = textoDestino490WC.Replace("{boletoOriginal490WC.Destino490WC}", $"{boletoOriginal490WC.Destino490WC}");
            sb.AppendLine(textoDestino490WC);
            string textoFechaPartida490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("FechaPartida490WC");
            textoFechaPartida490WC = textoFechaPartida490WC.Replace("{boletoOriginal490WC.FechaPartida490WC}", $"{boletoOriginal490WC.FechaPartida490WC.ToString("dd/MM/yyyy")}");
            sb.AppendLine(textoFechaPartida490WC);
            string textoFechaLlegada490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("FechaLlegada490WC");
            textoFechaLlegada490WC = textoFechaLlegada490WC.Replace("{boletoOriginal490WC.FechaLlegada490WC}", $"{boletoOriginal490WC.FechaLlegada490WC.ToString("dd/MM/yyyy")}");
            sb.AppendLine(textoFechaLlegada490WC);

            if (boletoOriginal490WC is BoletoIDAVUELTA490WC idaVuelta)
            {
                string textoFechaPartidaVUELTA490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("FechaPartidaVUELTA490WC");
                textoFechaPartidaVUELTA490WC = textoFechaPartidaVUELTA490WC.Replace("{idaVuelta.FechaPartidaVUELTA490WC}", $"{idaVuelta.FechaPartidaVUELTA490WC.ToString("dd/MM/yyyy")}");
                sb.AppendLine(textoFechaPartidaVUELTA490WC);
                string textoFechaLlegadaVUELTA490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("FechaLlegadaVUELTA490WC");
                textoFechaLlegadaVUELTA490WC = textoFechaLlegadaVUELTA490WC.Replace("{idaVuelta.FechaLlegadaVUELTA490WC}", $"{idaVuelta.FechaLlegadaVUELTA490WC.ToString("dd/MM/yyyy")}");
                sb.AppendLine(textoFechaLlegadaVUELTA490WC);
            }
            string textoClaseBoleto490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ClaseBoleto490WC");
            textoClaseBoleto490WC = textoClaseBoleto490WC.Replace("{boletoOriginal490WC.ClaseBoleto490WC}", $"{boletoOriginal490WC.ClaseBoleto490WC}");
            sb.AppendLine(textoClaseBoleto490WC);
            string textoEquipajePermitido490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("EquipajePermitido490WC");
            textoEquipajePermitido490WC = textoEquipajePermitido490WC.Replace("{boletoOriginal490WC.EquipajePermitido490WC}", $"{boletoOriginal490WC.EquipajePermitido490WC}");
            sb.AppendLine(textoEquipajePermitido490WC);
            string textoTitular490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("Titular490WC");
            textoTitular490WC = textoTitular490WC.Replace("{boletoOriginal490WC.Titular490WC.DNI490WC}", $"{boletoOriginal490WC.Titular490WC.DNI490WC}");
            textoTitular490WC = textoTitular490WC.Replace("{boletoOriginal490WC.Titular490WC.Nombre490WC}", $"{boletoOriginal490WC.Titular490WC.Nombre490WC}");
            textoTitular490WC = textoTitular490WC.Replace("{boletoOriginal490WC.Titular490WC.Apellido490WC}", $"{boletoOriginal490WC.Titular490WC.Apellido490WC}");
            sb.AppendLine(textoTitular490WC);
            string textoAsiento490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("NumeroAsiento490WC");
            textoAsiento490WC = textoAsiento490WC.Replace("{boletoOriginal490WC.NumeroAsiento490WC}", $"{boletoOriginal490WC.NumeroAsiento490WC}");
            sb.AppendLine(textoAsiento490WC);


            if (string.IsNullOrWhiteSpace(boletoOriginal490WC.BeneficioAplicado490WC))
            {
                string textoBeneficioAplicado490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("BeneficioNoPosee490WC");
                sb.AppendLine(textoBeneficioAplicado490WC);
            }
            else
            {
                string textoBeneficioAplicado490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("BeneficioAplicado490WC");
                textoBeneficioAplicado490WC = textoBeneficioAplicado490WC.Replace("{boletoOriginal490WC.BeneficioAplicado490WC}", $"{boletoOriginal490WC.BeneficioAplicado490WC}");
                sb.AppendLine(textoBeneficioAplicado490WC);
            }
            string textoPrecio490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("Precio490WC");
            textoPrecio490WC = textoPrecio490WC.Replace("{boletoOriginal490WC.Precio490WC}", $"{boletoOriginal490WC.Precio490WC}");
            sb.AppendLine(textoPrecio490WC);
            return sb.ToString();
        }

        public void Mostrar()
        {
            TBINFOBOLETOINFOPREVIA490WC.Clear();
            if (boletoOriginal490WC == null)
            {
                string textoIngreseNumeroBoleto490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("IngreseNumeroBoleto490WC");
                TBINFOBOLETOINFOPREVIA490WC.Text = textoIngreseNumeroBoleto490WC;
                calendarioFECHAPARTIDA_IDA490WC.SelectionStart = DateTime.Now;
                calendarioFECHALLEGADA_IDA490WC.SelectionStart = DateTime.Now;
                calendarioFECHAPARTIDA_VUELTA490WC.SelectionStart = DateTime.Now;
                calendarioFECHALLEGADA_VUELTA490WC.SelectionStart = DateTime.Now;
                TB_ASIENTO490WC.Clear();
                TB_PESOEQUIPAJE490WC.Clear();
                CB_BENEFICIOSCLIENTE490WC.Items.Clear();

            }
            else
            {

                TB_ASIENTO490WC.Text = boletoOriginal490WC.NumeroAsiento490WC;
                TB_PESOEQUIPAJE490WC.Text = boletoOriginal490WC.EquipajePermitido490WC.ToString();
                calendarioFECHAPARTIDA_IDA490WC.SelectionStart = boletoOriginal490WC.FechaPartida490WC;
                calendarioFECHALLEGADA_IDA490WC.SelectionStart = boletoOriginal490WC.FechaLlegada490WC;
                if (boletoOriginal490WC is BoletoIDAVUELTA490WC boleIDAVUELTA490WC)
                {
                    TBINFOBOLETOINFOPREVIA490WC.Text = ConstruirTextoBoleto490WC();
                    calendarioFECHAPARTIDA_VUELTA490WC.SelectionStart = boleIDAVUELTA490WC.FechaPartidaVUELTA490WC;
                    calendarioFECHALLEGADA_VUELTA490WC.SelectionStart = boleIDAVUELTA490WC.FechaLlegadaVUELTA490WC;
                }
                else
                {
                    TBINFOBOLETOINFOPREVIA490WC.Text = ConstruirTextoBoleto490WC();
                }

            }

        }
        public void LlenarCB()
        {
            if (clienteOriginal490WC.BeneficiosCliente490WC.Count > 0)
            {
                foreach (Beneficio490WC bene490WC in clienteOriginal490WC.BeneficiosCliente490WC)
                {
                    if (!CB_BENEFICIOSCLIENTE490WC.Items.Contains(bene490WC.Nombre490WC))
                    {
                        CB_BENEFICIOSCLIENTE490WC.Items.Add(bene490WC.Nombre490WC);

                    }
                }
            }
        }
        public void HabilitarOpcionesModificar()
        {
            CB_BENEFICIOSCLIENTE490WC.SelectedIndex = -1;
            CB_CLASEBOLETO490WC.SelectedIndex = -1;
            if (boletoOriginal490WC != null)
            {
                calendarioFECHAPARTIDA_IDA490WC.Enabled = true;
                calendarioFECHALLEGADA_IDA490WC.Enabled = true;
                if (boletoOriginal490WC is BoletoIDAVUELTA490WC)
                {
                    calendarioFECHAPARTIDA_VUELTA490WC.Enabled = true;
                    calendarioFECHALLEGADA_VUELTA490WC.Enabled = true;
                }
                else
                {
                    calendarioFECHAPARTIDA_VUELTA490WC.Enabled = false;
                    calendarioFECHALLEGADA_VUELTA490WC.Enabled = false;
                }
                CB_BENEFICIOSCLIENTE490WC.Enabled = true;
                CB_BENEFICIOSCLIENTE490WC.Items.Clear();
                LlenarCB();
                CB_BENEFICIOSCLIENTE490WC.Text = boletoOriginal490WC.BeneficioAplicado490WC;
                CB_CLASEBOLETO490WC.Text = boletoOriginal490WC.ClaseBoleto490WC;
                BT_SELECCIONARBENEFICIO490WC.Enabled = true;
                CB_CLASEBOLETO490WC.Enabled = true;
                TB_ASIENTO490WC.Enabled = true;
                TB_PESOEQUIPAJE490WC.Enabled = true;
                BarraProgresoConsulta490WC.Enabled = true;
                BT_CONSULTARCAMBIOS490WC.Enabled = true;

            }
            else
            {
                calendarioFECHAPARTIDA_IDA490WC.Enabled = false;
                calendarioFECHALLEGADA_IDA490WC.Enabled = false;

                calendarioFECHAPARTIDA_VUELTA490WC.Enabled = false;
                calendarioFECHALLEGADA_VUELTA490WC.Enabled = false;

                CB_BENEFICIOSCLIENTE490WC.Enabled = false;
                CB_BENEFICIOSCLIENTE490WC.Items.Clear();
                BT_SELECCIONARBENEFICIO490WC.Enabled = false;
                BT_APLICARCAMBIOS490WC.Enabled = false;
                CB_CLASEBOLETO490WC.Enabled = false;
                TB_ASIENTO490WC.Enabled = false;
                TB_PESOEQUIPAJE490WC.Enabled = false;
                BarraProgresoConsulta490WC.Enabled = false;
                BT_CONSULTARCAMBIOS490WC.Enabled = false;

            }
        }


        private void BT_BUSCARBOLETO490WC_Click(object sender, EventArgs e)
        {
            string NumeroBoleto490WC = TB_NUMEROBOLETO490WC.Text;
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            boletoOriginal490WC = gestorBoleto490WC.ObtenerBoletoParaModificarPorID490WC(NumeroBoleto490WC);
            if (!string.IsNullOrWhiteSpace(NumeroBoleto490WC))
            {
                if (boletoOriginal490WC != null)
                {
                    clienteOriginal490WC = gestorCliente490WC.BuscarClientePorDNI490WC(boletoOriginal490WC.Titular490WC.DNI490WC);
                    Mostrar();
                    HabilitarOpcionesModificar();
                }
                else
                {
                    clienteOriginal490WC = null;
                    Mostrar();
                    HabilitarOpcionesModificar();
                    string textoBoletoNoDisponible490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("BoletoNoDisponible490WC");
                    MessageBox.Show(textoBoletoNoDisponible490WC);
                }
            }
            else
            {
                clienteOriginal490WC = null;
                Mostrar();
                HabilitarOpcionesModificar();
                string textoError490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("IngreseNumeroBoleto490WC");
                MessageBox.Show(textoError490WC);
            }
            TB_NUMEROBOLETO490WC.Clear();
        }

        Boleto490WC boletoModificarCopia490WC;
        bool IsCambioFecha490WC = false;
        bool IsCambioBeneficio490WC = false;
        bool IsCambioClaseBoleto490WC = false;
        bool IsCambioAsiento490WC = false;
        bool IsCambioPesoEquipaje490WC = false;
        public void VerificarCambios490WC()
        {
            if (boletoOriginal490WC is BoletoIDAVUELTA490WC)
            {
                if (boletoOriginal490WC.FechaPartida490WC.Date != boletoModificarCopia490WC.FechaPartida490WC.Date || boletoOriginal490WC.FechaLlegada490WC.Date != boletoModificarCopia490WC.FechaLlegada490WC.Date || (boletoOriginal490WC as BoletoIDAVUELTA490WC).FechaPartidaVUELTA490WC.Date != (boletoModificarCopia490WC as BoletoIDAVUELTA490WC).FechaPartidaVUELTA490WC.Date || (boletoOriginal490WC as BoletoIDAVUELTA490WC).FechaLlegadaVUELTA490WC.Date != (boletoModificarCopia490WC as BoletoIDAVUELTA490WC).FechaLlegadaVUELTA490WC.Date)
                {
                    IsCambioFecha490WC = true;
                }
                if (boletoOriginal490WC.BeneficioAplicado490WC != boletoModificarCopia490WC.BeneficioAplicado490WC)
                {
                    IsCambioBeneficio490WC = true;
                }
                if (boletoOriginal490WC.ClaseBoleto490WC != boletoModificarCopia490WC.ClaseBoleto490WC)
                {
                    IsCambioClaseBoleto490WC = true;
                }
                if (boletoOriginal490WC.NumeroAsiento490WC != boletoModificarCopia490WC.NumeroAsiento490WC)
                {
                    IsCambioAsiento490WC = true;
                }
                if (boletoOriginal490WC.EquipajePermitido490WC != boletoModificarCopia490WC.EquipajePermitido490WC)
                {
                    IsCambioPesoEquipaje490WC = true;
                }
            }
            else
            {
                if (boletoOriginal490WC.FechaPartida490WC.Date != boletoModificarCopia490WC.FechaPartida490WC.Date || boletoOriginal490WC.FechaLlegada490WC.Date != boletoModificarCopia490WC.FechaLlegada490WC.Date)
                {
                    IsCambioFecha490WC = true;
                }
                if (boletoOriginal490WC.BeneficioAplicado490WC != boletoModificarCopia490WC.BeneficioAplicado490WC)
                {
                    IsCambioBeneficio490WC = true;
                }
                if (boletoOriginal490WC.ClaseBoleto490WC != boletoModificarCopia490WC.ClaseBoleto490WC)
                {
                    IsCambioClaseBoleto490WC = true;
                }
                if (boletoOriginal490WC.NumeroAsiento490WC != boletoModificarCopia490WC.NumeroAsiento490WC)
                {
                    IsCambioAsiento490WC = true;
                }
                if (boletoOriginal490WC.EquipajePermitido490WC != boletoModificarCopia490WC.EquipajePermitido490WC)
                {
                    IsCambioPesoEquipaje490WC = true;
                }
            }
        }
        public string ArmarArrayCambiosBoleto490WC()
        {
            List<string> cambios490WC = new List<string>();
            cambios490WC.Add($"{boletoOriginal490WC.IDBoleto490WC}");
            if (boletoOriginal490WC is BoletoIDAVUELTA490WC)
            {
                if (IsCambioFecha490WC)
                {
                    cambios490WC.Add($"{boletoModificarCopia490WC.FechaPartida490WC.ToString("dd/MM/yyyy")}");
                    cambios490WC.Add($"{boletoModificarCopia490WC.FechaLlegada490WC.ToString("dd/MM/yyyy")}");
                    cambios490WC.Add($"{(boletoModificarCopia490WC as BoletoIDAVUELTA490WC).FechaPartidaVUELTA490WC.ToString("dd/MM/yyyy")}");
                    cambios490WC.Add($"{(boletoModificarCopia490WC as BoletoIDAVUELTA490WC).FechaLlegadaVUELTA490WC.ToString("dd/MM/yyyy")}");
                }
                else
                {
                    cambios490WC.Add("");
                    cambios490WC.Add("");
                    cambios490WC.Add("");
                    cambios490WC.Add("");
                }
                if (IsCambioBeneficio490WC)
                {
                    cambios490WC.Add($"{boletoModificarCopia490WC.BeneficioAplicado490WC}");
                }
                else
                {
                    cambios490WC.Add("");
                }
                if (IsCambioClaseBoleto490WC)
                {
                    cambios490WC.Add($"{boletoModificarCopia490WC.ClaseBoleto490WC}");
                }
                else
                {
                    cambios490WC.Add("");
                }
                if (IsCambioAsiento490WC)
                {
                    cambios490WC.Add($"{boletoModificarCopia490WC.NumeroAsiento490WC}");
                }
                else
                {
                    cambios490WC.Add("");
                }
                if (IsCambioPesoEquipaje490WC)
                {
                    cambios490WC.Add($"{boletoModificarCopia490WC.EquipajePermitido490WC}");
                }
                else
                {
                    cambios490WC.Add("");
                }
            }
            else
            {
                if (IsCambioFecha490WC)
                {
                    cambios490WC.Add($"{boletoModificarCopia490WC.FechaPartida490WC.ToString("dd/MM/yyyy")}");
                    cambios490WC.Add($"{boletoModificarCopia490WC.FechaLlegada490WC.ToString("dd/MM/yyyy")}");
                    cambios490WC.Add("");
                    cambios490WC.Add("");
                }
                else
                {
                    cambios490WC.Add("");
                    cambios490WC.Add("");
                    cambios490WC.Add("");
                    cambios490WC.Add("");
                }
                if (IsCambioBeneficio490WC)
                {
                    cambios490WC.Add($"{boletoModificarCopia490WC.BeneficioAplicado490WC}");
                }
                else
                {
                    cambios490WC.Add("");
                }
                if (IsCambioClaseBoleto490WC)
                {
                    cambios490WC.Add($"{boletoModificarCopia490WC.ClaseBoleto490WC}");
                }
                else
                {
                    cambios490WC.Add("");
                }
                if (IsCambioAsiento490WC)
                {
                    cambios490WC.Add($"{boletoModificarCopia490WC.NumeroAsiento490WC}");
                }
                else
                {
                    cambios490WC.Add("");
                }
                if (IsCambioPesoEquipaje490WC)
                {
                    cambios490WC.Add($"{boletoModificarCopia490WC.EquipajePermitido490WC}");
                }
                else
                {
                    cambios490WC.Add("");
                }
            }
            cambios490WC.Add("");
            return string.Join(";", cambios490WC);
        }
        public void RecalcularPrecioBoleto490WC()
        {
            float precioFinal490WC = boletoOriginal490WC.Precio490WC;
            if (IsCambioFecha490WC)
            {
                precioFinal490WC += (boletoOriginal490WC.Precio490WC * 0.30f);
            }
            if (IsCambioBeneficio490WC)
            {
                precioFinal490WC += (boletoOriginal490WC.Precio490WC * 0.20f);
            }
            if (IsCambioClaseBoleto490WC)
            {
                precioFinal490WC += (boletoOriginal490WC.Precio490WC * 0.40f);
            }
            if (IsCambioAsiento490WC)
            {
                precioFinal490WC += (boletoOriginal490WC.Precio490WC * 0.20f);
            }
            if (IsCambioPesoEquipaje490WC)
            {
                precioFinal490WC += (boletoOriginal490WC.Precio490WC * 0.13f);
            }
            boletoModificarCopia490WC.Precio490WC = precioFinal490WC;

        }
        private void BT_CONSULTARCAMBIOS490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCLiente490WC = new GestorCliente490WC();
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            DateTime fechaPartidaIDA490WC = calendarioFECHAPARTIDA_IDA490WC.SelectionStart;
            DateTime fechaLlegadaIDA490WC = calendarioFECHALLEGADA_IDA490WC.SelectionStart;
            string asiento490WC = TB_ASIENTO490WC.Text;
            string pesoEquipaje490WC = TB_PESOEQUIPAJE490WC.Text;
            if (!string.IsNullOrWhiteSpace(CB_CLASEBOLETO490WC.Text))
            {
                string beneficio490WC = CB_BENEFICIOSCLIENTE490WC.Text;
                if (string.IsNullOrWhiteSpace(CB_BENEFICIOSCLIENTE490WC.Text))
                {
                    beneficio490WC = null;

                }
                string claseBoleto490WC = CB_CLASEBOLETO490WC.Text;
                if (gestorBoleto490WC.VerificarFormatoAsiento490WC(asiento490WC))
                {

                    if (float.TryParse(pesoEquipaje490WC, out float pesoParse490WC) && pesoParse490WC > 0)
                    {
                        if (boletoOriginal490WC is BoletoIDAVUELTA490WC)
                        {
                            DateTime fechaPartidaVUELTA490WC = calendarioFECHAPARTIDA_VUELTA490WC.SelectionStart;
                            DateTime fechaLlegadaVUELTA490WC = calendarioFECHALLEGADA_VUELTA490WC.SelectionStart;

                            if (fechaPartidaIDA490WC <= fechaLlegadaIDA490WC && fechaLlegadaIDA490WC <= fechaPartidaVUELTA490WC && fechaPartidaVUELTA490WC <= fechaLlegadaVUELTA490WC)
                            {
                                boletoModificarCopia490WC = new BoletoIDAVUELTA490WC(boletoOriginal490WC.IDBoleto490WC, boletoOriginal490WC.Origen490WC, boletoOriginal490WC.Destino490WC, fechaPartidaIDA490WC, fechaLlegadaIDA490WC, fechaPartidaVUELTA490WC, fechaLlegadaVUELTA490WC, false, pesoParse490WC, claseBoleto490WC, boletoOriginal490WC.Precio490WC, clienteOriginal490WC, asiento490WC, beneficio490WC);
                                VerificarCambios490WC();
                                if (IsCambioFecha490WC == false && IsCambioBeneficio490WC == false && IsCambioClaseBoleto490WC == false && IsCambioAsiento490WC == false && IsCambioPesoEquipaje490WC == false)
                                {
                                    string errorMensaje490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("DebeRealizarAlgunCambioBoleto490WC");
                                    MessageBox.Show(errorMensaje490WC);
                                }
                                else
                                {
                                    boletoModificarCopia490WC.CambiosRealizados490WC = ArmarArrayCambiosBoleto490WC();
                                    RecalcularPrecioBoleto490WC();
                                    BarraProgresoConsulta490WC.Value = 0;
                                    timer.Start();
                                }
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("FechasIDAPosterioresVUELTA");
                                MessageBox.Show(mensajeError);
                            }

                        }
                        else
                        {
                            if (fechaPartidaIDA490WC <= fechaLlegadaIDA490WC)
                            {
                                boletoModificarCopia490WC = new BoletoIDA490WC(boletoOriginal490WC.IDBoleto490WC, boletoOriginal490WC.Origen490WC, boletoOriginal490WC.Destino490WC, fechaPartidaIDA490WC, fechaLlegadaIDA490WC, false, pesoParse490WC, claseBoleto490WC, boletoOriginal490WC.Precio490WC, clienteOriginal490WC, asiento490WC, beneficio490WC);
                                VerificarCambios490WC();
                                if (IsCambioFecha490WC == false && IsCambioBeneficio490WC == false && IsCambioClaseBoleto490WC == false && IsCambioAsiento490WC == false && IsCambioPesoEquipaje490WC == false)
                                {
                                    string errorMensaje490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("DebeRealizarAlgunCambioBoleto490WC");
                                    MessageBox.Show(errorMensaje490WC);
                                }
                                else
                                {
                                    boletoModificarCopia490WC.CambiosRealizados490WC = ArmarArrayCambiosBoleto490WC();
                                    RecalcularPrecioBoleto490WC();
                                    BarraProgresoConsulta490WC.Value = 0;
                                    timer.Start();
                                }
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("FechaPartidaPosteriorLlegada");
                                MessageBox.Show(mensajeError);
                            }
                        }
                    }
                    else
                    {
                        string errorPeso490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("FormatoPesoIncorrecto");
                        MessageBox.Show(errorPeso490WC);
                    }
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("FormatoAsientoIncorrecto");
                    MessageBox.Show(mensajeError);
                }
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("SeleccionarBeneficioBoleto490WC");
                MessageBox.Show(mensajeError);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            if (BarraProgresoConsulta490WC.Value < BarraProgresoConsulta490WC.Maximum)
            {
                BarraProgresoConsulta490WC.Value += 5; 
            }
            else
            {
                timer.Stop(); 

                
                booleanoRandom = true;
                if (gestorBoleto490WC.GenerarBoletoModificado490WC(boletoModificarCopia490WC))
                {
                    string textoModificacionExitosa490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ModificacionExitosa490WC");
                    MessageBox.Show(textoModificacionExitosa490WC);
                    clienteOriginal490WC = null;
                    boletoOriginal490WC = null;
                    Mostrar();
                    HabilitarOpcionesModificar();
                }
                else
                {
                    string textoErrorModificacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorModificacionBoleto490WC");
                    MessageBox.Show(textoErrorModificacion490WC);
                }
                BarraProgresoConsulta490WC.Value = 0; 
            }
        }

        private void BT_SELECCIONARBENEFICIO490WC_Click(object sender, EventArgs e)
        {
            formSeleccionarBeneficio490WC = new FormSeleccionarBeneficio490WC(clienteOriginal490WC);
            formSeleccionarBeneficio490WC.ShowDialog();
            clienteOriginal490WC = formSeleccionarBeneficio490WC.clienteCargado490WC;
            LlenarCB();
        }

        private void BT_APLICARCAMBIOS490WC_Click(object sender, EventArgs e)
        {

        }
    }
}
