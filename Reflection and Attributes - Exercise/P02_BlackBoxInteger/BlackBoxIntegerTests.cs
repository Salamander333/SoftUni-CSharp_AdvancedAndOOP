namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);
            var instance = (BlackBoxInteger)Activator.CreateInstance(type, true);

            while (true)
            {
                var input = Console.ReadLine().Split("_");
                if (input[0] == "END")
                {
                    break;
                }

                var method = input[0];
                var value = int.Parse(input[1]);

                type.GetMethod(method, BindingFlags.Instance | BindingFlags.NonPublic).Invoke(instance, new object[] { value });

                var currentValue = type.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(instance);

                Console.WriteLine(currentValue);
            }
        }
    }
}
