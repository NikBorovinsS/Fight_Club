using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    public interface IFighterView
    {
        void setController(IFighterController cont);
        void changeHP(int hp);
        void changeName(string name);
    }
}
