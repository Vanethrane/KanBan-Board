using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBan_Board
{
    public partial class AssignWorkerDialog : Form
    {
        public JobCard card;
        public AssignWorkerDialog()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)        {
           
            card.worker.name= textBox1.Text;
            card.UpdateUI();
            this.Close();
        }
        
    }
}
