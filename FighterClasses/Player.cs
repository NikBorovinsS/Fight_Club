using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    public class Player: Fighter
    {
        public override void GetHit(BodyParts AttackedPart)
        {
            HitMethodsEventArgs args = new HitMethodsEventArgs();
            args.BodyId = AttackedPart;
            args.TimeHit = DateTime.Now;
            args.FighterName = this.Name;
            args.RoundCount = 1;
            args.CurrHP = HP;

            LastInputBP = AttackedPart;

            OnHitMethods(args);

        }

        public void SetBlock(BodyParts Blocked)
        {
            BlockedPart = Blocked;
        }
    }
}
