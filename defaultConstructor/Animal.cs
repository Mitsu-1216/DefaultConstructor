using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultConstructor
{
    public class Animal
    {
        public int id;
        public string name;

        // 引数が1つの場合のコンストラクタ
        public Animal(string name)
        {
            this.id = 0;
            this.name = name;
            Console.WriteLine(name + "さん、"+"はじめまして！");
        }

        public Animal(string name, int id = 0)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine(name + "さん、"+"いつもありがとうございます！");

            //if (id == 0)
            //{
            //    Console.WriteLine(name + "さん、"+"はじめまして！");
            //}
            //else
            //{
            //    Console.WriteLine( name + "さん、"+"いつもありがとうございます！" );
            //}

        }


    }
}
