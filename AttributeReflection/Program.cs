using System;
using System.Linq;

namespace AttributeReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo(@"C:\Users\rocho\Desktop", "Lesson.png");
            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
                Console.WriteLine(attribute);

            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
                var attrs = property.GetCustomAttributes(false);
                foreach (var attr in attrs)
                    Console.WriteLine(attr);
            }
            foreach (var property in properties)
            {
                var attrs = property.GetCustomAttributes(false);
                if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                    Console.WriteLine(property.PropertyType + " " + property.Name);
            }
            Console.ReadLine();
        }
    }
}
