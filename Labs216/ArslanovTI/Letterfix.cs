using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI
{
    class Letterfix
    { private string _name;
    }
    
        public void SetName(string newName)
        {


            newName = newName.Trim();
            var firstletter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = (firstletter.ToString().ToUpper() + otherLetters);

        }
    }

