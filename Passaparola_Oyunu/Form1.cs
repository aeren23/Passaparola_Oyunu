using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                       if(textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "akdeniz")
                            {
                                button1.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button1.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 2:
                        if(textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "bursa")
                            {
                                button2.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "cuma")
                            {
                                button3.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button3.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "diyarbakır")
                            {
                                button4.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "eskişehir")
                            {
                                button5.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button5.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "ferman")
                            {
                                button6.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "güneş")
                            {
                                button7.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button7.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "harikalar")
                            {
                                button8.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "ısparta")
                            {
                                button9.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "iltica")
                            {
                                button10.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button10.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "jinekomasti")
                            {
                                button11.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button11.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "kayısı")
                            {
                                button12.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button12.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "lale")
                            {
                                button13.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button13.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "mart")
                            {
                                button14.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button14.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "ney")
                            {
                                button15.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button15.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "ozan")
                            {
                                button16.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button16.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "paragraf")
                            {
                                button17.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button17.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "ruin")
                            {
                                button18.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button18.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "sahil")
                            {
                                button19.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button19.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "tarkan")
                            {
                                button20.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button20.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "umut")
                            {
                                button21.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button21.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "van")
                            {
                                button22.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button22.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "yıldırım")
                            {
                                button23.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Uyarı!! Bir cevap girmelisiniz");
                        }
                        else
                        {
                            if (textBox1.Text.ToLower() == "zonguldak")
                            {
                                button24.BackColor = Color.Green;
                                dogru++;
                            }
                            else
                            {
                                button24.BackColor = Color.Red;
                                yanlis++;
                            }
                            label2.Text = dogru.ToString();
                            label4.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;

                    default:
                        break;

                }
            }
        }

        private void linkLable1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLable1.Text = "Sonraki";
            textBox1.Visible = true;
            soruno++;
            this.Text="Soru No:"+soruno.ToString();

            if(soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü Marmara ilimiz?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Porsuk nehrine sahip ilimiz?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Kurtlar Vadisinde, Çakırın hapiste Bastonuyla öldürdüğü adam kimdir?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın enerji kaynağı olan cisim?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Alice .......... diyarında?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Laiklik elden gidiyeahh ......... geliyeahh?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = " Erkeklerde iyi huylu, aşırı meme gelişimi?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Osmanlı'da yaşanan 'zevk ve sefa' devri olarak bilinen devir?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli çalgı?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairlerine verilen genel isim?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "HTML'de P etiketi neyi ifade eder?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "İngilizcede mahvetmek anlamına gelen kelime?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Beach kelimesinin anlamı nedir?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Geçcek geçcek buda geçcek....";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamı?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Göz renkleri farkından dolayı ünlü kediye sahip il?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Zeus ne tanrısıdır?";
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Kömürüm de kömürüm?";
                button24.BackColor = Color.Yellow;
            }

        }
    }
}
