using netFrameworkProject.Engine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.UI.Custom.IControl
{
    public interface IShowItem
    {
        void ShowItem(Car item);
        void SetChosenItem(Car item);
        void MaxListWidth();
        void MinListWidth();
    }
}
