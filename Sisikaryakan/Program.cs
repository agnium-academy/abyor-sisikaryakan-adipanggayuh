using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Program
    {
        public static void Main()
        {
            Manager tegar = new Manager("Manager Drilling");
            Manager haidar = new Manager("Manager Drilling");
            Manager sani = new Manager("Manager Refinery");
            Manager adi = new Manager("Manager General Affairs");

            Supervisor iqbal = new Supervisor("Supervisor Drilling Riau");
            Supervisor ucu = new Supervisor("Supervisor Drilling Luwuk");
            Supervisor dhani = new Supervisor("Supervisor Refinery Balikpapan");

            Staff dwi = new Staff("Staff Drilling Riau 1");
            Staff trio = new Staff("Straff Drilling Riau 2");
            Staff nuragus = new Staff("Staff Drilling Luwuk");
            Staff sofi = new Staff("Staff Refinery Balikpapan");
            Staff seta = new Staff("Staff General Affairs");

            tegar._nama = "Tegar";
            haidar._nama = "Haidar";
            sani._nama = "Sani";
            adi._nama = "Adi";
            iqbal._nama = "Iqbal";
            ucu._nama = "Ucu";
            dhani._nama = "Dhani";
            dwi._nama = "Dwi";
            trio._nama = "Trio";
            nuragus._nama = "Nuragus";
            sofi._nama = "Sofi";
            seta._nama = "Seta";


        }
    }
}
