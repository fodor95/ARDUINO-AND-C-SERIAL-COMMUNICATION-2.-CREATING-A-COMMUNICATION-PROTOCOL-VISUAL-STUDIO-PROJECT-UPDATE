using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports; //used for scanning the serial ports

delegate void StringArgReturningVoidDelegate(string text); //used for fixing multithreading problems

namespace fodor95com_arduino_serial_communication
{
    public partial class fodor95com_arduino_serial_connection : Form
    {
        public fodor95com_arduino_serial_connection()
        {
            InitializeComponent();
            string serialMessage;
            updateDataTimer.Interval = 1000;
        }

        int errorFrames = 0;
        int correctFrames = 0;

        private void scanButton_Click(object sender, EventArgs e)
        {
            int itemsFound = 0; //how many active ports are found

            //finding available serial ports and filling up the combo box with found port names
            foreach (string s in SerialPort.GetPortNames())
            {
                portComboBox.Items.Add(s);//adding port name to combo box
                itemsFound++;//incrementing the items found variable
            }

            if (itemsFound < 1)
                MessageBox.Show("NO ITEMS FOUND");//if no serial devices have been found, an error message window will show up
            else
                portComboBox.SelectedIndex = 0;//if there were found active ports, than the first one is going to be automatically selected in the combo box
        }

        private void portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = portComboBox.Text;//if the value of the combo box was changed then the serial port component port name will be updated
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //a try-catch statement is used for not crashing the program if the serial connection is impossible to realize 
            try
            {
                serialPort1.Open();//the specific command to open the serial port
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displaying the error in a message box
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            updateDataTimer.Enabled = false;
        }

        private void updateStartButton_Click(object sender, EventArgs e)
        {
            updateDataTimer.Enabled = true;
        }

        private void updateNowButton_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("request_message");
        }

        private void updateStopButton_Click(object sender, EventArgs e)
        {
            updateDataTimer.Enabled = false;
            
        }

        private void updateDataTimer_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            try {
                serialPort1.WriteLine("request_message");//sends a specific message to arduino
            }catch(Exception er)
            {
                //if an error is detected then the error message is displayed and timer gets disabled
                MessageBox.Show(er.Message);
                updateDataTimer.Enabled = false;
            }



        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string s;
            s = sp.ReadLine();

            SetTextOfTextBox2(s);

            string[] splittedData = s.Split(':');

            string checksum = splittedData[0];
            string data = splittedData[1];

            //the code only counts the correct/error frames, nothing else - 

            if (calculateChecksum(data) == checksum)
            {
                //incrementing the correctFrames variable
                correctFrames++;
                SetTextOfCorrectFramesLabel(correctFrames.ToString());
            }
            else
            {
               //incrementing the errorFrames variable
                errorFrames++;
                SetTextOfErrorFramesLabel(errorFrames.ToString());
            }

        }

        private void SetTextOfTextBox2(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox2.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetTextOfTextBox2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox2.Text = text;
            }
        }

        private void SetTextOfCorrectFramesLabel(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.correctFramesLabel.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetTextOfCorrectFramesLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.correctFramesLabel.Text = text;
            }
        }

        private void SetTextOfErrorFramesLabel(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.errorFramesLabel.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetTextOfErrorFramesLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.errorFramesLabel.Text = text;
            }
        }


        public string calculateChecksum(string data)
        {
            int lengthOfString = data.Length;
            int sum = 0;
            int asciiCharacter = 0;


            for (int i = 0; i < lengthOfString-1; i++)
            {
                //covert the character to its ascii value
                asciiCharacter = (int)data[i];
                sum = sum + asciiCharacter * (i+1);                
            }


            int checksum = sum % 1001;

            //MessageBox.Show(checksum.ToString() + "-" + data);
            return checksum.ToString();
        }

        


    }
}
