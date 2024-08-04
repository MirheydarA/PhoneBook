using MetroFramework.Forms;

namespace PhoneBook
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm();
            Program.MainFormInstance.Hide();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e) { }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListForm frm = new ListForm();
            Program.MainFormInstance.Hide();
            frm.ShowDialog();
        }
    }
}
