using System;
using System.Collections.Generic;
using System.Text;

namespace Enkapsulasi_XIRPL1_30_Wendy
{
    class Dokter : User
    {
        private double NomorHp;
        public string BiodataDokter()
        {
                
                base.RiwayatPasien = "-";
                return RiwayatPasien;
        }
        public double NoHP
        {
            get { return this.NomorHp; }
            set { this.NomorHp += value; }
        }
    }
}
