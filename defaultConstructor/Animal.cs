using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultConstructor
{
    internal class Animal
    {
        int id;
        string name;

        public Animal(string name, int id = 0)
        {
            this.id = id;
            this.name = name;

            if (id==0)
            {
                Console.WriteLine(name + "さん、"+"はじめまして！");
            }
            else
            {
                Console.WriteLine( name + "さん、"+"いつもありがとうございます！" );
            }

        }



    }
}
