using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Otomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *********** Otomata Makinesi tasarlayınız. ************
            // ** Müşteri **
            // 1.Ürünleri ve fiyatlarını tutan 2 dizi tanımlanacak.
            // 2.Müşteri tanımlı olan ürünlerden istediğini seçecek ve para girişi yapacak.
            // 3.Ödeme yeterli ise ürün verildi ve para üstü bilgisi döndürülecek.
            // 4.Para yetersiz ise eklemek ister misiniz? E-> 3 H-> Çıkış
            // ** Admin **
            // Tanımlı şifre ile giriş
            // Ürün ekleme/güncelleme/silme
            // Fiyat güncelleme

            string sifre = "12ab";
            double para_üstü = 0.00;
            string[] isimler = { "Eticin ", "Su", "Sprite", "Coca-cola", "Fanta", "Browni", "Karam", "İkram", "Saklıköy", "Caramio" };
            double[] fiyatlar = { 3, 2, 6, 8, 8, 4, 6, 4, 5, 2 };
            int boyutlandir = isimler.Length;
        DON:
            Console.WriteLine("Müşteri girişi için : 1\nAdmin girişi için : 2\nÇıkış için 3");
            int secim = Convert.ToInt32(Console.ReadLine());



            if (secim == 1)
            {
                Console.Clear();
                for (int i = 0; i <isimler.Length; i++)
                {
                    Console.WriteLine(isimler[i]+" "+$"{i+1}");
                }
                Console.WriteLine("Lütfen ürün seçimi için bir numara giriniz:");
                int secim2 = Convert.ToInt32(Console.ReadLine());
                if (secim2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün:" + isimler[secim2 - 1] + " " + "Fiyat:" + fiyatlar[secim2 - 1]);


                    Console.WriteLine("Lütfen para girişi yapınız:");
                    double giris = Convert.ToDouble(Console.ReadLine());
                    if (giris == fiyatlar[secim2 - 1])
                    {
                        Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);

                    }
                    else if (giris > fiyatlar[secim2 - 1])
                    {
                        para_üstü = giris - fiyatlar[secim2 - 1];
                        Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Para üstünüz:" + para_üstü);
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (giris < fiyatlar[secim2 - 1])
                    {
                    DON2:
                        Console.WriteLine("Para yetersiz\nPara eklemek ister misini?\nE\tH");
                        string giris2 = Console.ReadLine().ToUpper();
                        if (giris2 == "E")
                        {
                            Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                            double ek_tutar = Convert.ToDouble(Console.ReadLine());
                            giris += ek_tutar;

                            if (giris == fiyatlar[secim2 - 1])
                            {
                                Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                            else if (giris > fiyatlar[secim2 - 1])
                            {
                                para_üstü = giris - fiyatlar[secim2 - 1];
                                Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Para üstünüz:" + para_üstü);
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                            else if (giris < fiyatlar[secim2 - 1])
                            {
                                goto DON2;
                            }


                        }


                        else if (giris2 == "H")
                        {
                            Console.WriteLine("Sistemden çıkılıyor...");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (secim2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün:" + isimler[secim2 - 1] + " " + "Fiyat:" + fiyatlar[secim2 - 1]);
                    Console.WriteLine("Lütfen para girişi yapınız:");

                    double giris = Convert.ToDouble(Console.ReadLine());
                    if (giris == fiyatlar[secim2 - 1])
                    {
                        Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);

                    }
                    else if (giris > fiyatlar[secim2 - 1])
                    {
                        para_üstü = giris - fiyatlar[secim2 - 1];
                        Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Para üstünüz:" + para_üstü);
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (giris < fiyatlar[secim2 - 1])
                    {
                    DON2:
                        Console.WriteLine("Para yetersiz\nPara eklemek ister misini?\nE\tH");
                        string giris2 = Console.ReadLine().ToUpper();
                        if (giris2 == "E")
                        {
                            Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                            double ek_tutar = Convert.ToDouble(Console.ReadLine());
                            giris += ek_tutar;

                            if (giris == fiyatlar[secim2 - 1])
                            {
                                Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                            else if (giris > fiyatlar[secim2 - 1])
                            {
                                para_üstü = giris - fiyatlar[secim2 - 1];
                                Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Para üstünüz:" + para_üstü);
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                            else if (giris < fiyatlar[secim2 - 1])
                            {
                                goto DON2;
                            }


                        }


                        else if (giris2 == "H")
                        {
                            Console.WriteLine("Sistemden çıkılıyor...");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (secim2 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün:" + isimler[secim2 - 1] + " " + "Fiyat:" + fiyatlar[secim2 - 1]);
                    Console.WriteLine("Lütfen para girişi yapınız:");

                    double giris = Convert.ToDouble(Console.ReadLine());
                    if (giris == fiyatlar[secim2 - 1])
                    {
                        Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);

                    }
                    else if (giris > fiyatlar[secim2 - 1])
                    {
                        para_üstü = giris - fiyatlar[secim2 - 1];
                        Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Para üstünüz:" + para_üstü);
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (giris < fiyatlar[secim2 - 1])
                    {
                    DON2:
                        Console.WriteLine("Para yetersiz\nPara eklemek ister misini?\nE\tH");
                        string giris2 = Console.ReadLine().ToUpper();
                        if (giris2 == "E")
                        {
                            Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                            double ek_tutar = Convert.ToDouble(Console.ReadLine());
                            giris += ek_tutar;

                            if (giris == fiyatlar[secim2 - 1])
                            {
                                Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                            else if (giris > fiyatlar[secim2 - 1])
                            {
                                para_üstü = giris - fiyatlar[secim2 - 1];
                                Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Para üstünüz:" + para_üstü);
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                            else if (giris < fiyatlar[secim2 - 1])
                            {
                                goto DON2;
                            }


                        }


                        else if (giris2 == "H")
                        {
                            Console.WriteLine("Sistemden çıkılıyor...");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (secim2 == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün:" + isimler[secim2 - 1] + " " + "Fiyat:" + fiyatlar[secim2 - 1]);
                    Console.WriteLine("Lütfen para girişi yapınız:");

                    double giris = Convert.ToDouble(Console.ReadLine());
                    if (giris == fiyatlar[secim2 - 1])
                    {
                        Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);

                    }
                    else if (giris > fiyatlar[secim2 - 1])
                    {
                        para_üstü = giris - fiyatlar[secim2 - 1];
                        Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Para üstünüz:" + para_üstü);
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (giris < fiyatlar[secim2 - 1])
                    {
                    DON2:
                        Console.WriteLine("Para yetersiz\nPara eklemek ister misini?\nE\tH");
                        string giris2 = Console.ReadLine().ToUpper();
                        if (giris2 == "E")
                        {
                            Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                            double ek_tutar = Convert.ToDouble(Console.ReadLine());
                            giris += ek_tutar;

                            if (giris == fiyatlar[secim2 - 1])
                            {
                                Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                            else if (giris > fiyatlar[secim2 - 1])
                            {
                                para_üstü = giris - fiyatlar[secim2 - 1];
                                Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Para üstünüz:" + para_üstü);
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                            else if (giris < fiyatlar[secim2 - 1])
                            {
                                goto DON2;
                            }


                        }


                        else if (giris2 == "H")
                        {
                            Console.WriteLine("Sistemden çıkılıyor...");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (secim2 == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün:" + isimler[secim2 - 1] + " " + "Fiyat:" + fiyatlar[secim2 - 1]);
                    Console.WriteLine("Lütfen para girişi yapınız:");

                    double giris = Convert.ToDouble(Console.ReadLine());
                    if (giris == fiyatlar[secim2 - 1])
                    {
                        Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);

                    }
                    else if (giris > fiyatlar[secim2 - 1])
                    {
                        para_üstü = giris - fiyatlar[secim2 - 1];
                        Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Para üstünüz:" + para_üstü);
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (giris < fiyatlar[secim2 - 1])
                    {
                    DON2:
                        Console.WriteLine("Para yetersiz\nPara eklemek ister misini?\nE\tH");
                        string giris2 = Console.ReadLine().ToUpper();
                        if (giris2 == "E")
                        {
                            Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                            double ek_tutar = Convert.ToDouble(Console.ReadLine());
                            giris += ek_tutar;

                            if (giris == fiyatlar[secim2 - 1])
                            {
                                Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                            else if (giris > fiyatlar[secim2 - 1])
                            {
                                para_üstü = giris - fiyatlar[secim2 - 1];
                                Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Para üstünüz:" + para_üstü);
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                            else if (giris < fiyatlar[secim2 - 1])
                            {
                                goto DON2;
                            }


                        }


                        else if (giris2 == "H")
                        {
                            Console.WriteLine("Sistemden çıkılıyor...");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (secim2 == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün:" + isimler[secim2 - 1] + " " + "Fiyat:" + fiyatlar[secim2 - 1]);
                    Console.WriteLine("Lütfen para girişi yapınız:");

                    double giris = Convert.ToDouble(Console.ReadLine());
                    if (giris == fiyatlar[secim2 - 1])
                    {
                        Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);

                    }
                    else if (giris > fiyatlar[secim2 - 1])
                    {
                        para_üstü = giris - fiyatlar[secim2 - 1];
                        Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Para üstünüz:" + para_üstü);
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (giris < fiyatlar[secim2 - 1])
                    {
                    DON2:
                        Console.WriteLine("Para yetersiz\nPara eklemek ister misini?\nE\tH");
                        string giris2 = Console.ReadLine().ToUpper();
                        if (giris2 == "E")
                        {
                            Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                            double ek_tutar = Convert.ToDouble(Console.ReadLine());
                            giris += ek_tutar;

                            if (giris == fiyatlar[secim2 - 1])
                            {
                                Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                            else if (giris > fiyatlar[secim2 - 1])
                            {
                                para_üstü = giris - fiyatlar[secim2 - 1];
                                Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Para üstünüz:" + para_üstü);
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                            else if (giris < fiyatlar[secim2 - 1])
                            {
                                goto DON2;
                            }


                        }


                        else if (giris2 == "H")
                        {
                            Console.WriteLine("Sistemden çıkılıyor...");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (secim2 == 7)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün:" + isimler[secim2 - 1] + " " + "Fiyat:" + fiyatlar[secim2 - 1]);
                    Console.WriteLine("Lütfen para girişi yapınız:");

                    double giris = Convert.ToDouble(Console.ReadLine());
                    if (giris == fiyatlar[secim2 - 1])
                    {
                        Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);

                    }
                    else if (giris > fiyatlar[secim2 - 1])
                    {
                        para_üstü = giris - fiyatlar[secim2 - 1];
                        Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Para üstünüz:" + para_üstü);
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (giris < fiyatlar[secim2 - 1])
                    {
                    DON2:
                        Console.WriteLine("Para yetersiz\nPara eklemek ister misini?\nE\tH");
                        string giris2 = Console.ReadLine().ToUpper();
                        if (giris2 == "E")
                        {
                            Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                            double ek_tutar = Convert.ToDouble(Console.ReadLine());
                            giris += ek_tutar;

                            if (giris == fiyatlar[secim2 - 1])
                            {
                                Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                            else if (giris > fiyatlar[secim2 - 1])
                            {
                                para_üstü = giris - fiyatlar[secim2 - 1];
                                Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Para üstünüz:" + para_üstü);
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                            else if (giris < fiyatlar[secim2 - 1])
                            {
                                goto DON2;
                            }


                        }


                        else if (giris2 == "H")
                        {
                            Console.WriteLine("Sistemden çıkılıyor...");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (secim2 == 8)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün:" + isimler[secim2 - 1] + " " + "Fiyat:" + fiyatlar[secim2 - 1]);
                    Console.WriteLine("Lütfen para girişi yapınız:");

                    double giris = Convert.ToDouble(Console.ReadLine());
                    if (giris == fiyatlar[secim2 - 1])
                    {
                        Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);

                    }
                    else if (giris > fiyatlar[secim2 - 1])
                    {
                        para_üstü = giris - fiyatlar[secim2 - 1];
                        Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Para üstünüz:" + para_üstü);
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (giris < fiyatlar[secim2 - 1])
                    {
                    DON2:
                        Console.WriteLine("Para yetersiz\nPara eklemek ister misini?\nE\tH");
                        string giris2 = Console.ReadLine().ToUpper();
                        if (giris2 == "E")
                        {
                            Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                            double ek_tutar = Convert.ToDouble(Console.ReadLine());
                            giris += ek_tutar;

                            if (giris == fiyatlar[secim2 - 1])
                            {
                                Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                            else if (giris > fiyatlar[secim2 - 1])
                            {
                                para_üstü = giris - fiyatlar[secim2 - 1];
                                Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Para üstünüz:" + para_üstü);
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                            else if (giris < fiyatlar[secim2 - 1])
                            {
                                goto DON2;
                            }


                        }


                        else if (giris2 == "H")
                        {
                            Console.WriteLine("Sistemden çıkılıyor...");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (secim2 == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün:" + isimler[secim2 - 1] + " " + "Fiyat:" + fiyatlar[secim2 - 1]);
                    Console.WriteLine("Lütfen para girişi yapınız:");

                    double giris = Convert.ToDouble(Console.ReadLine());
                    if (giris == fiyatlar[secim2 - 1])
                    {
                        Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);

                    }
                    else if (giris > fiyatlar[secim2 - 1])
                    {
                        para_üstü = giris - fiyatlar[secim2 - 1];
                        Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Para üstünüz:" + para_üstü);
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (giris < fiyatlar[secim2 - 1])
                    {
                    DON2:
                        Console.WriteLine("Para yetersiz\nPara eklemek ister misini?\nE\tH");
                        string giris2 = Console.ReadLine().ToUpper();
                        if (giris2 == "E")
                        {
                            Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                            double ek_tutar = Convert.ToDouble(Console.ReadLine());
                            giris += ek_tutar;

                            if (giris == fiyatlar[secim2 - 1])
                            {
                                Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                            else if (giris > fiyatlar[secim2 - 1])
                            {
                                para_üstü = giris - fiyatlar[secim2 - 1];
                                Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Para üstünüz:" + para_üstü);
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                            else if (giris < fiyatlar[secim2 - 1])
                            {
                                goto DON2;
                            }


                        }


                        else if (giris2 == "H")
                        {
                            Console.WriteLine("Sistemden çıkılıyor...");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (secim2 == 10)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün:" + isimler[secim2 - 1] + " " + "Fiyat:" + fiyatlar[secim2 - 1]);
                    Console.WriteLine("Lütfen para girişi yapınız:");

                    double giris = Convert.ToDouble(Console.ReadLine());
                    if (giris == fiyatlar[secim2 - 1])
                    {
                        Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);

                    }
                    else if (giris > fiyatlar[secim2 - 1])
                    {
                        para_üstü = giris - fiyatlar[secim2 - 1];
                        Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                        Console.WriteLine("Para üstünüz:" + para_üstü);
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (giris < fiyatlar[secim2 - 1])
                    {
                    DON2:
                        Console.WriteLine("Para yetersiz\nPara eklemek ister misini?\nE\tH");
                        string giris2 = Console.ReadLine().ToUpper();
                        if (giris2 == "E")
                        {
                            Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                            double ek_tutar = Convert.ToDouble(Console.ReadLine());
                            giris += ek_tutar;

                            if (giris == fiyatlar[secim2 - 1])
                            {
                                Console.WriteLine("Para yeterli ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);

                            }
                            else if (giris > fiyatlar[secim2 - 1])
                            {
                                para_üstü = giris - fiyatlar[secim2 - 1];
                                Console.WriteLine("Para yeteri ürün veriliyor lütfen bekleyiniz.");
                                Console.WriteLine("Para üstünüz:" + para_üstü);
                                Console.WriteLine("Sistemden çıkılıyor...");
                                System.Threading.Thread.Sleep(3000);
                                Environment.Exit(0);
                            }
                            else if (giris < fiyatlar[secim2 - 1])
                            {
                                goto DON2;
                            }


                        }


                        else if (giris2 == "H")
                        {
                            Console.WriteLine("Sistemden çıkılıyor...");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }


            }
            else if (secim == 2)
            {
                Console.Clear();
                int hak = 1;
                while (hak<4)
                {
                    Console.WriteLine("Admin şifresi giriniz:");
                    string admin_sifre=Console.ReadLine();
                    hak++;
                    if (admin_sifre==sifre)
                    {
                        break;
                    }
                    
                    if (hak==4)
                    {
                        
                        Console.WriteLine("Sifre Bloke oldu.");
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }


                }
                Console.Clear();
                Console.WriteLine("Ürün ekleme 1\nÜrün Güncelleme 2\nÜrün Silme 3\nFiyat Güncelleme 4");
                int secim2 = Convert.ToInt32(Console.ReadLine());
                if (secim2 == 1)
                {
                    boyutlandir++;
                    Array.Resize(ref isimler, boyutlandir);
                    Console.Clear();
                    Console.WriteLine("Ekleyeceğiniz ürünü giriniz:");
                    isimler[isimler.Length - 1] = Console.ReadLine();
                    DON3:
                    Console.WriteLine("Ana menü için 1\nÇıkış için 2");
                    int islem=Convert.ToInt32(Console.ReadLine());
                    if (islem == 1)
                    {
                        goto DON;
                    }
                    else if (islem == 2)
                    {
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir işlem giriniz.");
                        goto DON3;
                    }
                }
                else if (secim2 == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Fiyatını Güncellemek istediğiniz ürünü seçiniz:");
                    for (int i = 0; i <isimler.Length; i++)
                    {
                        Console.WriteLine(isimler[i] + " " + $"{i + 1}");
                    }
                    int islem = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ürün fiyatını girinzi:");
                    double fiyat = Convert.ToDouble(Console.ReadLine());
                    fiyatlar[islem - 1] = fiyat;
                    Console.WriteLine("Ana menü için 1\nÇıkış için 2");
                    int islem2 = Convert.ToInt32(Console.ReadLine());
                    if (islem2 == 1)
                    {
                        goto DON;
                    }
                    else if (islem2 == 2)
                    {
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }

                }
                else if (secim2== 3)
                {
                    Console.Clear();
                    Console.WriteLine("Silmek istedğiniz ürünü seçiniz:");
                    for (int i = 0; i < isimler.Length; i++)
                    {
                        Console.WriteLine(isimler[i] + " " + $"{i + 1}");
                    }

                    int girilen = Convert.ToInt32(Console.ReadLine());
                    int deger = girilen - 1;
                    Array.Clear(isimler,deger,girilen) ;
                    Array.Clear(fiyatlar, deger, girilen);
                    Console.WriteLine("Ana menü için 1\nÇıkış için 2");
                    int islem2 = Convert.ToInt32(Console.ReadLine());
                    if (islem2 == 1)
                    {
                        goto DON;
                    }
                    else if (islem2 == 2)
                    {
                        Console.WriteLine("Sistemden çıkılıyor...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }

                }

            }

            
            else if (secim == 3)
            
            {
                Console.WriteLine("Sistemden çıkılıyor...");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);

            }

            else
            {
                Console.WriteLine("Lütfen geçerli bir işlem yapınız.");
                goto DON;
            }


            Console.ReadLine();

            
        }
    }
}
