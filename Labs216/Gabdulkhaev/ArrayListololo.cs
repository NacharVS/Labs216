using System.Collections;

namespace Labs216.Gabdulkhaev
{
    class ArrayListololo
    {
        public static void array()
        {
            ArrayList LList = new ArrayList();
            LList.Add("оп");
            LList.Add(2.3);
            LList.Add(55);
            LList.Add("фыддф");
            LList.Add(5.084);
            LList.Add(243);
            LList.Add("фысьфысь");
            LList.Add(0.0001);
            LList.Add(1);
            LList.Add("строка");
            LList.Add(100.001);
            LList.Add(1000);
            ArrayList ChislaList = new ArrayList();
            ArrayList SlovaList = new ArrayList();
            ArrayList DrobiList = new ArrayList();
            foreach (var item in LList)
            {
                string tip = item.GetType().ToString();
                switch (tip)
                {
                    case "System.Int32":
                        ChislaList.Add(item);
                        break;
                    case "System.String":
                        SlovaList.Add(item);
                        break;
                    case "System.Double":
                        DrobiList.Add(item);
                        break;
                }
            }
            // отсортировать на int, double and string и раскидать по трем разным массивам ( либо коллекциям)
        }
}
}
