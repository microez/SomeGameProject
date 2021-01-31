using System;
using System.Collections.Generic;
using System.Text;
using SomeGameP.Props;

namespace SomeGameP.Ops
{
    interface IItemManager
    {
        void ListItems();
        void Add(IItem item);
        void Discard(IItem item);
    }
}
