using FactoryPattern.Models;
using FactoryPattern.Repsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new RepositoryFactory();
            var repoTrainee = factory.CreateRepository<GenericRepository<Trainee>>();
            repoTrainee.Add(new Trainee { Id = 101, Name = "T1", Course = "ESAD", Round = 52 });
            repoTrainee.Add(new Trainee { Id = 102, Name = "T2", Course = "NT", Round = 52 });
            repoTrainee.Add(new Trainee { Id = 103, Name = "T3", Course = "WPSI", Round = 52 });
            repoTrainee.GetAll()
                .ToList()
                .ForEach(t => Console.WriteLine($"Id: {t.Id}\tName: {t.Name}\tRound: {t.Round}\tCourse: {t.Course}"));
            
            Console.WriteLine("Updating Trainee with Id 102");
            repoTrainee.Update(new Trainee { Id = 102, Name = "T2", Course = "DDD", Round = 52 });
            repoTrainee.GetAll()
                .ToList()
                .ForEach(t => Console.WriteLine($"Id: {t.Id}\tName: {t.Name}\tRound: {t.Round}\tCourse: {t.Course}"));
            Console.WriteLine("Deleting Trainee with Id 102");
            repoTrainee.Delete(102);
            repoTrainee.GetAll()
                .ToList()
                .ForEach(t => Console.WriteLine($"Id: {t.Id}\tName: {t.Name}\tRound: {t.Round}\tCourse: {t.Course}"));
            Console.WriteLine("---------------------------------------------");
            var repoInstructor = factory.CreateRepository<GenericRepository<Instructor>>();
            repoInstructor.Add(new Instructor { Id = 1, Name = "Instructor 1", Course = "ESAD" });
            repoInstructor.Add(new Instructor { Id = 2, Name = "Instructor 2", Course = "GAVE" });
            repoInstructor.Add(new Instructor { Id = 3, Name = "Instructor 3", Course = "DDD" });
            repoInstructor.GetAll()
                .ToList()
                .ForEach(i => Console.WriteLine($"Id: {i.Id}\t Name: {i.Name}\t{i.Course}"));
            Console.WriteLine("Updating Instructor with Id 2");
            repoInstructor.Update(new Instructor { Id = 2, Name = "Instructor 2", Course = "CCO" });
            repoInstructor.GetAll()
               .ToList()
               .ForEach(i => Console.WriteLine($"Id: {i.Id}\t Name: {i.Name}\t{i.Course}"));
            Console.WriteLine("Deleing Instructor with Id 2");
            repoInstructor.Delete(2);
            repoInstructor.GetAll()
               .ToList()
               .ForEach(i => Console.WriteLine($"Id: {i.Id}\t Name: {i.Name}\t{i.Course}"));
            
            Console.ReadLine();

        }
    }
}
