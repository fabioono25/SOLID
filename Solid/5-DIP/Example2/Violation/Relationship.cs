using System;
using System.Collections.Generic;
using System.Linq;

namespace Solid.DIP.Example2.Violation
{
    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }

    public class Person{
        public string Name;
    }

    //LOW-LEVEL
    public class Relationships{
        private List<(Person, Relationship, Person)> relations 
        = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child){
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public List<(Person, Relationship, Person)> Relations => relations;
    }

    public class Research{
        
        public Research(Relationships relationships)
        {
            var relations = relationships.Relations;

            foreach (var r in relations.Where(
                x => x.Item1.Name == "John" &&
                x.Item2 == Relationship.Parent
            )){
                Console.WriteLine($"John has a child called {r.Item3.Name}");
            }


        }

        public static void Execute(){
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);
        }
    }

}