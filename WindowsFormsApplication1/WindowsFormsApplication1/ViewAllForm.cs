using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.localhost;

namespace WindowsFormsApplication1
{
    public partial class ViewAllForm : Form
    {
        public ViewAllForm()
        {
            InitializeComponent();
           
        }
        public string contactId;
        private void ViewAllForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
             localhost.ContactArray contactFound=new ContactArray();
                var webService = new contact();
            contactFound = webService.viewAllContact("");
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
                        labelLastName.AutoSize = true; //make size of box to autoSize so as long name could be displayed
                        labelLastName.Text = "Last Name: " +
                                             contactFound.Any[i].GetElementsByTagName("lastName")
                                                 .Item(0)
                                                 .InnerText.Trim();

                        labelLastName.Location = new System.Drawing.Point(15, 50 + (base1));

                        Label labelFirstName = new Label();
                        labelFirstName.AutoSize = true;//make size of box to autoSize so as long name could be displayed
                        labelFirstName.Text = "FirstName: " +
                                              contactFound.Any[i].GetElementsByTagName("firstName")
                                                  .Item(0)
                                                  .InnerText.Trim();

                        labelFirstName.Location = new System.Drawing.Point(15, 80 + (base1));



                        Button btnEdit = new Button();
                        btnEdit.Text = "Edit/ More Det.";
                        btnEdit.AutoSize = true;
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
                { //xml empty or does not exist
                    DialogResult responseResult = MessageBox.Show("xml empty do you wish to add contact ?", "Do choose",
              MessageBoxButtons.YesNo);
                    switch (responseResult)
                    {
              case DialogResult.Yes:
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NewAddForm));
                    t.Start();
                   this.Close();
                     break;
                        case DialogResult.No:
                            this.Close();
                           Application.Exit();
                            break;
                    }
                }
            }
          private void DeleteBtnClick(object sender, EventArgs e)
        {
            Button btnClicked = (Button) sender;
          
            DialogResult responseResult = MessageBox.Show("Do you want to delete ?", "Do choose",
                MessageBoxButtons.YesNo);
            switch (responseResult)
            {
                case DialogResult.Yes:
                    var er = new contact();
                   MessageBox.Show(er.deleteContactById(btnClicked.Name));


                    break;
                case DialogResult.No:
                    break;
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
          private void SearchForm_Click(object sender, EventArgs e)
          {
              System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NewSearchForm));
              t.Start();
              this.Close();


          }
          private void AddContact_Click(object sender, EventArgs e)
          {
              System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NewAddForm));
              t.Start();
              this.Close();


          }

        private void EditBtnClick(object sender, EventArgs e)
        {
            Button btnClick = (Button) sender;
            Form editForm = new EditContact(btnClick.Name);
       
            editForm.Show();

        }

       

     
     

       
        }
    }

