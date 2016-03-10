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
    public partial class EditContact : Form
    {
        public string contactId;
        public EditContact(string id)
        {
        
            contactId = id;
            InitializeComponent();
        }

        public EditContact()
        {
           
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
           
            if (contactId != null)
            {

                localhost.ContactArray contactFound = new ContactArray();
                var webService = new contact();
                contactFound = webService.searchId(contactId);
                if (contactFound.Any != null) // if size of arr >1 means data had been found
                {
                    lblId.Text = contactFound.Any[0].GetElementsByTagName("id").Item(0).InnerText.Trim();
                    txtFirstName.Text = contactFound.Any[0].GetElementsByTagName("firstName").Item(0).InnerText.Trim();
                    txtLastName.Text = contactFound.Any[0].GetElementsByTagName("lastName").Item(0).InnerText.Trim();
                    txtGender.Text = contactFound.Any[0].GetElementsByTagName("gender").Item(0).InnerText.Trim();
                    txtNickName.Text = contactFound.Any[0].GetElementsByTagName("nickName").Item(0).InnerText.Trim();
                    txtDateOfBirth.Text =
                        contactFound.Any[0].GetElementsByTagName("dateOfBirth").Item(0).InnerText.Trim();

                    //postal details
                    txtCity.Text = contactFound.Any[0].GetElementsByTagName("city").Item(0).InnerText.Trim();
                    txtStreet.Text = contactFound.Any[0].GetElementsByTagName("street").Item(0).InnerText.Trim();
                    txtPostalCode.Text = contactFound.Any[0].GetElementsByTagName("postalCode").Item(0).InnerText.Trim();
                    txtCountry.Text = contactFound.Any[0].GetElementsByTagName("country").Item(0).InnerText.Trim();

                    //Contact
                    txtOfficeEmail.Text =
                        contactFound.Any[0].GetElementsByTagName("officeEmail").Item(0).InnerText.Trim();
                    txtPrivateEmail.Text =
                        contactFound.Any[0].GetElementsByTagName("privateEmail").Item(0).InnerText.Trim();
                    txtPrivateMobile.Text =
                        contactFound.Any[0].GetElementsByTagName("privateMobile").Item(0).InnerText.Trim();
                    txtOffice.Text = contactFound.Any[0].GetElementsByTagName("office").Item(0).InnerText.Trim();

                }
            }
            else
            {
                MessageBox.Show("something went wrong");
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NewWindow));
                t.Start();
                this.Close();
               
                
               
            }

        }
        public static void NewWindow()
        {
            Application.Run(new searchForm());
        }
        private void btnSave3_Click(object sender, EventArgs e)
        {

            try
            {



                var webService = new contact();
                string serverResponse = webService.editContactById(contactId, txtFirstName.Text, txtLastName.Text,
                    txtNickName.Text, txtGender.Text, Convert.ToDateTime(txtDateOfBirth.Text), txtCity.Text,
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

        private void tnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var webService = new contact();
                string serverResponse = webService.deleteContactById(contactId);
                MessageBox.Show(serverResponse);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       
        

    }
}
