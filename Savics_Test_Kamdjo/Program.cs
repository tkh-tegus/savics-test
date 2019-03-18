using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savics_Test_Kamdjo
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<Patient> medical_registre = new List<Patient>();
            medical_registre.Add(new Patient
            {
                FisrtName = "DUPONT",
                LastName = "Jean",
                Sexe = "Male",
                Age = 46,
                City = "Paris",
                Country = "France"
            });
            medical_registre.Add(new Patient
            {
                FisrtName = "TALEB",
                LastName = "Amina",
                Sexe = "Female",
                Age = 12,
                City = "Alger",
                Country = "Algeria"
            });
            medical_registre.Add(new Patient
            {
                FisrtName = "VANVO",
                LastName = "Marc",
                Sexe = "Male",
                Age = 19,
                City = "Brussels",
                Country = "Belgium"
            });
            Application.Run(new Form1(medical_registre));
        }
    }
}
