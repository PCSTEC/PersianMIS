namespace PIASService
{
    partial class PIASService
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort5 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort6 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort7 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort8 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort9 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort10 = new System.IO.Ports.SerialPort(this.components);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            // 
            // serialPort3
            // 
               // PIASService
            // 
            this.ServiceName = "PIASService";

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.IO.Ports.SerialPort serialPort4;
        private System.IO.Ports.SerialPort serialPort5;
        private System.IO.Ports.SerialPort serialPort6;
        private System.IO.Ports.SerialPort serialPort7;
        private System.IO.Ports.SerialPort serialPort8;
        private System.IO.Ports.SerialPort serialPort9;
        private System.IO.Ports.SerialPort serialPort10;
    }
}
