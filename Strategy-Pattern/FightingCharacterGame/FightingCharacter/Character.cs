using System;
using System.Collections.Generic;
using System.Text;

namespace FightingCharacter
{
    public class Character
    {

        private FightingWeapon _fightingWeapon;

        public void SetFightingWeapon(FightingWeapon fightingWeapon)
        {
            _fightingWeapon = fightingWeapon;
        }

        public virtual void DisplayFight()
        {
            _fightingWeapon.UseWeapon();
        }

    }
}
