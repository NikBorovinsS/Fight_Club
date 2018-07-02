using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class LogModel
    {
    //    public int RoundCount;

    //    private Player FirstPlayer;
    //    private Player SecondPlayer;

    //    private string GetTimeNow()
    //    {
    //        return DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
    //    }

    //    public string LogForBlock(Object sender, HitMethodsEventArgs e)
    //    {
    //        if (RoundCount % 2 == 0)
    //        {
    //            GameLogs.Items.Add("First player did blocked hit.");
    //            GameLogs.Items.Add(GetTimeNow() + " - Round has ended");

    //            ++RoundCount;
    //            GameLogs.Items.Add(GetTimeNow() + " - Round " + RoundCount.ToString());
    //            GameLogs.Items.Add("You attack");

    //            return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
    //        }
    //        else
    //        {
    //            GameLogs.Items.Add("Second player did blocked hit.");
    //            GameLogs.Items.Add(GetTimeNow() + " - Round has ended");

    //            ++RoundCount;
    //            GameLogs.Items.Add(GetTimeNow() + " - Round " + RoundCount.ToString());
    //            GameLogs.Items.Add("You are defending yourself");

    //            return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
    //        }
    //    }

    //    public string LogForWound(Object sender, HitMethodsEventArgs e)
    //    {
    //        if (RoundCount % 2 == 0)
    //        {
    //            GameLogs.Items.Add("First player has wounded in the " + FirstPlayer.LastInputBP.ToString()
    //                + " by " + ((int)FirstPlayer.LastInputBP).ToString());
    //            GameLogs.Items.Add(GetTimeNow() + " - Round has ended");

    //            Player1HPBox.Text = FirstPlayer.GetPlayerHp() < 0 ? "0" : FirstPlayer.GetPlayerHp().ToString();

    //            ++RoundCount;
    //            GameLogs.Items.Add(GetTimeNow() + " - Round " + RoundCount.ToString());
    //            GameLogs.Items.Add("You attack");

    //            return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
    //        }
    //        else
    //        {
    //            GameLogs.Items.Add("Second player has wounded in the " + SecondPlayer.LastInputBP.ToString()
    //                + " by " + ((int)SecondPlayer.LastInputBP).ToString());
    //            GameLogs.Items.Add(GetTimeNow() + " - Round has ended");

    //            Player2HPBox.Text = SecondPlayer.GetPlayerHp() < 0 ? "0" : SecondPlayer.GetPlayerHp().ToString();

    //            ++RoundCount;
    //            GameLogs.Items.Add(GetTimeNow() + " - Round " + RoundCount.ToString());
    //            GameLogs.Items.Add("You are defending yourself");

    //            return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
    //        }
    //    }

    //    public string LogForDeath(Object sender, HitMethodsEventArgs e)
    //    {
    //        if (RoundCount % 2 == 0)
    //        {
    //            GameLogs.Items.Add("First player was killed.");
    //            GameLogs.Items.Add(GetTimeNow() + " - You lose");

    //            Player1HPBox.Text = FirstPlayer.GetPlayerHp() < 0 ? "0" : FirstPlayer.GetPlayerHp().ToString();

    //            return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
    //        }
    //        else
    //        {
    //            GameLogs.Items.Add("Second player was killed.");
    //            GameLogs.Items.Add(GetTimeNow() + " - Congratulations! You won");

    //            Player2HPBox.Text = SecondPlayer.GetPlayerHp() < 0 ? "0" : SecondPlayer.GetPlayerHp().ToString();

    //            return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
    //        }
    //    }

    //    private string GetAttackedPlayer()
    //    {
    //        if (RoundCount % 2 == 0)
    //        {
    //            return (FirstPlayer.GetPlayerName() + FirstPlayer.GetPlayerHp().ToString());
    //        }
    //        else
    //        {
    //            return (SecondPlayer.GetPlayerName() + SecondPlayer.GetPlayerHp().ToString());
    //        }
    //    }

    //    private void InitializeEvents()
    //    {
    //        FirstPlayer.Block += this.LogForBlock;
    //        SecondPlayer.Block += this.LogForBlock;

    //        FirstPlayer.Wound += this.LogForWound;
    //        SecondPlayer.Wound += this.LogForWound;

    //        FirstPlayer.Death += this.LogForDeath;
    //        SecondPlayer.Death += this.LogForDeath;

    //        FirstPlayer.Death += this.ProposeRestart;
    //        SecondPlayer.Death += this.ProposeRestart;
    //    }

    //    private void Start_Fight(object sender, EventArgs e)
    //    {
    //        if (!FightButton.Text.Equals("Revenge!"))
    //        {
    //            InitializeEvents();

    //            FightButton.Text = "Revenge!";
    //        }
    //        else
    //        {
    //            RoundCount = 0;

    //            GameLogs.Items.Clear();
    //        }

    //        ReadAllSettings();

    //        Player1NameLabel.Text = FirstPlayer.GetPlayerName();
    //        Player2NameLabel.Text = SecondPlayer.GetPlayerName();

    //        Player1HPBox.Text = FirstPlayer.MAX_HP.ToString();
    //        Player2HPBox.Text = FirstPlayer.MAX_HP.ToString();

    //        ButtonHead.Visible = true;
    //        ButtonTorso.Visible = true;
    //        ButtonLegs.Visible = true;

    //        HeadOpp.Visible = true;
    //        TorsoOpp.Visible = true;
    //        LegsOpp.Visible = true;

    //        GameLogs.Items.Add(GetTimeNow() + " - Fight started!");

    //        ++RoundCount;
    //        if (RoundCount % 2 != 0)
    //        {
    //            GameLogs.Items.Add("Round " + RoundCount.ToString());
    //            GameLogs.Items.Add("You attack");
    //        }
    //        else
    //        {
    //            GameLogs.Items.Add("Round " + RoundCount.ToString());
    //            GameLogs.Items.Add("You are defending yourself");
    //        }
    //    }

    //    private void Round(BodyParts ChoosedPart)
    //    {
    //        if (RoundCount % 2 != 0)
    //        {
    //            SecondPlayer.SetBlock();
    //            SecondPlayer.GetHit(ChoosedPart);
    //        }
    //        else
    //        {
    //            FirstPlayer.SetBlock(ChoosedPart);
    //            FirstPlayer.GetHit(FirstPlayer.CalculateAttackedPart());
    //        }

    //    }
    }
}
