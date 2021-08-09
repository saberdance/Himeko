using System;
using tsubasa;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Redis redis = new("localhost");
            bool succ = redis.Connect();
            Console.WriteLine($"连接redis:{succ}");
            if (succ)
            {
                succ = redis.Set("huangyi", "牛逼");
                Console.WriteLine($"写入Redis,[huangyi]:牛逼 {succ}");
            }
            if (succ)
            {
                string val = redis.Get("huangyi");
                Console.WriteLine($"取出[huangyi]:{val}");
            }
        }
    }
}
