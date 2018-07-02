using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight_Club
{
    public partial class FighterForm : Form, IFighterView
    {
        public IFighterController fighter_controller;

        public FighterForm()
        {
            InitializeComponent();
        }

        public void setController(IFighterController fc)
        {
            fighter_controller = fc;
        }

        public void changeHP(int Hp)
        {
            HpBox.Text = Hp > 0 ? Hp.ToString() : "0";

            HpBar.Value = Hp > 0 ? Hp : 0;
        }
        public void changeName(string name)
        {
            NameLabel.Text = name;
            this.Text = name;
        }

        public void setHPBar(int maxhp)
        {
            HpBar.Maximum = maxhp;
        }

        private void buttonHead_Click(object sender, EventArgs e)
        {
            fighter_controller.SetBodyPart(BodyParts.Head);
        }

        private void buttonTorso_Click(object sender, EventArgs e)
        {
            fighter_controller.SetBodyPart(BodyParts.Torso);
        }

        private void buttonLegs_Click(object sender, EventArgs e)
        {
            fighter_controller.SetBodyPart(BodyParts.Legs);
        }
    }
}
