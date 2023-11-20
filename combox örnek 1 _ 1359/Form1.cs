﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combox_örnek_1___1359
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//formu çalıştırır
            //20 sayıyı burada oluşturabiliriz.metot bilgisi gerekiyor
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {  
            cmbÇiftSayılar.Items.Clear();
            //rastgele oluşturulmuş olan sayılarıdan çift olanlarını aktar
            for (int i = 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(lbSayilar.Items[i]);
                if(sayi % 2  == 0)
                {
                    cmbÇiftSayılar.Items.Add(sayi);
                }
                  
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //rastgele 20 sayı oluştur 
            Random rnd = new Random(); 

            for (int i = 0; i < 20 ; i++)
            {
                lbSayilar.Items.Add(rnd.Next(1,101));
            }

        }
    }
}
