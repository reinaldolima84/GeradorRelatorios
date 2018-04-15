using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FirebirdSql.Data.FirebirdClient;

namespace GeradorRelatorios
{
    public partial class frmGeradorRelatorios : Form
    {
        //Declara as variáveis
        OpenFileDialog openFile = new OpenFileDialog();
        string arquivo = "";
        string strSQL = "";
        double dblPercentual = 0;

        public frmGeradorRelatorios()
        {
            InitializeComponent();
            lblProgressao.Visible = false;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Limpa os dados
            arquivo = "";
            lstConsultaSQL.Items.Clear();
            txtCaminhoSQL.Text = "";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                txtCaminhoSQL.Text = openFile.FileName;
                while (arquivo != null)
                {
                    arquivo = sr.ReadLine();
                    if (arquivo != null)
                    {
                        lstConsultaSQL.Items.Add(arquivo);
                    }
                }
                sr.Close();
            }
        }

        private void btnExecutarConsulta_Click(object sender, EventArgs e)
        {
            //Cria a string de conexão
            string strConn = @"DataSource=localhost; Database=nomedb; username= SYSDBA; password = MASTERKEY";
            FbConnection conn;
            conn = new FbConnection(strConn);
            //Monta a string com a consulta a partir do listbox
            foreach (object x in lstConsultaSQL.Items)
            {
                strSQL = strSQL + x.ToString() + " ";
            }
            //Executa a consulta
            FbCommand cmd = new FbCommand(strSQL, conn);
            FbDataAdapter DA = new FbDataAdapter(cmd);
            //Atribui no dataset
            DataSet DS = new DataSet();
            conn.Open();
            DA.Fill(DS, "strDados");
            dtgDados.DataSource = DS; dtgDados.DataMember = "strDados";
            //Fecha a conexão
            conn.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //Rotina de exportação dos dados para Excel
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

            if (dtgDados.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dtgDados.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dtgDados.Columns[i - 1].HeaderText;
                    }
                    //Inicializa a barra de progressão
                    pbProgessao.Value = 0;
                    pbProgessao.Maximum = dtgDados.Rows.Count - 2;
                    //Percorre os registros
                    for (int i = 0; i < dtgDados.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dtgDados.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dtgDados.Rows[i].Cells[j].Value.ToString();
                            //Incrementa barra de progressão
                            pbProgessao.Value = i;
                            dblPercentual = (i * 100) / pbProgessao.Maximum;
                        }
                        lblProgressao.Visible = true;
                        lblProgressao.Text = Convert.ToString(dblPercentual) + "%";
                    }
                    //Dimensiona as colunas
                    XcelApp.Columns.AutoFit();
                    //Mostra o Excel em tela
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
    }
}
