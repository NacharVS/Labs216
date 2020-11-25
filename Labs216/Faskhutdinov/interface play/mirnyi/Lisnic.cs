using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Faskhutdinov.interface_play.mirnyi
{

    class Lisnic : Characteristic, IMove, IAtac, IMine

    {
        public int domak { get; }

        public int mine => throw new NotImplementedException();

        public void Atac()
        {

        }

        public void Mine()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {

        }

    }
}

   