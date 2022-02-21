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
using WIA;

namespace ScannerWIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListaScanners()
        {
            // limpa a lista
            listaScanners.Items.Clear();

            // cria uma instancia do tipo DeviceManager 
            var deviceManager = new DeviceManager();

            // laço para pesquisar os dispositivos
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
            
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // adicionando o scanner a listBox
                // Io nome do scanner vai aparecer conforme está o 'ToString' na classe scanner
                listaScanners.Items.Add(new Scanner(deviceManager.DeviceInfos[i]));

                
            }
            if (listaScanners.Items.Count == 0)
            {
                listaScanners.Items.Add("Nenhum dispositivo encontrado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaScanners();

            // pegando caminho temporário
            txtCaminho.Text = Path.GetTempPath();
            // JPEG serão o padrão
            comboTipoImagem.SelectedIndex = 1;

        }

        private void btnTrocarCaminho_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtCaminho.Text = folderDlg.SelectedPath;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
        }
        private void TriggerScan()
        {
            Console.WriteLine("Imagem digitalizada com sucesso");
        }

        public void StartScanning()
        {
            Scanner device = null;

            this.Invoke(new MethodInvoker(delegate ()
            {
                device = listaScanners.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("Você precisa antes selecionar um dispositivo",
                                "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(txtNomeArquivo.Text))
            {
                MessageBox.Show("Entre com o nome do arquivo",
                                "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile image = new ImageFile();
            string imageExtension = "";

            this.Invoke(new MethodInvoker(delegate ()
            {
                switch (comboTipoImagem.SelectedIndex)
                {
                    case 0:
                        image = device.ScanPNG();
                        imageExtension = ".png";
                        break;
                    case 1:
                        image = device.ScanJPEG();
                        imageExtension = ".jpeg";
                        break;
                    case 2:
                        image = device.ScanTIFF();
                        imageExtension = ".tiff";
                        break;
                }
            }));


            // Save the image
            var path = Path.Combine(txtCaminho.Text, txtNomeArquivo.Text + imageExtension);

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            image.SaveFile(path);

            pictureBox1.Image = new Bitmap(path);
        }
    }
}
