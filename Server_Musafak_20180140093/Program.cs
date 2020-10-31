using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20180140093;

namespace Server_Musafak_20180140093
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }
    }

    public class server
    {
        public void ON()
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                Console.WriteLine("Server ON");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
        public void OFF()
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Close();
                Console.WriteLine("Server OFF");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
