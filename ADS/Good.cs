using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ADS
{
    public sealed class Good
    {
        public readonly string typeOfGood;
        public readonly int Width;
        public readonly int Height;
        public readonly int Weight;


        public Good(string typeOfGood, int Width, int Height, int Weight)
        {
            this.typeOfGood = typeOfGood;
            this.Width = Width;
            this.Height = Height;
            this.Weight = Weight;
        }

    }
}
