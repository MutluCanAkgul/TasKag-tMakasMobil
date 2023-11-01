using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TasKagıtMakasMobil
{
    public partial class MainPage : ContentPage
    {
        int kulllaniciskor=0,bilgisayarskor=0, sayi, tur = 5;
        String KullaniciSecim, BilgisayarSecim;
        String[] Bilgisayar = {"Taş","Kağıt","Makas"};
        public MainPage()
        {
            InitializeComponent();
            Random rnd = new Random();
            sayi = rnd.Next(0,Bilgisayar.Length);
            BilgisayarSecim = Bilgisayar[sayi];
        }
        public void Tas(object sender,EventArgs e)
        {
            KullaniciSecim = "Taş";
            Control();
          
          
        }
        public void Kagıt(object sender,EventArgs e)
        {
            KullaniciSecim = "Kağıt";
            Control();
            
        }
        public void Makas(object sender,EventArgs e) 
        {
            KullaniciSecim = "Makas";
            Control();
            
        }
        public void Control()
        {
            // Kullanıcının Kazandığı Senaryo
            if(KullaniciSecim == "Taş" && BilgisayarSecim == "Makas")
            {
                Durum.Text = "Kullanıcı Kazandı";
                Durum.TextColor = Color.Green;
                SecimLabel.Text = BilgisayarSecim;
                kulllaniciskor++;
            }
            else if (KullaniciSecim == "Kağıt" && BilgisayarSecim == "Taş")
            {
                Durum.Text = "Kullanıcı Kazandı";
                Durum.TextColor = Color.Green;
                SecimLabel.Text = BilgisayarSecim;
                kulllaniciskor++;
            }
            else if (KullaniciSecim == "Makas" && BilgisayarSecim == "Kağıt")
            {
                Durum.Text = "Kullanıcı Kazandı";
                Durum.TextColor = Color.Green;
                SecimLabel.Text = BilgisayarSecim;
                kulllaniciskor++;
            }
            // Bilgisayarın Kazandığı Senaryo
            else if (KullaniciSecim == "Makas" && BilgisayarSecim == "Taş")
            {
                Durum.Text = "Bilgisayar Kazandı";
                Durum.TextColor = Color.Red;
                SecimLabel.Text = BilgisayarSecim;
                bilgisayarskor++;
            }
            else if (KullaniciSecim == "Taş" && BilgisayarSecim == "Kağıt")
            {
                Durum.Text = "Bilgisayar Kazandı";
                Durum.TextColor = Color.Red;
                SecimLabel.Text = BilgisayarSecim;
                bilgisayarskor++;
            }
            else if (KullaniciSecim == "Kağıt" && BilgisayarSecim == "Makas")
            {
                Durum.Text = "Bilgisayar Kazandı";
                Durum.TextColor = Color.Red;
                SecimLabel.Text = BilgisayarSecim;
                bilgisayarskor++;
            }
            else
            {
                Durum.Text = "Berabere";
                SecimLabel.Text = BilgisayarSecim;
            }
            Skor.Text = "Kullanıcı = " + kulllaniciskor + " || " + "Bilgisayar = " + bilgisayarskor;

        }
        public void RestartGame(object sender,EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(0, Bilgisayar.Length);
            BilgisayarSecim = Bilgisayar[sayi];
            Durum.Text = String.Empty;
            SecimLabel.Text = String.Empty;
           
        }

     
    }
}
