using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Fight_Club
{
    public partial class FightClubMainForm : Form, IMainView, IModelObserver
    {
        public SettingsForm SettingsForm;

        public IMainController controller;
        public event ViewHandler<IMainView> changed;

        protected FighterForm PlayerForm;
        protected FighterForm NPCForm;

        protected LogForm GameLogs;

        public FighterController PlrCnt;
        public FighterController NPCCnt;

        public FightClubMainForm()
        {
            InitializeComponent();

            SettingsForm = new SettingsForm();
            SettingsForm.ParentMainForm = this;

            SettingsForm.VisibleChanged += this.SettingsClosed;
            SettingsForm.FormClosed += this.SettingsClosed;

            PlayerForm = new FighterForm();
            NPCForm = new FighterForm();

            GameLogs = new LogForm();
            GameLogs.MdiParent = this;
            GameLogs.Text = "Game Logs";
            GameLogs.Show();

            PlrCnt = new FighterController(PlayerForm, this);
          
            NPCCnt = new FighterController(NPCForm, this);

            PlayerForm.MdiParent = this;
            NPCForm.MdiParent = this;
        }

        private void SettingsClosed(object sender, EventArgs e)
        {
            if (SettingsForm != null)
            {
                this.Enabled = true;
                return;
            }
            if (SettingsForm.Visible)
            {
                return;
            }
            else
            {
                if (SettingsForm.ChangeAccepted)
                {
                    controller.InitializeSettings();
                    setMaxHp(controller.GetMaxHp());
                    controller.StartFight();
                }
            }
        }

        public void setController(IMainController cont)
        {
            controller = cont;
        }

        public void hpChanged(IFightModel m, ModelEventArgs e)
        {
            NPCCnt.SetHp(e.newhp);
        }

        public void showFighters()
        {
            NPCForm.Show();
            NPCForm.Location = new Point(850, 250);

            PlayerForm.Show();
            PlayerForm.Enabled = false;
            PlayerForm.Location = new Point(300, 250);

            setMaxHp(controller.GetMaxHp());
            controller.SetFightersCharacteristic();
        }
        public void showWinner(HitMethodsEventArgs e) 
        {
            string caption;
            string message = e.FighterName + " was defeated";
            if (e.RoundCount == 1)
            {
                caption = "Did you lose that fight. Want to restart?";
            }
            else 
            {
                caption = "Congratulations! You won. May be another fight?";
            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                controller.StartFight();

            }
            else
            {
                this.Close();
            }
        }

        public void setMaxHp(int hp)
        {
            NPCForm.fighter_controller.setMAX_HP(hp);
            PlayerForm.fighter_controller.setMAX_HP(hp);
        }

        public void ReverseFighter()
        {
            if (PlayerForm.Enabled)
            {
                PlayerForm.Enabled = false;
                NPCForm.Enabled = true;
            }
            else 
            {
                PlayerForm.Enabled = true;
                NPCForm.Enabled = false;
            }
        }

        public void showFighterChanges(int hp, string name, int round)
        {
            
        }

        public void setPlayer(int hp, string name)
        {
            PlayerForm.fighter_controller.SetHp(hp);

            PlayerForm.fighter_controller.SetName(name);
        }

        public void setNPC(int hp, string name)
        {
            NPCForm.fighter_controller.SetHp(hp);

            NPCForm.fighter_controller.SetName(name);
        }

        public LogForm GetLogForm()
        {
            return this.GameLogs;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            controller.StartFight();

            if(buttonStart.Text.Equals("Fight!")) buttonStart.Text = "Restart";
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (SettingsForm == null)
            {
                SettingsForm = new SettingsForm();
            }
            SettingsForm.Show();
        }
    }
}
