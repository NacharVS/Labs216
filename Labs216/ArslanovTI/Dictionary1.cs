using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI
{
    class Dictionary1
    {
        public string _name;


        public Dictionary1(Dictionary<int, Setid1> NameOfId, string name)
        {

            _name = name;
            NameOfId.Add
        }
        

        public class Setid1
        {
            public void SetId()
            {
                Random rnd = new Random();
                int IdName1 = rnd.Next(100000, 900000);
                int IdName2 = rnd.Next(100000, 900000);
                int IdName3 = rnd.Next(100000, 900000);
                int IdName4 = rnd.Next(100000, 900000);
                int IdName5 = rnd.Next(100000, 900000);

                if (IdName1 == IdName2)
                {
                    IdName1 += 1;
                    if (IdName2 == IdName3)
                    {
                        IdName2 += 1;
                        if (IdName3 == IdName4)
                        {
                            IdName3 += 1;
                            if (IdName4 == IdName5)
                            {
                                IdName5 += 1;
                            }
                        }
                    }

                }
                
                



            }


        }
    }
}

        
