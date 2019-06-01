using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_War
{
    public partial class Menu_frm : Form
    {
        MainForm Game = new MainForm();
        public Menu_frm()
        {
            InitializeComponent();
            playtheme();//Воспроизведение музыки
        }
        public void playtheme()//Метод воспроизведения музыки
        {
            theme.PlayLooping();
        }
        SoundPlayer theme = new SoundPlayer(Properties.Resources.Menu);
        private void Menu_Load(object sender, EventArgs e)
        {//Расстановка элэментов
            btn_Play.Top = SystemInformation.PrimaryMonitorSize.Height - btn_Play.Height*2;
            btn_Exit.Top = SystemInformation.PrimaryMonitorSize.Height - btn_Play.Height*2;
            btn_Play.Width = SystemInformation.PrimaryMonitorSize.Width/2;
            btn_Play.Left = btn_Play.Width;
            btn_Exit.Left = 0;
            btn_load.Top = SystemInformation.PrimaryMonitorSize.Height - btn_Play.Height;
            btn_load.Left = btn_Play.Left;
            btn_load.Width = btn_Play.Width;
            btn_Exit.Width = SystemInformation.PrimaryMonitorSize.Width/2;
            panel_enemy.Top = SystemInformation.PrimaryMonitorSize.Height / 3;
            panel_own.Top = panel_enemy.Top;
            panel_own.Left = (SystemInformation.PrimaryMonitorSize.Width - (panel_own.Width + panel_enemy.Width)) / 3;
            panel_enemy.Left = (panel_own.Left * 2) + panel_own.Width;
            btn_back.Left = 0;
            btn_back.Top = SystemInformation.PrimaryMonitorSize.Height-btn_back.Height;
            btn_Play_toGame.Top = btn_back.Top;
            btn_Play_toGame.Width = SystemInformation.PrimaryMonitorSize.Width-btn_back.Width;
            btn_Play_toGame.Left = btn_back.Width;
            btn_Play_toGame.Height = btn_back.Height;
            label1.Width = SystemInformation.PrimaryMonitorSize.Width;
            label1.Top = panel_own.Top - label2.Height - label1.Height;
            label2.Width = panel_own.Width;
            label3.Width = panel_enemy.Width;
            label1.Left = 0;
            label2.Left = panel_own.Left;
            label3.Left = panel_enemy.Left;
            label2.Top = panel_own.Top - label2.Height;
            label3.Top = panel_enemy.Top - label3.Height;
            btn_score.Left = 0;
            btn_score.Width = SystemInformation.PrimaryMonitorSize.Width;
            btn_score.Top = btn_Play.Top - btn_score.Height;
            lst_score_name.Top = 0;
            lst_score_name.Left = 0;
            lst_score_name.Width = (SystemInformation.PrimaryMonitorSize.Width / 2) + ((SystemInformation.PrimaryMonitorSize.Width / 6)*2);
            lst_score_score.Top = 0;
            lst_score_score.Left = lst_score_name.Width;
            lst_score_score.Width = (SystemInformation.PrimaryMonitorSize.Width / 6) * 2;
            lst_score_score.Height = SystemInformation.PrimaryMonitorSize.Height - btn_back_score.Height;
         lst_score_name.Height=lst_score_score.Height;
         btn_score_clear.Width = SystemInformation.PrimaryMonitorSize.Width/2;
         btn_score_clear.Top = lst_score_score.Height;
         btn_score_clear.Left = 0;
         btn_score_clear.Height = btn_back_score.Height;
         btn_back_score.Left = SystemInformation.PrimaryMonitorSize.Width / 2;
         btn_score_clear.Top = lst_score_score.Height;
         btn_back_score.Top = lst_score_score.Height;
         btn_back_score.Width = SystemInformation.PrimaryMonitorSize.Width/2;

        }
        
        private void btn_Play_Click(object sender, EventArgs e)
        {//Смена интерфейса
            btn_Exit.Visible=false;
            btn_score.Visible = false;
            btn_Play.Visible = false;
            btn_load.Visible = false;
            btn_back.Visible = true;
            panel_own.Visible = true;
            panel_enemy.Visible= true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            btn_Play_toGame.Visible = true;
        }
//Задание назвний
        private void pic_Spanish_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ob in panel_own.Controls)
            {
                ob.BackgroundImage = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Flag_" + ob.Tag.ToString()));
            }
            ((PictureBox)sender).BackgroundImage = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Flag_" + ((PictureBox)sender).Tag.ToString() + "1"));
            Game.Team_Own = ((PictureBox)sender).Tag.ToString();
        }

        private void pic_Russian2_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ob in panel_enemy.Controls)
            {
                ob.BackgroundImage = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Flag_" + ob.Tag.ToString()));
            }
            ((PictureBox)sender).BackgroundImage = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Flag_" + ((PictureBox)sender).Tag.ToString() + "1"));
            Game.Team_Enemy = ((PictureBox)sender).Tag.ToString();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {//Смена интерфейса
            btn_Exit.Visible = true;
            btn_Play.Visible = true;
            btn_score.Visible = true;
            btn_load.Visible = true;
            btn_back.Visible = false;
            panel_own.Visible = false;
            panel_enemy.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            btn_Play_toGame.Visible = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {//Закрытие программы
            Application.Exit();
        }

        private void btn_Play_toGame_Click(object sender, EventArgs e)
        {
            theme.Stop();//Остановка музыки
 //this.Hide();
            Game.ShowDialog();//Открытие формы с игрой
            playtheme();//После закрытия формы с игрой
            
            btn_back_Click(sender, e); //Смена интерфейса
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            if (File.Exists("Score"))//Проверка наличия Посл. игроков
            {
                readscore();
                //Смена интерфейса
                btn_back_score.Visible = true;
                lst_score_score.Visible = true;
                lst_score_name.Visible = true;
                btn_score_clear.Visible = true;
                btn_score.Visible = false;
                btn_Play.Visible = false;
                btn_Exit.Visible = false;
            }
            else
            {
                btn_score.Text = "ИГРОКИ НЕ НАЙДЕНЫ";
                btn_back_score_delay.Start();
            }
        }
        public void readscore()//Чтение последних резутьтатов
        {
            List<string> name = new List<string>();
            List<string> score = new List<string>();
            lst_score_name.Items.Clear();
            lst_score_score.Items.Clear();
            StreamReader myfile;
            myfile = new StreamReader("Score", Encoding.UTF8);
            string abc;
            while ((abc = myfile.ReadLine()) != null)
            {
                name.Add(abc.Substring(0, abc.IndexOf("-@-")));
                score.Add(abc.Substring((abc.IndexOf("-@-") + 3)));
            }
            myfile.Close();
            int d = 0;
            if (name.Count <= 13)
            {
                d = 0;
            }
            else
            {
                d =name.Count- 13;
            }
            //Запись последних разультатов
            lst_score_name.Items.Add("Имя");
            lst_score_name.Items.Add("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            lst_score_score.Items.Add("Счет");
            lst_score_score.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------");

            for (int i = name.Count; i > d; i--)
            {
                lst_score_name.Items.Add(name[i - 1]);
            }
            for (int i = score.Count; i > d; i--)
            {
                lst_score_score.Items.Add(score[i - 1]);
            }
        }
        private void btn_back_score_Click(object sender, EventArgs e)
        {
            //Смена интерфейса
            btn_back_score.Visible = false;
            lst_score_score.Visible = false;
            lst_score_name.Visible = false;
            btn_score_clear.Visible = false;
            btn_score.Visible = true;
            btn_Play.Visible = true;
            btn_Exit.Visible = true;

        }
        //Синхронизайия Списков
        bool mousedowned = false;
        private void lst_score_name_MouseDown(object sender, MouseEventArgs e)
        {
            mousedowned = true;
            lst_score_name_MouseMove(sender, e);
        }

        private void lst_score_score_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowned = false;
        }

        private void lst_score_name_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowned)
            {
                lst_score_score.SelectedIndex = ((ListBox)sender).SelectedIndex;
                lst_score_name.SelectedIndex = ((ListBox)sender).SelectedIndex;
            }
        }
        //Очистка игроков
        private void btn_score_clear_Click(object sender, EventArgs e)
        {
            if (File.Exists("Score"))
            {
                File.Delete("Score");

            }
            btn_back_score_Click(sender, e);
        }

        private void btn_back_score_delay_Tick(object sender, EventArgs e)
        {
            btn_score.Text = "ПОСЛЕДНИЕ ИГРОКИ";
            btn_back_score_delay.Stop();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //Тык по кнопке "Загрузить" 
            dlg_load.ShowDialog();
            Game.Focus();
        }
        public Byte[, ,] ShipsLoaded = new byte[2, 20, 20];
        public string doploaded = "";
        string secretcode = "fjdlncbe4km843i586e79834gnvepokun";
        private void dlg_load_FileOk(object sender, CancelEventArgs e)
        {
            //Загрузка сохранения
            string Floaded = "";
            StreamReader myfile;
            myfile = new StreamReader(dlg_load.FileName, Encoding.UTF8);
            string abc;
            abc = myfile.ReadToEnd();
            myfile.Close();
            Floaded = Decrypt(abc, secretcode);
            int i = 0;
            for (int i2 = 0; i2 < 10; i2++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    ShipsLoaded[1, i2, i3] = Byte.Parse(Floaded[i].ToString());
                    i++;
                }
            }
            for (int i2 = 0; i2 < 10; i2++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    ShipsLoaded[0, i2, i3] = Byte.Parse(Floaded[i].ToString());
                    i++;
                }
            }
            doploaded = Floaded.Substring(i);
            theme.Stop();
            Game.loadgame(ShipsLoaded, doploaded);
        }
        #region Шифроване
        public static string Decrypt(string cipherText, string password,
   string salt = "Kosher", string hashAlgorithm = "SHA1",
   int passwordIterations = 2, string initialVector = "OFRna73m*aze01xY",
    int keySize = 256)
        {
            if (string.IsNullOrEmpty(cipherText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int byteCount = 0;

            using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream(cipherTextBytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                    {
                        byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
        }
        public static string Encrypt(string plainText, string password,
             string salt = "Kosher", string hashAlgorithm = "SHA1",
           int passwordIterations = 2, string initialVector = "OFRna73m*aze01xY",
            int keySize = 256)
        {
            if (string.IsNullOrEmpty(plainText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] cipherTextBytes = null;

            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }
        #endregion
    }
}
