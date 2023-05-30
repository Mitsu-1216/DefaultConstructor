using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defaultConstructor
{
    public static class main
    {
        // メイン エントリ ポイント
        static void Main()
        {
            // インスタンス生成
            Animal r = new Animal("うさぎ");
            Animal t = new Animal("かめ", 100);
        }

    }
}
