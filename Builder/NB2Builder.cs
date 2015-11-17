using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class NB2Builder : ActorBuilder
    {
        public override void buildtype()
        {
            actor.type = "type2";
        }

        public override void buildface()
        {
            actor.face = "face2";
        }

        public override void buildsex()
        {
            actor.sex = "sex2";
        }

        public override void buildweapon()
        {
            actor.weapon = "weapon2";
        }


    }
}
