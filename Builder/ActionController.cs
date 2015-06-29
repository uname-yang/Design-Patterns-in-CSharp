using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class ActionController
    {
        public Actor Build(ActorBuilder AB)
        {
            AB.buildface();
            AB.buildsex();
            AB.buildtype();
            AB.buildweapon();
            return AB.CreateActor();
        }
    }
}
