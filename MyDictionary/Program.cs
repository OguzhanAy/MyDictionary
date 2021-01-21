using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> products = new MyDictionary<int, string>();
            products.Add(1, "Samsung");
            products.Add(2, "Xiaomi");
            products.Add(3, "Huawei");
        }
    }
}
