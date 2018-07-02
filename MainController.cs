using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    public interface IMainController
    {
        void StartFight();
        void InitHit(BodyParts BP);
        void InitializeSettings();
        void InitializeEvents();
        void SetFightersCharacteristic();
        int GetNPC_HP();
        string GetNPC_Name();
        int GetPlayerHp();
        string GetPlayerName();
        void NextTurn();
        int GetMaxHp();
    }

    public class MainController: IMainController
    {
        IMainView View;
        IFightModel FightMdl;

        LogController GameLogsController;

        public event HitMethodsEventHandler Block;
        public event HitMethodsEventHandler Wound;
        public event HitMethodsEventHandler Death;

        public MainController(IMainView v, IFightModel fm)
        {
            View = v;
            FightMdl = fm;

            GameLogsController = new LogController(View.GetLogForm());

            FightMdl.attach((IModelObserver)View);

            View.setController(this);

            InitializeEvents();
        }

        public void StartFight()
        {
            FightMdl.StartFight();
            InitializeSettings();
            View.showFighters();
            GameLogsController.LogForStart();
        }

        public void InitHit(BodyParts Bp)
        {
            FightMdl.CalculateHit(Bp);

            SetFightersCharacteristic();
            NextTurn();
        }

        public void InitializeSettings()
        {
            FightMdl.ReadAllSettings();
        }

        public void SetFightersCharacteristic()
        {
            View.setPlayer(GetPlayerHp(), GetPlayerName());
            View.setNPC(GetNPC_HP(), GetNPC_Name());
        }

        public void NextTurn()
        {
            View.ReverseFighter();
        }

        public string GetPlayerName()
        {
            return FightMdl.PlayerName;
        }

        public int GetNPC_HP()
        {
            return FightMdl.NPC_HP;
        }

        public string GetNPC_Name()
        {
            return FightMdl.NPC_Name;
        }

        public int GetPlayerHp()
        {
            return FightMdl.PlayerHP;
        }

        public int GetMaxHp()
        {
            return FightMdl.maxHP;
        }

        public void InitializeEvents()
        {
            this.Block += GameLogsController.LogForBlock;
            FightMdl.SetFighterBlock(Block);

            this.Wound += GameLogsController.LogForWound;
            FightMdl.SetFighterWound(Wound);

            this.Death += GameLogsController.LogForDeath;
            FightMdl.SetFighterDeath(Death);
        }
    }
}
