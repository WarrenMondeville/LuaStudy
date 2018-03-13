using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LuaInterface;

namespace luainterface1
{
    class Program
    {
        public string name = "wada";
        static void Main(string[] args)
        {  
            Lua lua = new Lua();
            lua["num"] = 33;
            Console.WriteLine(lua["num"]);

            //lua.DoString("num=2");
            lua.DoString("str='a string'");
            object[] values = lua.DoString("return num,str");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("________________");
            lua.DoFile("LuaScripts/mylua.lua");
            Console.WriteLine("________________");

            Program p = new Program();
            lua.RegisterFunction("LuaMethod", p, p.GetType().GetMethod("CLRMethod"));
            lua.DoString("LuaMethod()");

            lua.RegisterFunction("LuaStaticMethod", null, p.GetType().GetMethod("CLRStaticMethod"));
            lua.DoString("LuaStaticMethod()");
            Console.WriteLine("________________");

            lua.DoFile("LuaScripts/script.lua");


            Console.ReadKey();
        }

        public  void CLRMethod()
        {
            Console.WriteLine("HHHHH");
        }
        public static void CLRStaticMethod()
        {
            Console.WriteLine("HHHHHAAAAAA");
        }

        public void TestOut(string str,out int count) {
            Console.WriteLine(str);
            count= str.Length;
        }

        public void TestRef(string str,ref int count)
        {
            Console.WriteLine(str+count);
            count = str.Length;
        }

    }
}
