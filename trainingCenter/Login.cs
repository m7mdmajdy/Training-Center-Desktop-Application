using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroSet_UI;
namespace trainingCenter
{
    public partial class Login : MetroSet_UI.Forms.MetroSetForm
    {
        EDPCenterEntities EDPDBContext = new EDPCenterEntities();
        IQueryable<User> Users;
        //Dictionary<string, string> Users;

        public Login()
        {
            InitializeComponent();
            Users = EDPDBContext.Users;
        }

        private void gunaBtnLogin_Click(object sender, EventArgs e)
        {
            //if (gunaTextBoxPassphrase.Text == Users[gunaTextBoxUsername.Text]) MessageBox.Show("Test");
            foreach (var userCredenetials in Users)
            {
                if (gunaTextBoxPassphrase.Text == userCredenetials.Password)
                    if (gunaTextBoxUsername.Text != "" && gunaTextBoxUsername.Text == userCredenetials.Username || gunaTextBoxUsername.Text == "")
                        /*new Teacher().Show(); */
                        MessageBox.Show("success");
                    else MessageBox.Show("user not found");
                else MessageBox.Show("failed to access");
            }
        }
    }
}
