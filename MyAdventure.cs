using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;
namespace MyAdventure
{
    public partial class MyAdventure : Form
    {
        private readonly Player player;
        public MyAdventure()
        {
            InitializeComponent();


            player = new Player(100, 100, 20, 0, 1);
            
            lblHitPoints.Text = player.CurrentHitPoints.ToString();
            lblGold.Text = player.Gold.ToString();
            lblLevel.Text = player.Level.ToString();
            lblExperience.Text = player.Exp.ToString();
        }
    }
}
