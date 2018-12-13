using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class theos : Form
    {
        public theos()
        {
            InitializeComponent();
        }
        public Form T;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {


            TreeNode node = treeView1.SelectedNode;
            switch (node.Text)
            {
                case "Calculator":
                    T.Dispose();
                    T = new Form1();
                    T.TopLevel = false;
                    this.moise.Controls.Add(T);
                    // T.Dock = DockStyle.Fill;
                    T.Show();

                    break;
            }
        }

        private void theos_Load(object sender, EventArgs e)
        {

            this.treeView1.Nodes[0].ExpandAll();
            T = new Form1();

            T.TopLevel = false;
            this.moise.Controls.Add(T);
            T.Dock = DockStyle.Fill;// fill the form in the main panel
        }
    }
}
