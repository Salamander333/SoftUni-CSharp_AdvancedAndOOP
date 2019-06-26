 namespace P01_HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type type = typeof(HarvestingFields);

            while (true)
            {
                var input = Console.ReadLine();

                List<FieldInfo> fields = new List<FieldInfo>();

                switch (input)
                {
                    case "protected":
                        fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.IsFamily).ToList();
                        break;
                    case "private":
                        fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.IsPrivate).ToList();
                        break;
                    case "public":
                        fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance).ToList();
                        break;
                    case "all":
                        fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static).ToList();
                        break;
                    case "HARVEST":
                        return;
                }

                foreach (var field in fields)
                {
                    var accessModifier = "";
                    if (field.IsPrivate)
                    {
                        accessModifier = "private";
                    }
                    else if (field.IsPublic)
                    {
                        accessModifier = "public";
                    }
                    else
                    {
                        accessModifier = "protected";
                    }
                    Console.WriteLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}
