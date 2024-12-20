using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoFinalProcesadoresDeLenguaje
{
    public partial class Form1 : Form
    {

        ClientHandler client;

        public Form1()
        {
            InitializeComponent();
            client = new ClientHandler(label6, this);
        }

        // Choose root directory
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                client.SelectedPath = new DirectoryInfo(folderBrowserDialog1
                    .SelectedPath);
                label4.Text = "Path: " + client.SelectedPath.FullName;
                Debug.WriteLine("Selected path set");
            }
        }

        // Start
        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(client.startWork);
            thread.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text += "/fs:{empty}" +
                    System.Environment.NewLine;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.AppendText("/fs:import,include,#include,using" +
                    System.Environment.NewLine);
            }
        }

        private void excludeFileExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasText(label8))
            {
                label8.Text = "Exclude Files: /e:extensions you want to exclude\n"
                    + "separated by coma without spaces";
                Debug.WriteLine("Hehehe");
            }
            else
            {
                label8.Text = "Exclude Files:";
            }
        }

        private void excludeLinesWithACertainStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label10.Text = "Exclude Files: /fs:text you want to exclude\n"
                + "separated by coma without spaces";
        }

        private bool hasText(Label label)
        {
            // Me quede haciendo que mostrara como usar los comandos
            Debug.WriteLine(label.Text.Split(":").Length);
            return label.Text.Split(":").Length > 2;
        }

        private void onlyFileExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label11.Text = "Only Files: /oe:the only file extensions you want to \ninclude"
                + "separated by comma without spaces";
        }

        public TextBox TextArea
        {
            get { return textBox1; }
        }

        public Label Label1
        {
            get { return label1; }
        }

        public Label Label2
        {
            get { return label2; }
        }

        public Label Label5
        {
            get { return label5; }
        }

        public Label Label7
        {
            get { return label7; }
        }
    }
}
