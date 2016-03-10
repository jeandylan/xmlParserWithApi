using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.localhost;

namespace WindowsFormsApplication1
{
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void AddContact_Load(object sender, EventArgs e)
        {

        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            try
            {
                
                var webService = new contact();

                string serverResponse = webService.insertContact(txtFirstName.Text, txtLastName.Text,
                    txtNickName.Text, cboGender.Text, Convert.ToDateTime(txtDateOfBirth.Text), txtCity.Text,
                    txtStreet.Text, txtCountry.Text
                    , txtPostalCode.Text, txtOfficeEmail.Text, txtPrivateEmail.Text, txtPrivateMobile.Text,
                    txtOffice.Text);
                MessageBox.Show(serverResponse);
                if (serverResponse.Equals("save and Modify"))
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }
        public static void NewSearchForm()
        {
            Application.Run(new searchForm());
        }
        public static void NewAddForm()
        {
            Application.Run(new AddContact());
        }
        public static void NewViewAllForm()
        {
            Application.Run(new ViewAllForm());
        }

        private void AddContact_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NewAddForm));
            t.Start();
            this.Close();


        }
        private void SearchForm_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NewSearchForm));
            t.Start();
            this.Close();


        }
        private void ViewAllContact_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NewViewAllForm));
            t.Start();
            this.Close();


        }

      

    }
}
