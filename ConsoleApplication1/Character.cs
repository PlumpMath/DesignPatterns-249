﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Character
    {


        private IWeapon weapon;

        public void SetWeapon(IWeapon newWeapon) {

            weapon = newWeapon;
        
        }

        public void Attack() {


            weapon.Use();
        
        
        }



    }
}
