using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_MusicalInstruments
{
    // 🔹 Абстрактний клас
    abstract class MusicalInstrument
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }

        public MusicalInstrument() { }

        public MusicalInstrument(string name, string type, string country)
        {
            Name = name;
            Type = type;
            Country = country;
        }

        public MusicalInstrument(MusicalInstrument other)
        {
            Name = other.Name;
            Type = other.Type;
            Country = other.Country;
        }

        // 🔹 Абстрактні методи
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();

        // 🔹 Загальний метод для виведення інформації
        public virtual void ShowInfo()
        {
            Show();
            Desc();
            History();
            Sound();
            Console.WriteLine(new string('-', 40));
        }
    }

    // 🎻 Скрипка
    class Violin : MusicalInstrument
    {
        public Violin() : base("Скрипка", "Смичковий", "Італія") { }
        public Violin(string name, string type, string country) : base(name, type, country) { }
        public Violin(Violin other) : base(other) { }

        public override void Sound() => Console.WriteLine("Скрипка видає ніжний мелодійний звук.");
        public override void Show() => Console.WriteLine($"Назва інструменту: {Name}");
        public override void Desc() => Console.WriteLine("Смичковий музичний інструмент з чотирма струнами.");
        public override void History() => Console.WriteLine("Виникла у XVI столітті в Італії.");
    }

    // 🎺 Тромбон
    class Trombone : MusicalInstrument
    {
        public Trombone() : base("Тромбон", "Духовий", "Франція") { }
        public Trombone(string name, string type, string country) : base(name, type, country) { }
        public Trombone(Trombone other) : base(other) { }

        public override void Sound() => Console.WriteLine("Тромбон звучить гучно і мідно.");
        public override void Show() => Console.WriteLine($"Назва інструменту: {Name}");
        public override void Desc() => Console.WriteLine("Духовий інструмент з рухомим смичком (кулісою).");
        public override void History() => Console.WriteLine("З’явився у XV столітті, спочатку у Франції.");
    }

    // 🎸 Укулеле
    class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Укулеле", "Струнний", "Гаваї") { }
        public Ukulele(string name, string type, string country) : base(name, type, country) { }
        public Ukulele(Ukulele other) : base(other) { }

        public override void Sound() => Console.WriteLine("Укулеле видає веселий і дзвінкий звук.");
        public override void Show() => Console.WriteLine($"Назва інструменту: {Name}");
        public override void Desc() => Console.WriteLine("Невелика гітара з чотирма струнами.");
        public override void History() => Console.WriteLine("З’явилась у XIX столітті на Гаваях.");
    }

    // 🎻 Віолончель
    class Cello : MusicalInstrument
    {
        public Cello() : base("Віолончель", "Смичковий", "Італія") { }
        public Cello(string name, string type, string country) : base(name, type, country) { }
        public Cello(Cello other) : base(other) { }

        public override void Sound() => Console.WriteLine("Віолончель видає глибокий, теплий звук.");
        public override void Show() => Console.WriteLine($"Назва інструменту: {Name}");
        public override void Desc() => Console.WriteLine("Смичковий інструмент з низьким тоном.");
        public override void History() => Console.WriteLine("Створена у XVI столітті в Італії.");
    }

    // 🧮 Головна програма
    class Program
    {
        static void Main(string[] args)
        {
            MusicalInstrument[] instruments =
            {
                new Violin(),
                new Trombone(),
                new Ukulele(),
                new Cello()
            };

            foreach (var instrument in instruments)
            {
                instrument.ShowInfo();
            }

            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}