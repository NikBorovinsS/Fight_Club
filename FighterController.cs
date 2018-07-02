using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    public interface IFighterController
    {
        void SetBodyPart(BodyParts BP);
        void SetHp(int v);
    }

    public class FighterController: IFighterController
    {
        IFighterView FView;
        public FightClubMainForm FCParent;

        public FighterController(IFighterView fv, FightClubMainForm fcmf)
        {
            FView = fv;
            FCParent = fcmf;

            FView.setController(this);
        }

        public void SetHp(int v)
        {
            FView.changeHP(v);
        }
        public void SetBodyPart(BodyParts ChoosedPart)
        {
            FCParent.controller.InitHit(ChoosedPart);
        }
    }
}
