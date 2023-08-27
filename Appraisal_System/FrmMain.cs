using Appraisal_System.Common;

namespace Appraisal_System {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {

        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e) {
            //隐藏所有节点高亮
            foreach (TreeNode node in trvMenu.Nodes) {
                node.BackColor = Color.White;
                node.ForeColor = Color.Black;
            }
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor = Color.White;

            Form form = FrmFactory<Form>.CreatForm(e.Node.Tag.ToString());
            form.MdiParent = this;
            form.Parent = splitContainer1.Panel2;
            form.Show();
        }
    }
}
