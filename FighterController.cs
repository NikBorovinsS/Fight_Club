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
        void SetHp(int hp);
        void SetName(string Name);
        void setMAX_HP(int max_hp);
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

        public void SetHp(int hp)
        {
            FView.changeHP(hp);
        }

        public void SetName(string name)
        {
            FView.changeName(name);
        }

        public void setMAX_HP(int max_hp)
        {
            FView.setHPBar(max_hp);
        }

        public void SetBodyPart(BodyParts ChoosedPart)
        {
            FCParent.controller.InitHit(ChoosedPart);
        }
    }
}
