using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Procesos;

namespace Compilador
{
    public partial class Form1 : Form
    {
        private readonly AnalizadorLexico _analizadorLexico;
        private readonly TablaSimbolos _tablaSimbolos;
        private readonly AnalizadorSintactico _analizadorSintactico;
        private readonly AnalizadorSemantico _analizadorSemantico;
        private readonly GeneradorCodigo _generadorCodigo;
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();
        
        public Form1()
        {
            InitializeComponent();
            _analizadorLexico = new AnalizadorLexico();
            _tablaSimbolos = new TablaSimbolos();
            _analizadorSintactico = new AnalizadorSintactico();
            _analizadorSemantico = new AnalizadorSemantico();
            _generadorCodigo = new GeneradorCodigo();
            cuadroResultados.ScrollBars = ScrollBars.Both;
            cuadroResultados.WordWrap = false;
            cuadroTexto.ScrollBars = ScrollBars.Both;
            cuadroTexto.WordWrap = false;
            new ToolTip().SetToolTip(btnNuevo, "Nuevo");
            new ToolTip().SetToolTip(btnCompilar, "Compilar");
            new ToolTip().SetToolTip(btnOpen, "Abrir");
            new ToolTip().SetToolTip(btnSave, "Guardar");
            new ToolTip().SetToolTip(btnLexi, "Análisis léxico");
            new ToolTip().SetToolTip(btnSemantic, "Análisis semántico");
            new ToolTip().SetToolTip(btnSitax, "Análisis sintáctico");
            new ToolTip().SetToolTip(btnMachine, "Código máquina");
            new ToolTip().SetToolTip(btnIntermedio, "Código intermedio");
            new ToolTip().SetToolTip(btnEjecutar, "Ejecutar");
            openFile.Title = "Abrir archivos C";
            openFile.Filter = "Archivo C|*.c";
            openFile.InitialDirectory = @"C:\";
            saveFile.Title = "Guarcar archivo";
            saveFile.Filter = "Archivo C|*.c";
            saveFile.InitialDirectory = @"C:\";
            

        }

        #region Hover Events

        private void btnCompilar_MouseHover(object sender, EventArgs e)
        {
            btnCompilar.BackColor = SystemColors.Highlight;
        }

        private void btnCompilar_MouseLeave(object sender, EventArgs e)
        {
            btnCompilar.BackColor = SystemColors.Control;
        }

        private void btnNuevo_MouseHover(object sender, EventArgs e)
        {
            btnNuevo.BackColor = SystemColors.Highlight;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackColor = SystemColors.Control;
        }

        private void btnOpen_MouseHover(object sender, EventArgs e)
        {
            btnOpen.BackColor = SystemColors.Highlight;
        }

        private void btnOpen_MouseLeave(object sender, EventArgs e)
        {
            btnOpen.BackColor = SystemColors.Control;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = SystemColors.Highlight;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = SystemColors.Control;
        }

        private void btnLexi_MouseHover(object sender, EventArgs e)
        {
            btnLexi.BackColor = SystemColors.Highlight;
        }

        private void btnLexi_MouseLeave(object sender, EventArgs e)
        {
            btnLexi.BackColor = SystemColors.Control;
        }

        private void btnSitax_MouseHover(object sender, EventArgs e)
        {
            btnSitax.BackColor = SystemColors.Highlight;
        }

        private void btnSitax_MouseLeave(object sender, EventArgs e)
        {
            btnSitax.BackColor = SystemColors.Control;
        }

        private void btnSemantic_MouseHover(object sender, EventArgs e)
        {
            btnSemantic.BackColor = SystemColors.Highlight;
        }

        private void btnSemantic_MouseLeave(object sender, EventArgs e)
        {
            btnSemantic.BackColor = SystemColors.Control;
        }

        private void btnIntermedio_MouseHover(object sender, EventArgs e)
        {
            btnIntermedio.BackColor = SystemColors.Highlight;
        }

        private void btnIntermedio_MouseLeave(object sender, EventArgs e)
        {
            btnIntermedio.BackColor = SystemColors.Control;
        }

        private void btnMachine_MouseHover(object sender, EventArgs e)
        {
            btnMachine.BackColor = SystemColors.Highlight;
        }

        private void btnMachine_MouseLeave(object sender, EventArgs e)
        {
            btnMachine.BackColor = SystemColors.Control;
        }

