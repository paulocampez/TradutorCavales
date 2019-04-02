using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradutorCavales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var replace = replacingConsonants(txtPt.Text);

            txtCavalo.Text = replace;
        }


        static bool isVowel(char ch)
        {
            if (ch != 'a' && ch != 'e' && ch != 'i'
                && ch != 'o' && ch != 'u')
                return false;

            return true;
        }


        static String replacingConsonants(String s)
        {
            for (int i = 0; i < s.Length; i++)
            {

                if (isVowel(s[i]))
                    continue;

                else
                {
                    if (s.Length.Equals(i + 1) || s[i + 1] == ' ')
                    {
                        continue;
                    }
                    else if (s[i] == 't')
                    {
                        continue;
                    }
                    else if (s[i] > 'a' && s[i] < 'e')
                    {

                        if (Math.Abs(s[i] - 'a') > Math.Abs(s[i] - 'e'))
                            s = s.Substring(0, i) + 'g' + s.Substring(i + 1);
                        else
                            s = s.Substring(0, i) + 'g' + s.Substring(i + 1);
                    }
                    else if (s[i] > 'e' && s[i] < 'i')
                    {
                        if (Math.Abs(s[i] - 'e') > Math.Abs(s[i] - 'i'))
                            s = s.Substring(0, i) + "gu" + s.Substring(i + 1);
                        else
                            s = s.Substring(0, i) + "gu" + s.Substring(i + 1);
                    }
                    else if (s[i] > 'i' && s[i] < 'o')
                    {
                        if (Math.Abs(s[i] - 'i') > Math.Abs(s[i] - 'o'))
                            s = s.Substring(0, i) + "gu" + s.Substring(i + 1);
                        else
                            s = s.Substring(0, i) + "gu" + s.Substring(i + 1);
                    }
                    else if (s[i] > 'o' && s[i] < 'u')
                    {
                        if (Math.Abs(s[i] - 'o') > Math.Abs(s[i] - 'u'))
                            s = s.Substring(0, i) + 'g' + s.Substring(i + 1);
                        else
                            s = s.Substring(0, i) + 'g' + s.Substring(i + 1);
                    }

                    else if (s[i] > 'u')
                        s = s.Substring(0, i) + 'g' + s.Substring(i + 1);
                }
            }

            return s;
        }

    }
}
