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
    public partial class JobCard : Form
    {
        public string title { get; set; }
        public string description { get; set; }

        public Worker worker { get; set; }
        public DateTime creationTime { get; set; }

        public static int Unstarted = 0;
        public static int inProgress = 1;
        public static int Done = 2;

        public Form1 form1;

        public int status = 0;
        public JobCard()
        {
            InitializeComponent();
            worker = new Worker("Unassigned");
            UpdateUI();
         
        }

     
        public JobCard(string tit, string descript)
        {
            this.title = tit;
            this.description = description;
            this.creationTime = DateTime.Now;
            status = Unstarted;
        }
        public JobCard(string tit)
        {
            this.title = tit;
            this.creationTime = DateTime.Now;
            status = Unstarted;
        }
        public void MoveTo(int stat)
        {
            switch (stat)
            {
                case 0:
                    this.status = Unstarted;
                    break;
                case 1:
                    this.status = inProgress;
                    break;
                case 2:
                    this.status = Done;
                    break;
                default:
                    Console.WriteLine("Job Status Invalid. Reverting to Unstarted...");
                    this.status = 0;
                    break;
            }
        }
        public void UpdateUI()
        {
            lbl_title.Text = title;
            lbl_desc.Text = description;
            lbl_worker.Text = worker.name;
            setColor();
        }
        public void setColor()
        {
            switch (status)
            {
                case 0:
                    this.BackColor = Color.Salmon;
                    break;
                case 1:
                    this.BackColor = Color.LightGoldenrodYellow;
                    break;
                case 2:
                    this.BackColor = Color.LightGreen;
                    break;
                default:
                    Console.WriteLine("Job Status Invalid. Reverting to Unstarted...");
                    this.status = 0;
                    break;
            }
        }

        #region clicks on card

        

        private void JobCard_MouseDown(object sender, MouseEventArgs e)
        {
            //status check prevents altering the status of a done job
            if (status < 2&& e.Button==MouseButtons.Left)
            {
                status += 1;
                UpdateUI();
            }
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(Cursor.Position);
            }
            }
      

        #endregion

        private void JobCard_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.RemoveJob(this);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.EditCard(this);
        }
    }
}
