using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uobei
{
    static class Order
    {
        //商品情報を格納するDictionary
        public static Dictionary<string, int> OrderList = new Dictionary<string, int>();

        //商品追加用
        public static Dictionary<string, int> OrderAdd(string neta)
        {
            if (OrderList.ContainsKey(neta))
            {
                //既に登録されている場合
                OrderList[neta]++;
            }
            else
            {
                OrderList[neta] = 1;
            }
            return OrderList;
        }

        public static Dictionary<string, int> OrderDec(string neta)
        {
            if (OrderList.ContainsKey(neta))
            {
                //既に登録されている場合
                OrderList[neta]--;

            }
            return OrderList;
        }


    }
}
