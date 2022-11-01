using System;
using StackExchange.Redis;


namespace redis
{
    class Program
    {
        static void Main(string[] args)
        {
            var redisDB = RedisDB.Connection.GetDatabase();

            redisDB.StringSet("1", "Luca");

            var valor = redisDB.StringGet("1");

            Console.WriteLine(valor);
        }
    }
}