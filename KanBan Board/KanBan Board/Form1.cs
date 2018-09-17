using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KanBan_Board
{
    public partial class Form1 : Form
    {
        public List<JobCard> jobs = new List<JobCard>();
        private Timer loopTime;
        public bool groupWork = false;
        public JobCard selected;

        public Form1()
        {
            InitializeComponent();

            //init a loop for updates
            loopTime = new Timer();
            loopTime.Tick += new EventHandler(loopTime_Tick);
            loopTime.Interval = 1000;
            loopTime.Start();

        }

      
        #region loopTimer
        private void loopTime_Tick(object sender, EventArgs e)
        {
            foreach (JobCard jcard in pan_unstarted.Controls)
            {
                if (jcard.status != 0)
                {
                    pan_unstarted.Controls.Remove(jcard);
                    if (jcard.worker.name == "Unassigned" && groupWork)
                    {
                        AssignWorkerDialog diag = new AssignWorkerDialog();
                        diag.card = jcard;
                        diag.Show();


                    }
                    pan_inprogress.Controls.Add(jcard);
                }
            }
            foreach (JobCard jcard in pan_inprogress.Controls)
            {
                if (jcard.status != 1)
                {
                    pan_inprogress.Controls.Remove(jcard);
                    pan_done.Controls.Add(jcard);
                }
            }


        }
        #endregion loopTimer

        #region addOnFly
        private void btn_addjob_Click(object sender, EventArgs e)
        {
            if (tb_addjob.Text != "")
            {

                AddJobToBoard();
            }
            else
            {
                Console.WriteLine("You must enter a Title for the job!");
            }
        }


        private void tb_addjob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_addjob_Click(sender, e);
            }
        }
        #endregion addOnFly

        #region radioControlGroup

        /*    this controls the radio buttons which determine our bool for group or solo
        *    
        *    Params:
        *    bool groupWork - true means group project, false means solo project
        * */
        private void checksolo_CheckedChanged(object sender, EventArgs e)
        {


            if (checksolo.Checked)
            {
                groupWork = false;
            }
            else
            {
                groupWork = true;
            }
        }

        private void checkgroup_CheckedChanged(object sender, EventArgs e)
        {


            if (checkgroup.Checked)
            {
                groupWork = true;
            }
            else
            {
                groupWork = false;
            }
        }
        #endregion

        // the following sends in a jobcard and removes it from both the list and the display
        public void RemoveJob(JobCard jobCard)
        {
            jobs.Remove(jobCard);
            if (jobCard.status == 0)
            {
                pan_unstarted.Controls.Remove(jobCard);
            }
            if (jobCard.status == 1)
            {
                pan_inprogress.Controls.Remove(jobCard);
            }
            if (jobCard.status == 2)
            {
                pan_done.Controls.Remove(jobCard);
            }
        }
        public void MoveCard(JobCard card, int where)
        {
            RemoveJob(card);
            switch (where)
            {
                case 0:
                    card.status = 0;
                    pan_unstarted.Controls.Add(card);
                    break;
                case 1:
                    card.status = 1;
                    pan_inprogress.Controls.Add(card);
                    break;

                case 2:
                    card.status = 2;
                    pan_done.Controls.Add(card);
                    break;
                default:
                    card.status = 0;
                    pan_unstarted.Controls.Add(card);
                    break;
            }
            card.TopLevel = false;

            card.setColor();
            card.UpdateUI();
            card.Show();
        }
        internal void EditCard(JobCard jobCard)
        {
            tb_edittitle.Text = jobCard.title;

            switch (jobCard.status)
            {
                case 0:
                    r_unstarted.Checked = true;
                   //jobCard.title = tb_edittitle.Text;
                    break;
                case 1:
                    r_progress.Checked = true;
                  //  jobCard.title = tb_edittitle.Text;
                    break;
                case 2:
                    r_done.Checked = true;
                  //  jobCard.title = tb_edittitle.Text;
                    break;
                default:
                    r_unstarted.Checked = true;
                  //  jobCard.title = tb_edittitle.Text;
                    break;
            }


            pan_edit.Visible = true;
           
           
          
            selected = jobCard;
           


        }

        #region newBoardMenu

        private void tb_tasker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_tasker.Text != "")
            {
                lb_jobs.Items.Add(tb_tasker.Text);
                tb_tasker.Text = "";
            }
        }
        /*   This button uses info from Controls on pan_create
         *   to create a new knaban project
         *   
         *   Controls:
         *   Panel pan_create - Parent Container
         *   TextBox tb_name - name of project
         *   ListBox lb_jobs -list of jobs to start the board with
         *   
         * */
        private void btn_proceed_Click(object sender, EventArgs e)
        {
            pan_create.Visible = false;
            foreach (String task in lb_jobs.Items)
            {
                AddJobToBoard(task);
            }
            lb_jobs.Items.Clear();
            lbl_proj.Text = tb_name.Text;
        }
        #endregion newBoardMenu

        #region addJobMethods
        /*    this is the DEFAULT method with no arguments.
         *    
         *    task title is taken from tb_addjob.Text
         * */
        public void AddJobToBoard()
        {

            //create jobcard
            JobCard card = new JobCard();

            card.title = tb_addjob.Text;
            card.description = "";
            card.UpdateUI();

            //add card to list of jobs
            jobs.Add(card);
            card.form1 = this;
            //add to the controls on the first flowpanel
            card.TopLevel = false;
            pan_unstarted.Controls.Add(card);
            card.Show();

            //clear our textbox as a first indication something is working, and for next use;
            tb_addjob.Text = "";

        }

        /*    this is the FIRST OVERLOADED method with one argument.
         *    
         *    Params:
         *    String job - applied to the newly created JobCard as JobCard.title
         *    
         * */
        public void AddJobToBoard(String job)
        {

            //create jobcard
            JobCard card = new JobCard();

            card.title = job;
            card.description = "";
            card.UpdateUI();

            //add card to list of jobs
            jobs.Add(card);
           card.form1 = this;
            //add to the controls on the first flowpanel
            card.TopLevel = false;
            pan_unstarted.Controls.Add(card);
            card.Show();

            //clear our textbox as a first indication something is working, and for next use;
            tb_addjob.Text = "";

        }
        /*    this is the Second OVERLOADED method with one argument.
     *    
     *    Params:
     *   JobCard job - applied to the newly created JobCard as JobCard.title
     *    
     * */
        public void AddJobToBoard(JobCard job)
        {

         
            job.UpdateUI();

            //add card to list of jobs
            jobs.Add(job);


            job.form1 = this;
            //add to the controls on the first flowpanel
            job.TopLevel = false;
            pan_unstarted.Controls.Add(job);
            job.Show();

           

        }
        #endregion addJobMethods

        private void clearBoard()
        {
            jobs.Clear();
            pan_unstarted.Controls.Clear();
            pan_inprogress.Controls.Clear();
            pan_done.Controls.Clear();

        }

        #region menustrip
        private void startNewKanbanBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jobs.Clear();
            pan_unstarted.Controls.Clear();
            pan_inprogress.Controls.Clear();
            pan_done.Controls.Clear();
            pan_create.Visible = true;
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void saveBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dres = diag_save.ShowDialog();

            if (dres == DialogResult.OK)
            {
                if (diag_save.FileName != "")
                {
                  
                    String fileName = diag_save.FileName;

                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        foreach (JobCard job in jobs)
                        {
                            sw.WriteLine(job.title + "," + job.description + "," + job.worker.name + "," + job.creationTime+","+ job.status+","+lbl_proj.Text);
                        }
                        sw.Close();
                    }
                }
            }
            else if (dres == DialogResult.Cancel)
            {
                MessageBox.Show("Save Canceled");

            }
        }
       
        private void loadBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dres = diag_load.ShowDialog();

            if (dres == DialogResult.OK)
            {
                if (diag_load.FileName != "")
                {
                    clearBoard();
                    String fileName = diag_load.FileName;

                    if (File.Exists(fileName))
                    {
                        string[] tasks = File.ReadAllLines(fileName);
                        foreach(string line in tasks)
                        {
                            string[] sets = line.Split(',');

                            JobCard card = new JobCard();
                            card.title = sets[0];
                            card.description = sets[1];
                            card.worker = new Worker(sets[2]);
                            card.creationTime = DateTime.Parse(sets[3]);
                            card.status = int.Parse(sets[4]);
                            AddJobToBoard(card);
                            lbl_proj.Text = sets[5];
                           
                         }
                    }
                }
            }
            else if (dres == DialogResult.Cancel)
            {
                MessageBox.Show("Save Canceled");

            }
        }
        #endregion menustrip

        private void btn_acceptEdit_Click(object sender, EventArgs e)
        {
            selected.title = tb_edittitle.Text;
            if (r_unstarted.Checked)
            {
                selected.status = 0;
                MoveCard(selected, 0);
            }
            if (r_progress.Checked)
            {
                selected.status = 1;
                MoveCard(selected, 1);
            }
            if (r_done.Checked)
            {
                selected.status = 2;
                MoveCard(selected, 2);
            }
            pan_edit.Visible = false;

        }
    }
}
