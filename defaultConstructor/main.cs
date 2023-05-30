using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defaultConstructor
{
    public static class main
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        static void Main()
        {
            Animal r = new Animal("うさぎ");
            Animal t = new Animal("かめ",10);
        }
    }
}
