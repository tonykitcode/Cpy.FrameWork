using System;
using Castle.DynamicProxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Castle.Test.AOP
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Main()
        {
            ProxyGenerator generator = new ProxyGenerator();//实例化【代理类生成器】 
            SimpleInterceptor interceptor = new SimpleInterceptor();//实例化【拦截器】

            var person = generator.CreateClassProxy<Person>(interceptor);

            Console.WriteLine("当前类型:{0},父类型:{1}", person.GetType(), person.GetType().BaseType);
             
            person.SayHello();
            person.SayHi();
        }
    }
}