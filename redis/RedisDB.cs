using System;
using StackExchange.Redis;

namespace redis
{
    public class RedisDB
    {
        private static Lazy<ConnectionMultiplexer> _lazyConnection;

        public static ConnectionMultiplexer Connection
        {
            get { return _lazyConnection.Value; }
        }
        static RedisDB()
        {
            _lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
                ConnectionMultiplexer.Connect("localhost")
            );
        }
    }
}
