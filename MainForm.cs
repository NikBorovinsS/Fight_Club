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
using System.Configuration;

namespace Fight_Club
{
    public enum BodyParts { Legs = 15, Torso = 20, Head = 25 };

    public partial class FightClubMainForm : Form
    {
        public int RoundCount;

        private Player FirstPlayer;
        private Player SecondPlayer;

        public SettingsForm SettingsForm;

        public FightClubMainForm()
        {
            InitializeComponent();

            SettingsForm = new SettingsForm();
            SettingsForm.ParentMainForm = this;

            SettingsForm.VisibleChanged += this.SettingsClosed;

            FirstPlayer = new Player();
            SecondPlayer = new Player();

            RoundCount = 0;
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
                    ReadAllSettings();
                }
            }
        }

        private string GetTimeNow()
        {
            return DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        public string LogForBlock(Object sender, HitMethodsEventArgs e)
        {
            if (RoundCount % 2 == 0)
            {
                GameLogs.Items.Add("First player did blocked hit.");
                GameLogs.Items.Add(GetTimeNow() + " - Round has ended");

                ++RoundCount;
                GameLogs.Items.Add(GetTimeNow() + " - Round " + RoundCount.ToString());
                GameLogs.Items.Add("You attack");

                return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
            }
            else
            {
                GameLogs.Items.Add("Second player did blocked hit.");
                GameLogs.Items.Add(GetTimeNow() + " - Round has ended");

                ++RoundCount;
                GameLogs.Items.Add(GetTimeNow() + " - Round " + RoundCount.ToString());
                GameLogs.Items.Add("You are defending yourself");

                return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
            }
        }

        public string LogForWound(Object sender, HitMethodsEventArgs e)
        {
            if (RoundCount % 2 == 0)
            {
                GameLogs.Items.Add("First player has wounded in the " + FirstPlayer.LastInputBP.ToString()
                    + " by " + ((int)FirstPlayer.LastInputBP).ToString());
                GameLogs.Items.Add(GetTimeNow() + " - Round has ended");

                Player1HPBox.Text = FirstPlayer.GetPlayerHp() < 0 ? "0" : FirstPlayer.GetPlayerHp().ToString();

                ++RoundCount;
                GameLogs.Items.Add(GetTimeNow() + " - Round " + RoundCount.ToString());
                GameLogs.Items.Add("You attack");

                return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
            }
            else
            {
                GameLogs.Items.Add("Second player has wounded in the " + SecondPlayer.LastInputBP.ToString()
                    + " by " + ((int)SecondPlayer.LastInputBP).ToString());
                GameLogs.Items.Add(GetTimeNow() + " - Round has ended");

                Player2HPBox.Text = SecondPlayer.GetPlayerHp() < 0 ? "0" : SecondPlayer.GetPlayerHp().ToString();

                ++RoundCount;
                GameLogs.Items.Add(GetTimeNow() + " - Round " + RoundCount.ToString());
                GameLogs.Items.Add("You are defending yourself");

                return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
            }
        }

        public string LogForDeath(Object sender, HitMethodsEventArgs e)
        {
            if (RoundCount % 2 == 0)
            {
                GameLogs.Items.Add("First player was killed.");
                GameLogs.Items.Add(GetTimeNow() + " - You lose");

                Player1HPBox.Text = FirstPlayer.GetPlayerHp() < 0 ? "0" : FirstPlayer.GetPlayerHp().ToString();

                return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
            }
            else
            {
                GameLogs.Items.Add("Second player was killed.");
                GameLogs.Items.Add(GetTimeNow() + " - Congratulations! You won");

                Player2HPBox.Text = SecondPlayer.GetPlayerHp() < 0 ? "0" : SecondPlayer.GetPlayerHp().ToString();

                return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
            }
        }

        private string GetAttackedPlayer()
        {
            if (RoundCount % 2 == 0)
            {
                return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
            }
            else
            {
                return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
            }
        }

        public string ProposeRestart(Object sender, HitMethodsEventArgs e)
        {
            RoundCount = 0;

            GameLogs.Items.Clear();

            ButtonHead.Visible = false;
            ButtonTorso.Visible = false;
            ButtonLegs.Visible = false;

            HeadOpp.Visible = false;
            TorsoOpp.Visible = false;
            LegsOpp.Visible = false;

            return GetAttackedPlayer();
        }

        private void InitializeEvents()
        {
            FirstPlayer.Block += this.LogForBlock;
            SecondPlayer.Block += this.LogForBlock;

            FirstPlayer.Wound += this.LogForWound;
            SecondPlayer.Wound += this.LogForWound;

            FirstPlayer.Death += this.LogForDeath;
            SecondPlayer.Death += this.LogForDeath;

            FirstPlayer.Death += this.ProposeRestart;
            SecondPlayer.Death += this.ProposeRestart;
        }

        private void Start_Fight(object sender, EventArgs e)
        {
            if (!FightButton.Text.Equals("Revenge!"))
            {
                InitializeEvents();

                FightButton.Text = "Revenge!";
            }
            else 
            {
                RoundCount = 0;

                GameLogs.Items.Clear();
            }

            ReadAllSettings();

            Player1NameLabel.Text = FirstPlayer.GetPlayerName();
            Player2NameLabel.Text = SecondPlayer.GetPlayerName();

            Player1HPBox.Text = FirstPlayer.MAX_HP.ToString();
            Player2HPBox.Text = FirstPlayer.MAX_HP.ToString();

            ButtonHead.Visible = true;
            ButtonTorso.Visible = true;
            ButtonLegs.Visible = true;

            HeadOpp.Visible = true;
            TorsoOpp.Visible = true;
            LegsOpp.Visible = true;

            GameLogs.Items.Add(GetTimeNow() + " - Fight started!");

            ++RoundCount;
            if (RoundCount % 2 != 0)
            {
                GameLogs.Items.Add("Round " + RoundCount.ToString());
                GameLogs.Items.Add("You attack");
            }
            else
            {
                GameLogs.Items.Add("Round " + RoundCount.ToString());
                GameLogs.Items.Add("You are defending yourself");
            }
        }

        private void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationSettings.AppSettings;

                if (appSettings.Count == 0)
                {
                    GameLogs.Items.Add("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        switch (key)
                        {
                            case "FirstName": FirstPlayer.SetPlayerName(appSettings[key]);
                                break;
                            case "SecondName": SecondPlayer.SetPlayerName(appSettings[key]);
                                break;
                            case "Duration": FirstPlayer.SetMaxHP(Int32.Parse(appSettings[key]));
                                SecondPlayer.SetMaxHP(Int32.Parse(appSettings[key]));
                                Player1HPBar.Maximum = Int32.Parse(appSettings[key]);
                                Player2HPBar.Maximum = Int32.Parse(appSettings[key]);
                                break;
                        }
                    }
                }
            }
            catch (ConfigurationException)
            {
                GameLogs.Items.Add("Error reading app settings");
            }
        }


        private void Round(BodyParts ChoosedPart)
        {
            if (RoundCount % 2 != 0)
            {
                SecondPlayer.SetBlock();
                SecondPlayer.GetHit(ChoosedPart);
            }
            else
            {
                FirstPlayer.SetBlock(ChoosedPart);
                FirstPlayer.GetHit(FirstPlayer.CalculateAttackedPart());
            }

        }

        private void ButtonHead_Click(object sender, EventArgs e)
        {
            Round(BodyParts.Head);
        }

        private void ButtonTorso_Click(object sender, EventArgs e)
        {
            Round(BodyParts.Torso);
        }

        private void ButtonLegs_Click(object sender, EventArgs e)
        {
            Round(BodyParts.Torso);
        }

        private void Player1HPBox_TextChanged(object sender, EventArgs e)
        {
            Player1HPBar.Value = Int32.Parse(Player1HPBox.Text) < 0 ? 0 : Int32.Parse(Player1HPBox.Text);
        }

        private void Player2HPBox_TextChanged(object sender, EventArgs e)
        {
            Player2HPBar.Value = Int32.Parse(Player2HPBox.Text) < 0 ? 0 : Int32.Parse(Player2HPBox.Text);
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            SettingsForm.Show();
        }
    }

    class Player
    {
        private string Name;
        private BodyParts Blocked;
        private int Hp;
        public int MAX_HP = 1;

        public BodyParts LastInputBP;

        public Player() { }
        public Player(string PlayerName)
        {
            Name = PlayerName;
            Hp = MAX_HP;
        }

        public void SetPlayerName(string SName)
        {
            Name = SName;
        }

        public void SetMaxHP(int MAXHP)
        {
            MAX_HP = MAXHP;
            Hp = MAX_HP;
        }

        public void GetHit(BodyParts AttackedPart)
        {
            HitMethodsEventArgs args = new HitMethodsEventArgs();
            args.BodyId = AttackedPart;
            args.TimeHit = DateTime.Now;

            LastInputBP = AttackedPart;

            OnHitMethods(args);

        }

        public void SetBlock()
        {
            Random randomizer = new Random();
            int number = randomizer.Next(1, 135);
            if (number < 60)
            {
                Blocked = BodyParts.Head;
            }
            else if (number < 105)
            {
                Blocked = BodyParts.Torso;
            }
            else Blocked = BodyParts.Legs;
        }

        public BodyParts CalculateAttackedPart()
        {
            Random randomizer = new Random();
            int number = randomizer.Next(1, 135);
            if (number < 60)
            {
                return BodyParts.Legs;
            }
            else if (number < 105)
            {
                return BodyParts.Torso;
            }
            else return BodyParts.Head;
        }

        public void SetBlock(BodyParts BlockedPart)
        {
            Blocked = BlockedPart;
        }

        public string GetPlayerName()
        {
            return Name;
        }

        public int GetPlayerHp()
        {
            return Hp;
        }

        protected virtual void OnHitMethods(HitMethodsEventArgs e)
        {
            HitMethodsEventHandler handler;
            if (e.BodyId.Equals(Blocked))
            {
                handler = Block;
            }
            else
            {
                Hp -= (int)e.BodyId;
                handler = Wound;

                if (Hp <= 0)
                {
                    handler = Death;
                }
            }
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event HitMethodsEventHandler Block;
        public event HitMethodsEventHandler Wound;
        public event HitMethodsEventHandler Death;
    }

    public class HitMethodsEventArgs : EventArgs
    {
        public BodyParts BodyId { get; set; }
        public DateTime TimeHit { get; set; }
    }

    public delegate string HitMethodsEventHandler(Object sender, HitMethodsEventArgs e);

}
