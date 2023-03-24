using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizikHesapApp
{
    public partial class Form1 : Form
    {
        public string Formul { get; set; }

        public Form1()
        {
            InitializeComponent();
            reset();
        }

        private void btn_Sifirla_Click(object sender, EventArgs e)
        {
            nud_Sonuc.Value = 0;
            nud_Formul1.Value = 0;
            nud_Formul2.Value = 0;
            nud_Formul3.Value = 0;
        }

        public void reset()
        {
            btn_Sifirla_Click(null, null);
            lbl_Hata.Text = "";
            lbl_Formul.Text = "";
            lbl_FormulOne.Text = "";
            lbl_FormulTwo.Text = "";
            lbl_FormulThree.Text = "";
            lbl_FormulFour.Text = "";
            nud_Formul1.Enabled = false;
            nud_Formul2.Enabled = false;
            nud_Formul3.Enabled = false;
            nud_Sonuc.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            Formul = "i=q/t";
            lbl_Formul.Text = "i=q/t";
            lbl_Islem1.Text = "/";
            lbl_FormulOne.Text = "i";
            lbl_FormulTwo.Text = "q";
            lbl_FormulThree.Text = "t";
            nud_Sonuc.Enabled = true;
            nud_Formul1.Enabled = true;
            nud_Formul2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reset();
            Formul = "R=ρ*l/A";
            lbl_Formul.Text = "R=ρ*l/A";
            lbl_Islem1.Text = "*";
            lbl_Islem2.Text = "/";
            lbl_FormulOne.Text = "R";
            lbl_FormulTwo.Text = "ρ";
            lbl_FormulThree.Text = "l";
            lbl_FormulFour.Text = "A";
            nud_Sonuc.Enabled = true;
            nud_Formul1.Enabled = true;
            nud_Formul2.Enabled = true;
            nud_Formul3.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reset();
            Formul = "V=i*R";
            lbl_Formul.Text = "V=i*R";
            lbl_Islem1.Text = "*";
            lbl_FormulOne.Text = "V";
            lbl_FormulTwo.Text = "i";
            lbl_FormulThree.Text = "R";
            nud_Sonuc.Enabled = true;
            nud_Formul1.Enabled = true;
            nud_Formul2.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
            Formul = "P=i*V";
            lbl_Formul.Text = "P=i*V";
            lbl_Islem1.Text = "*";
            lbl_FormulOne.Text = "P";
            lbl_FormulTwo.Text = "i";
            lbl_FormulThree.Text = "V";
            nud_Sonuc.Enabled = true;
            nud_Formul1.Enabled = true;
            nud_Formul2.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reset();
            Formul = "P=i²*R";
            lbl_Formul.Text = "P=i²*R";
            lbl_Islem1.Text = "*";
            lbl_FormulOne.Text = "P";
            lbl_FormulTwo.Text = "i²";
            lbl_FormulThree.Text = "R";
            nud_Sonuc.Enabled = true;
            nud_Formul1.Enabled = true;
            nud_Formul2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reset();
            Formul = "R=V/i";
            lbl_Formul.Text = "R=V/i";
            lbl_Islem1.Text = "/";
            lbl_FormulOne.Text = "R";
            lbl_FormulTwo.Text = "V";
            lbl_FormulThree.Text = "i";
            nud_Sonuc.Enabled = true;
            nud_Formul1.Enabled = true;
            nud_Formul2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
            Formul = "P=F/A";
            lbl_Formul.Text = "P=F/A";
            lbl_Islem1.Text = "/";
            lbl_FormulOne.Text = "P";
            lbl_FormulTwo.Text = "F";
            lbl_FormulThree.Text = "A";
            nud_Sonuc.Enabled = true;
            nud_Formul1.Enabled = true;
            nud_Formul2.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reset();
            Formul = "P=h*d*g";
            lbl_Formul.Text = "P=h*d*g";
            lbl_Islem1.Text = "*";
            lbl_Islem2.Text = "*";
            lbl_FormulOne.Text = "P";
            lbl_FormulTwo.Text = "h";
            lbl_FormulThree.Text = "d";
            lbl_FormulFour.Text = "g";
            nud_Sonuc.Enabled = true;
            nud_Formul1.Enabled = true;
            nud_Formul2.Enabled = true;
            nud_Formul3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset();
            Formul = "P=G/A";
            lbl_Formul.Text = "P=G/A";
            lbl_Islem1.Text = "/";
            lbl_FormulOne.Text = "P";
            lbl_FormulTwo.Text = "G";
            lbl_FormulThree.Text = "A";
            nud_Sonuc.Enabled = true;
            nud_Formul1.Enabled = true;
            nud_Formul2.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //λ=v/f
            reset();
            Formul = "λ=v/f";
            lbl_Formul.Text = "λ=v/f";
            lbl_Islem1.Text = "/";
            lbl_FormulOne.Text = "λ";
            lbl_FormulTwo.Text = "v";
            lbl_FormulThree.Text = "f";
            nud_Sonuc.Enabled = true;
            nud_Formul1.Enabled = true;
            nud_Formul2.Enabled = true;
        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            int bos = 0;

            if (nud_Sonuc.Value != 0) { bos++; }
            if (nud_Formul1.Value != 0) { bos++; }
            if (nud_Formul2.Value != 0) { bos++; }
            if (nud_Formul3.Value != 0) { bos++; }

            if (Formul == "i=q/t")
            {
                if (bos != 2)
                {
                    lbl_Hata.Text = "En Fazla Bir Değişken Boş Bırakılmalıdır";
                }
                else
                {
                    lbl_Hata.Text = "";
                    decimal i = nud_Sonuc.Value;
                    decimal q = nud_Formul1.Value;
                    decimal t = nud_Formul2.Value;

                    if (i == 0)
                    {
                        nud_Sonuc.Value = q / t;
                    }
                    else if (q == 0)
                    {
                        nud_Formul1.Value = i * t;
                    }
                    else
                    {
                        nud_Formul2.Value = q / i;
                    }
                }
            }

            else if (Formul == "R=ρ*l/A")
            {
                if (bos != 3)
                {
                    lbl_Hata.Text = "En Fazla Bir Değişken Boş Bırakılmalıdır";
                }
                else
                {
                    lbl_Hata.Text = "";
                    decimal R = nud_Sonuc.Value;
                    decimal ρ = nud_Formul1.Value;
                    decimal l = nud_Formul2.Value;
                    decimal A = nud_Formul3.Value;

                    if (R == 0)
                    {
                        nud_Sonuc.Value = ρ * l / A;
                    }
                    else if (ρ == 0)
                    {
                        nud_Formul1.Value = R * l / A;
                    }
                    else if (l == 0)
                    {
                        nud_Formul2.Value = (R / ρ) * (A);
                    }
                    else
                    {
                        nud_Formul3.Value = ρ / R * l;
                    }
                }

            }

            else if (Formul == "V=i*R")
            {
                if (bos != 2)
                {
                    lbl_Hata.Text = "En Fazla Bir Değişken Boş Bırakılmalıdır";
                }
                else
                {
                    lbl_Hata.Text = "";
                    decimal V = nud_Sonuc.Value;
                    decimal i = nud_Formul1.Value;
                    decimal R = nud_Formul2.Value;

                    if (V == 0)
                    {
                        nud_Sonuc.Value = i * R;
                    }
                    else if (i == 0)
                    {
                        nud_Formul1.Value = V / R;
                    }
                    else
                    {
                        nud_Formul2.Value = V / i;
                    }
                }
            }

            else if (Formul == "P=i*V")
            {
                if (bos != 2)
                {
                    lbl_Hata.Text = "En Fazla Bir Değişken Boş Bırakılmalıdır";
                }
                else
                {
                    lbl_Hata.Text = "";
                    decimal P = nud_Sonuc.Value;
                    decimal i = nud_Formul1.Value;
                    decimal V = nud_Formul2.Value;

                    if (P == 0)
                    {
                        nud_Sonuc.Value = i * V;
                    }
                    else if (i == 0)
                    {
                        nud_Formul1.Value = P / V;
                    }
                    else
                    {
                        nud_Formul2.Value = P / i;
                    }
                }
            }

            else if (Formul == "P=i²*R")
            {
                if (bos != 2)
                {
                    lbl_Hata.Text = "En Fazla Bir Değişken Boş Bırakılmalıdır";
                }
                else
                {
                    lbl_Hata.Text = "";
                    decimal P = nud_Sonuc.Value;
                    decimal i2 = nud_Formul1.Value;
                    decimal R = nud_Formul2.Value;

                    if (P == 0)
                    {
                        nud_Sonuc.Value = (i2 * i2) * R;
                    }
                    else if (i2 == 0)
                    {
                        nud_Formul1.Value = (P / R) / 2;
                    }
                    else
                    {
                        nud_Formul2.Value = (P / i2) / 2;
                    }
                }
            }

            else if (Formul == "R=V/i")
            {
                if (bos != 2)
                {
                    lbl_Hata.Text = "En Fazla Bir Değişken Boş Bırakılmalıdır";
                }
                else
                {
                    lbl_Hata.Text = "";
                    decimal R = nud_Sonuc.Value;
                    decimal V = nud_Formul1.Value;
                    decimal i = nud_Formul2.Value;

                    if (R == 0)
                    {
                        nud_Sonuc.Value = V / i;
                    }
                    else if (V == 0)
                    {
                        nud_Formul1.Value = R * i;
                    }
                    else
                    {
                        nud_Formul2.Value = V / R;
                    }
                }
            }

            else if (Formul == "P=F/A")
            {
                if (bos != 2)
                {
                    lbl_Hata.Text = "En Fazla Bir Değişken Boş Bırakılmalıdır";
                }
                else
                {
                    lbl_Hata.Text = "";
                    decimal P = nud_Sonuc.Value;
                    decimal F = nud_Formul1.Value;
                    decimal A = nud_Formul2.Value;

                    if (P == 0)
                    {
                        nud_Sonuc.Value = F / A;
                    }
                    else if (F == 0)
                    {
                        nud_Formul1.Value = P * A;
                    }
                    else
                    {
                        nud_Formul2.Value = F / P;
                    }
                }
            }

            else if (Formul == "P=h*d*g")
            {
                if (bos != 3)
                {
                    lbl_Hata.Text = "En Fazla Bir Değişken Boş Bırakılmalıdır";
                }
                else
                {
                    lbl_Hata.Text = "";
                    decimal P = nud_Sonuc.Value;
                    decimal h = nud_Formul1.Value;
                    decimal d = nud_Formul2.Value;
                    decimal g = nud_Formul3.Value;

                    if (P == 0)
                    {
                        nud_Sonuc.Value = h * d * g;
                    }
                    else if (h == 0)
                    {
                        nud_Formul1.Value = P / (d * g);
                    }
                    else if (d == 0)
                    {
                        nud_Formul2.Value = P / (g * h);
                    }
                    else
                    {
                        nud_Formul3.Value = P / (h * d);
                    }
                }

            }

            else if (Formul == "P=G/A")
            {
                if (bos != 2)
                {
                    lbl_Hata.Text = "En Fazla Bir Değişken Boş Bırakılmalıdır";
                }
                else
                {
                    lbl_Hata.Text = "";
                    decimal P = nud_Sonuc.Value;
                    decimal G = nud_Formul1.Value;
                    decimal A = nud_Formul2.Value;

                    if (P == 0)
                    {
                        nud_Sonuc.Value = G / A;
                    }
                    else if (G == 0)
                    {
                        nud_Formul1.Value = P * A;
                    }
                    else
                    {
                        nud_Formul2.Value = G / P;
                    }
                }
            }

            else if (Formul == "λ=v/f")
            {
                if (bos != 2)
                {
                    lbl_Hata.Text = "En Fazla Bir Değişken Boş Bırakılmalıdır";
                }
                else
                {
                    lbl_Hata.Text = "";
                    decimal λ = nud_Sonuc.Value;
                    decimal v = nud_Formul1.Value;
                    decimal f = nud_Formul2.Value;

                    if (λ == 0)
                    {
                        nud_Sonuc.Value = v / f;
                    }
                    else if (v == 0)
                    {
                        nud_Formul1.Value = λ * f;
                    }
                    else
                    {
                        nud_Formul2.Value = v / λ;
                    }
                }
            }
        }
        
    }
}
