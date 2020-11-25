using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Faskhutdinov.interface_play
{
    interface IMove
    {
        void Move();
    }
    interface IAtac
    {
        public int domak { get; }
        void Atac();
    }
    interface IMine
    {
        void Mine();
        public int mine { get; }

    }
}