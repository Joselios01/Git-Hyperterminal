namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonS15 = new System.Windows.Forms.Button();
            this.textBoxS15 = new System.Windows.Forms.TextBox();
            this.buttonS14 = new System.Windows.Forms.Button();
            this.textBoxS14 = new System.Windows.Forms.TextBox();
            this.buttonS13 = new System.Windows.Forms.Button();
            this.textBoxS13 = new System.Windows.Forms.TextBox();
            this.buttonS12 = new System.Windows.Forms.Button();
            this.textBoxS12 = new System.Windows.Forms.TextBox();
            this.buttonS11 = new System.Windows.Forms.Button();
            this.textBoxS11 = new System.Windows.Forms.TextBox();
            this.buttonS10 = new System.Windows.Forms.Button();
            this.textBoxS10 = new System.Windows.Forms.TextBox();
            this.buttonS9 = new System.Windows.Forms.Button();
            this.textBoxS9 = new System.Windows.Forms.TextBox();
            this.buttonS8 = new System.Windows.Forms.Button();
            this.textBoxS8 = new System.Windows.Forms.TextBox();
            this.buttonS7 = new System.Windows.Forms.Button();
            this.textBoxS7 = new System.Windows.Forms.TextBox();
            this.buttonS4 = new System.Windows.Forms.Button();
            this.textBoxS4 = new System.Windows.Forms.TextBox();
            this.buttonS6 = new System.Windows.Forms.Button();
            this.textBoxS6 = new System.Windows.Forms.TextBox();
            this.buttonS5 = new System.Windows.Forms.Button();
            this.textBoxS5 = new System.Windows.Forms.TextBox();
            this.buttonS3 = new System.Windows.Forms.Button();
            this.textBoxS3 = new System.Windows.Forms.TextBox();
            this.buttonS2 = new System.Windows.Forms.Button();
            this.textBoxS2 = new System.Windows.Forms.TextBox();
            this.buttonS1 = new System.Windows.Forms.Button();
            this.textBoxS1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Open port";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(13, 13);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 1;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(140, 13);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 2;
            this.comboBox8.Text = "115200";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(267, 13);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 3;
            this.comboBox9.Text = "8";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(17, 42);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox17.Size = new System.Drawing.Size(407, 115);
            this.textBox17.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(430, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(491, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 317);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(6, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(252, 293);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonS15);
            this.groupBox2.Controls.Add(this.textBoxS15);
            this.groupBox2.Controls.Add(this.buttonS14);
            this.groupBox2.Controls.Add(this.textBoxS14);
            this.groupBox2.Controls.Add(this.buttonS13);
            this.groupBox2.Controls.Add(this.textBoxS13);
            this.groupBox2.Controls.Add(this.buttonS12);
            this.groupBox2.Controls.Add(this.textBoxS12);
            this.groupBox2.Controls.Add(this.buttonS11);
            this.groupBox2.Controls.Add(this.textBoxS11);
            this.groupBox2.Controls.Add(this.buttonS10);
            this.groupBox2.Controls.Add(this.textBoxS10);
            this.groupBox2.Controls.Add(this.buttonS9);
            this.groupBox2.Controls.Add(this.textBoxS9);
            this.groupBox2.Controls.Add(this.buttonS8);
            this.groupBox2.Controls.Add(this.textBoxS8);
            this.groupBox2.Controls.Add(this.buttonS7);
            this.groupBox2.Controls.Add(this.textBoxS7);
            this.groupBox2.Controls.Add(this.buttonS4);
            this.groupBox2.Controls.Add(this.textBoxS4);
            this.groupBox2.Controls.Add(this.buttonS6);
            this.groupBox2.Controls.Add(this.textBoxS6);
            this.groupBox2.Controls.Add(this.buttonS5);
            this.groupBox2.Controls.Add(this.textBoxS5);
            this.groupBox2.Controls.Add(this.buttonS3);
            this.groupBox2.Controls.Add(this.textBoxS3);
            this.groupBox2.Controls.Add(this.buttonS2);
            this.groupBox2.Controls.Add(this.textBoxS2);
            this.groupBox2.Controls.Add(this.buttonS1);
            this.groupBox2.Controls.Add(this.textBoxS1);
            this.groupBox2.Location = new System.Drawing.Point(9, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 161);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Envio Data";
            // 
            // buttonS15
            // 
            this.buttonS15.Enabled = false;
            this.buttonS15.Location = new System.Drawing.Point(421, 125);
            this.buttonS15.Name = "buttonS15";
            this.buttonS15.Size = new System.Drawing.Size(45, 19);
            this.buttonS15.TabIndex = 29;
            this.buttonS15.Text = "Send";
            this.buttonS15.UseVisualStyleBackColor = true;
            this.buttonS15.Click += new System.EventHandler(this.buttonS15_Click);
            // 
            // textBoxS15
            // 
            this.textBoxS15.Location = new System.Drawing.Point(324, 125);
            this.textBoxS15.Name = "textBoxS15";
            this.textBoxS15.Size = new System.Drawing.Size(97, 20);
            this.textBoxS15.TabIndex = 28;
            // 
            // buttonS14
            // 
            this.buttonS14.Enabled = false;
            this.buttonS14.Location = new System.Drawing.Point(421, 100);
            this.buttonS14.Name = "buttonS14";
            this.buttonS14.Size = new System.Drawing.Size(45, 19);
            this.buttonS14.TabIndex = 27;
            this.buttonS14.Text = "Send";
            this.buttonS14.UseVisualStyleBackColor = true;
            this.buttonS14.Click += new System.EventHandler(this.buttonS14_Click);
            // 
            // textBoxS14
            // 
            this.textBoxS14.Location = new System.Drawing.Point(324, 100);
            this.textBoxS14.Name = "textBoxS14";
            this.textBoxS14.Size = new System.Drawing.Size(97, 20);
            this.textBoxS14.TabIndex = 26;
            // 
            // buttonS13
            // 
            this.buttonS13.Enabled = false;
            this.buttonS13.Location = new System.Drawing.Point(421, 75);
            this.buttonS13.Name = "buttonS13";
            this.buttonS13.Size = new System.Drawing.Size(45, 19);
            this.buttonS13.TabIndex = 25;
            this.buttonS13.Text = "Send";
            this.buttonS13.UseVisualStyleBackColor = true;
            this.buttonS13.Click += new System.EventHandler(this.buttonS13_Click);
            // 
            // textBoxS13
            // 
            this.textBoxS13.Location = new System.Drawing.Point(324, 75);
            this.textBoxS13.Name = "textBoxS13";
            this.textBoxS13.Size = new System.Drawing.Size(97, 20);
            this.textBoxS13.TabIndex = 24;
            // 
            // buttonS12
            // 
            this.buttonS12.Enabled = false;
            this.buttonS12.Location = new System.Drawing.Point(421, 48);
            this.buttonS12.Name = "buttonS12";
            this.buttonS12.Size = new System.Drawing.Size(45, 19);
            this.buttonS12.TabIndex = 23;
            this.buttonS12.Text = "Send";
            this.buttonS12.UseVisualStyleBackColor = true;
            this.buttonS12.Click += new System.EventHandler(this.buttonS12_Click);
            // 
            // textBoxS12
            // 
            this.textBoxS12.Location = new System.Drawing.Point(324, 48);
            this.textBoxS12.Name = "textBoxS12";
            this.textBoxS12.Size = new System.Drawing.Size(97, 20);
            this.textBoxS12.TabIndex = 22;
            // 
            // buttonS11
            // 
            this.buttonS11.Enabled = false;
            this.buttonS11.Location = new System.Drawing.Point(421, 24);
            this.buttonS11.Name = "buttonS11";
            this.buttonS11.Size = new System.Drawing.Size(45, 19);
            this.buttonS11.TabIndex = 21;
            this.buttonS11.Text = "Send";
            this.buttonS11.UseVisualStyleBackColor = true;
            this.buttonS11.Click += new System.EventHandler(this.buttonS11_Click);
            // 
            // textBoxS11
            // 
            this.textBoxS11.Location = new System.Drawing.Point(324, 24);
            this.textBoxS11.Name = "textBoxS11";
            this.textBoxS11.Size = new System.Drawing.Size(97, 20);
            this.textBoxS11.TabIndex = 20;
            // 
            // buttonS10
            // 
            this.buttonS10.Enabled = false;
            this.buttonS10.Location = new System.Drawing.Point(263, 127);
            this.buttonS10.Name = "buttonS10";
            this.buttonS10.Size = new System.Drawing.Size(45, 19);
            this.buttonS10.TabIndex = 19;
            this.buttonS10.Text = "Send";
            this.buttonS10.UseVisualStyleBackColor = true;
            this.buttonS10.Click += new System.EventHandler(this.buttonS10_Click);
            // 
            // textBoxS10
            // 
            this.textBoxS10.Location = new System.Drawing.Point(166, 127);
            this.textBoxS10.Name = "textBoxS10";
            this.textBoxS10.Size = new System.Drawing.Size(97, 20);
            this.textBoxS10.TabIndex = 18;
            // 
            // buttonS9
            // 
            this.buttonS9.Enabled = false;
            this.buttonS9.Location = new System.Drawing.Point(263, 101);
            this.buttonS9.Name = "buttonS9";
            this.buttonS9.Size = new System.Drawing.Size(45, 19);
            this.buttonS9.TabIndex = 17;
            this.buttonS9.Text = "Send";
            this.buttonS9.UseVisualStyleBackColor = true;
            this.buttonS9.Click += new System.EventHandler(this.buttonS9_Click);
            // 
            // textBoxS9
            // 
            this.textBoxS9.Location = new System.Drawing.Point(166, 101);
            this.textBoxS9.Name = "textBoxS9";
            this.textBoxS9.Size = new System.Drawing.Size(97, 20);
            this.textBoxS9.TabIndex = 16;
            // 
            // buttonS8
            // 
            this.buttonS8.Enabled = false;
            this.buttonS8.Location = new System.Drawing.Point(263, 76);
            this.buttonS8.Name = "buttonS8";
            this.buttonS8.Size = new System.Drawing.Size(45, 19);
            this.buttonS8.TabIndex = 15;
            this.buttonS8.Text = "Send";
            this.buttonS8.UseVisualStyleBackColor = true;
            this.buttonS8.Click += new System.EventHandler(this.buttonS8_Click);
            // 
            // textBoxS8
            // 
            this.textBoxS8.Location = new System.Drawing.Point(166, 76);
            this.textBoxS8.Name = "textBoxS8";
            this.textBoxS8.Size = new System.Drawing.Size(97, 20);
            this.textBoxS8.TabIndex = 14;
            // 
            // buttonS7
            // 
            this.buttonS7.Enabled = false;
            this.buttonS7.Location = new System.Drawing.Point(263, 49);
            this.buttonS7.Name = "buttonS7";
            this.buttonS7.Size = new System.Drawing.Size(45, 19);
            this.buttonS7.TabIndex = 13;
            this.buttonS7.Text = "Send";
            this.buttonS7.UseVisualStyleBackColor = true;
            this.buttonS7.Click += new System.EventHandler(this.buttonS7_Click);
            // 
            // textBoxS7
            // 
            this.textBoxS7.Location = new System.Drawing.Point(166, 49);
            this.textBoxS7.Name = "textBoxS7";
            this.textBoxS7.Size = new System.Drawing.Size(97, 20);
            this.textBoxS7.TabIndex = 12;
            // 
            // buttonS4
            // 
            this.buttonS4.Enabled = false;
            this.buttonS4.Location = new System.Drawing.Point(106, 102);
            this.buttonS4.Name = "buttonS4";
            this.buttonS4.Size = new System.Drawing.Size(45, 19);
            this.buttonS4.TabIndex = 11;
            this.buttonS4.Text = "Send";
            this.buttonS4.UseVisualStyleBackColor = true;
            this.buttonS4.Click += new System.EventHandler(this.buttonS4_Click);
            // 
            // textBoxS4
            // 
            this.textBoxS4.Location = new System.Drawing.Point(9, 102);
            this.textBoxS4.Name = "textBoxS4";
            this.textBoxS4.Size = new System.Drawing.Size(97, 20);
            this.textBoxS4.TabIndex = 10;
            // 
            // buttonS6
            // 
            this.buttonS6.Enabled = false;
            this.buttonS6.Location = new System.Drawing.Point(263, 24);
            this.buttonS6.Name = "buttonS6";
            this.buttonS6.Size = new System.Drawing.Size(45, 19);
            this.buttonS6.TabIndex = 9;
            this.buttonS6.Text = "Send";
            this.buttonS6.UseVisualStyleBackColor = true;
            this.buttonS6.Click += new System.EventHandler(this.buttonS6_Click);
            // 
            // textBoxS6
            // 
            this.textBoxS6.Location = new System.Drawing.Point(166, 24);
            this.textBoxS6.Name = "textBoxS6";
            this.textBoxS6.Size = new System.Drawing.Size(97, 20);
            this.textBoxS6.TabIndex = 8;
            // 
            // buttonS5
            // 
            this.buttonS5.Enabled = false;
            this.buttonS5.Location = new System.Drawing.Point(106, 128);
            this.buttonS5.Name = "buttonS5";
            this.buttonS5.Size = new System.Drawing.Size(45, 19);
            this.buttonS5.TabIndex = 7;
            this.buttonS5.Text = "Send";
            this.buttonS5.UseVisualStyleBackColor = true;
            this.buttonS5.Click += new System.EventHandler(this.buttonS5_Click);
            // 
            // textBoxS5
            // 
            this.textBoxS5.Location = new System.Drawing.Point(9, 128);
            this.textBoxS5.Name = "textBoxS5";
            this.textBoxS5.Size = new System.Drawing.Size(97, 20);
            this.textBoxS5.TabIndex = 6;
            // 
            // buttonS3
            // 
            this.buttonS3.Enabled = false;
            this.buttonS3.Location = new System.Drawing.Point(106, 76);
            this.buttonS3.Name = "buttonS3";
            this.buttonS3.Size = new System.Drawing.Size(45, 19);
            this.buttonS3.TabIndex = 5;
            this.buttonS3.Text = "Send";
            this.buttonS3.UseVisualStyleBackColor = true;
            this.buttonS3.Click += new System.EventHandler(this.buttonS3_Click);
            // 
            // textBoxS3
            // 
            this.textBoxS3.Location = new System.Drawing.Point(9, 76);
            this.textBoxS3.Name = "textBoxS3";
            this.textBoxS3.Size = new System.Drawing.Size(97, 20);
            this.textBoxS3.TabIndex = 4;
            // 
            // buttonS2
            // 
            this.buttonS2.Enabled = false;
            this.buttonS2.Location = new System.Drawing.Point(106, 50);
            this.buttonS2.Name = "buttonS2";
            this.buttonS2.Size = new System.Drawing.Size(45, 19);
            this.buttonS2.TabIndex = 3;
            this.buttonS2.Text = "Send";
            this.buttonS2.UseVisualStyleBackColor = true;
            this.buttonS2.Click += new System.EventHandler(this.buttonS2_Click);
            // 
            // textBoxS2
            // 
            this.textBoxS2.Location = new System.Drawing.Point(9, 50);
            this.textBoxS2.Name = "textBoxS2";
            this.textBoxS2.Size = new System.Drawing.Size(97, 20);
            this.textBoxS2.TabIndex = 2;
            // 
            // buttonS1
            // 
            this.buttonS1.Enabled = false;
            this.buttonS1.Location = new System.Drawing.Point(106, 24);
            this.buttonS1.Name = "buttonS1";
            this.buttonS1.Size = new System.Drawing.Size(45, 19);
            this.buttonS1.TabIndex = 1;
            this.buttonS1.Text = "Send";
            this.buttonS1.UseVisualStyleBackColor = true;
            this.buttonS1.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxS1
            // 
            this.textBoxS1.Location = new System.Drawing.Point(9, 24);
            this.textBoxS1.Name = "textBoxS1";
            this.textBoxS1.Size = new System.Drawing.Size(97, 20);
            this.textBoxS1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Actualizar Comandos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(765, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "HyperTerminal SERIAL - Jose Luis Rodriguez";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonS6;
        private System.Windows.Forms.TextBox textBoxS6;
        private System.Windows.Forms.Button buttonS5;
        private System.Windows.Forms.TextBox textBoxS5;
        private System.Windows.Forms.Button buttonS3;
        private System.Windows.Forms.TextBox textBoxS3;
        private System.Windows.Forms.Button buttonS2;
        private System.Windows.Forms.TextBox textBoxS2;
        private System.Windows.Forms.Button buttonS1;
        private System.Windows.Forms.TextBox textBoxS1;
        private System.Windows.Forms.Button buttonS10;
        private System.Windows.Forms.TextBox textBoxS10;
        private System.Windows.Forms.Button buttonS9;
        private System.Windows.Forms.TextBox textBoxS9;
        private System.Windows.Forms.Button buttonS8;
        private System.Windows.Forms.TextBox textBoxS8;
        private System.Windows.Forms.Button buttonS7;
        private System.Windows.Forms.TextBox textBoxS7;
        private System.Windows.Forms.Button buttonS4;
        private System.Windows.Forms.TextBox textBoxS4;
        private System.Windows.Forms.Button buttonS15;
        private System.Windows.Forms.TextBox textBoxS15;
        private System.Windows.Forms.Button buttonS14;
        private System.Windows.Forms.TextBox textBoxS14;
        private System.Windows.Forms.Button buttonS13;
        private System.Windows.Forms.TextBox textBoxS13;
        private System.Windows.Forms.Button buttonS12;
        private System.Windows.Forms.TextBox textBoxS12;
        private System.Windows.Forms.Button buttonS11;
        private System.Windows.Forms.TextBox textBoxS11;
        private System.Windows.Forms.Button button2;
    }
}

