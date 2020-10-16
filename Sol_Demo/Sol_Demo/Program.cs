using System;

namespace Sol_Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDemo<UserModel, UserModel> demo = new Demo();
            var userModel = demo.DemoMethod(new UserModel()
            {
                FullName = "Kishor Naik"
            });
            Console.WriteLine(userModel.FullName);
        }
    }

    public interface IDemo<out TReturn, in TPara>
        where TReturn : class
        where TPara : class
    {
        TReturn DemoMethod(TPara para);
    }

    public class UserModel
    {
        public String FullName { get; set; }
    }

    public class Demo : IDemo<UserModel, UserModel>
    {
        UserModel IDemo<UserModel, UserModel>.DemoMethod(UserModel para)
        {
            return para;
        }
    }
}