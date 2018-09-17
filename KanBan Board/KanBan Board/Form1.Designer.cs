namespace KanBan_Board
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_addjob = new System.Windows.Forms.Button();
            this.tb_addjob = new System.Windows.Forms.TextBox();
            this.pan_unstarted = new System.Windows.Forms.FlowLayoutPanel();
            this.pan_inprogress = new System.Windows.Forms.FlowLayoutPanel();
            this.pan_done = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewKanbanBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_create = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.lb_jobs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tasker = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checksolo = new System.Windows.Forms.RadioButton();
            this.checkgroup = new System.Windows.Forms.RadioButton();
            this.lbl_proj = new System.Windows.Forms.Label();
            this.diag_save = new System.Windows.Forms.SaveFileDialog();
            this.diag_load = new System.Windows.Forms.OpenFileDialog();
            this.pan_edit = new System.Windows.Forms.Panel();
            this.tb_edittitle = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.r_unstarted = new System.Windows.Forms.RadioButton();
            this.r_progress = new System.Windows.Forms.RadioButton();
            this.r_done = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_acceptEdit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pan_create.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pan_edit.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addjob
            // 
            this.btn_addjob.Location = new System.Drawing.Point(227, 27);
            this.btn_addjob.Name = "btn_addjob";
            this.btn_addjob.Size = new System.Drawing.Size(80, 20);
            this.btn_addjob.TabIndex = 3;
            this.btn_addjob.Text = "Add Job";
            this.btn_addjob.UseVisualStyleBackColor = true;
            this.btn_addjob.Click += new System.EventHandler(this.btn_addjob_Click);
            // 
            // tb_addjob
            // 
            this.tb_addjob.Location = new System.Drawing.Point(9, 27);
            this.tb_addjob.Name = "tb_addjob";
            this.tb_addjob.Size = new System.Drawing.Size(212, 20);
            this.tb_addjob.TabIndex = 4;
            this.tb_addjob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_addjob_KeyDown);
            // 
            // pan_unstarted
            // 
            this.pan_unstarted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pan_unstarted.AutoScroll = true;
            this.pan_unstarted.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pan_unstarted.Location = new System.Drawing.Point(9, 53);
            this.pan_unstarted.Name = "pan_unstarted";
            this.pan_unstarted.Size = new System.Drawing.Size(298, 479);
            this.pan_unstarted.TabIndex = 0;
            // 
            // pan_inprogress
            // 
            this.pan_inprogress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_inprogress.AutoScroll = true;
            this.pan_inprogress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pan_inprogress.Location = new System.Drawing.Point(313, 53);
            this.pan_inprogress.Name = "pan_inprogress";
            this.pan_inprogress.Size = new System.Drawing.Size(298, 479);
            this.pan_inprogress.TabIndex = 5;
            // 
            // pan_done
            // 
            this.pan_done.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_done.AutoScroll = true;
            this.pan_done.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pan_done.Location = new System.Drawing.Point(617, 53);
            this.pan_done.Name = "pan_done";
            this.pan_done.Size = new System.Drawing.Size(298, 479);
            this.pan_done.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewKanbanBoardToolStripMenuItem,
            this.saveBoardToolStripMenuItem,
            this.loadBoardToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startNewKanbanBoardToolStripMenuItem
            // 
            this.startNewKanbanBoardToolStripMenuItem.Name = "startNewKanbanBoardToolStripMenuItem";
            this.startNewKanbanBoardToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.startNewKanbanBoardToolStripMenuItem.Text = "Start New Board";
            this.startNewKanbanBoardToolStripMenuItem.Click += new System.EventHandler(this.startNewKanbanBoardToolStripMenuItem_Click);
            // 
            // saveBoardToolStripMenuItem
            // 
            this.saveBoardToolStripMenuItem.Name = "saveBoardToolStripMenuItem";
            this.saveBoardToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saveBoardToolStripMenuItem.Text = "Save Board";
            this.saveBoardToolStripMenuItem.Click += new System.EventHandler(this.saveBoardToolStripMenuItem_Click);
            // 
            // loadBoardToolStripMenuItem
            // 
            this.loadBoardToolStripMenuItem.Name = "loadBoardToolStripMenuItem";
            this.loadBoardToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadBoardToolStripMenuItem.Text = "Load Board";
            this.loadBoardToolStripMenuItem.Click += new System.EventHandler(this.loadBoardToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pan_create
            // 
            this.pan_create.AutoSize = true;
            this.pan_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pan_create.Controls.Add(this.label2);
            this.pan_create.Controls.Add(this.tb_name);
            this.pan_create.Controls.Add(this.button1);
            this.pan_create.Controls.Add(this.btn_proceed);
            this.pan_create.Controls.Add(this.lb_jobs);
            this.pan_create.Controls.Add(this.label1);
            this.pan_create.Controls.Add(this.tb_tasker);
            this.pan_create.Controls.Add(this.panel1);
            this.pan_create.Location = new System.Drawing.Point(300, 135);
            this.pan_create.Name = "pan_create";
            this.pan_create.Size = new System.Drawing.Size(339, 372);
            this.pan_create.TabIndex = 8;
            this.pan_create.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Project Name:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(93, 24);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(231, 20);
            this.tb_name.TabIndex = 8;
            this.tb_name.Text = "Nameless Project";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Location = new System.Drawing.Point(249, 341);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 6;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // lb_jobs
            // 
            this.lb_jobs.FormattingEnabled = true;
            this.lb_jobs.Location = new System.Drawing.Point(16, 162);
            this.lb_jobs.Name = "lb_jobs";
            this.lb_jobs.Size = new System.Drawing.Size(308, 173);
            this.lb_jobs.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tb_tasker
            // 
            this.tb_tasker.Location = new System.Drawing.Point(16, 136);
            this.tb_tasker.Name = "tb_tasker";
            this.tb_tasker.Size = new System.Drawing.Size(212, 20);
            this.tb_tasker.TabIndex = 3;
            this.tb_tasker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_tasker_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.checksolo);
            this.panel1.Controls.Add(this.checkgroup);
            this.panel1.Location = new System.Drawing.Point(228, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 77);
            this.panel1.TabIndex = 2;
            // 
            // checksolo
            // 
            this.checksolo.AutoSize = true;
            this.checksolo.Checked = true;
            this.checksolo.Location = new System.Drawing.Point(3, 3);
            this.checksolo.Name = "checksolo";
            this.checksolo.Size = new System.Drawing.Size(82, 17);
            this.checksolo.TabIndex = 0;
            this.checksolo.TabStop = true;
            this.checksolo.Text = "Solo Project";
            this.checksolo.UseVisualStyleBackColor = true;
            this.checksolo.CheckedChanged += new System.EventHandler(this.checksolo_CheckedChanged);
            // 
            // checkgroup
            // 
            this.checkgroup.AutoSize = true;
            this.checkgroup.Location = new System.Drawing.Point(3, 37);
            this.checkgroup.Name = "checkgroup";
            this.checkgroup.Size = new System.Drawing.Size(90, 17);
            this.checkgroup.TabIndex = 1;
            this.checkgroup.Text = "Group Project";
            this.checkgroup.UseVisualStyleBackColor = true;
            this.checkgroup.CheckedChanged += new System.EventHandler(this.checkgroup_CheckedChanged);
            // 
            // lbl_proj
            // 
            this.lbl_proj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_proj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_proj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proj.Location = new System.Drawing.Point(313, 27);
            this.lbl_proj.Name = "lbl_proj";
            this.lbl_proj.Size = new System.Drawing.Size(602, 23);
            this.lbl_proj.TabIndex = 9;
            this.lbl_proj.Text = "Nameless Project";
            this.lbl_proj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diag_save
            // 
            this.diag_save.DefaultExt = "kbn";
            this.diag_save.Title = "Save a KanBan Board";
            // 
            // pan_edit
            // 
            this.pan_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pan_edit.Controls.Add(this.btn_acceptEdit);
            this.pan_edit.Controls.Add(this.panel3);
            this.pan_edit.Controls.Add(this.tb_edittitle);
            this.pan_edit.Location = new System.Drawing.Point(303, 85);
            this.pan_edit.Name = "pan_edit";
            this.pan_edit.Size = new System.Drawing.Size(321, 177);
            this.pan_edit.TabIndex = 10;
            this.pan_edit.Visible = false;
            // 
            // tb_edittitle
            // 
            this.tb_edittitle.Location = new System.Drawing.Point(10, 3);
            this.tb_edittitle.Name = "tb_edittitle";
            this.tb_edittitle.Size = new System.Drawing.Size(298, 20);
            this.tb_edittitle.TabIndex = 1;
            this.tb_edittitle.Text = "set to current title";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.r_done);
            this.panel3.Controls.Add(this.r_progress);
            this.panel3.Controls.Add(this.r_unstarted);
            this.panel3.Location = new System.Drawing.Point(10, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 93);
            this.panel3.TabIndex = 2;
            // 
            // r_unstarted
            // 
            this.r_unstarted.AutoSize = true;
            this.r_unstarted.Location = new System.Drawing.Point(13, 27);
            this.r_unstarted.Name = "r_unstarted";
            this.r_unstarted.Size = new System.Drawing.Size(71, 17);
            this.r_unstarted.TabIndex = 0;
            this.r_unstarted.TabStop = true;
            this.r_unstarted.Text = "Unstarted";
            this.r_unstarted.UseVisualStyleBackColor = true;
            // 
            // r_progress
            // 
            this.r_progress.AutoSize = true;
            this.r_progress.Location = new System.Drawing.Point(13, 44);
            this.r_progress.Name = "r_progress";
            this.r_progress.Size = new System.Drawing.Size(78, 17);
            this.r_progress.TabIndex = 1;
            this.r_progress.TabStop = true;
            this.r_progress.Text = "In Progress";
            this.r_progress.UseVisualStyleBackColor = true;
            // 
            // r_done
            // 
            this.r_done.AutoSize = true;
            this.r_done.Location = new System.Drawing.Point(13, 63);
            this.r_done.Name = "r_done";
            this.r_done.Size = new System.Drawing.Size(69, 17);
            this.r_done.TabIndex = 2;
            this.r_done.TabStop = true;
            this.r_done.Text = "Complete";
            this.r_done.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Status:";
            // 
            // btn_acceptEdit
            // 
            this.btn_acceptEdit.Location = new System.Drawing.Point(228, 137);
            this.btn_acceptEdit.Name = "btn_acceptEdit";
            this.btn_acceptEdit.Size = new System.Drawing.Size(75, 23);
            this.btn_acceptEdit.TabIndex = 3;
            this.btn_acceptEdit.Text = "Accept";
            this.btn_acceptEdit.UseVisualStyleBackColor = true;
            this.btn_acceptEdit.Click += new System.EventHandler(this.btn_acceptEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 544);
            this.Controls.Add(this.pan_edit);
            this.Controls.Add(this.lbl_proj);
            this.Controls.Add(this.pan_create);
            this.Controls.Add(this.pan_done);
            this.Controls.Add(this.pan_inprogress);
            this.Controls.Add(this.pan_unstarted);
            this.Controls.Add(this.tb_addjob);
            this.Controls.Add(this.btn_addjob);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KanBan Board V 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pan_create.ResumeLayout(false);
            this.pan_create.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pan_edit.ResumeLayout(false);
            this.pan_edit.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addjob;
        private System.Windows.Forms.TextBox tb_addjob;
        private System.Windows.Forms.FlowLayoutPanel pan_unstarted;
        private System.Windows.Forms.FlowLayoutPanel pan_inprogress;
        private System.Windows.Forms.FlowLayoutPanel pan_done;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewKanbanBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pan_create;
        private System.Windows.Forms.RadioButton checkgroup;
        private System.Windows.Forms.RadioButton checksolo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.ListBox lb_jobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tasker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_proj;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog diag_save;
        private System.Windows.Forms.OpenFileDialog diag_load;
        private System.Windows.Forms.Panel pan_edit;
        private System.Windows.Forms.Button btn_acceptEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton r_done;
        private System.Windows.Forms.RadioButton r_progress;
        private System.Windows.Forms.RadioButton r_unstarted;
        private System.Windows.Forms.TextBox tb_edittitle;
    }
}

