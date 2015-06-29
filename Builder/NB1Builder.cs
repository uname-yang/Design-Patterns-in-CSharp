using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class NB1Builder:ActorBuilder
    {
        public override void buildtype()
        {
            actor.type = "type1";
        }

        public override void buildface()
        {
            actor.face = "face1";
        }

        public override void buildsex()
        {
            actor.sex = "sex1";
        }

        public override void buildweapon()
        {
            actor.weapon = "weapon1";
        }


    }
}
