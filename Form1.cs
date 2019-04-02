using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.TextToSpeech.V1;

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

            txtCavalo.Text = replace.Replace("gg","g");
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                    
                    else if (s[i] == 't' || s[i] == 'n')
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

        private void FalaDoGoogle(object sender, EventArgs e)
        {
            TextToSpeechClient client = TextToSpeechClient.Create();

            SynthesisInput input = new SynthesisInput
            {
                Text = txtCavalo.Text
            };
            VoiceSelectionParams voice = new VoiceSelectionParams
            {
                LanguageCode = "pt-BR",
                SsmlGender = SsmlVoiceGender.Female
            };

            // Select the type of audio file you want returned.
            AudioConfig config = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Mp3
            };

            // Perform the Text-to-Speech request, passing the text input
            // with the selected voice parameters and audio file type
            var response = client.SynthesizeSpeech(new SynthesizeSpeechRequest
            {
                Input = input,
                Voice = voice,
                AudioConfig = config
            });

            // Write the binary AudioContent of the response to an MP3 file.
            using (Stream output = File.Create("sample.mp3"))
            {
                response.AudioContent.WriteTo(output);
                Console.WriteLine($"Audio content written to file 'sample.mp3'");
            }
        }

    }
}
