using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string Data = "", Temp = "";
        public Form1()
        {
            InitializeComponent();
            string[] Ports;
            Ports = SerialPort.GetPortNames();

            foreach (string port in Ports)
            {
                comboBox7.Items.Add(port);
                comboBox7.Text = port;
            }

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Count", 50);
            listView1.Columns.Add("ASCI", 50);
            listView1.Columns.Add("INT", 50);
            listView1.Columns.Add("BINARY", 100);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Close port")
            {
                serialPort2.Close();
                button3.Text = "Open port";
                buttonS1.Enabled = false;
                buttonS2.Enabled = false;
                buttonS3.Enabled = false;
                buttonS4.Enabled = false;
                buttonS5.Enabled = false;
                buttonS6.Enabled = false;
                buttonS7.Enabled = false;
                buttonS8.Enabled = false;
                buttonS9.Enabled = false;
                buttonS10.Enabled = false;
                buttonS11.Enabled = false;
                buttonS12.Enabled = false;
                buttonS13.Enabled = false;
                buttonS14.Enabled = false;
                buttonS15.Enabled = false;


            }
            else
            {
                serialPort2.BaudRate = Int32.Parse(comboBox8.Text);
                serialPort2.DataBits = Int32.Parse(comboBox9.Text);
                serialPort2.Parity = Parity.None;  //none ComboBox 4
                serialPort2.Handshake = Handshake.None; // none ComboBox5
                serialPort2.StopBits = StopBits.One; // Int32.Parse(comboBox6.Text);
                serialPort2.PortName = comboBox7.Text;



                if (serialPort2.IsOpen)
                {
                    MessageBox.Show("ComPort busy");

                }
                else
                {
                    serialPort2.Open();
                    button3.Text = "Close port";
                    serialPort2.DiscardInBuffer();
                    Data = "";
                    MessageBox.Show("ComPort Opened!");
                    buttonS1.Enabled = true;
                    buttonS2.Enabled = true;
                    buttonS3.Enabled = true;
                    buttonS4.Enabled = true;
                    buttonS5.Enabled = true;
                    buttonS6.Enabled = true;
                    buttonS7.Enabled = true;
                    buttonS8.Enabled = true;
                    buttonS9.Enabled = true;
                    buttonS10.Enabled = true;
                    buttonS12.Enabled = true;
                    buttonS13.Enabled = true;
                    buttonS14.Enabled = true;
                    buttonS15.Enabled = true;

                }


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox17.Text = "";

        }

        private void serialPort2_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            char[] Buffer = new char[1000];

            int LongTrama = serialPort2.Read(Buffer, 0, 1000);
            for (int i = 0; i < LongTrama; i++)
            {
                Data = Data + Buffer[i];
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            byte[] trama = new byte[50];
            if (button1.Text == "Pause")
            {
                this.textBox17.Text = this.textBox17.Text + Data;
                Data = "";
            }
            string Temporal = textBox17.SelectedText;
            if (Temporal.Length != 0)
            {
                if (Temporal != Temp)
                {
                    Temp = Temporal;


                    listView1.Clear();

                    listView1.View = View.Details;
                    listView1.GridLines = true;
                    listView1.FullRowSelect = true;

                    listView1.Columns.Add("Count", 50);
                    listView1.Columns.Add("ASCI", 50);
                    listView1.Columns.Add("INT", 50);
                    listView1.Columns.Add("BINARY", 100);
                    string[] arr = new string[5];
                    ListViewItem itm;

                    int NumStr = Temporal.Length;
                    byte[] b2 = Encoding.ASCII.GetBytes(Temporal);
                    for (int i = 0; i < NumStr; i++)
                    {
                        arr[0] = i.ToString();
                        arr[1] = char.ToString(Temporal.ElementAt(i));


                        int b = (Temporal.ElementAt(i));
                        arr[2] = b.ToString();

                        arr[3] = Convert.ToString(Temporal.ElementAt(i), 2);

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);


                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Pause")
                button1.Text = "Play";
            else
                button1.Text = "Pause";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS1.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {




        }

        private void buttonS2_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS2.Text);
        }

        private void buttonS3_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS3.Text);
        }

        private void buttonS4_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS4.Text);
        }

        private void buttonS5_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS5.Text);
        }

        private void buttonS6_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS6.Text);
        }

        private void buttonS7_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS7.Text);
        }

        private void buttonS8_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS8.Text);
        }

        private void buttonS9_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS9.Text);
        }

        private void buttonS10_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS10.Text);
        }

        private void buttonS11_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS11.Text);
        }

        private void buttonS12_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS12.Text);
        }

        private void buttonS13_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS13.Text);
        }

        private void buttonS14_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS14.Text);
        }

        private void buttonS15_Click(object sender, EventArgs e)
        {
            serialPort2.Write(textBoxS15.Text);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
