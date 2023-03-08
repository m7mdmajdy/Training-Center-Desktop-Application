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
            EDPCenterEntities context = new EDPCenterEntities();
            Student student = context.Students.Where(s => s.St_ID == 2).FirstOrDefault();
            Application.Run(new addRoom());

        }
    }
}
