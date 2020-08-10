using System;
using System.Collections.Generic;
using System.Text;

namespace Enkapsulasi_XIRPL1_30_Wendy
{
    class Pasien : User
    {
        private double NomorHp;
        public string BiodataPasien()
        {
            base.RiwayatPasien = "Magh";
            return RiwayatPasien;
        }
            public double NoHP
        {
            get { return this.NomorHp; }
            set { this.NomorHp += value; }
        }
    }
    
}
