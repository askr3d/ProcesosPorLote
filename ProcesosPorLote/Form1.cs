using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProcesosPorLote
{
    public partial class Form1 : Form
    {
        private int contadorGlobal = 0;
        private List<String> nombres = new List<String> { "Carlos", "Juan", "Luis" };
        private List<String> signos = new List<String>{"+", "-", "*", "/"};
        private int numLote = 1;
        private int numProcesos = 0;
        private List<Proceso> procesos = new List<Proceso>();
        private List<Proceso> procesosTerminados = new List<Proceso>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblValidacionNumProcesos.Text = "";
            lblTiempo.Text = contadorGlobal + " segs";
            btnObtenerResultados.Enabled = false;
            lblReporteMsg.Text = "";
        }

        private void btnGenerarProcesos_Click(object sender, EventArgs e)
        {
            lblValidacionNumProcesos.Text = "";
            if(txtNumProcesos.Text.Length == 0 || !int.TryParse(txtNumProcesos.Text, out _))
            {
                lblValidacionNumProcesos.Text = "Debe intruducir un numero";
                return;
            }
            btnObtenerResultados.Enabled = false;
            numProcesos = int.Parse(txtNumProcesos.Text);
            lblTiempo.Text = contadorGlobal + " segs";
            lblReporteMsg.Text = "";
            empezarCronometro();
            ingresarProcesos();
            numLote++;
        }
        private void ingresarProcesos()
        {
            for (int i = 0; i < numProcesos; i++)
            {
                generarProceso(numLote);
            }
        }

        private void generarProceso(int id)
        {
            Random rnd = new Random();
            Proceso proceso = new Proceso
            {
                id = id,
                nombre= nombres[rnd.Next(0,nombres.Count)],
                signo= signos[rnd.Next(0, signos.Count)],
                numFinal = rnd.Next(0, 10),
                numInicio= rnd.Next(0, 10),
                tiempo= rnd.Next(1, 4),
            };
            proceso.tiempoOriginal = proceso.tiempo;


            procesos.Add(proceso);

            ListViewItem item = crearListaElemento(proceso);

            listEspera.Items.Add(item);
        }

        private void ejecutarProceso()
        {
            Proceso procesoActual = procesos.FirstOrDefault();
            listEjecucion.Items.Clear();
            if (procesoActual != null)
            {
                if (!procesoActual.ejecucion)
                {
                    procesoActual.ejecucion = true;
                    listEspera.Items.RemoveAt(0);
                }
                ListViewItem item = crearListaElemento(procesoActual);
                if (procesoActual.tiempo > 0)
                {
                    procesoActual.tiempo--;
                    listEjecucion.Items.Add(item);
                }
                else
                {
                    procesoActual.tiempo = procesoActual.tiempoOriginal;
                    listTerminados.Items.Add(item);
                    procesosTerminados.Add(procesoActual);
                    procesos.Remove(procesoActual);

                    Proceso procesoSiguiente = procesos.FirstOrDefault();
                    if(procesoSiguiente != null)
                    {
                        if (!procesoSiguiente.ejecucion)
                        {
                            procesoSiguiente.ejecucion = true;
                            listEspera.Items.RemoveAt(0);
                        }
                        contadorGlobal--;
                        ListViewItem itemSiguiente = crearListaElemento(procesoSiguiente);
                        listEjecucion.Items.Add(itemSiguiente);
                    }
                    else
                    {
                        timerGlobal.Stop();
                        btnObtenerResultados.Enabled = true;
                    }
                }
            }
            else
            {
                timerGlobal.Stop();
                btnObtenerResultados.Enabled = true;
            }
        }

        public ListViewItem crearListaElemento(Proceso proceso)
        {
            ListViewItem item = new ListViewItem(proceso.id.ToString());
            item.SubItems.Add(proceso.nombre);
            if (proceso.tiempo == 0)
            {
                item.SubItems.Add(
                    proceso.numInicio + proceso.signo + proceso.numFinal + " = " +
                    calcularOperacion(proceso.numInicio, proceso.numFinal, proceso.signo).ToString());
                item.SubItems.Add(proceso.tiempoOriginal.ToString());
            }
            else
            {
                item.SubItems.Add(proceso.numInicio + proceso.signo + proceso.numFinal);
                item.SubItems.Add(proceso.tiempo.ToString());
            }

            return item;
        }

        public int calcularOperacion(int num1, int num2, String signo)
        {
            int resultado = 0;
            switch (signo)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                default:
                    break;
            }

            return resultado;
        }


        //Cronometro Logica
        private void empezarCronometro()
        {
            timerGlobal.Start();
        }

        private void sumarSegundos()
        {
            lblTiempo.Text = contadorGlobal++ + " segs";
            ejecutarProceso();
        }

        private void timerGlobal_Tick(object sender, EventArgs e)
        {
            sumarSegundos();
        }

        private void generarReporteExcel()
        {

            string filePath = "./resultado.xlsx";

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Hoja1");

                worksheet.Cells[1, 1].Value = "Lote";
                worksheet.Cells[1, 2].Value = "Nombre";
                worksheet.Cells[1, 3].Value = "Operacion";
                worksheet.Cells[1, 4].Value = "Tiempo";
                int celda = 2;

                procesosTerminados.ForEach(procesoAux =>
                {
                    worksheet.Cells[celda, 1].Value = procesoAux.id;
                    worksheet.Cells[celda, 2].Value = procesoAux.nombre;
                    worksheet.Cells[celda, 3].Value = procesoAux.numInicio + procesoAux.signo + procesoAux.numFinal + " = " +
                    calcularOperacion(procesoAux.numInicio, procesoAux.numFinal, procesoAux.signo).ToString();
                    worksheet.Cells[celda, 4].Value = procesoAux.tiempoOriginal;
                    celda++;
                });

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                FileInfo excelFile = new FileInfo(filePath);
                package.SaveAs(excelFile);
            }
            lblReporteMsg.Text = "Archivo Creado en: " + Path.GetFullPath(filePath);
        }

        private void btnObtenerResultados_Click(object sender, EventArgs e)
        {
            generarReporteExcel();
            procesosTerminados.Clear();
            listTerminados.Items.Clear();
            numLote = 1;
        }
    }

    public class Proceso
    {
        public int id;
        public String nombre;
        public int numInicio;
        public int numFinal;
        public String signo;
        public int tiempo;
        public int tiempoOriginal;
        public bool ejecucion = false;
    }
}
