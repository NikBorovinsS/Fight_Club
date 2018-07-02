using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class LogController
    {
        ILogView LogView;

        public LogController(ILogView v)
        {
            LogView = v;

            RoundCounter = 1;
        }

        public int RoundCounter
        {
            get;
            set;
        }

        private string GetTimeNow()
        {
            return DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        public string LogForBlock(Object sender, HitMethodsEventArgs e)
        {
            if (e.RoundCount == 0)
            {
                LogView.AddLog(e.FighterName + " did blocked hit.");
                LogView.AddLog(GetTimeNow() + " - Round has ended");

                ++RoundCounter;
                LogView.AddLog(GetTimeNow() + " - Round " + RoundCounter.ToString());
                LogView.AddLog("You are defending yourself");

                return (e.FighterName + e.CurrHP.ToString());
            }
            else
            {
                LogView.AddLog(e.FighterName + " did blocked hit.");
                LogView.AddLog(GetTimeNow() + " - Round has ended");

                ++RoundCounter;
                LogView.AddLog(GetTimeNow() + " - Round " + RoundCounter.ToString());
                LogView.AddLog("You attack");

                return (e.FighterName + e.CurrHP.ToString());
            }
        }

        public string LogForWound(Object sender, HitMethodsEventArgs e)
        {
            if (e.RoundCount == 0)
            {
                LogView.AddLog(e.FighterName + " has wounded in the " + e.BodyId.ToString()
                    + " by " + ((int)e.BodyId).ToString());
                LogView.AddLog(GetTimeNow() + " - Round has ended");

                ++RoundCounter;
                LogView.AddLog(GetTimeNow() + " - Round " + RoundCounter.ToString());
                LogView.AddLog("You are defending yourself");

                return (e.FighterName + e.CurrHP.ToString());
            }
            else
            {
                LogView.AddLog(e.FighterName + " has wounded in the " + e.BodyId.ToString()
                    + " by " + ((int)e.BodyId).ToString());
                LogView.AddLog(GetTimeNow() + " - Round has ended");

                ++RoundCounter;
                LogView.AddLog(GetTimeNow() + " - Round " + RoundCounter.ToString());
                LogView.AddLog("You attack");

                return (e.FighterName + e.CurrHP.ToString());
            }
        }

        public string LogForDeath(Object sender, HitMethodsEventArgs e)
        {
            if (e.RoundCount == 0)
            {
                LogView.AddLog(e.FighterName + " was killed.");
                LogView.AddLog(GetTimeNow() + " - You lose");

                return (e.FighterName + e.CurrHP.ToString());
            }
            else
            {
                LogView.AddLog(e.FighterName + " was killed.");
                LogView.AddLog(GetTimeNow() + " - Congratulations! You won");

                return (e.FighterName + e.CurrHP.ToString());
            }
        }

        public void LogForStart()
        {
            RoundCounter = 1;
            LogView.AddLog(GetTimeNow() + "- Fight started");
            LogView.AddLog(GetTimeNow() + " - Round " + RoundCounter.ToString());
            LogView.AddLog("You attack");
        }
    }
}
