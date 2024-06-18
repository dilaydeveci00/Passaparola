using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e) // e harfi klavyeden herhangi bir tuşa atama işlemi yapmak için gerekli olan komutumuz.
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    //cevap 1
                    case 1:
                        if(textBox1.Text=="akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap 2
                    case 2:
                        if(textBox1.Text=="bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 3
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 4
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 8
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 9
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 10
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 11
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 12
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 13
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 14
                    case 14:
                        if (textBox1.Text == "mayıs")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 15
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 16
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 17
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 18
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 19
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 20
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 21
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 22
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 23
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //cevap 24
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;


                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox2.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;

            }
            if (soruno == 2)
            {
                richTextBox2.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox2.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox2.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox2.Text = "Yeni kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox2.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox2.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox2.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox2.Text = "Gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox2.Text = "Mersinin diğer ismi?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox2.Text = "Askeri bir topluluk?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox2.Text = "Malatyanın meşhur meyvesi?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox2.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox2.Text = "Yılın üçüncü ayı?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox2.Text = "Üflemeli bir müzik aleti?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox2.Text = "Halk şairi?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox2.Text = "Çocukların pek sevmediği pirinç , havuç gibi sebzeler ile yapılan yemek?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox2.Text = "11 ayın sultanı?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox2.Text = "İngilizcede yılan?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox2.Text = "Türkiyenin mega starı?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox2.Text = "Ümit kelimesinin eş anlamlısı?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox2.Text = "Kahvaltısı ile ünlü ilimiz?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox2.Text = "Şimşek kelimesinin eş anlamlısı?";
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox2.Text = "Ege bölgesinin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini?";
                button24.BackColor = Color.Yellow;
            }
        }
    }
}
