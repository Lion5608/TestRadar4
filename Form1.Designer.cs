using System.Windows.Forms;

namespace TestRadar4
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Mexico",
            "0",
            "Canada",
            "5",
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Spain",
            "10",
            "Brazil",
            "2"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoalsH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoalsA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDX,
            this.TeamH,
            this.GoalsH,
            this.TeamA,
            this.GoalsA});
            this.listView1.HideSelection = false;
            listViewItem3.Tag = "";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(789, 790);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IDX
            // 
            this.IDX.Text = "IDX";
            this.IDX.Width = 43;
            // 
            // TeamH
            // 
            this.TeamH.Text = "Team Home";
            this.TeamH.Width = 155;
            // 
            // GoalsH
            // 
            this.GoalsH.Text = "GoalsH";
            this.GoalsH.Width = 174;
            // 
            // TeamA
            // 
            this.TeamA.Text = "TeamAway";
            this.TeamA.Width = 245;
            // 
            // GoalsA
            // 
            this.GoalsA.Text = "GoalsA";
            this.GoalsA.Width = 110;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 108);
            this.button1.TabIndex = 1;
            this.button1.Text = "Initialize table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 790);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Scoreboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IDX;
        private System.Windows.Forms.ColumnHeader TeamH;
        private System.Windows.Forms.ColumnHeader GoalsH;
        private System.Windows.Forms.ColumnHeader TeamA;
        private System.Windows.Forms.ColumnHeader GoalsA;
        private Button button1;
    }
}

