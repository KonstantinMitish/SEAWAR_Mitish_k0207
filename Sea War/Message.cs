using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Security.Cryptography;
namespace Sea_War
{
    public partial class Message_FRM : Form
    {
        public Message_FRM()
        {
            InitializeComponent();
        }
        public bool ended = false;
        public bool loaded = false;
        public string secretcode = "fjdlncbe4km843i586e79834gnvepokun";
        public SoundPlayer theme = new SoundPlayer(Properties.Resources.message_theme);
           public SoundPlayer tip = new SoundPlayer(Properties.Resources.message1);
        private void Message_Load(object sender, EventArgs e)
        {
            //Расстановка элэметов
            this.Width = SystemInformation.PrimaryMonitorSize.Width / 3;
            this.Height = SystemInformation.PrimaryMonitorSize.Height;
            this.Top = 0;
            this.Left = SystemInformation.PrimaryMonitorSize.Width / 3;
            lbl_MSg.Width = SystemInformation.PrimaryMonitorSize.Width / 3;
            lbl_MSg.Top = 0;
            lbl_MSg.Left = 0;
            //lbl_MSg.Height = SystemInformation.PrimaryMonitorSize.Height / 3;
            //pic_fon.Top = 0;
            //pic_fon.Left =0;
            //pic_fon.Width = SystemInformation.PrimaryMonitorSize.Width / 3;
            //pic_fon.Height = SystemInformation.PrimaryMonitorSize.Height;
            btn_Again.Top = (SystemInformation.PrimaryMonitorSize.Height / 3) * 2;
            btn_Menu.Top = (SystemInformation.PrimaryMonitorSize.Height / 3) * 2;
            btn_Again.Width = (SystemInformation.PrimaryMonitorSize.Width / 3)/2;
            btn_Menu.Width = (SystemInformation.PrimaryMonitorSize.Width / 3)/2;
            btn_Menu.Left = ((SystemInformation.PrimaryMonitorSize.Width / 3) - btn_Menu.Width - btn_Again.Width) / 3;
            btn_Again.Left = (btn_Menu.Left * 2 + btn_Menu.Width);
            btn_res.Top = btn_Menu.Top + btn_Menu.Height;
            btn_res.Left = 0;
            btn_res.Width = SystemInformation.PrimaryMonitorSize.Width / 3;
            btn_Load.Width = SystemInformation.PrimaryMonitorSize.Width / 3;
            btn_Save.Width = SystemInformation.PrimaryMonitorSize.Width / 3;
            btn_Load.Top = btn_Menu.Top - btn_Load.Height;
            btn_Save.Top = btn_Load.Top - btn_Save.Height;
            btn_Save.Left = 0;
            btn_Load.Left = 0;
            textBox1.Top = lbl_MSg.Top + lbl_MSg.Height;
            textBox1.Width = SystemInformation.PrimaryMonitorSize.Width / 3;
            textBox1.Left = 0;
            textBox1.Text = SystemInformation.UserName;
            dlg_save.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
            dlg_load.InitialDirectory = dlg_save.InitialDirectory;
       }
        public void addscore(string name, int score)
        {//Запись результата в файл
            if (ended)
            {
                FileStream myFile;
                myFile = new FileStream("Score", FileMode.Append);
                StreamWriter myfile_1;
                myfile_1 = new StreamWriter(myFile, Encoding.UTF8);
                string abc;
                abc = name + "-@-" + score.ToString();
                myfile_1.WriteLine(abc);
                myfile_1.Close();
            }
        }
        int sc = 0;
        public void SetMessage(string mes,int score)
        {//Установка текста
            lbl_MSg.Text = mes;
            sc = score;
            if (mes.Contains("победили") || mes.Contains("проиграли"))
            {
                textBox1.Visible = true;
                ended = true;
            }
            else
            {
                ended = false;
            }
            
        }
        public bool res = true;
        public bool restart = true;
        private void btn_Again_Click(object sender, EventArgs e)
        {
            //Тык по кнопке "Заново"
            addscore(textBox1.Text, sc);
            restart = true;
            res = false;
            loaded = false;
            tip.Stop();
            theme.Stop();
            this.Hide();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            //Тык по кнопке "Меню" 
            addscore(textBox1.Text, sc);
            restart = false;
            res = false;
            loaded = false;
            tip.Stop();
            theme.Stop();
            this.Hide();
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            //Тык по кнопке "Продолжить" 
            restart = false;
            res = true;
            loaded = false;
            tip.Stop();
            theme.Stop();
            this.Hide();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            //Тык по кнопке "Загрузить" 
            dlg_load.ShowDialog();
        }
        public Byte[, ,] ShipstoSave = new byte[2, 20, 20];
        public Byte[, ,] ShipsLoaded = new byte[2, 20, 20]; 
        private void dlg_save_FileOk(object sender, CancelEventArgs e)
        {//Загрузка сохранения
            string FtoWrite1 = "";
            string FtoWrite2 = "";
            for (int i2 = 0; i2 < 10; i2++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    FtoWrite1 += ShipstoSave[1, i2, i3].ToString();
                }
            }
            for (int i2 = 0; i2 < 10; i2++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    FtoWrite1 += ShipstoSave[0, i2, i3].ToString();
                }
            }

            FtoWrite1 += doptosave;
            FtoWrite2 = Encrypt(FtoWrite1, secretcode);


            ShipstoSave = null;

            FileStream myFile;
            myFile = new FileStream(dlg_save.FileName, FileMode.Append);
            StreamWriter myfile_1;
            myfile_1 = new StreamWriter(myFile, Encoding.UTF8);
            string abc;
            abc = FtoWrite2;
            myfile_1.Write(abc);
            myfile_1.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Тык по кнопке "Сохранить" 
            DateTime dt = DateTime.Now;
            dlg_save.FileName = SystemInformation.UserName + " (" + dt.Year + "-" + dt.Month + "-" + dt.Day + "-" + dt.Hour + "-" + dt.Minute + "-" + dt.Second + ")";
            dlg_save.ShowDialog();
        }
        public string doptosave = "";
        public string doploaded = "";
        private void dlg_load_FileOk(object sender, CancelEventArgs e)
        {//Сохранение
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
            restart = false;
            res = true;
            loaded = true;
            tip.Stop();
            theme.Stop();
            this.Hide();
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
