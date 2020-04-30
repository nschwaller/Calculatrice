using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premier_projet_calculatrice_reseau
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
            for (int i = 2; i < 5; i++)
            {
                c1.Items.Add(i + " sous réseaux");
            }

        }

        int[] bina = { 128, 64, 32, 16, 8, 4, 2, 1 };
        char[] convert1 = new char[8];
        char[] convert2 = new char[8];
        char[] convert3 = new char[8];
        char[] convert4 = new char[8];
        char[] convert11 = new char[8];
        char[] convert22 = new char[8];
        char[] convert33 = new char[8];
        char[] convert44 = new char[8];
        char[] convere11 = new char[8];
        char[] convere22 = new char[8];
        char[] convere33 = new char[8];
        char[] convere44 = new char[8];
        int ip1;
        int ip2;
        int ip3;
        int ip4;
        int masquee;
        char[] le = new char[32];

        //convertir une ip en bianaire
        public char[] convertir(int valeur)
        {
            char[] convert = new char[8];
            if (valeur>255)
            {
                MessageBox.Show("valeur supérieur à 255, veuillez refaire votre saisie");
            }
            else
            {
                for(int i=0;i<bina.Length;i++)
                {
                    if((valeur>bina[i])||(valeur==bina[i]))
                    {
                        convert[i] = '1';
                        valeur = valeur - bina[i];
                    }
                    else
                    {
                        convert[i] = '0';
                    }
                }
            }
            return convert;
        }


        //bouton valider de l'onglet 1
        private void button1_Click(object sender, EventArgs e)
        {
            
            string contenu="  ";
            string contenu2 = " ";
            string contenu3 = " ";
            int valeur1=0;
            int valeur2=0;
            int valeur3=0;
            int valeur4=0;

            if ((tb1.Text == "") || (tb2.Text == "") || (tb3.Text == "") || (tb4.Text == "") || (tb5.Text == ""))
            {
                MessageBox.Show("Vous n'avez pas remplit toute les cases");
            }
            else
            {
                ip1 = Convert.ToInt16(tb1.Text);
                ip2 = Convert.ToInt16(tb2.Text);
                ip3 = Convert.ToInt16(tb3.Text);
                ip4 = Convert.ToInt16(tb4.Text);
                masquee = Convert.ToInt16(tb5.Text);
                //convertir premiere partie de l'ip
                convert1 = convertir(ip1);
                contenu = "" + convert1[0] + convert1[1] + convert1[2] + convert1[3] + " " + convert1[4] + convert1[5] + convert1[6] + convert1[7];
                lb6.Text = contenu;
                contenu = " ";
                label7.Text = " . ";

                //convertir deuxieme partie de l'ip
                convert2 = convertir(ip2);
                contenu = "" + convert2[0] + convert2[1] + convert2[2] + convert2[3] + " " + convert2[4] + convert2[5] + convert2[6] + convert2[7];
                lb11.Text = contenu;
                contenu = " ";
                label10.Text = " . ";

                //convertir troisieme partie de l'ip
                convert3 = convertir(ip3);
                contenu = "" + convert3[0] + convert3[1] + convert3[2] + convert3[3] + " " + convert3[4] + convert3[5] + convert3[6] + convert3[7];
                lb7.Text = contenu;
                contenu = " ";
                label11.Text = " . ";

                //convertir quatrieme partie de l'ip
                convert4 = convertir(ip4);
                contenu = "" + convert4[0] + convert4[1] + convert4[2] + convert4[3] + " " + convert4[4] + convert4[5] + convert4[6] + convert4[7];
                lb10.Text = contenu;

                masque(masquee);
                label6.Text = "ET";

                //affichage du masque
                for (int i = 0; i < 4; i++)
                {
                    contenu2 += le[i];
                }
                contenu2 += " ";
                for (int i = 4; i < 8; i++)
                {
                    contenu2 += le[i];
                }

                label18.Text = ".";
                label8.Text = contenu2;

                contenu2 = "  ";
                for (int i = 8; i < 12; i++)
                {
                    contenu2 += le[i];
                }
                contenu2 += " ";
                for (int i = 12; i < 16; i++)
                {
                    contenu2 += le[i];
                }

                label17.Text = ".";
                label12.Text = contenu2;

                contenu2 = "  ";
                for (int i = 16; i < 20; i++)
                {
                    contenu2 += le[i];
                }
                contenu2 += " ";
                for (int i = 20; i < 24; i++)
                {
                    contenu2 += le[i];
                }

                label16.Text = ".";
                label13.Text = contenu2;

                contenu2 = "  ";
                for (int i = 24; i < 28; i++)
                {
                    contenu2 += le[i];
                }
                contenu2 += " ";
                for (int i = 28; i < 32; i++)
                {
                    contenu2 += le[i];
                }

                label14.Text = contenu2;

                int j = 0;

                //ET logique test si y a 1 et 1 des deux cote
                for (int i = 0; i < 8; i++)
                {
                    if ((convert1[i] == '1') && (le[i] == '1'))
                    {
                        convert11[i] = '1';
                        valeur1 += bina[i];
                    }
                    else
                    {
                        convert11[i] = '0';
                    }
                }

                for (int i = 8; i < 16; i++)
                {
                    if ((convert2[j] == '1') && (le[i] == '1'))
                    {
                        convert22[j] = '1';
                        valeur2 += bina[j];
                    }
                    else
                    {
                        convert22[j] = '0';
                    }
                    j++;
                }
                j = 0;
                for (int i = 16; i < 24; i++)
                {
                    if ((convert3[j] == '1') && (le[i] == '1'))
                    {
                        convert33[j] = '1';
                        valeur3 += bina[j];
                    }
                    else
                    {
                        convert33[j] = '0';
                    }
                    j++;
                }
                j = 0;
                for (int i = 24; i < 32; i++)
                {

                    if ((convert4[j] == '1') && (le[i] == '1'))
                    {
                        convert44[j] = '1';
                        valeur4 += bina[j];
                    }
                    else
                    {
                        convert44[j] = '0';
                    }
                    j++;
                }

                label22.Text = "---------------------------------------------------------------------------------------------------------";

                //affichage ET logique 
                contenu3 = "" + convert11[0] + convert11[1] + convert11[2] + convert11[3] + " " + convert11[4] + convert11[5] + convert11[6] + convert11[7];
                label9.Text = contenu3;

                label23.Text = ".";

                contenu3 = "" + convert22[0] + convert22[1] + convert22[2] + convert22[3] + " " + convert22[4] + convert22[5] + convert22[6] + convert22[7];
                label15.Text = contenu3;

                label24.Text = ".";

                contenu3 = "" + convert33[0] + convert33[1] + convert33[2] + convert33[3] + " " + convert33[4] + convert33[5] + convert33[6] + convert33[7];
                label19.Text = contenu3;

                label25.Text = ".";

                contenu3 = "" + convert44[0] + convert44[1] + convert44[2] + convert44[3] + " " + convert44[4] + convert44[5] + convert44[6] + convert44[7];
                label20.Text = contenu3;

                contenu3 = "Votre réseau est " + valeur1 + " . " + valeur2 + " . " + valeur3 + " . " + valeur4 + "  /" + masquee;
                label21.Text = contenu3;
            }
          }



            // calculer le masque
            public void masque(int masquee)
            {
                if(masquee>32)
                {
                    MessageBox.Show("Votre masque n'est pas bon");
                }
                else
                {
                    for(int i=0;i<masquee;i++)
                    {
                        le[i] = '1';
                    }

                    for (int i = masquee; i < le.Length; i++)
                    {
                        le[i] = '0';
                    }   
                }
        }
    
        //premier pc dernier pc
        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == ""))
            {
                MessageBox.Show("Vous n'avez pas remplit toute les cases");
            }
            else
            {
                int jp1 = Convert.ToInt16(textBox1.Text);
                int jp2 = Convert.ToInt16(textBox2.Text);
                int jp3 = Convert.ToInt16(textBox3.Text);
                int jp4 = Convert.ToInt16(textBox4.Text);
                masquee = Convert.ToInt16(textBox5.Text);
                char[] convere1 = new char[8];
                char[] convere2 = new char[8];
                char[] convere3 = new char[8];
                char[] convere4 = new char[8];
                string contenu;

                //premiere partie ip
                convere1 = convertir(jp1);
                contenu = "" + convere1[0] + convere1[1] + convere1[2] + convere1[3] + " " + convere1[4] + convere1[5] + convere1[6] + convere1[7];
                //label65.Text = lecontenu(convere1[]);
                label65.Text = contenu;
                label59.Text = contenu;
                contenu = " ";

                //deuxieme partie ip
                convere2 = convertir(jp2);
                contenu = "" + convere2[0] + convere2[1] + convere2[2] + convere2[3] + " " + convere2[4] + convere2[5] + convere2[6] + convere2[7];
                label34.Text = contenu;
                label32.Text = contenu;
                contenu = " ";

                //troisieme partie ip
                convere3 = convertir(jp3);
                contenu = "" + convere3[0] + convere3[1] + convere3[2] + convere3[3] + " " + convere3[4] + convere3[5] + convere3[6] + convere3[7];
                label37.Text = contenu;
                label54.Text = contenu;
                contenu = " ";

                //quatrieme reseau
                convere4 = convertir(jp4);
                contenu = "" + convere4[0] + convere4[1] + convere4[2] + convere4[3] + " " + convere4[4] + convere4[5] + convere4[6] + convere4[7];
                label57.Text = contenu;
                label68.Text = contenu;
                contenu = " ";

                //convertir masque
                masque(masquee);

                contenu = "1";

                //calcul premier pc
                for (int i = 1; i < 4; i++)
                {
                    contenu += le[i];
                }
                contenu += " ";
                for (int i = 4; i < 8; i++)
                {
                    contenu += le[i];
                }
                label38.Text = contenu;

                contenu = "  ";
                for (int i = 8; i < 12; i++)
                {
                    contenu += le[i];
                }
                contenu += " ";
                for (int i = 12; i < 16; i++)
                {
                    contenu += le[i];
                }
                label36.Text = contenu;

                contenu = "  ";
                for (int i = 16; i < 20; i++)
                {
                    contenu += le[i];
                }
                contenu += " ";
                for (int i = 20; i < 24; i++)
                {
                    contenu += le[i];
                }
                label66.Text = contenu;

                contenu = "  ";
                for (int i = 24; i < 28; i++)
                {
                    contenu += le[i];
                }
                contenu += " ";
                for (int i = 28; i < 31; i++)
                {
                    contenu += le[i];
                }

                le[31] = '1';
                contenu += le[31];
                label39.Text = contenu;

                int j = 0;

                int valeur1 = 0;
                int valeur2 = 0;
                int valeur3 = 0;
                int valeur4 = 0;

                //affichage premier pc
                for (int i = 0; i < 8; i++)
                {
                    if ((convere1[i] == '1') && (le[i] == '1'))
                    {
                        convere11[i] = '1';
                        valeur1 += bina[i];
                    }
                    else
                    {
                        convere11[i] = '0';
                    }
                }

                for (int i = 8; i < 16; i++)
                {
                    if ((convere2[j] == '1') && (le[i] == '1'))
                    {
                        convere22[j] = '1';
                        valeur2 += bina[j];
                    }
                    else
                    {
                        convere22[j] = '0';
                    }
                    j++;
                }
                j = 0;
                for (int i = 16; i < 24; i++)
                {
                    if ((convere3[j] == '1') && (le[i] == '1'))
                    {
                        convere33[j] = '1';
                        valeur3 += bina[j];
                    }
                    else
                    {
                        convere33[j] = '0';
                    }
                    j++;
                }
                j = 0;
                for (int i = 24; i < 31; i++)
                {

                    if ((convere4[j] == '1') && (le[i] == '1'))
                    {
                        convere44[j] = '1';
                        valeur4 += bina[j];
                    }
                    else
                    {
                        convere44[j] = '0';
                    }
                    j++;
                }

                convere44[7] = '1';
                valeur4 += 1;

                contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                label50.Text = contenu;

                label61.Text = Convert.ToString(valeur1);

                contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                label49.Text = contenu;

                label81.Text = Convert.ToString(valeur2);


                contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                label48.Text = contenu;

                label62.Text = Convert.ToString(valeur3);

                contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                label45.Text = contenu;

                label63.Text = Convert.ToString(valeur4);

                char[] la = new char[32];

                for (int i= 0;i<le.Length;i++)
                {
                    la[i] = le[i];
                }

                for(int i=masquee;i<31;i++)
                {
                    le[i] = '1';
                }

                    le[31] = '0';

                contenu = "";

                //calcul dernier pc
                for (int i = 0; i < 4; i++)
                {
                    contenu += le[i];
                }
                contenu += " ";
                for (int i = 4; i < 8; i++)
                {
                    contenu += le[i];
                }
                label35.Text = contenu;

                contenu = "  ";
                for (int i = 8; i < 12; i++)
                {
                    contenu += le[i];
                }
                contenu += " ";
                for (int i = 12; i < 16; i++)
                {
                    contenu += le[i];
                }
                label56.Text = contenu;

                contenu = "  ";
                for (int i = 16; i < 20; i++)
                {
                    contenu += le[i];
                }
                contenu += " ";
                for (int i = 20; i < 24; i++)
                {
                    contenu += le[i];
                }
                label53.Text = contenu;

                contenu = "  ";
                for (int i = 24; i < 28; i++)
                {
                    contenu += le[i];
                }
                contenu += " ";
                for (int i = 28; i < 32; i++)
                {
                    contenu += le[i];
                }

                
                label52.Text = contenu;

                j = 0;

                valeur1 = 0;
                valeur2 = 0;
                valeur3 = 0;
                valeur4 = 0;

                //afficahge dernier pc
                for (int i = 0; i < 8; i++)
                {
                    if ((convere1[i] == '1') && (la[i] == '1') && (le[i] == '1'))
                    {
                        convere11[i] = '1';
                        valeur1 += bina[i];
                    }
                    else
                    {
                        if (((convere1[i] == '1') || (convere1[i] == '0')) && (la[i] == '0') && (le[i] == '1'))
                        {
                            convere11[i] = '1';
                            valeur1 += bina[i];
                        }
                        else
                        {
                            convere11[i] = '0';
                        }
                    }
                }

                for (int i = 8; i < 16; i++)
                {
                    if ((convere2[j] == '1') && (la[i] == '1') && (le[i] == '1'))
                    {
                        convere22[j] = '1';
                        valeur2 += bina[j];
                    }
                    else
                    {
                        if (((convere2[j] == '1') || (convere2[j] == '0')) && (la[i] == '0') && (le[i] == '1'))
                        {
                            convere22[j] = '1';
                            valeur2 += bina[j];
                        }
                        else
                        {
                            convere22[j] = '0';
                        }
                    }
                    j++;
                }
                j = 0;
                for (int i = 16; i < 24; i++)
                {
                    if ((convere3[j] == '1') && (la[i] == '1') && (le[i] == '1'))
                    {
                        convere33[j] = '1';
                        valeur3 += bina[j];
                    }
                    else
                    {
                        if (((convere3[j] == '1') || (convere3[j] == '0')) && (la[i] == '0') && (le[i] == '1'))
                        {
                            convere33[j] = '1';
                            valeur3 += bina[j];
                        }
                        else
                        {
                            convere33[j] = '0';
                        }
                    }
                    j++;
                }
                j = 0;
                for (int i = 24; i < 31; i++)
                {

                    if ((convere4[j] == '1') && (le[i] == '1') && (la[i] == '1'))
                    {
                        convere44[j] = '1';
                        valeur4 += bina[j];
                    }
                    else
                    {
                        if (((convere4[j] == '1') || (convere4[j] == '0')) && (la[i] == '0') && (le[i] == '1'))
                        {

                            convere44[j] = '1';
                            valeur4 += bina[j];
                        }
                        else
                        {
                            convere44[j] = '0';
                        }
                    }
                    j++;
                }

               

                convere44[7] = '0';

                contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                label43.Text = contenu;

                label64.Text = Convert.ToString(valeur1);

                contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                label42.Text = contenu;

                label55.Text = Convert.ToString(valeur2);

                contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                label41.Text = contenu;

                label58.Text = Convert.ToString(valeur3);

                contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                label47.Text = contenu;

                label33.Text = Convert.ToString(valeur4);

                label83.Text = Convert.ToString(masquee);
                label84.Text = Convert.ToString(masquee);

                panel1.Visible = true;
            }

        }

        //sous reseau   
        private void button3_Click(object sender, EventArgs e)
        {
            if ((t1.Text == "") || (t2.Text == "") || (t3.Text == "") || (t4.Text == "") || (t5.Text == "") || (c1.SelectedIndex == -1))
            {
                MessageBox.Show("Il vous manque une info");
            }
            else
            {

                int reseau;
                int jp1 = Convert.ToInt16(t1.Text);
                int jp2 = Convert.ToInt16(t2.Text);
                int jp3 = Convert.ToInt16(t3.Text);
                int jp4 = Convert.ToInt16(t4.Text);
                masquee = Convert.ToInt16(t5.Text);
                int lemasque;
                reseau = (c1.SelectedIndex + 2);
                char[] convere1 = new char[8];
                char[] convere2 = new char[8];
                char[] convere3 = new char[8];
                char[] convere4 = new char[8];
                char[] la = new char[32];
                convere1 = convertir(jp1);
                convere2 = convertir(jp2);
                convere3 = convertir(jp3);
                convere4 = convertir(jp4);
                string contenu;
                int valeur1 = 0;
                int valeur2 = 0;
                int valeur3 = 0;
                int valeur4 = 0;

                masque(masquee);
                contenu = "" + convere1[0] + convere1[1] + convere1[2] + convere1[3] + " " + convere1[4] + convere1[5] + convere1[6] + convere1[7];
                t11.Text = contenu;
                contenu = "" + convere2[0] + convere2[1] + convere2[2] + convere2[3] + " " + convere2[4] + convere2[5] + convere2[6] + convere2[7];
                t22.Text = contenu;
                contenu = "" + convere3[0] + convere3[1] + convere3[2] + convere3[3] + " " + convere3[4] + convere3[5] + convere3[6] + convere3[7];
                t33.Text = contenu;
                contenu = "" + convere4[0] + convere4[1] + convere4[2] + convere4[3] + " " + convere4[4] + convere4[5] + convere4[6] + convere4[7];
                t44.Text = contenu;

                //deux sous réseaux
                if (reseau == 2)
                {
                    lemasque = masquee + 1;

                    int j = 0;
                    //premier sous réseau
                    if (lemasque > 32)
                    {
                        MessageBox.Show("Votre masque n'est pas bon pour deux sous réseaux");
                    }
                    else
                    {
                        for (int i = 0; i < la.Length; i++)
                        {
                            la[i] = '2';
                        }

                        la[lemasque - 1] = '0';
                    }


                    for (int i = 0; i < 8; i++)
                    {
                        if ((convere1[i] == '1') && (le[i] == '1'))
                        {
                            convere11[i] = '1';
                            valeur1 += bina[i];
                        }
                        else
                        {
                            convere11[i] = '0';
                        }
                        if (la[i] == '0')
                        {
                            convere11[i] = '0';
                        }

                    }

                    for (int i = 8; i < 16; i++)
                    {
                        if ((convere2[j] == '1') && (le[i] == '1'))
                        {
                            convere22[j] = '1';
                            valeur2 += bina[j];
                        }
                        else
                        {
                            convere22[j] = '0';
                        }
                        if (la[i] == '0')
                        {
                            convere22[j] = '0';
                        }
                        j++;
                    }
                    j = 0;
                    for (int i = 16; i < 24; i++)
                    {
                        if ((convere3[j] == '1') && (le[i] == '1'))
                        {
                            convere33[j] = '1';
                            valeur3 += bina[j];
                        }
                        else
                        {
                            convere33[j] = '0';
                        }
                        if (la[i] == '0')
                        {
                            convere33[j] = '0';
                        }
                        j++;
                    }
                    j = 0;
                    for (int i = 24; i < 32; i++)
                    {

                        if ((convere4[j] == '1') && (le[i] == '1'))
                        {
                            convere44[j] = '1';
                            valeur4 += bina[j];
                        }
                        else
                        {
                            convere44[j] = '0';
                        }
                        if (la[i] == '0')
                        {
                            convere44[j] = '0';
                        }
                        j++;
                    }

                    contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                    label112.Text = contenu;

                    contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                    label396.Text = contenu;

                    contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                    label397.Text = contenu;

                    contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                    label398.Text = contenu;

                    label420.Text = "" + valeur1 + " . " + valeur2 + " . " + valeur3 + " . " + valeur4 + " /" + lemasque;

                    panel2.Visible = true;

                    //deuxieme sous réseaux
                    if (lemasque > 32)
                    {
                        MessageBox.Show("Votre masque n'est pas bon pour deux sous réseaux");
                    }
                    else
                    {
                        for (int i = 0; i < la.Length; i++)
                        {
                            la[i] = '2';
                        }

                        la[lemasque - 1] = '1';


                        valeur1 = 0;
                        valeur2 = 0;
                        valeur3 = 0;
                        valeur4 = 0;

                        for (int i = 0; i < 8; i++)
                        {
                            if ((convere1[i] == '1') && (le[i] == '1'))
                            {
                                convere11[i] = '1';
                                valeur1 += bina[i];
                            }
                            else
                            {
                                convere11[i] = '0';
                            }
                            if (la[i] == '1')
                            {
                                convere11[i] = '1';
                                valeur1 += bina[i];
                            }

                        }
                        j = 0;
                        for (int i = 8; i < 16; i++)
                        {
                            if ((convere2[j] == '1') && (le[i] == '1'))
                            {
                                convere22[j] = '1';
                                valeur2 += bina[j];
                            }
                            else
                            {
                                convere22[j] = '0';
                            }
                            if (la[i] == '1')
                            {
                                convere22[j] = '1';
                                valeur2 += bina[j];
                            }
                            j++;
                        }
                        j = 0;
                        for (int i = 16; i < 24; i++)
                        {
                            if ((convere3[j] == '1') && (le[i] == '1'))
                            {
                                convere33[j] = '1';
                                valeur3 += bina[j];
                            }
                            else
                            {
                                convere33[j] = '0';
                            }
                            if (la[i] == '1')
                            {
                                convere33[j] = '1';
                                valeur3 += bina[j];
                            }
                            j++;
                        }
                        j = 0;
                        for (int i = 24; i < 32; i++)
                        {

                            if ((convere4[j] == '1') && (le[i] == '1'))
                            {
                                convere44[j] = '1';
                                valeur4 += bina[j];
                            }
                            else
                            {
                                convere44[j] = '0';
                            }
                            if (la[i] == '1')
                            {
                                convere44[j] = '1';
                                valeur4 += bina[j];
                            }
                        }

                        contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                        label111.Text = contenu;

                        contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                        label399.Text = contenu;

                        contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                        label400.Text = contenu;

                        contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                        label401.Text = contenu;

                        label421.Text = "" + valeur1 + " . " + valeur2 + " . " + valeur3 + " . " + valeur4 + " /" + lemasque;
                        panel3.Visible = false;
                        panel4.Visible = false;
                        label422.Text = "";

                    }
                }
                else
                {   //3 sous réseaux 
                    if (reseau == 3)
                    {
                        label113.Text = "3 Sous Réseaux";
                        lemasque = masquee + 2;

                        int j = 0;
                        //premier sous réseau
                        if (lemasque > 32)
                        {
                            MessageBox.Show("Votre masque n'est pas bon pour trois sous réseaux");
                        }
                        else
                        {
                            for (int i = 0; i < la.Length; i++)
                            {
                                la[i] = '2';
                            }

                            la[lemasque - 2] = '0';
                            la[lemasque - 1] = '0';

                            valeur1 = 0;
                            valeur2 = 0;
                            valeur3 = 0;
                            valeur4 = 0;


                            for (int i = 0; i < 8; i++)
                            {
                                if ((convere1[i] == '1') && (le[i] == '1'))
                                {
                                    convere11[i] = '1';
                                    valeur1 += bina[i];
                                }
                                else
                                {
                                    convere11[i] = '0';
                                }
                                if (la[i] == '0')
                                {
                                    convere11[i] = '0';
                                }

                            }

                            for (int i = 8; i < 16; i++)
                            {
                                if ((convere2[j] == '1') && (le[i] == '1'))
                                {
                                    convere22[j] = '1';
                                    valeur2 += bina[j];
                                }
                                else
                                {
                                    convere22[j] = '0';
                                }
                                if (la[i] == '0')
                                {
                                    convere22[j] = '0';
                                }
                                j++;
                            }
                            j = 0;
                            for (int i = 16; i < 24; i++)
                            {
                                if ((convere3[j] == '1') && (le[i] == '1'))
                                {
                                    convere33[j] = '1';
                                    valeur3 += bina[j];
                                }
                                else
                                {
                                    convere33[j] = '0';
                                }
                                if (la[i] == '0')
                                {
                                    convere33[j] = '0';
                                }
                                j++;
                            }
                            j = 0;
                            for (int i = 24; i < 32; i++)
                            {

                                if ((convere4[j] == '1') && (le[i] == '1'))
                                {
                                    convere44[j] = '1';
                                    valeur4 += bina[j];
                                }
                                else
                                {
                                    convere44[j] = '0';
                                }
                                if (la[i] == '0')
                                {
                                    convere44[j] = '0';
                                }
                                j++;
                            }

                            contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                            label112.Text = contenu;

                            contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                            label396.Text = contenu;

                            contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                            label397.Text = contenu;

                            contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                            label398.Text = contenu;

                            label420.Text = "" + valeur1 + " . " + valeur2 + " . " + valeur3 + " . " + valeur4 + " /" + lemasque;

                            panel2.Visible = true;

                            //deuxieme sous réseau
                            for (int i = 0; i < la.Length; i++)
                            {
                                la[i] = '2';
                            }

                            la[lemasque - 2] = '0';
                            la[lemasque - 1] = '1';

                            j = 0;
                            valeur1 = 0;
                            valeur2 = 0;
                            valeur3 = 0;
                            valeur4 = 0;

                            for (int i = 0; i < 8; i++)
                            {
                                if ((convere1[i] == '1') && (le[i] == '1'))
                                {
                                    convere11[i] = '1';
                                    valeur1 += bina[i];
                                }
                                else
                                {
                                    convere11[i] = '0';
                                }
                                if (la[i] == '0')
                                {
                                    convere11[i] = '0';
                                }
                                if (la[i] == '1')
                                {
                                    convere11[i] = '1';
                                    valeur1 += bina[i];

                                }

                            }

                            for (int i = 8; i < 16; i++)
                            {
                                if ((convere2[j] == '1') && (le[i] == '1'))
                                {
                                    convere22[j] = '1';
                                    valeur2 += bina[j];
                                }
                                else
                                {
                                    convere22[j] = '0';
                                }
                                if (la[i] == '0')
                                {
                                    convere22[j] = '0';
                                }
                                if (la[i] == '1')
                                {
                                    convere22[j] = '1';
                                    valeur2 += bina[j];

                                }
                                j++;
                            }
                            j = 0;
                            for (int i = 16; i < 24; i++)
                            {
                                if ((convere3[j] == '1') && (le[i] == '1'))
                                {
                                    convere33[j] = '1';
                                    valeur3 += bina[j];
                                }
                                else
                                {
                                    convere33[j] = '0';
                                }
                                if (la[i] == '0')
                                {
                                    convere33[j] = '0';
                                }
                                if (la[i] == '1')
                                {
                                    convere33[j] = '1';
                                    valeur3 += bina[j];

                                }
                                j++;
                            }
                            j = 0;
                            for (int i = 24; i < 32; i++)
                            {

                                if ((convere4[j] == '1') && (le[i] == '1'))
                                {
                                    convere44[j] = '1';
                                    valeur4 += bina[j];
                                }
                                else
                                {
                                    convere44[j] = '0';
                                }
                                if (la[i] == '0')
                                {
                                    convere44[j] = '0';
                                }
                                if (la[i] == '1')
                                {
                                    convere44[j] = '1';
                                    valeur4 += bina[j];

                                }
                                j++;
                            }
                            contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                            label111.Text = contenu;

                            contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                            label399.Text = contenu;

                            contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                            label400.Text = contenu;

                            contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                            label401.Text = contenu;

                            label421.Text = "" + valeur1 + " . " + valeur2 + " . " + valeur3 + " . " + valeur4 + " /" + lemasque;


                            //troisieme sous réseaux
                            for (int i = 0; i < la.Length; i++)
                            {
                                la[i] = '2';
                            }

                            la[lemasque - 2] = '1';
                            la[lemasque - 1] = '1';

                            j = 0;

                            valeur1 = 0;
                            valeur2 = 0;
                            valeur3 = 0;
                            valeur4 = 0;
                            for (int i = 0; i < 8; i++)
                            {
                                if ((convere1[i] == '1') && (le[i] == '1'))
                                {
                                    convere11[i] = '1';
                                    valeur1 += bina[i];
                                }
                                else
                                {
                                    convere11[i] = '0';
                                }
                                if (la[i] == '1')
                                {
                                    convere11[i] = '1';
                                    valeur1 += bina[i];

                                }

                            }

                            for (int i = 8; i < 16; i++)
                            {
                                if ((convere2[j] == '1') && (le[i] == '1'))
                                {
                                    convere22[j] = '1';
                                    valeur2 += bina[j];
                                }
                                else
                                {
                                    convere22[j] = '0';
                                }
                                if (la[i] == '1')
                                {
                                    convere22[j] = '1';
                                    valeur2 += bina[j];

                                }
                                j++;
                            }
                            j = 0;
                            for (int i = 16; i < 24; i++)
                            {
                                if ((convere3[j] == '1') && (le[i] == '1'))
                                {
                                    convere33[j] = '1';
                                    valeur3 += bina[j];
                                }
                                else
                                {
                                    convere33[j] = '0';
                                }
                                if (la[i] == '1')
                                {
                                    convere33[j] = '1';
                                    valeur3 += bina[j];

                                }
                                j++;
                            }
                            j = 0;
                            for (int i = 24; i < 32; i++)
                            {

                                if ((convere4[j] == '1') && (le[i] == '1'))
                                {
                                    convere44[j] = '1';
                                    valeur4 += bina[j];
                                }
                                else
                                {
                                    convere44[j] = '0';
                                }
                                if (la[i] == '1')
                                {
                                    convere44[j] = '1';
                                    valeur4 += bina[j];

                                }
                                j++;
                            }

                            contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                            label110.Text = contenu;

                            contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                            label402.Text = contenu;

                            contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                            label403.Text = contenu;

                            contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                            label404.Text = contenu;

                            label422.Text = "" + valeur1 + " . " + valeur2 + " . " + valeur3 + " . " + valeur4 + " /" + lemasque;

                            panel3.Visible = true;
                            panel4.Visible = false;

                        }
                    }
                    else
                    {
                        if (reseau == 4)
                        {
                            label113.Text = "4 Sous Réseaux";
                            lemasque = masquee + 2;

                            int j = 0;
                            //premier sous réseau
                            if (lemasque > 32)
                            {
                                MessageBox.Show("Votre masque n'est pas bon pour quatre sous réseaux");
                            }
                            else
                            {
                                for (int i = 0; i < la.Length; i++)
                                {
                                    la[i] = '2';
                                }

                                la[lemasque - 2] = '0';
                                la[lemasque - 1] = '0';

                                valeur1 = 0;
                                valeur2 = 0;
                                valeur3 = 0;
                                valeur4 = 0;


                                for (int i = 0; i < 8; i++)
                                {
                                    if ((convere1[i] == '1') && (le[i] == '1'))
                                    {
                                        convere11[i] = '1';
                                        valeur1 += bina[i];
                                    }
                                    else
                                    {
                                        convere11[i] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere11[i] = '0';
                                    }

                                }

                                for (int i = 8; i < 16; i++)
                                {
                                    if ((convere2[j] == '1') && (le[i] == '1'))
                                    {
                                        convere22[j] = '1';
                                        valeur2 += bina[j];
                                    }
                                    else
                                    {
                                        convere22[j] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere22[j] = '0';
                                    }
                                    j++;
                                }
                                j = 0;
                                for (int i = 16; i < 24; i++)
                                {
                                    if ((convere3[j] == '1') && (le[i] == '1'))
                                    {
                                        convere33[j] = '1';
                                        valeur3 += bina[j];
                                    }
                                    else
                                    {
                                        convere33[j] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere33[j] = '0';
                                    }
                                    j++;
                                }
                                j = 0;
                                for (int i = 24; i < 32; i++)
                                {

                                    if ((convere4[j] == '1') && (le[i] == '1'))
                                    {
                                        convere44[j] = '1';
                                        valeur4 += bina[j];
                                    }
                                    else
                                    {
                                        convere44[j] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere44[j] = '0';
                                    }
                                    j++;
                                }

                                contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                                label112.Text = contenu;

                                contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                                label396.Text = contenu;

                                contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                                label397.Text = contenu;

                                contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                                label398.Text = contenu;

                                label420.Text = "" + valeur1 + " . " + valeur2 + " . " + valeur3 + " . " + valeur4 + " /" + lemasque;

                                panel2.Visible = true;

                                //deuxieme sous réseau
                                for (int i = 0; i < la.Length; i++)
                                {
                                    la[i] = '2';
                                }

                                la[lemasque - 2] = '0';
                                la[lemasque - 1] = '1';

                                j = 0;
                                valeur1 = 0;
                                valeur2 = 0;
                                valeur3 = 0;
                                valeur4 = 0;

                                for (int i = 0; i < 8; i++)
                                {
                                    if ((convere1[i] == '1') && (le[i] == '1'))
                                    {
                                        convere11[i] = '1';
                                        valeur1 += bina[i];
                                    }
                                    else
                                    {
                                        convere11[i] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere11[i] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere11[i] = '1';
                                        valeur1 += bina[i];

                                    }

                                }

                                for (int i = 8; i < 16; i++)
                                {
                                    if ((convere2[j] == '1') && (le[i] == '1'))
                                    {
                                        convere22[j] = '1';
                                        valeur2 += bina[j];
                                    }
                                    else
                                    {
                                        convere22[j] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere22[j] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere22[j] = '1';
                                        valeur2 += bina[j];

                                    }
                                    j++;
                                }
                                j = 0;
                                for (int i = 16; i < 24; i++)
                                {
                                    if ((convere3[j] == '1') && (le[i] == '1'))
                                    {
                                        convere33[j] = '1';
                                        valeur3 += bina[j];
                                    }
                                    else
                                    {
                                        convere33[j] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere33[j] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere33[j] = '1';
                                        valeur3 += bina[j];

                                    }
                                    j++;
                                }
                                j = 0;
                                for (int i = 24; i < 32; i++)
                                {

                                    if ((convere4[j] == '1') && (le[i] == '1'))
                                    {
                                        convere44[j] = '1';
                                        valeur4 += bina[j];
                                    }
                                    else
                                    {
                                        convere44[j] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere44[j] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere44[j] = '1';
                                        valeur4 += bina[j];

                                    }
                                    j++;
                                }
                                contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                                label111.Text = contenu;

                                contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                                label399.Text = contenu;

                                contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                                label400.Text = contenu;

                                contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                                label401.Text = contenu;

                                label421.Text = "" + valeur1 + " . " + valeur2 + " . " + valeur3 + " . " + valeur4 + " /" + lemasque;


                                //troisieme sous réseaux
                                for (int i = 0; i < la.Length; i++)
                                {
                                    la[i] = '2';
                                }

                                la[lemasque - 2] = '1';
                                la[lemasque - 1] = '1';

                                j = 0;

                                valeur1 = 0;
                                valeur2 = 0;
                                valeur3 = 0;
                                valeur4 = 0;
                                for (int i = 0; i < 8; i++)
                                {
                                    if ((convere1[i] == '1') && (le[i] == '1'))
                                    {
                                        convere11[i] = '1';
                                        valeur1 += bina[i];
                                    }
                                    else
                                    {
                                        convere11[i] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere11[i] = '1';
                                        valeur1 += bina[i];

                                    }

                                }

                                for (int i = 8; i < 16; i++)
                                {
                                    if ((convere2[j] == '1') && (le[i] == '1'))
                                    {
                                        convere22[j] = '1';
                                        valeur2 += bina[j];
                                    }
                                    else
                                    {
                                        convere22[j] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere22[j] = '1';
                                        valeur2 += bina[j];

                                    }
                                    j++;
                                }
                                j = 0;
                                for (int i = 16; i < 24; i++)
                                {
                                    if ((convere3[j] == '1') && (le[i] == '1'))
                                    {
                                        convere33[j] = '1';
                                        valeur3 += bina[j];
                                    }
                                    else
                                    {
                                        convere33[j] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere33[j] = '1';
                                        valeur3 += bina[j];

                                    }
                                    j++;
                                }
                                j = 0;
                                for (int i = 24; i < 32; i++)
                                {

                                    if ((convere4[j] == '1') && (le[i] == '1'))
                                    {
                                        convere44[j] = '1';
                                        valeur4 += bina[j];
                                    }
                                    else
                                    {
                                        convere44[j] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere44[j] = '1';
                                        valeur4 += bina[j];

                                    }
                                    j++;
                                }

                                contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                                label110.Text = contenu;

                                contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                                label402.Text = contenu;

                                contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                                label403.Text = contenu;

                                contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                                label404.Text = contenu;

                                label422.Text = "" + valeur1 + " . " + valeur2 + " . " + valeur3 + " . " + valeur4 + " /" + lemasque;

                                panel3.Visible = true;

                                //quatrieme sous réseaux

                                for (int i = 0; i < la.Length; i++)
                                {
                                    la[i] = '2';
                                }

                                la[lemasque - 2] = '1';
                                la[lemasque - 1] = '0';

                                valeur1 = 0;
                                valeur2 = 0;
                                valeur3 = 0;
                                valeur4 = 0;

                                j = 0;


                                for (int i = 0; i < 8; i++)
                                {
                                    if ((convere1[i] == '1') && (le[i] == '1'))
                                    {
                                        convere11[i] = '1';
                                        valeur1 += bina[i];
                                    }
                                    else
                                    {
                                        convere11[i] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere11[i] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere11[i] = '1';
                                        valeur1 += bina[i];
                                    }

                                }

                                for (int i = 8; i < 16; i++)
                                {
                                    if ((convere2[j] == '1') && (le[i] == '1'))
                                    {
                                        convere22[j] = '1';
                                        valeur2 += bina[j];
                                    }
                                    else
                                    {
                                        convere22[j] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere22[j] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere22[j] = '1';
                                        valeur2 += bina[j];
                                    }
                                    j++;
                                }
                                j = 0;
                                for (int i = 16; i < 24; i++)
                                {
                                    if ((convere3[j] == '1') && (le[i] == '1'))
                                    {
                                        convere33[j] = '1';
                                        valeur3 += bina[j];
                                    }
                                    else
                                    {
                                        convere33[j] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere33[j] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere33[j] = '1';
                                        valeur3 += bina[j];
                                    }
                                    j++;
                                }
                                j = 0;
                                for (int i = 24; i < 32; i++)
                                {

                                    if ((convere4[j] == '1') && (le[i] == '1'))
                                    {
                                        convere44[j] = '1';
                                        valeur4 += bina[j];
                                    }
                                    else
                                    {
                                        convere44[j] = '0';
                                    }
                                    if (la[i] == '0')
                                    {
                                        convere44[j] = '0';
                                    }
                                    if (la[i] == '1')
                                    {
                                        convere44[j] = '1';
                                        valeur4 += bina[j];
                                    }
                                    j++;
                                }

                                contenu = "" + convere11[0] + convere11[1] + convere11[2] + convere11[3] + " " + convere11[4] + convere11[5] + convere11[6] + convere11[7];
                                label205.Text = contenu;

                                contenu = "" + convere22[0] + convere22[1] + convere22[2] + convere22[3] + " " + convere22[4] + convere22[5] + convere22[6] + convere22[7];
                                label405.Text = contenu;

                                contenu = "" + convere33[0] + convere33[1] + convere33[2] + convere33[3] + " " + convere33[4] + convere33[5] + convere33[6] + convere33[7];
                                label406.Text = contenu;

                                contenu = "" + convere44[0] + convere44[1] + convere44[2] + convere44[3] + " " + convere44[4] + convere44[5] + convere44[6] + convere44[7];
                                label407.Text = contenu;

                                label106.Text = "" + valeur1 + " . " + valeur2 + " . " + valeur3 + " . " + valeur4 + " /" + lemasque;

                                panel4.Visible = true;

                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void c1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}