namespace WindowsFormsApp1
{
    partial class theos
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Rooms", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Club");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Student", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Calculator");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Utilities", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.moise = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Rooms";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Club";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Student";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Calculator";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Utilities";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(177, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // moise
            // 
            this.moise.AccessibleName = "moise";
            this.moise.Location = new System.Drawing.Point(183, 1);
            this.moise.Name = "moise";
            this.moise.Size = new System.Drawing.Size(614, 450);
            this.moise.TabIndex = 1;
            // 
            // theos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moise);
            this.Controls.Add(this.treeView1);
            this.Name = "theos";
            this.Text = "theos";
            this.Load += new System.EventHandler(this.theos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel moise;
    }
}