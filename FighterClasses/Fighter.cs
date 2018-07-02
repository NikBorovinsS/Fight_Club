using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    abstract public class Fighter
    {
        private string _Name;

        private int _HP;

        private BodyParts _BlockedPart;

        public BodyParts LastInputBP
        {
            get;
            set;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int HP
        {
            get { return _HP; }
            set { _HP = value; }
        }

        public BodyParts BlockedPart
        {
            get { return _BlockedPart; }
            set { _BlockedPart = value; }
        }

        abstract public void GetHit(BodyParts BP);

        public event HitMethodsEventHandler Block;
        public event HitMethodsEventHandler Wound;
        public event HitMethodsEventHandler Death;

        public void OnHitMethods(HitMethodsEventArgs e)
        {
            HitMethodsEventHandler handler;
            if (e.BodyId.Equals(BlockedPart))
            {
                handler = Block;
            }
            else
            {
                HP -= (int)e.BodyId;
                e.CurrHP = HP;
                handler = Wound;

                if (HP <= 0)
                {
                    handler = Death;
                }
            }
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void SetBlockEvent(HitMethodsEventHandler block)
        {
            this.Block = block;
        }
        public void SetWoundEvent(HitMethodsEventHandler wound)
        {
            this.Wound = wound;
        }
        public void SetDeathEvent(HitMethodsEventHandler death)
        {
            this.Death = death;
        }
    }

    public class HitMethodsEventArgs : EventArgs
    {
        public BodyParts BodyId { get; set; }
        public DateTime TimeHit { get; set; }
        public string FighterName { get; set; }
        public int RoundCount { get; set; }
        public int CurrHP { get; set; }
    }

    public delegate string HitMethodsEventHandler(Object sender, HitMethodsEventArgs e);

    
}

