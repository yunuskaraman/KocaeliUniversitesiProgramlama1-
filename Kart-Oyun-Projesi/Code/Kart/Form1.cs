using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kart
{
    public partial class Form1 : Form
    {
        List<Sporcu> bilgisayarListe = new List<Sporcu>();
        List<Sporcu> kullaniciListe = new List<Sporcu>();
        
        Bilgisayar bilgisayar = new Bilgisayar();
        Kullanici kullanici = new Kullanici();
        ListBox[] listboxDizi = new ListBox[8];
        List<String> fPozisyon = new List<string>();
        List<String> bPozisyon = new List<string>();
        Random rnd = new Random();
        int[] kullaniciKartKullanildi = { 0, 1, 2, 3, 4, 5, 6, 7 };
        int[] bilgisayarKartKullanildi = { 0, 1, 2, 3, 4, 5, 6, 7 };
        int secilenKart;
        int adim = 0,sira=0;
        int birOncekiKart = 1;
        int tekrarPozisyon = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            label2.Visible = true;
            labelPozisyon.Visible = true;
            lblSonuc.Visible = true;
            labelKullanici.Visible = true;
            labelBilgisayar.Visible = true;

            Random rnd = new Random();

            List<Futbolcu> futbolcular = new List<Futbolcu>();
            List<Basketbolcu> basketbolcular = new List<Basketbolcu>();

            Basketbolcu basketbolcu1 = new Basketbolcu("Cedi", "Cleveland", 75,90,90);
            Basketbolcu basketbolcu2 = new Basketbolcu("Kevin", "Brooklyn", 95  , 90,85);
            Basketbolcu basketbolcu3 = new Basketbolcu("Cabbar", "Cleveland", 75, 95, 85);
            Basketbolcu basketbolcu4 = new Basketbolcu("Stephen Curry", "Golden State", 90, 80, 90);
            Basketbolcu basketbolcu5 = new Basketbolcu("Durant", "Brooklyn", 80, 85, 90);
            Basketbolcu basketbolcu6 = new Basketbolcu("LeBron James", "Los Angales", 95, 95, 80);
            Basketbolcu basketbolcu7 = new Basketbolcu("Michael Jordan", "Brooklyn", 100, 80, 85);
            Basketbolcu basketbolcu8 = new Basketbolcu("Bogdanović", "Sacramento", 80, 80, 95);

            Futbolcu futbolcu1 = new Futbolcu("Messi", "Barcelona", 80, 100, 90);
            Futbolcu futbolcu2 = new Futbolcu("Ronaldo", "Juventus", 80, 90, 95);
            Futbolcu futbolcu3 = new Futbolcu("Rous", "Dordmund", 80, 90, 90);
            Futbolcu futbolcu4 = new Futbolcu("Kros", "Realmadrid", 80, 100, 95);
            Futbolcu futbolcu5 = new Futbolcu("Suarez", "Barcelona", 100, 80, 95);
            Futbolcu futbolcu6 = new Futbolcu("Modric", "Realmadrid", 90, 100, 95);
            Futbolcu futbolcu7 = new Futbolcu("Ramos", "Realmadrid", 95, 80, 85);
            Futbolcu futbolcu8 = new Futbolcu("Aguero", "City", 85, 80, 95);

            futbolcular.Add(futbolcu1);
            futbolcular.Add(futbolcu2);
            futbolcular.Add(futbolcu3);
            futbolcular.Add(futbolcu4);
            futbolcular.Add(futbolcu5);
            futbolcular.Add(futbolcu6);
            futbolcular.Add(futbolcu7);
            futbolcular.Add(futbolcu8);

            basketbolcular.Add(basketbolcu1);
            basketbolcular.Add(basketbolcu2);
            basketbolcular.Add(basketbolcu3);
            basketbolcular.Add(basketbolcu4);
            basketbolcular.Add(basketbolcu5);
            basketbolcular.Add(basketbolcu6);
            basketbolcular.Add(basketbolcu7);
            basketbolcular.Add(basketbolcu8);

            fPozisyon.Add("KALECİ K. KARŞIYA");
            fPozisyon.Add("PENALTI");
            fPozisyon.Add("SERBEST VURUŞ");

           
            bPozisyon.Add("İKİLİK");
            bPozisyon.Add("ÜÇLÜK");
            bPozisyon.Add("SERBEST ATIŞ");

            

            //Bilgisayar kartları oluşturuyor
            int k = 8;
            for (int i = 0; i < 8; i++)
            {

                int rast = rnd.Next(0, k);
                if (i % 2 == 0)
                {
                    bilgisayarListe.Add(futbolcular[rast]);
                    
                    futbolcular.RemoveAt(rast);
                    
                }
                else
                {
                    bilgisayarListe.Add(basketbolcular[rast]);
                    basketbolcular.RemoveAt(rast);
                    k--;
                }

                

            }

           
            int x = 3;
            //Kullanıcı kartları oluşturuyor

            for (int i = 0; i < 8; i++)
            {
                Thread.Sleep(100);

                if (i % 2 == 0)
                {
                    kullaniciListe.Add(futbolcular[0]);
                    listboxDizi[i] = new ListBox();
                    listboxDizi[i].Width = 120;
                    listboxDizi[i].Height = 147;
                    listboxDizi[i].Left = x;
                    listboxDizi[i].BackColor = System.Drawing.Color.FromArgb(112, 214, 23);
                    this.panel2.Controls.Add(listboxDizi[i]);
                    futbolcular.RemoveAt(0);
                    
                }
                else
                {
                    
                    kullaniciListe.Add(basketbolcular[0]);
                    listboxDizi[i] = new ListBox();
                    listboxDizi[i].Width = 120;
                    listboxDizi[i].Height = 147;
                    listboxDizi[i].Left = x;
                    listboxDizi[i].Enabled = false;
                    listboxDizi[i].BackColor = System.Drawing.Color.FromArgb(255, 137, 28);
                    
                    this.panel2.Controls.Add(listboxDizi[i]);
                   
                    
                    basketbolcular.RemoveAt(0);
                }
                x += 123;

            }


                //Bilgisayar kartlarını ekrana yazdırır
             for (int i = 0; i < 8; i++)
             {
                 if (bilgisayarListe[i].GetType().Name.ToString() == "Futbolcu")
                 {
                    futbolcu1 = (Futbolcu)bilgisayarListe[i];
                    Console.WriteLine(futbolcu1.sporcuIsim + "=>" + futbolcu1.kaleciKarsiKarsiya);
                }
                 else
                 {
                     basketbolcu1 = (Basketbolcu)bilgisayarListe[i];
                     Console.WriteLine(basketbolcu1.sporcuIsim + "=>" + basketbolcu1.ikilik);
                     
                 }
             }
            Console.WriteLine("------------------------------");

            

            //Kullanıcı kartlarını dağıtır
            for (int i = 0; i < 8; i++)
            {

                if (kullaniciListe[i].GetType().Name.ToString() == "Futbolcu")
                {
                    futbolcu1 = (Futbolcu)kullaniciListe[i];
                    listboxDizi[i].Items.Add("Futbolcu");
                    listboxDizi[i].Items.Add("Adı :" + futbolcu1.sporcuIsim);
                    listboxDizi[i].Items.Add("Takım : " + futbolcu1.sporcuTakim);
                    listboxDizi[i].Items.Add("Kaleci K. Karşıya :" + futbolcu1.kaleciKarsiKarsiya);
                    listboxDizi[i].Items.Add("Penaltı : " + futbolcu1.penalti);
                    listboxDizi[i].Items.Add("Serbest Vuruş : " + futbolcu1.serbestVurus);
                }
                else
                {
                    basketbolcu1 = (Basketbolcu)kullaniciListe[i];
                    listboxDizi[i].Items.Add("Basketbolcu");
                    listboxDizi[i].Items.Add("Adı : " + basketbolcu1.sporcuIsim);
                    listboxDizi[i].Items.Add("Takım : " + basketbolcu1.sporcuTakim);
                    listboxDizi[i].Items.Add("İkilik : " + basketbolcu1.ikilik);
                    listboxDizi[i].Items.Add("Üçlük : " + basketbolcu1.ucluk);
                    listboxDizi[i].Items.Add("Serbest Atış : " + basketbolcu1.serbestAtis);
                }
                
            }
            button1.Visible = false;
            button2.Visible = false;
            textKulAdi.Visible = false;

            for (secilenKart = 0; secilenKart < 8; secilenKart++)
            {
                listboxDizi[secilenKart].Name = secilenKart.ToString();
                listboxDizi[secilenKart].SelectedIndexChanged += new EventHandler(listboxDizi_Changed);
            }
            
        }
        private void listboxDizi_Changed(object sender, EventArgs e)
        {
            //Kartı oyun alanına atar

            ListBox list = (sender as ListBox);
            secilenKart = Convert.ToInt16(list.Name);

            labelPozisyon.Text = "Rastgele Pozisyon";
            labelBilgisayar.Text = "0";
            labelKullanici.Text = "0";

            listboxDizi[birOncekiKart].Enabled = false;

            if (kullanici.kartSec(kullaniciKartKullanildi, secilenKart) != -1)
            {
                listKulKart.Items.Clear();
                listBilKart.Items.Clear();


                if ((kullaniciListe[kullanici.kartSec(kullaniciKartKullanildi, secilenKart)].GetType().Name.ToString() == "Futbolcu" && sira % 2 == 0) || (kullaniciListe[kullanici.kartSec(kullaniciKartKullanildi, secilenKart)].GetType().Name.ToString() == "Futbolcu" && sira>=8))
                    {
                        while (true)
                        {
                            adim = rnd.Next(0, 8);
                            if (adim % 2 == 0)
                            {
                                if (bilgisayar.kartSec(bilgisayarKartKullanildi, adim) != -1)
                                {
                                    break;
                                }
                            }
                        }
                        
                        gizleGoster(112, 214, 23);
                        //listKartlar("Futbolcu");

                        button3.Visible = true;
                    }
                else
                    {

                        while (true)
                        {
                            adim = rnd.Next(1, 8);
                            if (adim % 2 == 1)
                            {
                                if (bilgisayar.kartSec(bilgisayarKartKullanildi, adim) != -1)
                                {
                                    break;
                                }
                            }
                        }
                        
                        gizleGoster(255, 137, 28);
                        //listKartlar("Basketbolcu");
                        button3.Visible = true;

                    }
            }
            else
            {
                listboxDizi[secilenKart].Enabled = false;
                MessageBox.Show("Bu kart daha önce kullanıldı.");
            }
            
            lblSonuc.Text = "SONUÇ";
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            label2.Visible = true;

            if (sira % 2 == 0)
            {
                for (int i = 0, k = 1; i < 8; i += 2, k += 2)
                {
                    listboxDizi[i].Enabled = false; //Futbol kartları

                    if (kullanici.kartSec(kullaniciKartKullanildi, k) == -1)
                    {

                        listboxDizi[k].Enabled = false; //Basketbol Kullanılmış kartlar
                    }
                    else
                    {
                        listboxDizi[k].Enabled = true; //Kullanılmamış kartlar
                    }

                }

            }
            if (sira % 2 == 1)
            {
                for (int i = 0, k = 1; i < 8; i += 2, k += 2)
                {
                    listboxDizi[i].Enabled = true;
                    listboxDizi[k].Enabled = false; //Basketbol kartları

                    if (kullanici.kartSec(kullaniciKartKullanildi, i) == -1)
                    {

                        listboxDizi[i].Enabled = false; //Futbol Kullanılmış kartlar
                    }
                    else
                    {
                        listboxDizi[i].Enabled = true; //Kullanılmamış kartlar
                    }

                }
            }
            if (sira >= 7)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (kullanici.kartSec(kullaniciKartKullanildi, i) == -1)
                    {
                        listboxDizi[i].Enabled = false;
                    }
                    else
                    {
                        listboxDizi[i].Enabled = true;
                    }
                }

            }

            
            int rast = rnd.Next(0, 3);
            List<Futbolcu> futbolcular = new List<Futbolcu>();
            List<Basketbolcu> basketbolcular = new List<Basketbolcu>();
            //Kart atılır kart futbolcu ise if e değilse else içi girer ve pozisyon karşılaştırılması yapılır
            if (kullaniciListe[secilenKart].GetType().Name.ToString() == "Futbolcu")
            {
                if (sira <8)
                    label2.Text = "BASKETBOLCU KARTI SEÇ";
                else
                    label2.Text = "ELDEKİ KARTI SEÇ";

                futbolcular.Add((Futbolcu)bilgisayarListe[adim]);
                futbolcular.Add((Futbolcu)kullaniciListe[secilenKart]);
                
                labelPozisyon.Text = fPozisyon[rast];

                //futbocular listesinin 0 ıncı indexi ne bilgisayar listesindeki seçilen kartının 
                // bilgiler atılır.  1 inci indexine kullanıcının seçilen kartının bilgisi atılır. 
                //bu bilgilar pozisyon değeri olarak karşılaştırma yapılır.

                listKartlar("Futbolcu");

                if (futbolcular[0].SporcuPuaniGoster(rast) > futbolcular[1].SporcuPuaniGoster(rast))
                {
                    labelBilgisayar.Text = futbolcular[0].SporcuPuaniGoster(rast).ToString();
                    labelKullanici.Text = futbolcular[1].SporcuPuaniGoster(rast).ToString();
                    lblSonuc.Text = futbolcular[0].sporcuIsim.ToUpper() + " KAZANDI";
                    bilgisayarKartKullanildi[adim] = -1;
                    kullaniciKartKullanildi[secilenKart] = -1; 
                    lblSkorBil.Text = bilgisayar.SkorGoster(10).ToString();

                    //.WriteLine("kaleciKarsiKarsiya");
                    //listBox1.Items.Add(fPozisyon[rast] + " => " + futbolcular[0].sporcuIsim + " " + futbolcular[0].kaleciKarsiKarsiya + " < VS > " + futbolcular[1].sporcuIsim + " => " + futbolcular[1].kaleciKarsiKarsiya);
                    //Console.WriteLine(futbolcular[0].sporcuIsim + " " + futbolcular[0].kaleciKarsiKarsiya + " " + futbolcular[1].sporcuIsim + " " + futbolcular[1].kaleciKarsiKarsiya);
                }
                else if (futbolcular[0].SporcuPuaniGoster(rast) < futbolcular[1].SporcuPuaniGoster(rast))
                {

                    labelBilgisayar.Text = futbolcular[0].SporcuPuaniGoster(rast).ToString();
                    labelKullanici.Text =  futbolcular[1].SporcuPuaniGoster(rast).ToString();
                    lblSonuc.Text = futbolcular[1].sporcuIsim.ToUpper() + " KAZANDI";
                    bilgisayarKartKullanildi[adim] = -1;
                    kullaniciKartKullanildi[secilenKart] = -1;
                    lblSkorKul.Text = kullanici.SkorGoster(10).ToString();
                    
                    //Console.WriteLine("penalti");
                    //listBox1.Items.Add(fPozisyon[rast] + " => " + futbolcular[0].sporcuIsim + " " + futbolcular[0].kaleciKarsiKarsiya + " < VS > " + futbolcular[1].sporcuIsim + " => " + futbolcular[1].kaleciKarsiKarsiya);
                    //Console.WriteLine(futbolcular[0].sporcuIsim + " " + futbolcular[0].kaleciKarsiKarsiya + " " + futbolcular[1].sporcuIsim + " " + futbolcular[1].kaleciKarsiKarsiya);
                }
                else
                {
                    labelBilgisayar.Text = futbolcular[0].SporcuPuaniGoster(rast).ToString();
                    labelKullanici.Text = futbolcular[1].SporcuPuaniGoster(rast).ToString();
                    lblSonuc.Text = " BERABERLİK";
                    kullaniciKartKullanildi[secilenKart] = secilenKart;
                    bilgisayarKartKullanildi[adim] = adim;
                    
                    if (Convert.ToInt16(lblSkorBil.Text) + Convert.ToInt16(lblSkorKul.Text) == 70)
                    {
                        if (tekrarPozisyon == 3)
                        {
                            button3.Visible = false;
                            label2.Visible = false;
                        }
                        else
                        {
                            button3.Visible = true;
                            label2.Visible = false;
                            tekrarPozisyon++;
                        }
                    }
                        
                    //Console.WriteLine("serbestVurus");
                    //listBox1.Items.Add(fPozisyon[rast] + " => " + futbolcular[0].sporcuIsim + " " + futbolcular[0].kaleciKarsiKarsiya + " < VS > " + futbolcular[1].sporcuIsim + " => " + futbolcular[1].kaleciKarsiKarsiya);
                    //WriteLine(futbolcular[0].sporcuIsim + " " + futbolcular[0].kaleciKarsiKarsiya + " " + futbolcular[1].sporcuIsim + " " + futbolcular[1].kaleciKarsiKarsiya);
                }
                Thread.Sleep(1500);
            }
            else
            {
                if (sira <= 7)
                    label2.Text = "FUTBOLCU KARTI SEÇ";
                else
                    label2.Text = "ELDEKİ KARTI SEÇ";

                basketbolcular.Add((Basketbolcu)bilgisayarListe[adim]);
                basketbolcular.Add((Basketbolcu)kullaniciListe[secilenKart]);
                
                labelPozisyon.Text = bPozisyon[rast];
                listKartlar("Basketbolcu");
                if (basketbolcular[0].SporcuPuaniGoster(rast) > basketbolcular[1].SporcuPuaniGoster(rast))
                {


                    //Console.WriteLine("İkilik");
                    //Console.WriteLine(basketbolcular[0].sporcuIsim + " " + basketbolcular[0].ikilik + " " + basketbolcular[1].sporcuIsim + " " + basketbolcular[1].ikilik);
                    //listBox1.Items.Add(bPozisyon[rast] + " => " + basketbolcular[0].sporcuIsim + " " + basketbolcular[0].ikilik + " < VS > " + basketbolcular[1].sporcuIsim + " => " + basketbolcular[1].ikilik);
                   
                    labelBilgisayar.Text = basketbolcular[0].SporcuPuaniGoster(rast).ToString();
                    labelKullanici.Text = basketbolcular[1].SporcuPuaniGoster(rast).ToString();
                    lblSonuc.Text = basketbolcular[0].sporcuIsim.ToUpper() + " KAZANDI";
                    lblSkorBil.Text = bilgisayar.SkorGoster(10).ToString();
                    bilgisayarKartKullanildi[adim] = -1;
                    kullaniciKartKullanildi[secilenKart] = -1;
                }
                else if (basketbolcular[0].SporcuPuaniGoster(rast) < basketbolcular[1].SporcuPuaniGoster(rast))
                {

                    //Console.WriteLine("Üçlük");
                    //Console.WriteLine(basketbolcular[0].sporcuIsim + " " + basketbolcular[0].ucluk + " " + basketbolcular[1].sporcuIsim + " " + basketbolcular[1].ucluk);
                    //listBox1.Items.Add(bPozisyon[rast] + " => " + basketbolcular[0].sporcuIsim + " " + basketbolcular[0].ucluk + " < VS > " + basketbolcular[1].sporcuIsim + " => " + basketbolcular[1].ucluk);
                    labelBilgisayar.Text = basketbolcular[0].SporcuPuaniGoster(rast).ToString();
                    labelKullanici.Text = basketbolcular[1].SporcuPuaniGoster(rast).ToString();
                    lblSonuc.Text = basketbolcular[1].sporcuIsim.ToUpper() + " KAZANDI";
                    lblSkorKul.Text = kullanici.SkorGoster(10).ToString();
                    bilgisayarKartKullanildi[adim] = -1;
                    kullaniciKartKullanildi[secilenKart] = -1;
                    
                }
                else
                {
                    labelBilgisayar.Text = basketbolcular[0].SporcuPuaniGoster(rast).ToString();
                    labelKullanici.Text = basketbolcular[1].SporcuPuaniGoster(rast).ToString();
                    lblSonuc.Text = " BERABERLİK";
                    kullaniciKartKullanildi[secilenKart] = secilenKart;
                    bilgisayarKartKullanildi[adim] = adim;
                    if (Convert.ToInt16(lblSkorBil.Text)+ Convert.ToInt16(lblSkorKul.Text) == 70)
                    {
                        if(tekrarPozisyon == 3){
                            button3.Visible = false;
                            label2.Visible = false;
                        }
                        else
                        {
                            button3.Visible = true;
                            label2.Visible = false;
                            tekrarPozisyon++;
                        }
                        
                    }
                        
                   
                }
                Thread.Sleep(1500);
            }
            sira++;
            Thread.Sleep(1000);

            if (Convert.ToInt16(lblSkorBil.Text) + Convert.ToInt16(lblSkorKul.Text) == 80 ||  tekrarPozisyon==3)
            {
                //Oyun bittikten sonraki panellerin kapatılışı ver formdaki sonuç

                

                if (Convert.ToInt16(lblSkorBil.Text) < Convert.ToInt16(lblSkorKul.Text))
                    label4.Text = "TEBRİKLER " + label1.Text + " KAZANDINIZ";
                else if (Convert.ToInt16(lblSkorBil.Text) > Convert.ToInt16(lblSkorKul.Text))
                    label4.Text = "OYUNU KAYBETTİNİZ";
                else
                    label4.Text = "OYUN BERABERE BİTTİ";

                label9.Text = label1.Text;
                label8.Text = lblBilAdi.Text;
                label5.Text = lblSkorBil.Text;
                label6.Text = lblSkorKul.Text;

                

                panel1.Visible = false;
                panel2.Visible = false;
                label4.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label9.Visible = true;

            }
                
        }
       
        private void gizleGoster(int a,int b, int c)
        {
            //kartları gizler, gösterir ve renklerini verir

            listboxDizi[birOncekiKart].Visible = true;
            
            listboxDizi[secilenKart].Visible = false;
            birOncekiKart = secilenKart;

            listKulKart.Visible = false;
            listBilKart.Visible = false;

            Thread.Sleep(1000);

            listKulKart.Visible = true;
            listBilKart.Visible = true;

            
            label2.Visible = false;

            listBilKart.BackColor = System.Drawing.Color.FromArgb(a, b, c);
            listKulKart.BackColor = System.Drawing.Color.FromArgb(a, b, c);
        }

        private void textKulAdi_Enter(object sender, EventArgs e)
        {
            if(textKulAdi.Text== "Kullanıcı Adı Giriniz")
            {
                textKulAdi.Text = "";
                textKulAdi.ForeColor = Color.Black;

                button2.Enabled = true;
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textKulAdi.Text == "" || textKulAdi.TextLength<=3)
            {
                textKulAdi.Text = "Kullanıcı Adı Giriniz"; ;
                textKulAdi.ForeColor = Color.Silver;
                
            }
            else if (textKulAdi.Text == "Kullanıcı Adı Giriniz")
            {
                textKulAdi.Text = "";
            }
            else
            {
                label1.Text=textKulAdi.Text.ToUpper();
                button1.Enabled = true;
            }

        }

        private void listKartlar(string sporcu)
        {
            //atılan kartların bilgilerini ekrana yansıtır.

            Futbolcu f = new Futbolcu();
            Basketbolcu b = new Basketbolcu();
            if (sporcu == "Futbolcu")
            {
                f = (Futbolcu)kullaniciListe[kullanici.kartSec(kullaniciKartKullanildi, secilenKart)];
                listKulKart.Items.Clear();
                listKulKart.Items.Add("Futbolcu");
                listKulKart.Items.Add("Adı :" + f.sporcuIsim);
                listKulKart.Items.Add("Takım : " + f.sporcuTakim);
                listKulKart.Items.Add("Kaleci K. Karşıya : " + f.kaleciKarsiKarsiya);
                listKulKart.Items.Add("Penaltı : " + f.penalti);
                listKulKart.Items.Add("Serbest Vuruş : " + f.serbestVurus);

                f = (Futbolcu)bilgisayarListe[bilgisayar.kartSec(bilgisayarKartKullanildi, adim)];
                listBilKart.Items.Clear();
                listBilKart.Items.Add("Futbolcu");
                listBilKart.Items.Add("Adı :" + f.sporcuIsim);
                listBilKart.Items.Add("Takım : " + f.sporcuTakim);
                listBilKart.Items.Add("Kaleci K. Karşıya : " + f.kaleciKarsiKarsiya);
                listBilKart.Items.Add("Penaltı : " + f.penalti);
                listBilKart.Items.Add("Serbest Vuruş : " + f.serbestVurus);
            }
            else
            {
                b = (Basketbolcu)kullaniciListe[kullanici.kartSec(kullaniciKartKullanildi, secilenKart)];
                listKulKart.Items.Clear();
                listKulKart.Items.Add("Basketbolcu");
                listKulKart.Items.Add("Adı : " + b.sporcuIsim);
                listKulKart.Items.Add("Takım : " + b.sporcuTakim);
                listKulKart.Items.Add("İkilik : " + b.ikilik);
                listKulKart.Items.Add("Üçlük : " + b.ucluk);
                listKulKart.Items.Add("Serbest Atış : " + b.serbestAtis);


                
                b = (Basketbolcu)bilgisayarListe[bilgisayar.kartSec(bilgisayarKartKullanildi, adim)];
                listBilKart.Items.Clear();
                listBilKart.Items.Add("Basketbolcu");
                listBilKart.Items.Add("Adı : " + b.sporcuIsim);
                listBilKart.Items.Add("Takım : " + b.sporcuTakim);
                listBilKart.Items.Add("İkilik : " + b.ikilik);
                listBilKart.Items.Add("Üçlük : " + b.ucluk);
                listBilKart.Items.Add("Serbest Atış : " + b.serbestAtis);
            }

            
        }
    }
}