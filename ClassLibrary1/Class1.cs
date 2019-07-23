using System;

namespace ClassLibrary1
{
   public abstract class QueryBase
    {
        public virtual void SendQuery(string query)
        {
            Console.WriteLine("Birşeyler yazdım");
        }

        public abstract void Method();
    }

   public interface ICache
    {
        object GetData(string key);
        void SetData(string key, object data);
    }

    public interface IConnectableCache : ICache
    {
        bool Connect(string conectionsrt);

        bool DisConnect();
    }

    public class InMemoryCache : ICache
    {
        public object GetData(string key)
        {
            return null;
        }

        public void SetData(string key, object data)
        {
            
        }
    }

    public class SQLCache: QueryBase, IConnectableCache
    {
        public override void SendQuery(string query)
        {
            Console.WriteLine("Birşeyler yazdım SQLCache");
            base.SendQuery(query);
        }

        public void SetData(string key, object data)
        {

        }

        public object GetData(string key)
        {
            return null;
        }

        public bool Connect(string conectionsrt)
        {
            throw new NotImplementedException();
        }

        public bool DisConnect()
        {
            throw new NotImplementedException();
        }

        public override void Method()
        {
            throw new NotImplementedException();
        }
    }

    public class OracleCache:SQLCache
    {

    }

    public class RedisCache : QueryBase, IConnectableCache
    {
        public bool Connect(string conectionsrt)
        {
            throw new NotImplementedException();
        }

        public bool DisConnect()
        {
            throw new NotImplementedException();
        }

        public object GetData(string key)
        {
            return null;
        }

        public override void Method()
        {
            throw new NotImplementedException();
        }

        public void SetData(string key, object data)
        {

        }
    }

    public class MyTransaction
    {
        public void Method1(ICache cache)
        {
  
            object data = cache.GetData("mykey");

        }
    }
}


