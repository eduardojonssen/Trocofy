using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trocofy.Core;
using Trocofy.Core.DataContracts;

namespace Trocofy {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void UxBtnCalculate_Click(object sender, EventArgs e) {
            this.UxTxtChange.Text = "";
            this.UxTxtChangeDetailAmount.Text = "";
            uint receivedAmount = uint.Parse(this.UxTxtReceivedAmount.Text);
            uint productAmount = uint.Parse(this.UxTxtProductAmount.Text);

            TrocofyManager manager = new TrocofyManager();
            ComputeChangeRequest request = new ComputeChangeRequest();
            request.ReceivedAmount = receivedAmount;
            request.ProductAmount = productAmount;
            ComputeChangeResponse response = manager.ComputeChange(request);

            if (response.Success == false) {
                string validationMessage = "";
                foreach (Report error in response.OperationReport) {
                    validationMessage += "Campo: " + error.Field + Environment.NewLine +
                                         "Mensagem: " + error.Message + "\n\n\r";
                }
                MessageBox.Show(validationMessage, "Trocofy - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                this.UxTxtChange.Text = response.TotalChangeAmount.ToString();

                foreach (ChangeData changeData in response.ChangeDataList) {
                    this.UxTxtChangeDetailAmount.Text += changeData.Name + Environment.NewLine;
                    foreach (KeyValuePair<uint, uint> kvPair in changeData.ChangeDictionary) {
                        this.UxTxtChangeDetailAmount.Text += kvPair.Key.ToString() + ": " + kvPair.Value.ToString() + Environment.NewLine;
                    }
                    this.UxTxtChangeDetailAmount.Text += Environment.NewLine;
                }
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox aboutBox = new AboutBox();

            aboutBox.Show();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label2_Click_1(object sender, EventArgs e) {

        }

        private void label2_Click_2(object sender, EventArgs e) {

        }

        private void UxTxtChangeDetailAmount_TextChanged(object sender, EventArgs e) {

        }
    }
}
