using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina.StrategyGame.Zdaniya
{
    class Ferma : Characteristic, IDlyaZdaniya
    {
        public Ferma (double height, double shirina,  int ckolichestvo)
        {
            _height = height;
            _shirina = shirina;
            
            _ckolichestvo=ckolichestvo;
        }
        public void ChisloChelovek()
        {
            _S = _height * _shirina;
            Console.WriteLine($"Сейчас вы посетили ФЕРМУ! Её площадь составляет {_S} метров в кв. ");
            Console.WriteLine($"На эту ферму поместится {_S/1} человек, либо {_S/2} коров, либо {_S/0.5} куриц...");

        }

        public void ChtoHranitca()
        {
            
        }
    }
}
