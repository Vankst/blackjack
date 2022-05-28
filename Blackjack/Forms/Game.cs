using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Blackjack.Forms
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        public int diler_count = 0, player_count = 0;
        public int diler_card = 0, player_card = 0, player_totalcard = 0;

        public string path;
        public string[] cardMast = new string[] { "_bubn.png", "_chervi.png", "_piki.png", "_tref.png" };
        private void Game_Load(object sender, EventArgs e)
        {
            
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            int ind = location.Length - 38;
            path = location.Remove(ind);
            path += @"Assets\";
            btn_newgame.Enabled = false;
            for(int i = 0; i < 2; i++)
            {
                AddCardDiler(false) ;
            }
            lbl_dilercount.Text = "??";
            for (int i = 0; i < 2; i++)
            {
                AddCardPlayer();
            }
            lbl_playercount.Text = player_count.ToString();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Check();
        }

        public void Check()
        {
            if (diler_count < player_count)
                while (diler_count <= player_count)
                    AddCardDiler(true);
            if(diler_count == player_count)
            {
                btn_add.Enabled = false;
                btn_stop.Enabled = false;
                btn_newgame.Enabled = true;
                MessageBox.Show("Ничья");
                lbl_dilercount.Text = diler_count.ToString();
            }
            else
            {
                btn_add.Enabled = false;
                btn_stop.Enabled = false;
                btn_newgame.Enabled = true;
                MessageBox.Show("Вы выиграли!");
                lbl_dilercount.Text = diler_count.ToString();
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!(player_count >= 21) && player_totalcard <= 6)
                AddCardPlayer();
        }

        private void btn_newgame_Click(object sender, EventArgs e)
        {
            diler_count = 0; player_count = 0;
            diler_card = 0; player_card = 0;
            lbl_dilercount.Text = "??";
            btn_add.Enabled = true;
            btn_stop.Enabled = true;
            btn_newgame.Enabled = false;
            player_totalcard = 0;
            pb_player1.Image = null; pb_player2.Image = null; pb_player3.Image = null; pb_player4.Image = null; pb_player5.Image = null; pb_player6.Image = null;
            Game_Load(sender, e);
        }

        public void AddCardPlayer()
        {
            player_card = rnd.Next(2, 12); //Игрок
            if (player_count > 11 && player_card == 12)
                player_count++;
            else
                player_count += player_card;
            lbl_playercount.Text = player_count.ToString();
            player_totalcard++;
            var cardZn = rnd.Next(0, 4);
            ViewCard(player_totalcard, player_card, cardZn);
            if (player_count > 21)
            {
                btn_add.Enabled = false;
                btn_stop.Enabled = false;
                btn_newgame.Enabled = true;
                lbl_dilercount.Text = diler_count.ToString();
                MessageBox.Show("Вы проиграли");
            }
          

        }

        public void ViewCard(int totalCard, int cardZn, int mast)
        {
            string CardZn = cardZn.ToString();
            if (cardZn == 10)
            {
          
                string[] tenMas = new string[] { "10", "valet", "dama", "korol"};
                CardZn = tenMas[rnd.Next(0, 4)];
            }
            if(cardZn == 11)
            {
                CardZn = "tus";
            }
            switch (totalCard)
            {
                case 1:
                    pb_player1.Image = Image.FromFile(path + CardZn + cardMast[mast]);break;
                case 2:
                    pb_player2.Image = Image.FromFile(path + CardZn + cardMast[mast]); break;
                case 3:
                    pb_player3.Image = Image.FromFile(path + CardZn + cardMast[mast]); break;
                case 4:
                    pb_player4.Image = Image.FromFile(path + CardZn + cardMast[mast]); break;
                case 5:
                    pb_player5.Image = Image.FromFile(path + CardZn + cardMast[mast]); break;
                case 6:
                    pb_player6.Image = Image.FromFile(path + CardZn + cardMast[mast]); break;
            }
        }

        public void AddCardDiler(bool check)
        {
            diler_card = rnd.Next(2, 11); //Дилер
            if (diler_count > 11 && diler_card == 11)
                diler_count++;
            else
                diler_count += diler_card;
            if (check)
                Check();
        }
    }
}
