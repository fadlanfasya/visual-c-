using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokGudang
{
    public class kardus
    {
        private string nama;
        private int berat;
        private int isi;
        private DateTime kadaluarsa;
        private int id;

        public string ID { get => nama; }
        public string Nama { get => nama; set => nama = value; }
        public int Berat { get => berat; set => berat = value; }
        public int Isi { get => isi; set => isi = value; }
        public DateTime Kadaluarsa { get => kadaluarsa; set => kadaluarsa = value; }

        public void EditKardus()
        {
            throw new System.NotImplementedException();
        }

        public void CheckKadaluarasa()
        {
            throw new System.NotImplementedException();
        }

        public void IsiKardus(int getId, string getNama, int getBerat, int getIsi, DateTime getKadaluarsa)
        {
            this.id = getId;
            this.nama = getNama;
            this.isi = getIsi;
            this.Kadaluarsa = getKadaluarsa;
        }
    }
}