using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using WindowsFormsApplication1.localhost;

namespace WindowsFormsApplication1
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        public string contactId;

        private void button1_Click(object sender, EventArgs e)
        {
          panel1.Controls.Clear();
            try
            {
                if (cboSearchCategory.SelectedItem != null)
                {

                    localhost.ContactArray contactFound = new ContactArray();
                    var webService = new contact();
                    string selectedCriteria = cboSearchCategory.SelectedItem.ToString();
                    switch (selectedCriteria)
                    {
                        case "First Name":
                            contactFound = webService.searchFirstName(txtDataSearch.Text);
                            break;
                        case "Last Name":
                            contactFound = webService.searchLastName(txtDataSearch.Text);

                            break;
                        case "Private Mobile":
                            contactFound = webService.searchPrivateMobile(txtDataSearch.Text);
                            break;
                        case "Street":
                            contactFound = webService.searchStreet(txtDataSearch.Text);

                            break;


                    }



                    if (contactFound.Any != null) // if size of arr >1 means data had been found
                    {


                        //MessageBox.Show(er.searchLastName("Bla").Any[0].GetElementsByTagName("firstName").Item(0).InnerText.ToString());
                        for (int i = 0; i < contactFound.Any.Length; i++)
                        {
                            int base1 = 100*i;
                            //id
                            Label labelID = new Label();
                            string id = contactFound.Any[i].GetElementsByTagName("id").Item(0).InnerText.Trim();
                            labelID.Text = "Id: " + id;
                            contactId = id;

                            labelID.Location = new System.Drawing.Point(15, 20 + (base1));

                            Label labelLastName = new Label();
                            labelLastName.Text = "Last Name: " +
                                                 contactFound.Any[i].GetElementsByTagName("lastName")
                                                     .Item(0)
                                                     .InnerText.Trim();

                            labelLastName.Location = new System.Drawing.Point(15, 50 + (base1));

                            Label labelFirstName = new Label();
                            labelFirstName.Text = "FirstName: " +
                                                  contactFound.Any[i].GetElementsByTagName("firstName")
                                                      .Item(0)
                                                      .InnerText.Trim();

                            labelFirstName.Location = new System.Drawing.Point(15, 80 + (base1));



                            Button btnEdit = new Button();
                            btnEdit.Text = "Edit ";
                            btnEdit.Location = new System.Drawing.Point(150, 20 + (base1));
                            btnEdit.Name = id;
                            btnEdit.Click += new EventHandler(EditBtnClick);
                            Button btnDelete = new Button();
                            btnDelete.Text = "delete ";
                            btnDelete.Location = new System.Drawing.Point(250, 20 + (base1));
                            btnDelete.Name = id;
                            btnDelete.Click += new EventHandler(DeleteBtnClick);


                            //add them to the groupBox
                            panel1.Controls.Add(labelID);
                            panel1.Controls.Add(labelFirstName);
                            panel1.Controls.Add(labelLastName);
                            panel1.Controls.Add(btnEdit);
                            panel1.Controls.Add(btnDelete);


                            //add group box to form

                        }
                    }
                    else
                    {
                        MessageBox.Show("nothing Found");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBtnClick(object sender, EventArgs e)
        {
            try
            {
                Button clicked = (Button) sender;

                DialogResult responseResult = MessageBox.Show("Do you want to delete ?", "Do choose",
                    MessageBoxButtons.YesNo);
                switch (responseResult)
                {
                    case DialogResult.Yes:
                        var er = new contact();
                        MessageBox.Show(er.deleteContactById(clicked.Name));


                        break;
                    case DialogResult.No:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void EditBtnClick(object sender, EventArgs e)
        {
            Form editForm = new EditContact(contactId);
       
            editForm.Show();

        }

    
     
        public static void NewViewAllForm()
        {
            Application.Run(new ViewAllForm());
        }
        public static void NewAddForm()
        {
            Application.Run(new AddContact());
        }

        private void AddContact_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NewAddForm));
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

