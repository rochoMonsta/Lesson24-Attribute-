using System;
using System.Linq;

namespace AttributeReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Створили об'єект класу фото
            var photo = new Photo(@"C:\Users\rocho\Desktop", "Lesson.png");
            //Отримування інформації про основні поля класу Photo
            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
                Console.WriteLine(attribute);
            //Отримування інформації про всі поля класу.
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
                var attrs = property.GetCustomAttributes(false);
                foreach (var attr in attrs)
                    Console.WriteLine(attr);
            }
            //Отримування інформації про ті елементи класу, які відмічені атрибутом.
            foreach (var property in properties)
            {
                var attrs = property.GetCustomAttributes(false);
                if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                    Console.WriteLine(property.PropertyType + " " + property.Name);
            }
            //Отримування інформації про методи класу.
            var mathods = type.GetMethods();
            foreach (var method in mathods)
            {
                Console.WriteLine(method.Name);
                var attrs = method.GetCustomAttributes(false);
                foreach (var attr in attrs)
                    Console.WriteLine(attr);
            }
            Console.ReadLine();
        }
    }
}