        private void btnEjecutar_MouseHover(object sender, EventArgs e)
        {
            btnEjecutar.BackColor = SystemColors.Highlight;
        }

        private void btnEjecutar_MouseLeave(object sender, EventArgs e)
        {
            btnEjecutar.BackColor = SystemColors.Control;
        }


        #endregion

        private void btnLexi_Click(object sender, EventArgs e)
        {
            string codigo = cuadroTexto.Text;
            codigo += "\r\n";
            string codigoSinComent = _analizadorLexico.RetirarComentarios(codigo);
            string codigoSinSaltos = _analizadorLexico.RetirarSaltos(codigoSinComent);
            List<Lexema> lexemas = _analizadorLexico.ExtraerLexemas(codigoSinSaltos);
            string analisisLex = ArmarResultadoAnalisisLexico(lexemas);
            cuadroResultados.Text = analisisLex;

        }

        private string ArmarResultadoAnalisisLexico(List<Lexema> lexemas)
        {
            string result = "";
            

            foreach (Lexema lexema in lexemas)
            {
                if (lexema.TipoElemento != Enums.TipoElemento.Error)
                {
                    result += "Lexema: ["+ lexema.Texto + "] del tipo: "+ lexema.TipoElemento + " \r\n";
                }
                else
                {
                    result += "Lexema: ["+ lexema.Texto + "] Error: "+ lexema.MensajeError + "  \r\n";
                }
                
            }


            return result;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cuadroTexto.Text = null;
            cuadroResultados.Text = null;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFile.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            using (StreamReader r = new StreamReader(myStream))
                            {
                                string texto = r.ReadToEnd();
                                cuadroTexto.Text = texto;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveFile.FileName;
                using (StreamWriter bw = new StreamWriter(File.Create(path)))
                {
                    bw.Write(cuadroTexto.Text);
                    bw.Close();
                }
            }
        }

        private void btnSitax_Click(object sender, EventArgs e)
        {
            string codigo = cuadroTexto.Text;
            codigo += "\r\n";
            string codigoSinComent = _analizadorLexico.RetirarComentarios(codigo);
            string codigoSinSaltos = _analizadorLexico.RetirarSaltos(codigoSinComent);
            List<Lexema> lexemas = _analizadorLexico.ExtraerLexemas(codigoSinSaltos);

            //Construir la tabla de simbolos
            _analizadorSintactico.ConstruirTablaSimbolos(lexemas);
            

            int pos = 0;

            
            List<Bloque> bloques = _analizadorSintactico.RealizarAnalisisSintax(lexemas,ref pos, lexemas.Count);
            bloques.ForEach(y => y.HacersePadre());
            List<Bloque> bloquesFlat = bloques.SelectMany(y => y.BloquesPlanos()).ToList();


            LimpiarTablaSimbolos();
            ImprimirTablaSimbolos(_analizadorSintactico.TablaSimbolos.RegistrosTabla);
            List<string> errores = _analizadorSintactico.ExtraerErroresBloques(bloques);
            if (errores.Count > 0)
            {
                arbolSintax.Nodes.Clear();
                cuadroResultados.Text = ArmarErroresSintax(errores);
            }
            else
            {
                cuadroResultados.Text = "Análisis sintactico correcto!";
                TreeNode root = null;
                arbolSintax.Nodes.Clear();
                LlenarArbol(ref root, bloquesFlat);
                arbolSintax.Nodes.Add(root);
            }


        }

        private void btnSemantic_Click(object sender, EventArgs e)
        {
            string codigo = cuadroTexto.Text;
            codigo += "\r\n";
            string codigoSinComent = _analizadorLexico.RetirarComentarios(codigo);
            string codigoSinSaltos = _analizadorLexico.RetirarSaltos(codigoSinComent);
            List<Lexema> lexemas = _analizadorLexico.ExtraerLexemas(codigoSinSaltos);

            int pos = 0;


            List<Bloque> bloques = _analizadorSintactico.RealizarAnalisisSintax(lexemas, ref pos, lexemas.Count);
            bloques.ForEach(y => y.HacersePadre());
            List<Bloque> bloquesFlat = bloques.SelectMany(y => y.BloquesPlanos()).ToList();


            List<string> errores = _analizadorSintactico.ExtraerErroresBloques(bloques);
            if (errores.Count > 0)
            {
                arbolSintax.Nodes.Clear();
                cuadroResultados.Text = ArmarErroresSintax(errores);
            }
            else
            {
                TreeNode root = null;
                arbolSintax.Nodes.Clear();
                LlenarArbol(ref root, bloquesFlat);
                arbolSintax.Nodes.Add(root);

                //Desde aca se hace el analisis semantico
                _analizadorSemantico.ProcesarLexemas(lexemas, bloques);

                if (_analizadorSemantico.Errores.Count > 0)
                {
                    string erroresSemantic = ArmarErroresSintax(_analizadorSemantico.Errores);
                    cuadroResultados.Text = erroresSemantic;

                }
                else
                {
                    cuadroResultados.Text = "Analisis semantico correcto";
                }

                LimpiarTablaSimbolos();
                ImprimirTablaSimbolos(_analizadorSemantico.TablaSimbolos.RegistrosTabla);

            }
        }

