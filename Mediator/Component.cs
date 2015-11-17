using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    abstract class Component
    {
        protected Mediator mediator;

        public void setMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void changed()
        {
            mediator.compontChanged(this);
        }

        public abstract void update();
    }
}
