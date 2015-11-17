using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class SpringFactory:SkinFactory
    {
        public Button createButton()
        {
            return new SpringButton();
        }

        public TextField createTextField()
        {
            return new SpringTextField();
        }
    }

    public class SummerFactory : SkinFactory
    {
        public Button createButton()
        {
            return new SummerButton();
        }

        public TextField createTextField()
        {
            return new SummerTextField();
        }
    }
}
