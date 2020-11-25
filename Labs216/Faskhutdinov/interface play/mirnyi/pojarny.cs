using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Faskhutdinov.interface_play.mirnyi
{
    class pojarny : Characteristic, IMove, IAtac, IMine

    {
        public int domak { get; }

        int IMine.mine => throw new NotImplementedException();

        public int mine;

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
