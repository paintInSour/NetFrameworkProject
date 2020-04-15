using lab2.Engine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.UI.Custom.IControl
{
    public interface IShowItem
    {
        void ShowItem(Car item);
        void SetChosenItem(Car item);
        void MaxListWidth();
        void MinListWidth();
    }
}
