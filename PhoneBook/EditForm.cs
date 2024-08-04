using MetroFramework.Forms;
using PhoneBookl;
using System.Data;
using System.Data.SqlClient;

namespace PhoneBook
{
    public partial class EditForm : MetroForm
    {

        private readonly AppDbContext _context;
        private int _id;
        public EditForm(int Id)
        {
            _id = Id;
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            var person = _context.People.FirstOrDefault(p => p.Id == _id);
            if (person != null)
            {
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtPhone.Text = person.Phone;
                txtMail.Text = person.Mail;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var person = _context.People.FirstOrDefault(p => p.Id == _id);
            if (person != null)
            {
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.Phone = txtPhone.Text;
                person.Mail = txtMail.Text;

                _context.SaveChanges();
                MessageBox.Show("Person updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Person not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
            }
        }
    }
}
