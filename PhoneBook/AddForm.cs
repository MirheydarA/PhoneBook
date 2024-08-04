using MetroFramework.Forms;
using PhoneBook.Models;
using PhoneBookl;
using System.Data;
using System.Data.SqlClient;

namespace PhoneBook
{
    public partial class AddForm : MetroForm
    {
        private readonly AppDbContext _context;
        public AddForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        void Clear(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox txt)
                {
                    txt.Clear();
                }
                else if (item is NumericUpDown nmr)
                {
                    nmr.Value = nmr.Minimum;
                }
                else if (item is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var person = new Person
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                Mail = txtMail.Text,
            };

            _context.People.Add(person);
            int result = _context.SaveChanges();


            MessageBox.Show(
                  text: result > 0 ? "Kayıt Eklendi" : "İşlem Hatası",
                  caption: "Kayıt Eklleme Bildirimi",
                  buttons: MessageBoxButtons.OK,
                  icon: result > 0 ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error
            );

            Clear(grbSavePerson);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainFormInstance.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
