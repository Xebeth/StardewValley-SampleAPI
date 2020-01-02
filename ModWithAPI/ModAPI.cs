using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModWithAPI
{
    // ReSharper disable UnusedMember.Global
    public class ModAPI
    {
        public IThing GetThing(string example)
        {
            return new Thing(example);
        }
    }

    public interface IThing
    {
        string DoStuff(int stuff);
    }

    public class Thing : IThing
    {
        private string _thing { get; }

        public Thing(string thing)
        {
            _thing = thing;
        }

        public string DoStuff(int stuff)
        {
            return (stuff == 42) ? _thing : "nope";
        }
    }
}
