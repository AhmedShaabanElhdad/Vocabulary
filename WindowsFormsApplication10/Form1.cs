using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;


namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speak(English.Text);
        }

        private void English_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(English.Text, "^[a-zA-Z0-9]*$"))
            {
                English.Text = "";
                label3.Text = "Please Enter English Letter";
            }
            else
                label3.Text = "";
        }

        private void Arabic_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Arabic.Text == "" || English.Text == "")
            { MessageBox.Show("Please don't let any textBox Empty");return; }
            if (search(English.Text))
            {
                MessageBox.Show("THis Word Existed");
                return;
            }

            try
            {
                Write(Directory.GetCurrentDirectory() + "\\English.txt",English.Text);
                Write(Directory.GetCurrentDirectory() + "\\Arabic.txt" ,Arabic.Text);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void View_Click(object sender, EventArgs e)
        {
            try
            {
                read(Directory.GetCurrentDirectory() + "\\English.txt",lstbEnglish);
                read(Directory.GetCurrentDirectory() + "\\Arabic.txt",lstbArabic);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lstbEnglish_SelectedIndexChanged(object sender, EventArgs e)
        {
            speak(lstbEnglish.Text);
        }

        public void read(string path,ListBox lstbox)
        {
            StreamReader Reader = new StreamReader(path);
            while (!Reader.EndOfStream)
                lstbox.Items.Add(Reader.ReadLine());
            Reader.Close();
        }
        public void Write(string path, string writeTo)
        {
            StreamWriter Write = new StreamWriter(path, true);
            Write.WriteLine(writeTo);
            Write.Close();
        }
        public bool search(string word) 
        {
            StreamReader Reader = new StreamReader(Directory.GetCurrentDirectory() + "\\English.txt");
            while (!Reader.EndOfStream)
            {
                if (Reader.ReadLine() == word)
                {
                    Reader.Close();
                    return true;
                }
            }
            Reader.Close();
            return true;
        }
        public void speak(string word)
        {
            try
            {
                SpeechSynthesizer voice = new SpeechSynthesizer();
                switch (cmbbox.SelectedIndex)
                {
                    case 0:
                        voice.SelectVoiceByHints(VoiceGender.NotSet);
                        break;
                    case 1:
                        voice.SelectVoiceByHints(VoiceGender.Male);
                        break;
                    case 2:
                        voice.SelectVoiceByHints(VoiceGender.Female);
                        break;
                    case 3:
                        voice.SelectVoiceByHints(VoiceGender.Neutral);
                        break;
                    default:
                        voice.SelectVoiceByHints(VoiceGender.NotSet);
                        break;
                }
                voice.SpeakAsync(word);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
