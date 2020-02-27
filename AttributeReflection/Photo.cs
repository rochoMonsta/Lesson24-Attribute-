using System;

namespace AttributeReflection
{
    //[Geo(10, 20)]
    public class Photo
    {
        public string Path { get; set; }
        [Geo(10, 20)]
        public string Name { get; set; }
        public Photo() { }
        [Geo(10, 20)]
        public Photo(string Path, string Name)
        {
            if (string.IsNullOrWhiteSpace(Path))
                throw new ArgumentNullException(nameof(Path), "Uncorrect input data.");
            else
                this.Path = Path;

            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException(nameof(Name), "Uncorrect input data.");
            else
                this.Name = Name;
        }
        public override string ToString()
        {
            return $"{this.Path} - {this.Name}";
        }
    }
}
