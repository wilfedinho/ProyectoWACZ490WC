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
            TB_CARTELERACAMBIOS490WC.Text = $"Recargos En Base Al Precio Del Boleto {Environment.NewLine}" +
                                            $"Modificar Fechas ===> 30% {Environment.NewLine}" +
                                            $"Modificar Beneficio ===> 20% {Environment.NewLine}" +
                                            $"Modificar Clase Boleto ===> 40% {Environment.NewLine}" +
                                            $"Modificar Asiento ===> 20% {Environment.NewLine}" +
                                            $"Modificar Peso del Equipaje ===> 13% {Environment.NewLine}" +
                                            $"Modificar Titular ===> 60%";
            random = new Random();
            timer = new Timer();
            booleanoRandom = false;
            timer.Interval = 50; // velocidad de carga (ms)
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

        }



        private string ConstruirTextoBoleto490WC()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Numero Boleto: {boletoOriginal490WC.IDBoleto490WC}");
            sb.AppendLine($"Origen: {boletoOriginal490WC.Origen490WC}");
            sb.AppendLine($"Destino: {boletoOriginal490WC.Destino490WC}");
            sb.AppendLine($"Fecha Partida: {boletoOriginal490WC.FechaPartida490WC.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Fecha Llegada: {boletoOriginal490WC.FechaLlegada490WC.ToString("dd/MM/yyyy")}");

            if (boletoOriginal490WC is BoletoIDAVUELTA490WC idaVuelta)
            {
                sb.AppendLine($"Fecha Partida Vuelta: {idaVuelta.FechaPartidaVUELTA490WC.ToString("dd/MM/yyyy")}");
                sb.AppendLine($"Fecha Llegada Vuelta: {idaVuelta.FechaLlegadaVUELTA490WC.ToString("dd/MM/yyyy")}");
            }

            sb.AppendLine($"Clase Del Boleto: {boletoOriginal490WC.ClaseBoleto490WC}");
            sb.AppendLine($"Equipaje Permitido: {boletoOriginal490WC.EquipajePermitido490WC} kg");
            sb.AppendLine($"Titular: {boletoOriginal490WC.Titular490WC.DNI490WC} {boletoOriginal490WC.Titular490WC.Nombre490WC} {boletoOriginal490WC.Titular490WC.Apellido490WC}");
            sb.AppendLine($"Asiento: {boletoOriginal490WC.NumeroAsiento490WC}");


            if (string.IsNullOrWhiteSpace(boletoOriginal490WC.BeneficioAplicado490WC))
                sb.AppendLine("Beneficio Aplicado: Este Boleto No Posee Un Beneficio Aplicado");
            else
                sb.AppendLine($"Beneficio Aplicado: {boletoOriginal490WC.BeneficioAplicado490WC}");

            sb.AppendLine($"Precio: {boletoOriginal490WC.Precio490WC}");
            return sb.ToString();
        }

        public void Mostrar()
        {
            TBINFOBOLETOINFOPREVIA490WC.Clear();
            if (boletoOriginal490WC == null)
            {
                TBINFOBOLETOINFOPREVIA490WC.Text = "Ingrese el Numero del Boleto Que Desea Modificar";
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
                    MessageBox.Show($"El Boleto No Se Encuentra Disponible Para Ser Modificado");
                }
            }
            else
            {
                clienteOriginal490WC = null;
                Mostrar();
                HabilitarOpcionesModificar();
                MessageBox.Show($"Ingrese un Numero de Boleto valido!!!");
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
                                    MessageBox.Show("Debe realizar Algun Cambio En el Boleto Para Consultar Dichos Cambios!!");
                                }
                                else
                                {
                                    boletoModificarCopia490WC.CambiosRealizados490WC = ArmarArrayCambiosBoleto490WC();
                                    RecalcularPrecioBoleto490WC();
                                    BarraProgresoConsulta490WC.Value = 0;
                                    timer.Start();
                                    //if (gestorBoleto490WC.GenerarBoletoModificado490WC(boletoModificarCopia490WC))
                                    //{
                                    //    MessageBox.Show("La Modificacion Se ha logrado con Exito, tiene 8 Horas Habiles Para Efectuar el Pago!!!");
                                    //    clienteOriginal490WC = null;
                                    //    boletoOriginal490WC = null;
                                    //    Mostrar();
                                    //    HabilitarOpcionesModificar();
                                    //}
                                    //else
                                    //{
                                    //    MessageBox.Show("No Se Pudo Realizar La Modificacion, Intente Nuevamente Mas Tarde!!!");
                                    //}

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
                                boletoModificarCopia490WC = new BoletoIDA490WC(boletoOriginal490WC.IDBoleto490WC, boletoOriginal490WC.Origen490WC, boletoOriginal490WC.Destino490WC, fechaPartidaIDA490WC, fechaLlegadaIDA490WC,false, pesoParse490WC, claseBoleto490WC, boletoOriginal490WC.Precio490WC, clienteOriginal490WC, asiento490WC, beneficio490WC);
                                VerificarCambios490WC();
                                if (IsCambioFecha490WC == false && IsCambioBeneficio490WC == false && IsCambioClaseBoleto490WC == false && IsCambioAsiento490WC == false && IsCambioPesoEquipaje490WC == false)
                                {
                                    MessageBox.Show("Debe realizar Algun Cambio Para Consultarlo!!");
                                }
                                else
                                {
                                    boletoModificarCopia490WC.CambiosRealizados490WC = ArmarArrayCambiosBoleto490WC();
                                    RecalcularPrecioBoleto490WC();
                                    BarraProgresoConsulta490WC.Value = 0;
                                    timer.Start();
                                    
                                    //if (gestorBoleto490WC.GenerarBoletoModificado490WC(boletoModificarCopia490WC))
                                    //{
                                    //    MessageBox.Show("La Modificacion Se ha logrado con Exito, tiene 8 Horas Habiles Para Efectuar el Pago!!!");
                                    //    clienteOriginal490WC = null;
                                    //    boletoOriginal490WC = null;
                                    //    Mostrar();
                                    //    HabilitarOpcionesModificar();
                                    //}
                                    //else
                                    //{
                                    //    MessageBox.Show("No Se Pudo Realizar La Modificacion, Intente Nuevamente Mas Tarde!!!");
                                    //}

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
                        MessageBox.Show("Ingrese Un Peso Valido!!");
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
                MessageBox.Show("Debe seleccionar Algun Beneficio!!");
            }




        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            if (BarraProgresoConsulta490WC.Value < BarraProgresoConsulta490WC.Maximum)
            {
                BarraProgresoConsulta490WC.Value += 5; // incrementar barra
            }
            else
            {
                timer.Stop(); // detener animación

                // Generar resultado booleano aleatorio
                booleanoRandom = true;
                if (gestorBoleto490WC.GenerarBoletoModificado490WC(boletoModificarCopia490WC))
                {
                    MessageBox.Show("La Modificacion Se ha logrado con Exito, tiene 8 Horas Habiles Para Efectuar el Pago!!!");
                    clienteOriginal490WC = null;
                    boletoOriginal490WC = null;
                    Mostrar();
                    HabilitarOpcionesModificar();
                }
                else
                {
                    MessageBox.Show("No Se Pudo Realizar La Modificacion, Intente Nuevamente Mas Tarde!!!");
                }
                BarraProgresoConsulta490WC.Value = 0; // reiniciar barra para próxima vez
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