        private string ArmarErroresSintax(List<string> list)
        {
            string result = "Se detectaron los siguientes errores: \r\n";
            foreach (string error in list)
            {
                result = result + error + "\r\n";
            }

            return result;
        }

        public void LlenarArbol(ref TreeNode root, List<Bloque> bloquesTotales)
        {
            if (root == null)
            {
                root = new TreeNode();
                root.Text = "Programa";
                root.Tag = null;
                // Todos los nodos cuyo padre no es nulo
                var bloques = bloquesTotales.Where(t => t.BloquePadre == null);
                foreach (var bloque in bloques)
                {
                    var child = new TreeNode()
                    {
                        Text = string.Join(" ", bloque.Lexemas.Select(y => y.Texto)),
                        Tag = bloque.Incia
                    };
                    LlenarArbol(ref child, bloquesTotales);
                    root.Nodes.Add(child);
                }
            }
            else
            {
                var id = (int)root.Tag;
                var bloques = bloquesTotales.Where(t => t.BloquePadre != null && t.BloquePadre.Incia == id);
                foreach (var bloque in bloques)
                {
                    var child = new TreeNode()
                    {
                        Text = string.Join(" ", bloque.Lexemas.Select(y => y.Texto)),
                        Tag = bloque.Incia
                    };
                    LlenarArbol(ref child, bloquesTotales);
                    root.Nodes.Add(child);
                }
            }
        }

        private void ImprimirTablaSimbolos(List<RegistroTabla> registros)
        {
            foreach (RegistroTabla registroTabla in registros)
            {
                int rowId = tablaSimbolos.Rows.Add();

                DataGridViewRow row = tablaSimbolos.Rows[rowId];

                row.Cells["Codigo"].Value = registroTabla.Codigo;
                row.Cells["Variable"].Value = registroTabla.Nombre;
                row.Cells["Tipo"].Value = registroTabla.TipoVariable;
                row.Cells["Valor"].Value = registroTabla.Valor;
            }
        }

        private void LimpiarTablaSimbolos()
        {
            tablaSimbolos.Rows.Clear();
        }

        private void btnCompilar_Click(object sender, EventArgs e)
        {

        }

        private void btnMachine_Click(object sender, EventArgs e)
        {
            string codigo = cuadroTexto.Text;
            codigo += "\r\n";
            string codigoSinComent = _analizadorLexico.RetirarComentarios(codigo);
            string codigoSinSaltos = _analizadorLexico.RetirarSaltos(codigoSinComent);
            List<Lexema> lexemas = _analizadorLexico.ExtraerLexemas(codigoSinSaltos);

            int pos = 0;


            List<Bloque> bloques = _analizadorSintactico.RealizarAnalisisSintax(lexemas, ref pos, lexemas.Count);
            bloques.ForEach(y => y.HacersePadre());
            List<Bloque> bloquesFlat = bloques.SelectMany(y => y.BloquesPlanos()).ToList();


            List<string> errores = _analizadorSintactico.ExtraerErroresBloques(bloques);
            if (errores.Count > 0)
            {
                arbolSintax.Nodes.Clear();
                cuadroResultados.Text = ArmarErroresSintax(errores);
            }
            else
            {
                TreeNode root = null;
                arbolSintax.Nodes.Clear();
                LlenarArbol(ref root, bloquesFlat);
                arbolSintax.Nodes.Add(root);

                //Desde aca se hace el analisis semantico
                _analizadorSemantico.ProcesarLexemas(lexemas, bloques);

                if (_analizadorSemantico.Errores.Count > 0)
                {
                    string erroresSemantic = ArmarErroresSintax(_analizadorSemantico.Errores);
                    cuadroResultados.Text = erroresSemantic;

                }
                else
                {
                    //Aca realizamos el proceso
                    string path = Path.Combine(GetPathGcc(), "temp.c");


                    using (StreamWriter bw = new StreamWriter(File.Create(path)))
                    {
                        bw.Write(FormatearCuadroTexto());
                        bw.Close();
                    }

                    //En este punto está el archivo c creado, vamos a crear el archivo asm
                    GenerarAsm();

                    //Leemos el ASM
                    string pathAsm = Path.Combine(GetPathGcc(), "temp.s");

                    Thread.Sleep(2000);
                    LeerAsm(pathAsm);


                    //Borramos los dos archivos
                    File.Delete(path);
                    File.Delete(pathAsm);
                }

                

                LimpiarTablaSimbolos();
                ImprimirTablaSimbolos(_analizadorSemantico.TablaSimbolos.RegistrosTabla);

            }
        }

