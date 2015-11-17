using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public abstract class ActorBuilder
    {
        protected Actor actor = new Actor();

        public Actor CreateActor()
        {
            return actor;
        }

        public abstract void buildtype();
        public abstract void buildsex();
        public abstract void buildweapon();
        public abstract void buildface();
    }
}
