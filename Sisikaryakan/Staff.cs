using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Staff : Karyawan
    {

        public Staff()
        {
            gajiPokok = 5000000;
            tunjanganTransportasi = 1000000;
        }

        public Staff(string jabatan)
        {
            this._jabatan = jabatan;
        }


    }
}