        private void btnIntermedio_Click(object sender, EventArgs e)
        {
            string codigo = cuadroTexto.Text;
            codigo += "\r\n";
            string codigoSinComent = _analizadorLexico.RetirarComentarios(codigo);
            string codigoSinSaltos = _analizadorLexico.RetirarSaltos(codigoSinComent);
            List<Lexema> lexemas = _analizadorLexico.ExtraerLexemas(codigoSinSaltos);

            int pos = 0;


            List<Bloque> bloques = _analizadorSintactico.RealizarAnalisisSintax(lexemas, ref pos, lexemas.Count);
            bloques.ForEach(y => y.HacersePadre());
            List<Bloque> bloquesFlat = bloques.SelectMany(y => y.BloquesPlanos()).ToList();


            List<string> errores = _analizadorSintactico.ExtraerErroresBloques(bloques);
            if (errores.Count > 0)
            {
                arbolSintax.Nodes.Clear();
                cuadroResultados.Text = ArmarErroresSintax(errores);
            }
            else
            {
                TreeNode root = null;
                arbolSintax.Nodes.Clear();
                LlenarArbol(ref root, bloquesFlat);
                arbolSintax.Nodes.Add(root);

                //Desde aca se hace el analisis semantico
                
                _analizadorSemantico.ProcesarLexemas(lexemas, bloques);

                if (_analizadorSemantico.Errores.Count > 0)
                {
                    string erroresSemantic = ArmarErroresSintax(_analizadorSemantico.Errores);
                    cuadroResultados.Text = erroresSemantic;

                }
                else
                {

                    //Hacemos la generacion de code
                    pos = 0;
                    List<Bloque> bloquesFin = _analizadorSintactico.RealizarAnalisisSintax(lexemas, ref pos, lexemas.Count);
                    bloquesFin.ForEach(y => y.HacersePadre());
                    List<ExpresionTripleta> expresionesResultado = _generadorCodigo.GenerarCodigo(bloquesFin);
                    string mensaje = _generadorCodigo.GenerarTextoResult(expresionesResultado);

                    cuadroResultados.Text = mensaje;
                }

                LimpiarTablaSimbolos();
                ImprimirTablaSimbolos(_analizadorSemantico.TablaSimbolos.RegistrosTabla);

            }
        }

        private static string GetPathLibrearia()
        {
            string parentOfStartupPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../"));
            parentOfStartupPath = Path.Combine(parentOfStartupPath, @"libreriaC");
            return parentOfStartupPath;
        }

        private static string GetPathGcc()
        {
            string path = Path.Combine(GetPathLibrearia(), @"bin");
            return path;
        }

        private void GenerarAsm()
        {
            string pathGcc = GetPathGcc(); // Example of location

            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WorkingDirectory = pathGcc,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true

            };

            process.StartInfo = startInfo;
            process.Start();
            process.StandardInput.WriteLine("gcc -S temp.c");
        }

        public void LeerAsm(string path)
        {
            try
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string texto = r.ReadToEnd();
                    cuadroResultados.Text = texto;
                }

                cuadroResultados.Text = cuadroResultados.Text.Replace("GCC: (MinGW.org GCC-6.3.0-1) 6.3.0",
                    "Universidad Don Bosco Compiladores Ciclo 2 2017");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }

        private string FormatearCuadroTexto()
        {
            string texto = "int main() {" + cuadroTexto.Text + " return 0; }";
            return texto;
            
        }
    }
}
