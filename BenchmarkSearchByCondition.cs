using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LearnBenchmark
{
    [MemoryDiagnoser]
    public class BenchmarkSearchByCondition
    {
        private readonly List<Person> people = Enumerable.Range(1, 1000)
            .Select(_ => Person.GeneratePerson())
            .ToList();

        private bool Condition(Person person)
        {
            return person.Age >= 18
                   && new[] {RegionsEnum.Bryansk, RegionsEnum.Belgorod, RegionsEnum.Smolensk}.Contains(
                       person.RegionEnum);
        }

        [Benchmark]
        public List<Person> FindConditionUsingFor()
        {
            var maturePeople = new List<Person>();
            for (var i = 0; i < people.Count; ++i)
            {
                if (Condition(people[i]))
                {
                    maturePeople.Add(people[i]);
                }
            }
            return maturePeople;
        }

        [Benchmark]
        public List<Person> FindConditionUsingListForeach()
        {
            var maturePeople = new List<Person>();
            people.ForEach(person =>
            {
                if (Condition(person))
                {
                    maturePeople.Add(person);
                }
            });
            return maturePeople;
        }

        [Benchmark]
        public List<Person> FindConditionUsingForeach()
        {
            var maturePeople = new List<Person>();
            foreach (var person in people)
            {
                if (Condition(person))
                {
                    maturePeople.Add(person);
                }
            }
            return maturePeople;
        }
        
        [Benchmark]
        public List<Person> FindConditionUsingListFindAll()
        {
            return people.FindAll(Condition);
        }

        [Benchmark]
        public List<Person> FindConditionUsingLinq()
        {
            return people.Where(Condition).ToList();
        }
    }
    
    public class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public RegionsEnum RegionEnum { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string secondName, int age, RegionsEnum regionEnum)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            RegionEnum = regionEnum;
        }

        public static Person GeneratePerson() =>
            new()
            {
                FirstName = PersonParameters.FirstNames[
                    new Random().Next(0, PersonParameters.FirstNames.Length - 1)],
                SecondName =
                    PersonParameters.SecondNames[new Random().Next(0, PersonParameters.SecondNames.Length - 1)],
                Age = new Random().Next(PersonParameters.MinAge, PersonParameters.MaxAge),
                RegionEnum = PersonParameters.Regions[new Random().Next(0, PersonParameters.Regions.Length - 1)]
            };
    }
    
    public static class PersonParameters
    {
        public static string[] FirstNames =
        {
            "Anton", "Artem", "Arthur",
            "Boris", "Benedict", "Brandon",
            "Vitaliy", "Vladimir"
        };

        public static string[] SecondNames =
        {
            "Antonov", "Artemov", "Petrov",
            "Borisov", "Filatov", "Stark",
            "Tirell", "Lanister", "Ivanov"
        };

        public static int MinAge = 12;
        public static int MaxAge = 100;

        public static RegionsEnum[] Regions =
        {
            RegionsEnum.Bryansk, RegionsEnum.Smolensk, RegionsEnum.Moscow,
            RegionsEnum.SaintPetersburg, RegionsEnum.Belgorod, RegionsEnum.Orel
        };
    }

    public enum RegionsEnum
    {
        Bryansk,
        Smolensk,
        Moscow,
        SaintPetersburg,
        Belgorod,
        Orel
    }
}