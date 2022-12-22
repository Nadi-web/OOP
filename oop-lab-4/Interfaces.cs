using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_4
{
    interface IControl
    {
        void Start_Event();
        void End_Event();
    }

    interface ICheckbox : IControl
    {
        void input();
        void GettingSq();
    }

    interface IRadiobutton : IControl
    {
        void show();
    }

    interface IButton : IControl
    {
        void resize();
    }

    interface ISquare
    {
        int GetSq();
        void GettingSq(int s);
    }
}
