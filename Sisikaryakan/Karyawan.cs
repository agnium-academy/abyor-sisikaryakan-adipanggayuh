using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    abstract class Karyawan
    {
        public string _nama;
        public string _alamat;
        public string _agama;
        public string _status;
        public string _jabatan;
        public string _tanggalDiterimaKerja;
        public string _lokasiPenugasan;
        public int _gajiPokok;
        public int _tunjanganTransportasi;


        public int gajiPokok
        {
            get { return _gajiPokok; }
            set { _gajiPokok = value; }
        }

        public int tunjanganTransportasi
        {
            get { return _tunjanganTransportasi; }
            set { _tunjanganTransportasi = value; }
        }



    }
}
