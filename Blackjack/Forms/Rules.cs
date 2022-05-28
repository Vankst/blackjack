using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack.Forms
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            tb_rules.Text = "Цель игры — набрать 21 очко или близкую к этому сумму. Если игрок набирает сумму очков, превышающую 21, то он проигрывает. Если сумма очков на картах дилера больше, чем 21, то все ставки, оставшиеся в игре, выигрывают. Игроки, набравшие сумму очков большую, чем дилер, выигрывают.";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main main = new();
            main.Show();
            this.Close();
        }
    }
}
