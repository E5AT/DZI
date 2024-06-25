using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad28
{
    class Person
    {
        public string firstName, lastName, id;
        public Person(string fName, string lName, string ID)
        {
            firstName = fName;
            lastName = lName;
            if (ID.Length == 10) id = ID;
            else Console.WriteLine($"{fName} {lName} - invalid identifier!");
        }
    }
    class Kid : Person
    {
        public int age;
        public string group, parentLastName, parentGSM;

       public Kid(string fName, string lName, string ID, int age, string parentName, string GSM ) : base(fName, lName, ID)
        {
            parentLastName = parentName;
            parentGSM = GSM;

            switch (age)
            {
                case 3: group = "1-ва група"; this.age = age; break;
                case 4: group = "2-ра група"; this.age = age; break;
                case 5: group = "3-та група"; this.age = age; break;
                case 6: group = "4-та група"; this.age = age; break;
                default: throw new Exception($"The child {firstName} {lastName} age is invalid - {age}"); break;
            }

            
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}, {age}, {parentGSM} ({parentLastName})";
        }
    }

    class KinderGarden
    {
        List<Kid> kidList;
        public KinderGarden()
        {
            kidList = new List<Kid>();
        }

        public void EnrollKid(Kid kid)
        {
            kidList.Add(kid);
            Console.WriteLine($"The child {kid.firstName} {kid.lastName} is enrolled.");
        }

        public void ReleaseKid(string id)
        {
            Kid kid = kidList.Find(k => k.id == id);
            if (kid !=null)
            {
                kidList.Remove(kid);
                Console.WriteLine($"The child {kid.firstName} {kid.lastName} has been unsubscribed.");
            }
            else Console.WriteLine($"Unsubscribe failed - invalididentifier {id}.");
        }
        public void GroupInfo(int i)
        {
                List<Kid> kidGarden = new List<Kid>();
                for(int j = 0; j < kidGarden.Count; j++)
                {
                    if (kidList[i].group.Contains(i.ToString()))
                        kidGarden.Add(kidList[i]);
                }
                Console.WriteLine($"{i} group - {kidGarden.Count} children");

                kidGarden.OrderBy(k => k.firstName).ThenBy(k => k.lastName);
                foreach (Kid kid in kidGarden)
                    Console.WriteLine(kid.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KinderGarden garden = new KinderGarden();
            string[] words;
            do
            {
                string answer = Console.ReadLine();
                words = answer.Split(' ');
                switch (words[0])
                {
                    case "enrollment":
                        Kid kid = new Kid(words[1], words[2], words[3], int.Parse(words[4]), words[5], words[6]);
                        garden.EnrollKid(kid);
                        break;

                    case "unsubscribe":
                        garden.ReleaseKid(words[1]);
                        break;

                    case "information":
                        garden.GroupInfo(int.Parse(words[1]));
                        break;

                    default:
                        Console.WriteLine($"{words[0]} - invalid command.");
                        break;
                }
            } while (words[0] != "END");

            
        }
    }
}
