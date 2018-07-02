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
    }

    public class MainController: IMainController
    {
        IMainView View;
        IFightModel FightMdl;

        public MainController(IMainView v, IFightModel fm)
        {
            View = v;
            FightMdl = fm;

            FightMdl.attach((IModelObserver)View);

            View.setController(this);
        }

        public void StartFight()
        {
            int b;
            b = 6;
        }

        public void InitHit(BodyParts Bp)
        {
            FightMdl.CalculateHit(Bp);
        }

        public void InitializeSettings()
        {
            FightMdl.ReadAllSettings();
        }
    }
}
