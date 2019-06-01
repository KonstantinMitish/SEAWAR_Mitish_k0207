using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Sea_War
{
    public partial class MainForm : Form
    {
        Message_FRM Msg = new Message_FRM();
        SoundPlayer theme = new SoundPlayer(Properties.Resources.theme);
        public string Team_Own = "Spanish";
        public string Team_Enemy = "Britan";
        public Byte[, ,] Ships = new byte[2, 20, 20];
        //0-own
        //1-emeny
        //0-ничего
        //1-промах
        //2-корабль
        //3-сбитый корабль
        public MainForm()
        {
            InitializeComponent();
        }
        Bitmap Ship_Own;
        Bitmap Fail;
        Bitmap Flag_O;
        Bitmap Flag_E;
        Bitmap Ship_Enemy;
        Bitmap Ship_Own_B;
        Bitmap Ship_Enemy_B;
        private void MainForm_Load(object sender, EventArgs e)
        {
            START();
        }
        public void START()
        {

            for (int i = 0; i <= 150; i++)
            {
                Ships[0, i / 10, i % 10] = 0;
                Ships[1, i / 10, i % 10] = 0;

            }
            //Расстановка элэментов
            this.BackgroundImage = Properties.Resources.bg;
            theme.PlayLooping();
            lbl_score_E.Text = "10";
            lbl_score_O.Text = "10";
            rasst = true;
            rasstN = 1;
            vistrel_O = 0;
            vistrel_E = 0;
            popad_O = 0;
            popad_E = 0;
            CommandLine.Top = SystemInformation.PrimaryMonitorSize.Height - CommandLine.Height;
            CommandLine.Left = SystemInformation.PrimaryMonitorSize.Width / 2;
            CommandLine.Width = SystemInformation.PrimaryMonitorSize.Width / 2;
            pic_ships_enemy.BackgroundImage = Properties.Resources.water;
            pic_ships_own.BackgroundImage = Properties.Resources.water;
            Flag_E = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Flag_" + Team_Enemy));
            Flag_O = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Flag_" + Team_Own));
            Fail = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Fail"));
            Ship_Own = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Ship_" + Team_Own));
            Ship_Enemy = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Ship_" + Team_Enemy));
            Ship_Own_B = (Bitmap)(Properties.Resources.ResourceManager.GetObject("BShip_" + Team_Own));
            Ship_Enemy_B = (Bitmap)(Properties.Resources.ResourceManager.GetObject("BShip_" + Team_Enemy));
            Generate();
            lbl_Layout.Text = "Расставьте Корабли!";
            lbl_Layout.Width = (lbl_score_E.Left + lbl_score_E.Width) - lbl_score_O.Width;
            lbl_Layout.Height = 600;
            lbl_Layout.Top = 100;
            lbl_Layout.Left = lbl_score_O.Left;
            REDRAW();
            pic_ships_enemy.Width = 600;
            pic_ships_enemy.Height = 600;
            pic_ships_own.Width = 400;
            pic_ships_own.Height = 400;
            pic_ships_enemy.Top = 10;
            pic_ships_enemy.Left = 10;
            pic_ships_own.Top = 620;
            pic_ships_own.Left = 110;
            lbl_score_E.Top = (MainForm.ActiveForm.Height / 2) - (lbl_score_O.Height / 2);
            lbl_score_E.Left = SystemInformation.PrimaryMonitorSize.Width - 100 - lbl_score_O.Width;
            label1.Top = lbl_score_E.Top;
            lbl_score_O.Top = lbl_score_E.Top;
            label1.Left = lbl_score_E.Left - label1.Width;
            lbl_score_O.Left = label1.Left - lbl_score_O.Width;
            lbl_score_E.Text = "0";
            lbl_score_O.Text = "0";
            pic_flag_E.Top = lbl_score_E.Top - pic_flag_E.Height;
            pic_flag_E.Left = lbl_score_E.Left;
            pic_flag_O.Top = lbl_score_O.Top - pic_flag_O.Height;
            pic_flag_O.Left = lbl_score_O.Left;
            btn_Exit.Top = SystemInformation.PrimaryMonitorSize.Height - btn_Exit.Height;
            btn_Exit.Left = SystemInformation.PrimaryMonitorSize.Width - btn_Exit.Width;
            pic_flag_O.BackgroundImage = Flag_O;
            pic_flag_E.BackgroundImage = Flag_E;
            lbl_Layout.Width = (pic_flag_E.Left + pic_flag_E.Width) - pic_flag_O.Left;
            lbl_Layout.Height = pic_flag_E.Top;
            lbl_Layout.Top = 0;
            lbl_Layout.Left = pic_flag_O.Left;
        }
        private void setdop()
        {//Запись доп. параметров сохранения
            Msg.doptosave = popad_E.ToString() + ":" + popad_O.ToString() + ":" + vistrel_E.ToString() + ":" + vistrel_O.ToString() + ":" + Team_Enemy + ":" + Team_Own;
        }
        private void getdop(string doploaded)
        {//Чтение доп. параметров сохранения
            string[] dop = doploaded.Split(':');
            popad_E = int.Parse(dop[0]);
            popad_O = int.Parse(dop[1]);
            vistrel_E = int.Parse(dop[2]);
            vistrel_O = int.Parse(dop[3]);
            Team_Enemy = dop[4];
            Team_Own = dop[5];

            Flag_E = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Flag_" + Team_Enemy));
            Flag_O = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Flag_" + Team_Own));
            Fail = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Fail"));
            Ship_Own = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Ship_" + Team_Own));
            Ship_Enemy = (Bitmap)(Properties.Resources.ResourceManager.GetObject("Ship_" + Team_Enemy));
            Ship_Own_B = (Bitmap)(Properties.Resources.ResourceManager.GetObject("BShip_" + Team_Own));
            Ship_Enemy_B = (Bitmap)(Properties.Resources.ResourceManager.GetObject("BShip_" + Team_Enemy));
            pic_flag_O.BackgroundImage = Flag_O;
            pic_flag_E.BackgroundImage = Flag_E;
            rasst = false;
            lbl_Layout.Text = "Игра началась!";

        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {//Тык по паузе и действия после закрытия
            theme.Stop();
            Msg.SetMessage("Пауза", vistrel_O);
            Msg.btn_res.Visible = true;
            Msg.textBox1.Visible = false;
            if (!rasst)
            {
                Msg.btn_Save.Visible = true;
            }
            else
            {
                Msg.btn_Save.Visible = false;
            }
            Msg.ShipstoSave = Ships;
            setdop();
            Msg.ShowDialog();
            if (Msg.restart)
            {
                START();
            }
            else
            {
                if (!Msg.res)
                {
                    theme.Stop();
                    this.Hide();
                }
                else
                {
                    theme.Play();
                    if (Msg.loaded)
                    {
                        Ships = Msg.ShipsLoaded;
                        getdop(Msg.doploaded);
                    }
                    REDRAW();
                }
            }
        }
        //Отрисовка полей
        #region Redraw
        private void REDRAW()
        {
            pic_ships_enemy.Invalidate();
            pic_ships_own.Invalidate();
            lbl_score_E.Text = popad_E.ToString();
            lbl_score_O.Text = popad_O.ToString();
        }
        private void pic_ships_own_Paint(object sender, PaintEventArgs e)
        {
            Graphics own;
            own = e.Graphics;
            DrawText(own, (PictureBox)sender, "Ваше поле");
            DrawLines(own, (PictureBox)sender);
            DrawShips(own, (PictureBox)sender, 0, Ship_Own);
            DrawCrashes(own, (PictureBox)sender, 0, Ship_Own_B);
            DrawFails(own, (PictureBox)sender, 0);
        }
        private void pic_ships_enemy_Paint(object sender, PaintEventArgs e)
        {
            Graphics enemy;
            enemy = e.Graphics;
            DrawText(enemy, (PictureBox)sender, "Поле противника");
            DrawCrashes(enemy, (PictureBox)sender, 1, Ship_Enemy_B);
            if (Cheat_Debug)
            {
                DrawShips(enemy, (PictureBox)sender, 1, Ship_Enemy);
            } DrawLines(enemy, (PictureBox)sender);
            DrawFails(enemy, (PictureBox)sender, 1);
        }
        private void DrawText(Graphics obj, PictureBox sendr, string txt)
        {
            Brush myb;
            myb = Brushes.LightGray;
            Font myf = new Font("Arial", sendr.Height/20, FontStyle.Bold);
            obj.DrawString(txt, myf, myb, 10, 10);
        }
        private void DrawCrashes(Graphics obj, PictureBox sendr, int num, Bitmap img)
        {
            for (int i = 0; i <= 150; i++)
            {
                if (Ships[num, i / 10, i % 10] == 3)
                {
                    obj.DrawImage(img, (((i / 10)) * (sendr.Width / 10)) + 1, 1 + (((i % 10)) * (sendr.Height / 10)), sendr.Width / 10, sendr.Height / 10);
                }
            }
        }
        private void DrawFails(Graphics obj, PictureBox sendr, int num)
        {
            for (int i = 0; i <= 150; i++)
            {
                if (Ships[num, i / 10, i % 10] == 1)
                {
                    obj.DrawImage(Fail, (((i / 10)) * (sendr.Width / 10)) + 1, 1 + (((i % 10)) * (sendr.Height / 10)), sendr.Width / 10, sendr.Height / 10);
                }
            }
        }
        private void DrawShips(Graphics obj, PictureBox sendr, int num, Bitmap ship)
        {
            for (int i = 0; i <= 150; i++)
            {
                if (Ships[num, i / 10, i % 10] == 2)
                {
                    obj.DrawImage(ship, (((i / 10)) * (sendr.Width / 10)) + 1, 1 + (((i % 10)) * (sendr.Height / 10)), sendr.Width / 10, sendr.Height / 10);
                }
            }
        }
        bool Cheat_Debug = false;
        private void DrawLines(Graphics obj, PictureBox sendr)
        {
            Pen mpen = new Pen(Color.Black, 2);
            for (int i = 1; i < 10; i++)
            {
                obj.DrawLine(mpen, i * sendr.Width / 10, 0, i * sendr.Width / 10, sendr.Height);
            }
            for (int i = 1; i < 10; i++)
            {
                obj.DrawLine(mpen, 0, i * sendr.Height / 10, sendr.Width, i * sendr.Height / 10);
            }
        }
        #endregion
        bool rasst = true;
        int rasstN = 1;
        int vistrel_O = 0;
        int vistrel_E = 0;
        int popad_O = 0;
        int popad_E = 0;
        private void pic_ships_enemy_MouseClick(object sender, MouseEventArgs e)
        {
            //Тык по вражескому полю
            int X = get_cords_x(e, pic_ships_enemy);
            int Y = get_cords_y(e, pic_ships_enemy);
            if (!rasst)
            {
                Hiter(X, Y);
                REDRAW();
            }

        }
        private void pic_ships_own_MouseDown(object sender, MouseEventArgs e)
        {
            //Тык по нашему полю
            int X = get_cords_x(e, pic_ships_own);
            int Y = get_cords_y(e, pic_ships_own);
            if (rasst)
            {
                Placer(X, Y);
            }
        }
        private void Hiter(int x, int y)
        {
            //Алгоритм выстрела
            vistrel_O++;
            if (Ships[1, x, y] != 3)
            {
                if (Ships[1, x, y] == 2)
                {
                    Ships[1, x, y] = 3;
                    popad_O++;
                }
                else if (Ships[1, x, y] == 0)
                {
                    Ships[1, x, y] = 1;
                }
            }
            REDRAW();
            if (Checker())
            {
                for (int i = 0; i < 100; i++)
                {
                    int ix = Rnd.Next(10);
                    int iy = Rnd.Next(10);
                    if (Ships[0, ix, iy] != 3 && Ships[0, ix, iy] != 1)
                    {
                        if (Ships[0, ix, iy] == 2)
                        {
                            popad_E++;
                            Ships[0, ix, iy] = 3;
                        }
                        if (Ships[0, ix, iy] == 0)
                        {
                            Ships[0, ix, iy] = 1;
                        }
                        vistrel_E++;
                        i = 101;
                    }
                    else
                    {
                        i = 0;
                    }
                }
                Checker();

            }
            REDRAW();
        }
        public void loadgame(Byte[, ,] ShipsLoaded, string doploaded)
        {
            //Загрузка сохранения
            this.Show();
            Ships = null;
            Ships = ShipsLoaded;
            getdop(doploaded);
            REDRAW();
        }
        private bool Checker()
        {
            //Проверка победы
            lbl_score_O.Text = popad_O.ToString();
            lbl_score_E.Text = popad_E.ToString();
            if (popad_E == 10 || popad_O == 10)
            {

                int scoreend = (1000 - vistrel_O);
                if (popad_E != 0)
                {
                    scoreend /= popad_E;
                }
                if (popad_E == 10)
                {
                    Msg.SetMessage("Вы проиграли" + "\r\nВаш счет:\r\n" + (scoreend.ToString()), scoreend);

                }
                if (popad_O == 10)
                {
                    Msg.SetMessage("Вы победили" + "\r\nВаш счет:\r\n" + (scoreend.ToString()), scoreend);
                }
                Msg.tip.Play();
                Msg.theme.Play();
                Msg.btn_res.Visible = false;
                Msg.btn_Save.Visible = false;
                Msg.ShipstoSave = Ships;
                setdop();
                Msg.ShowDialog();


                if (Msg.restart)
                {
                    START();
                }
                else
                {
                    if (!Msg.res)
                    {
                        theme.Stop();
                        this.Hide();
                    }
                    else
                    {
                        theme.Play();
                        Ships = Msg.ShipsLoaded;
                        getdop(Msg.doploaded);
                        REDRAW();
                    }
                }
                return false;
            }
            else
            {
                return true;
            }

        }
        private void Placer(int x, int y)
        {//Расставлялка кораблей
            if (rasstN <= 10)
            {
                if (Ships[0, x, y] != 2)
                {
                    Ships[0, x, y] = 2;
                    REDRAW();
                    rasstN++;
                    if (rasstN == 11) { lbl_Layout.Text = "Игра началась!"; rasst = false; }
                }
            }
            else { lbl_Layout.Text = "Игра уже идет!"; }


        }
        //Два метода на считание координат клетки
        public int get_cords_x(MouseEventArgs arg, PictureBox obj)
        {
            int CX = arg.X / (obj.Width / 10);
            return CX;
        }
        public int get_cords_y(MouseEventArgs arg, PictureBox obj)
        {
            int CY = arg.Y / (obj.Height / 10);
            return CY;
        }
        Random Rnd = new Random();
        public void Generate()
        {
            //Расставляка вражеских кораблей
            for (int i = 0; i < 10; i++)
            {
                int ix = Rnd.Next(10);
                int iy = Rnd.Next(10);
                if (Ships[1, ix, iy] != 2)
                {
                    Ships[1, ix, iy] = 2;
                }
                else { i--; }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {//Проверка тыка по эФ10
            if (e.KeyData == Keys.F10)
            {
                if (CommandLine.Visible)
                {
                    CommandLine.Visible = false;
                }
                else
                {
                    CommandLine.Visible = true;
                    CommandLine.Focus();
                }
            }
            if (e.KeyData == Keys.Up)
            {
                CommandLine.Text = prevCommand;
            }
            if (e.KeyData == Keys.Enter)
            {
                Command_Do(CommandLine.Text);
                prevCommand = CommandLine.Text;
                CommandLine.Text = "";
            }
        }
        string prevCommand = "";
        private void Command_Do(string Cmd)
        {
            //Читы и команды
            switch (Cmd.ToLower())
            {
                case "/debug true":
                    Cheat_Debug = true;
                    break;
                case "/debug false":
                    Cheat_Debug = false;
                    break;
                case "/generate":
                    Generate();
                    break;
                case "/restart":
                    START();
                    break;
                case "/winner enemy":
                    popad_E = 10;
                    Checker();
                    break;
                case "/winner own":
                    popad_O = 10;
                    Checker();
                    break;
            }
            REDRAW();
        }

    }
}
