using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Fight_Club
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public class ModelEventArgs : EventArgs
    {
        public int newhp;
        public string playerName;

        public ModelEventArgs(int hp, string name)
        {
            newhp = hp;
            playerName = name;
        }
    }

    public interface IModelObserver
    {
        void hpChanged(IFightModel model, ModelEventArgs e);
    }

    public interface IFightModel
    {
        void attach(IModelObserver imo);
        void CalculateHit(BodyParts bodyPart);
        void StartFight();
        void EndOfFight();
        void ReadAllSettings();
    }

    public class FightModel : IFightModel
    {
        public Player UserCharacter;
        public NPC ComputerCharacter;

        public int maxHP;

        public event ModelHandler<FightModel> changed;

        public int RoundCount;

        public FightModel()
        {
            UserCharacter = new Player();
            
            ComputerCharacter = new NPC();

            ReadAllSettings();

            changed.Invoke(this, new ModelEventArgs(UserCharacter.HP, UserCharacter.Name));
            changed.Invoke(this, new ModelEventArgs(ComputerCharacter.HP, ComputerCharacter.Name));
        }

        public void CalculateHit(BodyParts bodyPart)
        {
            ++RoundCount;

            if (RoundCount % 2 != 0)
            {
                ComputerCharacter.SetBlock();

                ComputerCharacter.GetHit(bodyPart);
            }
            else
            {
                UserCharacter.GetHit(ComputerCharacter.CalculateAttackedPart());
            }
        }

        public void StartFight()
        {
            RoundCount = 0;
        }

        public void EndOfFight() { }

        public void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationSettings.AppSettings;

                if (appSettings.Count == 0)
                {
                    //LogForm.GameLogs.Items.Add("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        switch (key)
                        {
                            case "FirstName": UserCharacter.Name = appSettings[key];
                                break;
                            case "SecondName": ComputerCharacter.Name = appSettings[key];
                                break;
                            case "Duration": maxHP = Int32.Parse(appSettings[key]);
                                UserCharacter.HP = maxHP;
                                ComputerCharacter.HP = maxHP;
                                break;
                        }
                    }
                }
            }
            catch (ConfigurationException)
            {
                //GameLogs.Items.Add("Error reading app settings");
            }
        }

        public void attach(IModelObserver imo)
        {
            changed += new ModelHandler<FightModel>(imo.hpChanged);
        }
    }
}
