using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Manager : Supervisor
    {
        public int _tunjanganHariRaya;
        public int _tunjanganKesehatan;
        public string _studiBanding;

        public Manager()
        {
            gajiPokok = 15000000;
            tunjanganTransportasi = 2000000;
        }

        public Manager(string jabatan)
        {
            this._jabatan = jabatan;
        }

    }
}
