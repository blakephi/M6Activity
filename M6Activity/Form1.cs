using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6Activity
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            ProductionWorker obj = new ProductionWorker();

            obj.empName = nameBox.Text;
            obj.empNumber = numberBox.Text;
            obj.shift = Convert.ToInt32(shiftBox.Text);
            obj.payRate = Convert.ToInt32(payBox.Text);


        }
    }
}
