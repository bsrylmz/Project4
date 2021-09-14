using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Kıyafetim
{
    class Siparis
    {
        private decimal _markaCarpani;
        private decimal _turfiyat;


        public string Beden { get; set; }

        private string _marka;

        public string Marka
        {
            get
            {
                return _marka;
            }
            set
            {
                switch (value)
                {
                    case "LWC":
                        _markaCarpani = 1.25m;
                        break;
                    case "Koton":
                        _markaCarpani = 1.45m;
                        break;
                    case "Zara":
                        _markaCarpani = 2.25m;
                        break;
                    case "Mavi":
                        _markaCarpani = 2m;
                        break;
                    case "Nike":
                        _markaCarpani = 2m;
                        break;
                    case "Adidas":
                        _markaCarpani = 2m;
                        break;
                    case "Sarar":
                        _markaCarpani = 3m;
                        break;
                    case "Levis":
                        _markaCarpani = 1.75m;
                        break;
                    case "Puma":
                        _markaCarpani = 1.50m;
                        break;
                    case "Ramsey":
                        _markaCarpani = 2.75m;
                        break;
                    default:
                        break;
                }
                _marka = value;
            }
        }
        private string _tur;

        public string Tur
        {
            get
            {
                return _tur;
            }
            set
            {
                switch (value)
                {
                    case "Pantolon":
                        _turfiyat = 20;
                        break;
                    case "Etek":
                        _turfiyat = 29.99m;
                        break;
                    case "Gömlek":
                        _turfiyat = 25;
                        break;
                    case "Elbise":
                        _turfiyat = 50;
                        break;
                    case "Takım Elbise":
                        _turfiyat = 125;
                        break;
                    case "Ayakkabı":
                        _turfiyat = 60;
                        break;
                    case "Kazak":
                        _turfiyat = 30;
                        break;
                    case "T-Shirt":
                        _turfiyat = 10;
                        break;

                    default:
                        break;
                }
                _tur = value;
            }
        }
        public string Sezon { get; set; }
        public string Renkler { get; set; }
        public int Adet { get; set; }

        public decimal AraToplam { get { return (_turfiyat * _markaCarpani) * Adet; } }

        public override string ToString()
        {
            return string.Format("Beden:{0} Marka:{1} Tur:{2} Sezon:{3} Renkler:{4} Adet:{5} Tutar:{6:C2}", Beden, Marka, Tur, Sezon, Renkler, Adet, AraToplam);
        }
      }
    }
