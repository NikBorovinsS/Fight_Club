using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    public class NPC: Fighter
    {
        private Random randomizer;

        public NPC()
        {
            randomizer = new Random();
        }

        public override void GetHit(BodyParts AttackedPart)
        {
            HitMethodsEventArgs args = new HitMethodsEventArgs();
            args.BodyId = AttackedPart;
            args.TimeHit = DateTime.Now;

            LastInputBP = AttackedPart;

            OnHitMethods(args);

        }

        public void SetBlock()
        {
            int number = randomizer.Next(1, 135);
            if (number < 60)
            {
                BlockedPart = BodyParts.Head;
            }
            else if (number < 105)
            {
                BlockedPart = BodyParts.Torso;
            }
            else BlockedPart = BodyParts.Legs;
        }

        public BodyParts CalculateAttackedPart()
        {
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
    }
}
