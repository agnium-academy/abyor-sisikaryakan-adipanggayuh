using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Supervisor : Staff
    {
        public int _tunjanganPenginapan;
        public int _tunjanganInternet;


        public Supervisor()
        {
            gajiPokok = 10000000;
            tunjanganTransportasi = 1500000;
        }

        public Supervisor(string jabatan)
        {
            this._jabatan = jabatan;
        }

    }
}
