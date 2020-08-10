using System;
using System.Collections.Generic;
using System.Text;

namespace Enkapsulasi_XIRPL1_30_Wendy
{
    class User
    {
        public string nama;
        public int NomorID;
        private double NomorHp;
        protected string RiwayatPasien;
        internal string Bangsal;

      
        
       
        // Abstraksi
        public double getNumber()
        {
            return NomorHp;
        }
        public double setNumber(double newNumber)
        {
            this.NomorHp = newNumber;
            return NomorHp;
        }
        // Class property
        public double NoHP
        {
            get { return this.NomorHp; }
            set { this.NomorHp += value; }
        }
        
    }
}
