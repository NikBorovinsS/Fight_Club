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

namespace Fight_Club
{
    public enum BodyParts { Legs = 15, Torso = 20, Head = 25 };

    public partial class FightClubMainForm : Form
    {
        public int RoundCount;

        private Player FirstPlayer;
        private Player SecondPlayer;

        public FightClubMainForm()
        {
            InitializeComponent();

            //PlayAmbient();

            RoundCount = 0;
        }

        private string GetTimeNow()
        {
            return DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        private void PlayAmbient()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = @"F:\ISD Initiative Program\Fight_Club\whatisfightclub.mp3";
            wplayer.controls.play();
        }

        public string LogForBlock()
        {
            GameLogs.Items.Add(GetTimeNow() + " - Hit was blocked.");
            GameLogs.Items.Add("Round has ended");

            if (RoundCount % 2 == 0)
            {
                return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
            }
            else
            {
                return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
            }
        }

        public string LogForWound()
        {
            GameLogs.Items.Add(GetTimeNow() + " - Player has wounded.");
            GameLogs.Items.Add("Round has ended");

            if (RoundCount % 2 == 0)
            {
                Player1HPBox.Text = FirstPlayer.GetPlayerHp() < 0 ? "0" : FirstPlayer.GetPlayerHp().ToString();

                return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
            }
            else
            {
                Player2HPBox.Text = SecondPlayer.GetPlayerHp() < 0 ? "0" : SecondPlayer.GetPlayerHp().ToString();

                return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
            }
        }

        public string LogForDeath()
        {
            if (RoundCount % 2 == 0)
            {
                GameLogs.Items.Add(GetTimeNow() + " - Firts player was killed.");
                GameLogs.Items.Add("You lose");

                Player1HPBox.Text = FirstPlayer.GetPlayerHp() < 0 ? "0" : FirstPlayer.GetPlayerHp().ToString();

                return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
            }
            else 
            {
                GameLogs.Items.Add(GetTimeNow() + " - Second player was killed.");
                GameLogs.Items.Add("Congratulations! You won");

                Player2HPBox.Text = SecondPlayer.GetPlayerHp() < 0 ? "0" : SecondPlayer.GetPlayerHp().ToString();

                return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
            }
        }

        private void InitializeEvents()
        {
            FirstPlayer.Block += this.LogForBlock;
            SecondPlayer.Block += this.LogForBlock;

            FirstPlayer.Wound += this.LogForWound;
            SecondPlayer.Wound += this.LogForWound;

            FirstPlayer.Death += this.LogForDeath;
            SecondPlayer.Death += this.LogForDeath;
        }

        private void Start_Fight(object sender, EventArgs e)
        {
            FirstPlayer = new Player("Narrator");
            SecondPlayer = new Player("Tyler");

            InitializeEvents();

            Player1NameLabel.Text = FirstPlayer.GetPlayerName();
            Player2NameLabel.Text = SecondPlayer.GetPlayerName();

            Player1HPBox.Text = Player.MAX_HP.ToString();
            Player2HPBox.Text = Player.MAX_HP.ToString();

            ButtonHead.Visible = true;
            ButtonTorso.Visible = true;
            ButtonLegs.Visible = true;

            GameLogs.Items.Add(GetTimeNow() + " - Fight started!");
        }

        private void Round(BodyParts ChoosedPart)
        {
            ++RoundCount;

            GameLogs.Items.Add(GetTimeNow() + " - Round " + RoundCount.ToString());

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
            Player1HPBar.Value = Int32.Parse(Player1HPBox.Text) < 0 ? 0: Int32.Parse(Player1HPBox.Text);
        }

        private void Player2HPBox_TextChanged(object sender, EventArgs e)
        {
            Player2HPBar.Value = Int32.Parse(Player2HPBox.Text) < 0 ? 0 : Int32.Parse(Player2HPBox.Text);
        }
    }

    class Player
    {
        private string Name;
        private BodyParts Blocked;
        private int Hp;
        public const int MAX_HP = 100;

        public delegate string BlockMethods();
        public delegate string WoundMethods();
        public delegate string DeathMethods();

        public event BlockMethods Block;
        public event WoundMethods Wound;
        public event DeathMethods Death;

        public Player()
        {
            Hp = MAX_HP;
        }
        public Player(string PlayerName)
        {
            Name = PlayerName;
            Hp = MAX_HP;
        }

        public void GetHit(BodyParts AttackedPart)
        {
            if (AttackedPart.Equals(Blocked))
            {
                Block();
            }
            else 
            {
                Hp -= (int)AttackedPart;
                Wound();

                if (Hp <= 0)
                {
                    Death();
                }
            }
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
    }
}
