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

        public FighterController PlrCnt;
        public FighterController NPCCnt;

        public FightClubMainForm()
        {
            InitializeComponent();

            SettingsForm = new SettingsForm();
            SettingsForm.ParentMainForm = this;

            SettingsForm.VisibleChanged += this.SettingsClosed;

            PlayerForm = new FighterForm();
            NPCForm = new FighterForm();

            PlrCnt = new FighterController(PlayerForm, this);
            NPCCnt = new FighterController(NPCForm, this);

            PlayerForm.MdiParent = this;
            NPCForm.MdiParent = this;

            PlayerForm.Show();
            NPCForm.Show();
        }

        private void SettingsClosed(object sender, EventArgs e)
        {
            if (SettingsForm.Visible)
            {
                return;
            }
            else
            {
                if (SettingsForm.ChangeAccepted)
                {
                    controller.InitializeSettings();
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

        public void showSettings() { }
        public void showLogs() { }
        public void showFighters() { }
        public void showWinner() { }
    }
}
