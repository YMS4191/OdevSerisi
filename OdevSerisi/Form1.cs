﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace OdevSerisi
{
    public partial class Form1 : MetroForm
    { 
        /*
         1) Kullanıcı çekiliş yap butonuna tıkladığında sol baştan başlayarak, 1 ile 49 arasında(49 dahil ) sayı üretecek.
         2) her bi kutuda toplamda 10 adet sayı gösterildikten sonra, 10. üretilen sayı ekrana sabitlecek ve dizi içerisinde tutulacak.
         3) 2. kutudan itibaren 10. sırada gelen sayı daha önce üretildiyse, yeni bir sayı üretilecek ve benzersiz olana kadar bu işlem devam edecek.
         4) 6 kutuda benzersiz sayı üretildikten sonra küçükten büyüğe doğru sıralama yapılacak ve ekrana yazdırılacak.
         5) kullanıcı çekiliş yap dediğinde ekran eski haline gelip tekrar çekiliş yapabilecek ( kullanıcı işlem devam ederkende yeniden başlatabilir.)
             */
        public Form1()
        {
            InitializeComponent();
        }
    }
}
