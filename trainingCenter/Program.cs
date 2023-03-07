using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trainingCenter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());

            //Application.Run(new studentPayment(new Student { St_ID = 1, St_Name = "mouaz & kareem & fatma" },
            //    new Student_Group {G_ID = 1,St_Balance=50 }));
        }
    }
}
