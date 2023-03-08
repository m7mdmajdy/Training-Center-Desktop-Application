using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trainingCenter.BL;

namespace trainingCenter
{
    public partial class Dashboard : MetroSetForm
    {
        

        EDPCenterEntities eDPCenterEntities;
        public Dashboard()
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(13,71, 161);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Size = new Size(this.Width,this.Height);
        }
    }
}
