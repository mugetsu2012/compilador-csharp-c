using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();
        
        public Form1()
        {
            InitializeComponent();
            _analizadorLexico = new AnalizadorLexico();
            _tablaSimbolos = new TablaSimbolos();
            _analizadorSintactico = new AnalizadorSintactico();
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
    }
}
