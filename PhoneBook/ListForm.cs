using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;
using PhoneBookl;
using System.Data;
using System.Data.SqlClient;
//Ef core version
namespace PhoneBook
{
    public partial class ListForm : MetroForm
    {
        private readonly AppDbContext _context;
        public ListForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        #region Load Function
        void Refresh()
        {
            lstPeople.Items.Clear();


            List<Person> people = _context.People.ToList();
            foreach (var person in people)
            {
                ListViewItem item = new ListViewItem(person.Id.ToString());
                item.SubItems.Add(person.FirstName);
                item.SubItems.Add(person.LastName);
                item.SubItems.Add(person.Phone);
                item.SubItems.Add(person.Mail);

                lstPeople.Items.Add(item);
            }

        }
        #endregion

        private void ListForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void cmsRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }


        private void cmsSil_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to delete.",
                    "Delete Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete the selected record?",
                "Delete Item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);


            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int selectedId = Convert.ToInt32(lstPeople.SelectedItems[0].Text);

            var person = _context.People.FirstOrDefault(p => p.Id == selectedId);

            if (person is not null)
            {
                _context.People.Remove(person);
                int result = _context.SaveChanges();
                lstPeople.SelectedItems[0].Remove();


                MessageBox.Show(
                    text: result > 0 ? "Kayıt Silindi" : "İşlem Hatası",
                    caption: "Kayıt Silme Bildirimi",
                    buttons: MessageBoxButtons.OK,
                    icon: result > 0 ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error
                );
            }

        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainFormInstance.Show();
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to update.",
                    "Update Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            int selectedId = Convert.ToInt32(lstPeople.SelectedItems[0].Text);
            EditForm frm = new(selectedId);
            frm.ShowDialog();
        }
    }
}
