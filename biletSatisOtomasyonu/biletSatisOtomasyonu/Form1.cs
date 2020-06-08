using System; //Temel c# sınıflarını kullanabilmek için gerekli kütüphane
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biletSatisOtomasyonu  //Projenin adı
{
    public partial class Form1 : Form  //formun adı ve public alanı.
    {
        public Form1()     //Yaptığımız formun ana alanı buraya kaydedilen değişkenler gün sonunda geri döndürmeyi ve hesaplamayı sağamak için tutulur.
        {
            InitializeComponent();
        }
        int seans1Kisi = 0; //Public olarak "seans1Kisi" değişkeni oluşturduk ve "0" atadık.
        int seans1Ucret = 0;//Public olarak "seans1Ucret" değişkeni oluşturduk ve "0" atadık.
        int seans2Kisi = 0;int seans2Ucret = 0;
        int seans3Kisi = 0;int seans3Ucret = 0;
        int seans4Kisi = 0;int seans4Ucret = 0;
        int seans5Kisi = 0;int seans5Ucret = 0;
        int seans6Kisi = 0;int seans6Ucret = 0;
        int seans7Kisi = 0;int seans7Ucret = 0;
        int seans8Kisi = 0;int seans8Ucret = 0;
        int menu1Sayi = 0; int menu1Fiyat = 0; int menu2Sayi = 0; int menu2Fiyat = 0; int menu3Sayi = 0; int menu3Fiyat = 0; int menu4Sayi = 0; int menu4Fiyat = 0;
        int kolaSayi = 0;int kolaFiyat = 0;int fantaSayi = 0;int fantaFiyat = 0;int spriteSayi = 0;int spriteFiyat = 0;int ayranSayi = 0;int ayranFiyat = 0;int suSayi = 0;int suFiyat = 0;
        int misirKucukSayi = 0;int misirKucukFiyat = 0;int misirOrtaSayi = 0;int misirOrtaFiyat = 0;int misirBuyukSayi = 0;int misirBuyukFiyat = 0;int cipsSayi = 0;int cipsFiyat = 0;int kekSayi = 0; int kekFiyat = 0;
        private int toplamücret; int biletFiyatToplam; int menuFiyatToplam; int icecekFiyatToplam; int toplamFiyat; int yiyecekFiyatToplam;

        private void seans1AzaltButton_Click(object sender, EventArgs e)
        {
            seans1Kisi--; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 azaltır.
            seans1Ucret = seans1Ucret -16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 azaltır.
            seans1KisiSayisiTextBox.Text = seans1Kisi.ToString();//azaltılan kişi sayısını textboxa yazdırıyor.
            if (seans1Kisi == 0)
            {
                seans1AzaltButton.Enabled = false; //eğer kişi sayısı 0 ise azaltma butonu pasif olacak
            }        
            if(seans1Kisi <= 52)
            {
                seans1ArttirButton.Enabled = true;//Eğer azaltma butonuna tıkladığımızda kişi sayısı 52 ye eşit veya küçükse arttırma butonunu aktif et.
            }
                
        }

        private void seans1ArttirButton_Click(object sender, EventArgs e)
        {
            seans1Kisi++; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 arttırır.
            seans1Ucret = seans1Ucret +16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 arttırır.
            seans1KisiSayisiTextBox.Text = seans1Kisi.ToString();//arttırılan kişi sayısını textboxa yazdırıyor.
            
            if (seans1Kisi > 0)
            {
                seans1AzaltButton.Enabled = true; //Eğer kişi sayısı 0 ın üzerinde olursa arttırma butonuna tıkladığımızda, azaltma butonunu etkin yap
            }
            if (seans1Kisi == 52)
            {
                seans1ArttirButton.Enabled = false; //Eğer kişi sayısı 52 olursa salon en fazla 52 kişikik olduğu için arttırma butonunu iptal et.
            }
                

        }

        private void seans2AzaltButton_Click(object sender, EventArgs e)
        {
            seans2Kisi--; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 azaltır.
            seans2Ucret = seans2Ucret - 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 azaltır.
            seans2KisiSayisiTextBox.Text = seans2Kisi.ToString();//azaltılan kişi sayısını textboxa yazdırıyor.

            if (seans2Kisi == 0)
            {
                seans2AzaltButton.Enabled = false; //eğer kişi sayısı 0 ise azaltma butonu pasif olacak
            }
            if (seans2Kisi <= 52)
            {
                seans2ArttirButton.Enabled = true;//Eğer azaltma butonuna tıkladığımızda kişi sayısı 52 ye eşit veya küçükse arttırma butonunu aktif et.
            }
        }

        private void seans2ArttirButton_Click(object sender, EventArgs e)
        {
            seans2Kisi++; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 arttırır.
            seans2Ucret = seans2Ucret + 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 arttırır.
            seans2KisiSayisiTextBox.Text = seans2Kisi.ToString();//arttırılan kişi sayısını textboxa yazdırıyor.

            if (seans2Kisi > 0)
            {
                seans2AzaltButton.Enabled = true; //Eğer kişi sayısı 0 ın üzerinde olursa arttırma butonuna tıkladığımızda, azaltma butonunu etkin yap
            }
            if (seans2Kisi == 52)
            {
                seans2ArttirButton.Enabled = false; //Eğer kişi sayısı 52 olursa arttırma butonunu iptal et.
            }

        }

        private void seans3AzaltButton_Click(object sender, EventArgs e)
        {
            seans3Kisi--; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 azaltır.
            seans3Ucret = seans3Ucret - 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 azaltır.
            seans3KisiSayisiTextBox.Text = seans3Kisi.ToString();//azaltılan kişi sayısını textboxa yazdırıyor.

            if (seans3Kisi == 0)
            {
                seans3AzaltButton.Enabled = false; //eğer kişi sayısı 0 ise azaltma butonu pasif olacak
            }
            if (seans3Kisi <= 52)
            {
                seans3ArttirButton.Enabled = true;//Eğer azaltma butonuna tıkladığımızda kişi sayısı 52 ye eşit veya küçükse arttırma butonunu aktif et.
            }
        }

        private void seans3ArttirButton_Click(object sender, EventArgs e)
        {
            seans3Kisi++; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 arttırır.
            seans3Ucret = seans3Ucret + 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 arttırır.
            seans3KisiSayisiTextBox.Text = seans3Kisi.ToString();//arttırılan kişi sayısını textboxa yazdırıyor.
            if (seans3Kisi == 3)//seans 3 için kamapanya kapsamında if oluşturdum. Seans3 ün kişilerinin tuttuğumuz değişken 3 değerini aldığında menü1 otomatik olarak 1 artıyor
            {
                menu1Sayi++;
                menu1TextBox.Text = menu1Sayi.ToString();
            }
            if (seans3Kisi > 0)
            {
                seans3AzaltButton.Enabled = true; //Eğer kişi sayısı 0 ın üzerinde olursa arttırma butonuna tıkladığımızda, azaltma butonunu etkin yap
            }
            if (seans3Kisi == 52)
            {
                seans3ArttirButton.Enabled = false; //Eğer kişi sayısı 52 olursa arttırma butonunu iptal et.
                {

                
                }
            }
        }

        private void seans1Label_Click(object sender, EventArgs e)
        {

        }

        private void seans4AzaltButton_Click(object sender, EventArgs e)
        {
            seans4Kisi--; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 azaltır.
            seans4Ucret = seans4Ucret - 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 azaltır.
            seans4KisiSayisiTextBox.Text = seans4Kisi.ToString();//azaltılan kişi sayısını textboxa yazdırıyor.

            if (seans4Kisi == 0)
            {
                seans4AzaltButton.Enabled = false; //eğer kişi sayısı 0 ise azaltma butonu pasif olacak
            }
            if (seans4Kisi <= 52)
            {
                seans4ArttirButton.Enabled = true;//Eğer azaltma butonuna tıkladığımızda kişi sayısı 52 ye eşit veya küçükse arttırma butonunu aktif et.
            }
        }

        private void seans4ArttirButton_Click(object sender, EventArgs e)
        {
            seans4Kisi++; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 arttırır.
            seans4Ucret = seans4Ucret + 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 arttırır.
            seans4KisiSayisiTextBox.Text = seans4Kisi.ToString();//arttırılan kişi sayısını textboxa yazdırıyor.

            if (seans4Kisi > 0)
            {
                seans4AzaltButton.Enabled = true; //Eğer kişi sayısı 0 ın üzerinde olursa arttırma butonuna tıkladığımızda, azaltma butonunu etkin yap
            }
            if (seans4Kisi == 52)
            {
                seans4ArttirButton.Enabled = false; //Eğer kişi sayısı 52 olursa arttırma butonunu iptal et.
            }    
        }

        private void seans5AzaltButton_Click(object sender, EventArgs e)
        {
            seans5Kisi--; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 azaltır.
            seans5Ucret = seans5Ucret - 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 azaltır.
            seans5KisiSayisiTextBox.Text = seans5Kisi.ToString();//azaltılan kişi sayısını textboxa yazdırıyor.

            if (seans5Kisi == 0)
            {
                seans5AzaltButton.Enabled = false; //eğer kişi sayısı 0 ise azaltma butonu pasif olacak
            }
            if (seans5Kisi <= 52)
            {
                seans5ArttirButton.Enabled = true;//Eğer azaltma butonuna tıkladığımızda kişi sayısı 52 ye eşit veya küçükse arttırma butonunu aktif et.
            }
        }

        private void seans5ArttirButton_Click(object sender, EventArgs e)
        {
            seans5Kisi++; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 arttırır.
            seans5Ucret = seans5Ucret + 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 arttırır.
            seans5KisiSayisiTextBox.Text = seans5Kisi.ToString();//arttırılan kişi sayısını textboxa yazdırıyor.

            if (seans5Kisi > 0)
            {
                seans5AzaltButton.Enabled = true; //Eğer kişi sayısı 0 ın üzerinde olursa arttırma butonuna tıkladığımızda, azaltma butonunu etkin yap
            }
            if (seans5Kisi == 52)
            {
                seans5ArttirButton.Enabled = false; //Eğer kişi sayısı 52 olursa arttırma butonunu iptal et.
            }
        }

        private void seans6AzaltButton_Click(object sender, EventArgs e)
        {
            seans6Kisi--; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 azaltır.
            seans6Ucret = seans6Ucret - 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 azaltır.
            seans6KisiSayisiTextBox.Text = seans6Kisi.ToString();//azaltılan kişi sayısını textboxa yazdırıyor.

            if (seans6Kisi == 0)
            {
                seans6AzaltButton.Enabled = false; //eğer kişi sayısı 0 ise azaltma butonu pasif olacak
            }
            if (seans6Kisi <= 52)
            {
                seans6ArttirButton.Enabled = true;//Eğer azaltma butonuna tıkladığımızda kişi sayısı 52 ye eşit veya küçükse arttırma butonunu aktif et.
            }
        }

        private void seans6ArttirButton_Click(object sender, EventArgs e)
        {

            seans6Kisi++; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 arttırır.
            seans6Ucret = seans6Ucret + 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 arttırır.
            seans6KisiSayisiTextBox.Text = seans6Kisi.ToString();//arttırılan kişi sayısını textboxa yazdırıyor.
            if (seans6Kisi == 6)//Kampanya kapsamında 6 kişiye ulaşan seans6 kişilerini tuttuğumuz değişken otomatik olarak menü 3 ün sayısını 1 arttırıyor.
            {
                menu3Sayi++;
                menu3TextBox.Text = menu3Sayi.ToString();
            }
            if (seans6Kisi > 0)
            {
                seans6AzaltButton.Enabled = true; //Eğer kişi sayısı 0 ın üzerinde olursa arttırma butonuna tıkladığımızda, azaltma butonunu etkin yap
            }
            if (seans6Kisi == 52)
            {
                seans6ArttirButton.Enabled = false; //Eğer kişi sayısı 52 olursa arttırma butonunu iptal et.
            }
        }

        private void seans7AzaltButton_Click(object sender, EventArgs e)
        {
            seans7Kisi--; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 azaltır.
            seans7Ucret = seans7Ucret - 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 azaltır.
            seans7KisiSayisiTextBox.Text = seans7Kisi.ToString();//azaltılan kişi sayısını textboxa yazdırıyor.

            if (seans7Kisi == 0)
            {
                seans7AzaltButton.Enabled = false; //eğer kişi sayısı 0 ise azaltma butonu pasif olacak
            }
            if (seans7Kisi <= 52)
            {
                seans7ArttirButton.Enabled = true;//Eğer azaltma butonuna tıkladığımızda kişi sayısı 52 ye eşit veya küçükse arttırma butonunu aktif et.
            }
        }

        private void seans7ArttirButton_Click(object sender, EventArgs e)
        {
            seans7Kisi++; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 arttırır.
            seans7Ucret = seans7Ucret + 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 arttırır.
            seans7KisiSayisiTextBox.Text = seans7Kisi.ToString();//arttırılan kişi sayısını textboxa yazdırıyor.

            if (seans7Kisi > 0)
            {
                seans7AzaltButton.Enabled = true; //Eğer kişi sayısı 0 ın üzerinde olursa arttırma butonuna tıkladığımızda, azaltma butonunu etkin yap
            }
            if (seans7Kisi == 52)
            {
                seans7ArttirButton.Enabled = false; //Eğer kişi sayısı 52 olursa arttırma butonunu iptal et.
            }
        }

        private void seans8AzaltButton_Click(object sender, EventArgs e)
        {
            seans8Kisi--; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 azaltır.
            seans8Ucret = seans8Ucret - 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 azaltır.
            seans8KisiSayisiTextBox.Text = seans8Kisi.ToString();//azaltılan kişi sayısını textboxa yazdırıyor.

            if (seans8Kisi == 0)
            {
                seans8AzaltButton.Enabled = false; //eğer kişi sayısı 0 ise azaltma butonu pasif olacak
            }
            if (seans8Kisi <= 52)
            {
                seans8ArttirButton.Enabled = true;//Eğer azaltma butonuna tıkladığımızda kişi sayısı 52 ye eşit veya küçükse arttırma butonunu aktif et.
            }
        }

        private void seans8ArttirButton_Click(object sender, EventArgs e)
        {
            seans8Kisi++; //butona tıklandığından daha önce public üzerinde oluşturduğumuz kişi değişkenini 1 arttırır.
            seans8Ucret = seans8Ucret + 16; //butona tıklandığından daha önce public üzerinde oluşturduğumuz ucret değişkenini 16 arttırır.
            seans8KisiSayisiTextBox.Text = seans8Kisi.ToString();//arttırılan kişi sayısını textboxa yazdırıyor.
            if(seans8Kisi==2)//8. seansın kampanyası için oluşturulan if komutu.
            {
                ayranSayi = 2;
                ayranTextBox.Text = ayranSayi.ToString();
                cipsSayi++;
                cipsTextBox.Text = cipsSayi.ToString();
            }
            if (seans8Kisi > 0)
            {
                seans8AzaltButton.Enabled = true; //Eğer kişi sayısı 0 ın üzerinde olursa arttırma butonuna tıkladığımızda, azaltma butonunu etkin yap
            }
            if (seans8Kisi == 52)
            {
                seans8ArttirButton.Enabled = false; //Eğer kişi sayısı 52 olursa arttırma butonunu iptal et.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu1Sayi++;//arttırma butonuna tıklandığında menünün sayısı 1 artacaktık.
            menu1Fiyat = menu1Fiyat + 26;//Her arttırıldığında menünün fiyatı da ne kadarsa o kadar sayı değişkene kaydedilir.
            menu1TextBox.Text = menu1Sayi.ToString();//menüden kaç adet alındığını yanındaki text boxa yazar
            if (menu1Sayi > 0)
            {
                menu1AzaltButton.Enabled = true; //Eğer arttırma butonuna tıkladığımızda menu sayısı 0 ın üzerine çıkarsa, azaltma butonunu etkin yap
            }
        }

        private void menu1AzaltButton_Click(object sender, EventArgs e)
        {
            menu1Sayi--;//azaltma butonuna tıklandığında menünün sayısı 1 azalacaktık.
            menu1Fiyat = menu1Fiyat - 26;//Her arttırıldığında menünün fiyatı da ne kadarsa o kadar sayı değişkenden azaltılır.
            menu1TextBox.Text = menu1Sayi.ToString();//menüden kaç adet alındığını yanındaki text boxa yazar
            if (menu1Sayi == 0)
            {
                menu1AzaltButton.Enabled = false; //eğer menu sayısı 0 ise azaltma butonu pasif olacak

            }
        }

        private void tutarButton_Click(object sender, EventArgs e)
        {
            int biletFiyatToplam = seans1Ucret + seans2Ucret + seans3Ucret + seans4Ucret + seans5Ucret + seans6Ucret + seans7Ucret + seans8Ucret;
            int menuFiyatToplam = menu1Fiyat + menu2Fiyat + menu3Fiyat + menu4Fiyat;
            int icecekFiyatToplam = kolaFiyat + fantaFiyat + spriteFiyat + ayranFiyat + suFiyat;
            int yiyecekFiyatToplam = misirKucukFiyat + misirOrtaFiyat + misirBuyukFiyat + cipsFiyat + kekFiyat;
            int toplamFiyat = biletFiyatToplam + menuFiyatToplam + icecekFiyatToplam + yiyecekFiyatToplam;
            biletFiyatToplamLabel.Text ="Bilet Fiyatı: "+ biletFiyatToplam.ToString();
            menuFiyatToplamLabel.Text = "Menu Fiyatı: "+menuFiyatToplam.ToString();
            icecekFiyatToplamLabel.Text = "İcecek Fiyatı: "+icecekFiyatToplam.ToString();
            yiyecekFiyatToplamLabel.Text = "Yiyecek Fiyatı: "+yiyecekFiyatToplam.ToString();
            toplamFiyatLabel.Text = "Toplam Tutar: " + toplamFiyat.ToString();
            iyiSeyirlerTextBox.Text = "İyi Seyirler";
        }

        private void sifirlaButton_Click(object sender, EventArgs e)
        {
            seans1Kisi = 0;seans2Kisi = 0; seans3Kisi = 0; seans4Kisi = 0; seans5Kisi = 0; seans6Kisi = 0; seans7Kisi = 0; seans8Kisi = 0;
            biletFiyatToplam = 0; menuFiyatToplam = 0; icecekFiyatToplam = 0; yiyecekFiyatToplam = 0; toplamFiyat = 0;
            menu1Fiyat = 0; menu2Fiyat = 0; menu3Fiyat = 0; menu4Fiyat = 0;menu1Sayi = 0;menu2Sayi = 0;menu3Sayi = 0;menu4Sayi = 0;
            seans1Ucret = 0; seans2Ucret = 0; seans3Ucret = 0; seans4Ucret = 0; seans5Ucret = 0; seans6Ucret = 0; seans7Ucret = 0; seans8Ucret = 0;
            kolaFiyat = 0; fantaFiyat = 0; spriteFiyat = 0; ayranFiyat = 0; suFiyat = 0;kolaSayi = 0;fantaSayi = 0;spriteSayi = 0;ayranSayi = 0;suSayi = 0;
            misirKucukFiyat = 0; misirBuyukFiyat = 0; misirOrtaFiyat = 0; cipsFiyat = 0; kekFiyat = 0;misirKucukSayi = 0;misirOrtaSayi = 0;misirBuyukSayi = 0;cipsSayi = 0;kekSayi = 0;
            seans1KisiSayisiTextBox.Text = "0"; seans2KisiSayisiTextBox.Text = "0"; seans3KisiSayisiTextBox.Text = "0"; seans4KisiSayisiTextBox.Text = "0"; seans5KisiSayisiTextBox.Text = "0"; seans6KisiSayisiTextBox.Text = "0"; seans7KisiSayisiTextBox.Text = "0"; seans8KisiSayisiTextBox.Text = "0";
            menu1TextBox.Text = "0"; menu2TextBox.Text = "0"; menu3TextBox.Text = "0"; menu4TextBox.Text = "0";
            kolaTextBox.Text = "0"; fantaTextBox.Text = "0"; spriteTextBox.Text = "0"; ayranTextBox.Text = "0"; suTextBox.Text = "0";
            mısırKucukTextBox.Text = "0"; mısırOrtaTextBox.Text = "0"; mısırBuyukTextBox.Text = "0"; cipsTextBox.Text = "0"; kekTextBox.Text = "0";
            biletFiyatToplamLabel.Text = ""; menuFiyatToplamLabel.Text = ""; icecekFiyatToplamLabel.Text = ""; yiyecekFiyatToplamLabel.Text = ""; toplamFiyatLabel.Text = ""; iyiSeyirlerTextBox.Text = "";




        }

        private void menu2ArttirButton_Click(object sender, EventArgs e)
        {
            menu2Sayi++;//arttırma butonuna tıklandığında menünün sayısı 1 artacaktık.
            menu2Fiyat = menu1Fiyat + 32;//Her arttırıldığında menünün fiyatı da ne kadarsa o kadar sayı değişkene kaydedilir.
            menu2TextBox.Text = menu2Sayi.ToString();//menüden kaç adet alındığını yanındaki text boxa yazar
            if (menu2Sayi > 0)
            {
                menu2AzaltButton.Enabled = true; //Eğer arttırma butonuna tıkladığımızda menu sayısı 0 ın üzerine çıkarsa, azaltma butonunu etkin yap
            }
        }

        private void menu2AzaltButton_Click(object sender, EventArgs e)
        {
            menu2Sayi--;//azaltma butonuna tıklandığında menünün sayısı 1 azalacaktık.
            menu2Fiyat = menu2Fiyat - 32;//Her arttırıldığında menünün fiyatı da ne kadarsa o kadar sayı değişkenden azaltılır.
            menu2TextBox.Text = menu2Sayi.ToString();//menüden kaç adet alındığını yanındaki text boxa yazar
            if (menu2Sayi == 0)
            {
                menu2AzaltButton.Enabled = false; //eğer menu sayısı 0 ise azaltma butonu pasif olacak

            }
        }

        private void menu3ArttirButton_Click(object sender, EventArgs e)
        {
            menu3Sayi++;//arttırma butonuna tıklandığında menünün sayısı 1 artacaktık.
            menu3Fiyat = menu3Fiyat + 38;//Her arttırıldığında menünün fiyatı da ne kadarsa o kadar sayı değişkene kaydedilir.
            menu3TextBox.Text = menu3Sayi.ToString();//menüden kaç adet alındığını yanındaki text boxa yazar
            if (menu3Sayi > 0)
            {
                menu3AzaltButton.Enabled = true; //Eğer arttırma butonuna tıkladığımızda menu sayısı 0 ın üzerine çıkarsa, azaltma butonunu etkin yap
            }
        }

        private void menu3AzaltButton_Click(object sender, EventArgs e)
        {
            menu3Sayi--;//azaltma butonuna tıklandığında menünün sayısı 1 azalacaktık.
            menu3Fiyat = menu3Fiyat - 38;//Her arttırıldığında menünün fiyatı da ne kadarsa o kadar sayı değişkenden azaltılır.
            menu3TextBox.Text = menu3Sayi.ToString();//menüden kaç adet alındığını yanındaki text boxa yazar
            if (menu3Sayi == 0)
            {
                menu3AzaltButton.Enabled = false; //eğer menu sayısı 0 ise azaltma butonu pasif olacak

            }
        }

        private void menu4ArttirButton_Click(object sender, EventArgs e)
        {
            menu4Sayi++;//arttırma butonuna tıklandığında menünün sayısı 1 artacaktık.
            menu4Fiyat = menu4Fiyat + 70;//Her arttırıldığında menünün fiyatı da ne kadarsa o kadar sayı değişkene kaydedilir.
            menu4TextBox.Text = menu4Sayi.ToString();//menüden kaç adet alındığını yanındaki text boxa yazar
            if (menu4Sayi > 0)
            {
                menu4AzaltButton.Enabled = true; //Eğer arttırma butonuna tıkladığımızda menu sayısı 0 ın üzerine çıkarsa, azaltma butonunu etkin yap
            }
        }

        private void menu4AzaltButton_Click(object sender, EventArgs e)
        {
            menu4Sayi--;//azaltma butonuna tıklandığında menünün sayısı 1 azalacaktık.
            menu4Fiyat = menu4Fiyat - 70;//Her arttırıldığında menünün fiyatı da ne kadarsa o kadar sayı değişkenden azaltılır.
            menu4TextBox.Text = menu4Sayi.ToString();//menüden kaç adet alındığını yanındaki text boxa yazar
            if (menu4Sayi == 0)
            {
                menu4AzaltButton.Enabled = false; //eğer menu sayısı 0 ise azaltma butonu pasif olacak

            }
        }

        private void kolaArttirButton_Click(object sender, EventArgs e)
        {
            kolaSayi++;//arttırma butonuna tılandığında kolanın sayısı bir artacaktır.
            kolaFiyat = kolaFiyat + 6; //Her arttırımda ürünün fiyatı da değeri kadar artıyor.
            kolaTextBox.Text = kolaSayi.ToString();
            if (kolaSayi >0)
            {
                kolaAzaltButton.Enabled = true;// Arttırma butonuna tıkladığımızda 0 ın üzerine çıktıysak azaltma butonu aktif oluyor
            }

        }

        private void kolaAzaltButton_Click(object sender, EventArgs e)
        {
            kolaSayi--;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            kolaFiyat = kolaFiyat - 6; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            kolaTextBox.Text = kolaSayi.ToString();
            if (kolaSayi == 0)
            {
                kolaAzaltButton.Enabled = false;//eğer kola sayısı 0 ise azaltma butonu pasif olacak
            }
        }

        private void fantaArttirButton_Click(object sender, EventArgs e)
        {
            fantaSayi++;//arttırma butonuna tılandığında kolanın sayısı bir artacaktır.
            fantaFiyat = fantaFiyat + 6; //Her arttırımda ürünün fiyatı da değeri kadar artıyor.
            fantaTextBox.Text = fantaSayi.ToString();
            if (fantaSayi > 0)
            {
                fantaAzaltButton.Enabled = true;// Arttırma butonuna tıkladığımızda 0 ın üzerine çıktıysak azaltma butonu aktif oluyor
            }
        }

        private void fantaAzaltButton_Click(object sender, EventArgs e)
        {
            fantaSayi--;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            fantaFiyat = fantaFiyat - 6; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            fantaTextBox.Text = fantaSayi.ToString();
            if (fantaSayi == 0)
            {
                fantaAzaltButton.Enabled = false;//eğer fanta sayısı 0 ise azaltma butonu pasif olacak
            }
        }

        private void spriteArttirButton_Click(object sender, EventArgs e)
        {
            spriteSayi++;//arttırma butonuna tılandığında kolanın sayısı bir artacaktır.
            spriteFiyat = spriteFiyat + 6; //Her arttırımda ürünün fiyatı da değeri kadar artıyor.
            spriteTextBox.Text = spriteSayi.ToString();
            if (spriteSayi > 0)
            {
                spriteAzaltButton.Enabled = true;// Arttırma butonuna tıkladığımızda 0 ın üzerine çıktıysak azaltma butonu aktif oluyor
            }
        }

        private void spriteAzaltButton_Click(object sender, EventArgs e)
        {
            spriteSayi--;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            spriteFiyat = spriteFiyat - 6; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            spriteTextBox.Text = spriteSayi.ToString();
            if (spriteSayi == 0)
            {
                spriteAzaltButton.Enabled = false;//eğer sprite sayısı 0 ise azaltma butonu pasif olacak
            }
        }

        private void ayranArttirButton_Click(object sender, EventArgs e)
        {
            ayranSayi++;//arttırma butonuna tılandığında kolanın sayısı bir artacaktır.
            ayranFiyat = ayranFiyat + 4; //Her arttırımda ürünün fiyatı da değeri kadar artıyor.
            ayranTextBox.Text = ayranSayi.ToString();
            if (ayranSayi > 0)
            {
                ayranAzaltButton.Enabled = true;// Arttırma butonuna tıkladığımızda 0 ın üzerine çıktıysak azaltma butonu aktif oluyor
            }
        }

        private void ayranAzaltButton_Click(object sender, EventArgs e)
        {
            ayranSayi--;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            ayranFiyat = ayranFiyat - 4; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            ayranTextBox.Text = ayranSayi.ToString();
            if (ayranSayi == 0)
            {
                ayranAzaltButton.Enabled = false;//eğer ayran sayısı 0 ise azaltma butonu pasif olacak
            }
        }

        private void suArttirButton_Click(object sender, EventArgs e)
        {
            suSayi++;//arttırma butonuna tılandığında kolanın sayısı bir artacaktır.
            suFiyat = suFiyat + 2; //Her arttırımda ürünün fiyatı da değeri kadar artıyor.
            suTextBox.Text = suSayi.ToString();
            if (suSayi > 0)
            {
                suAzaltButton.Enabled = true;// Arttırma butonuna tıkladığımızda 0 ın üzerine çıktıysak azaltma butonu aktif oluyor
            }
        }

        private void suAzaltButton_Click(object sender, EventArgs e)
        {
            suSayi--;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            suFiyat = suFiyat - 2; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            suTextBox.Text = suSayi.ToString();
            if (suSayi == 0)
            {
                suAzaltButton.Enabled = false;//eğer su sayısı 0 ise azaltma butonu pasif olacak
            }
        }

        private void mısırKucukArttirButton_Click(object sender, EventArgs e)
        {
            misirKucukSayi++;//Arttırma butonuna her tıklandığında bir artacaktır.
            misirKucukFiyat = misirKucukFiyat +8; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            mısırKucukTextBox.Text = misirKucukSayi.ToString();
            if (misirKucukSayi > 0)
            {
                mısırKucukAzaltButton.Enabled = true;// Arttırma butonuna tıkladığımızda 0 ın üzerine çıktıysak azaltma butonu aktif oluyor
            }
        }

        private void mısırKucukAzaltButton_Click(object sender, EventArgs e)
        {
            misirKucukSayi--;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            misirKucukFiyat = misirKucukFiyat - 8; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            mısırKucukTextBox.Text = misirKucukSayi.ToString();
            if (misirKucukSayi == 0)
            {
                mısırKucukAzaltButton.Enabled = false;//eğer Mısır sayısı 0 ise azaltma butonu pasif olacak
            }
        }

        private void mısırOrtaArttirButton_Click(object sender, EventArgs e)
        {
            misirOrtaSayi++;//Arttırma butonuna her tıklandığında bir artacaktır.
            misirOrtaFiyat = misirOrtaFiyat + 12; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            mısırOrtaTextBox.Text = misirOrtaSayi.ToString();
            if (misirOrtaSayi > 0)
            {
                mısırOrtaAzaltButton.Enabled = true;// Arttırma butonuna tıkladığımızda 0 ın üzerine çıktıysak azaltma butonu aktif oluyor
            }
        }

        private void mısırOrtaAzaltButton_Click(object sender, EventArgs e)
        {
            misirOrtaSayi--;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            misirOrtaFiyat = misirOrtaFiyat - 12; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            mısırOrtaTextBox.Text = misirOrtaSayi.ToString();
            if (misirOrtaSayi == 0)
            {
                mısırOrtaAzaltButton.Enabled = false;//eğer Mısır sayısı 0 ise azaltma butonu pasif olacak
            }
        }

        private void mısırBuyukArttirButton_Click(object sender, EventArgs e)
        {
            
            misirBuyukSayi++;//Arttırma butonuna her tıklandığında bir artacaktır.
            misirBuyukFiyat = misirBuyukFiyat + 16; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            mısırBuyukTextBox.Text = misirBuyukSayi.ToString();
            if (misirBuyukSayi > 0)
            {
                mısırBuyukAzaltButton.Enabled = true;// Arttırma butonuna tıkladığımızda 0 ın üzerine çıktıysak azaltma butonu aktif oluyor
            }
        }

        private void mısırBuyukAzaltButton_Click(object sender, EventArgs e)
        {
            misirBuyukSayi--;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            misirBuyukFiyat = misirBuyukFiyat - 16; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            mısırBuyukTextBox.Text = misirBuyukSayi.ToString();
            if (misirBuyukSayi == 0)
            {
                mısırBuyukAzaltButton.Enabled = false;//eğer Mısır sayısı 0 ise azaltma butonu pasif olacak
            }
        }

        private void cipsArttirButton_Click(object sender, EventArgs e)
        {
            cipsSayi++;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            cipsFiyat = cipsFiyat + 6; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            cipsTextBox.Text = cipsSayi.ToString();
            if (cipsSayi > 0)
            {
                cipsAzaltButton.Enabled = true;// Arttırma butonuna tıkladığımızda 0 ın üzerine çıktıysak azaltma butonu aktif oluyor
            }
        }

        private void cipsAzaltButton_Click(object sender, EventArgs e)
        {
            cipsSayi--;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            cipsFiyat = cipsFiyat - 6; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            cipsTextBox.Text = cipsSayi.ToString();
            if (cipsSayi == 0)
            {
                cipsAzaltButton.Enabled = false;//eğer kek sayısı 0 ise azaltma butonu pasif olacak
            }
        }

        private void kekArttirButton_Click(object sender, EventArgs e)
        {
            kekSayi++;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            kekFiyat = kekFiyat + 2; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            kekTextBox.Text = kekSayi.ToString();
            if (kekSayi > 0)
            {
                kekAzaltButton.Enabled = true;// Arttırma butonuna tıkladığımızda 0 ın üzerine çıktıysak azaltma butonu aktif oluyor.
            }
        }

        private void kekAzaltButton_Click(object sender, EventArgs e)
        {
            kekSayi--;//azaltma butonuna tılandığında kolanın sayısı bir azalacaktır.
            kekFiyat = kekFiyat - 2; //Her azaltımda ürünün fiyatı da değeri kadar azalıyor.
            kekTextBox.Text = kekSayi.ToString();
            if (kekSayi == 0)
            {
                kekAzaltButton.Enabled = false;//eğer kek sayısı 0 ise azaltma butonu pasif olacak
            }
        }
    }
}
