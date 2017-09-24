using System;
using System.IO;
using System.Windows.Forms;

namespace RoboCopyCWG2
{
    public partial class MainForm : Form
    {
        /// <summary> Commando que será executado no RoboCopy </summary>
        private string commandRobocopy = "robocopy \"[dir_origem]\" \"[dir_destino]\" /E";
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary> Seleciona o diretório de origem ou destino </summary>
        private void buscarDiretorio(object sender, EventArgs e) {
            var bt = (Button) sender;

            if (bt.Name.Equals("btDirOrigem")) { 
                folderBrowserOrigem.ShowDialog();
                textBoxOrigem.Text = folderBrowserOrigem.SelectedPath;
            } else {
                folderBrowserDestino.ShowDialog();
                textBoxDestino.Text = folderBrowserDestino.SelectedPath;
            }
        }

        /// <summary> Executa o RoboCopy </summary>
        private void copiar(object sender, EventArgs e) {

            if (!Directory.Exists(textBoxOrigem.Text)) {
                MessageBox.Show(this, "Diretório Origem não existe", "Erro");
            } else if (!Directory.Exists(textBoxDestino.Text)) {
                MessageBox.Show(this, "Diretório Destino não existe", "Erro");
            } else {
                //Executa o comando
                var command = commandRobocopy;
                command = command.Replace("[dir_origem]", textBoxOrigem.Text);
                command = command.Replace("[dir_destino]", textBoxDestino.Text);
                System.Diagnostics.Process.Start("CMD.exe", "/K " + command);
            }
        }
    }
}
