using System;
using System.Collections.Generic;
using System.Text;
using SomeGameP.Props;

namespace SomeGameP.Ops
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);

    }
}
