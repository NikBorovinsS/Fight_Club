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
        void SetFighterBlock(HitMethodsEventHandler block);
        void SetFighterWound(HitMethodsEventHandler wound);
        void SetFighterDeath(HitMethodsEventHandler death);

        int RoundCounter { get; set; }
        int PlayerHP { get; set; }
        string PlayerName { get; set; }
        int NPC_HP { get; set; }
        string NPC_Name { get; set; }

        int maxHP { get; set; }
    }

    public class FightModel : IFightModel
    {
        public Player UserCharacter;
        public NPC ComputerCharacter;

        public int maxHP
        {
            get;
            set;
        }

        public event ModelHandler<FightModel> changed;

        public int _RoundCount;

        public FightModel()
        {
            UserCharacter = new Player();
            
            ComputerCharacter = new NPC();

            ReadAllSettings();
        }

        public void CalculateHit(BodyParts bodyPart)
        {
            ++RoundCounter;

            if (RoundCounter % 2 != 0)
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
            RoundCounter = 0;
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

        public void SetFighterBlock(HitMethodsEventHandler block)
        {
            UserCharacter.SetBlockEvent(block);
            ComputerCharacter.SetBlockEvent(block);
        }

        public void SetFighterWound(HitMethodsEventHandler wound)
        {
            UserCharacter.SetWoundEvent(wound);
            ComputerCharacter.SetWoundEvent(wound);
        }

        public void SetFighterDeath(HitMethodsEventHandler death)
        {
            UserCharacter.SetDeathEvent(death);
            ComputerCharacter.SetDeathEvent(death);
        }

        public void attach(IModelObserver imo)
        {
            changed += new ModelHandler<FightModel>(imo.hpChanged);
        }

        public int RoundCounter
        {
            get { return _RoundCount; }
            set { _RoundCount = value; }
        }

        public int PlayerHP
        {
            get { return UserCharacter.HP; }
            set { UserCharacter.HP = value; }
        }

        public string PlayerName
        {
            get { return UserCharacter.Name; }

            set { UserCharacter.Name = value; }
        }

        public int NPC_HP
        {
            get { return ComputerCharacter.HP; }
            set { ComputerCharacter.HP = value; }
        }

        public string NPC_Name
        {
            get { return ComputerCharacter.Name; }

            set { ComputerCharacter.Name = value; }
        }
    }
}
