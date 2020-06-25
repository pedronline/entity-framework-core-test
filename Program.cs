using System;
using entity_framework_core_test.Entities;

namespace entity_framework_core_test {
    class Program {
        static void Main (string[] args) {
            using (var db = new ActorDbContext()) {
                db.Actors.AddRange (
                    new Actor { Name = "Bruce Lee", Age = 75, AcademyWinner = false },
                    new Actor { Name = "Madonna", Age = 55, AcademyWinner = true }
                );
                var count = db.SaveChanges();
                Console.WriteLine($"{count} records added");
                foreach (var Actor in db.Actors) {
                    Console.WriteLine($"Name - {Actor.Name},\t\t" +
                        $"Age: {Actor.Age}, \t\t" +
                        $"Academy Winner: {Actor.AcademyWinner}");
                }
            }
        }
    }
}