using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSyntaxDemo
{
    class Program
    {
        /// <summary>
        /// Property Example 1
        /// </summary>
        public static string[] Words = new string[] { "This", "is", "a", "test", "of", "the", "emergency", "broadcast", "system." };

        public static IList<string> WordsList = Words.ToList();


        public static object[] HeterogenousArray = new object[] { 1, "a" };

        // const is always static
        private const double PI = 3.14D;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //string userChoice = Console.ReadLine();
            //Console.Clear();
            //Environment.Exit(0);
            // variable declaration
            int j, k, l;
            int m = 0;
            var n = 0;
            Console.WriteLine(n.GetType());
            Console.WriteLine(m.CompareTo(n));
            Console.WriteLine(true);

            Person newperson = new();
            Console.WriteLine(newperson);

            // bad variable name -> var if = 1;
            // valid variable
            var @if = 1;

            @if++;
            double t = 1.23;
            Console.WriteLine(Convert.ToString(@if));    // convert int to string
            Console.WriteLine(Convert.ToDouble(m));    // convert int to double
            Console.WriteLine(Convert.ToInt32(t));  // convert double to int
            Console.WriteLine(Convert.ToString(true));   // convert bool to string

            // flow and logic control

            // for loop
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("For loop");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Words.Length; i++)
            {
                Console.WriteLine(Words[i]);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("For loop, if statement and ternary statement");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Words.Length; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(Words[i]);
                }


                var wordToWrite = (Words[i].Contains('e')) ? Words[i] : "Not a match";

                Console.WriteLine(wordToWrite);
            }

            // foreach loop
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("For Each loop");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var word in Words)
            {
                if (word.Contains("e"))
                    Console.WriteLine(word);
            }

            // do-while/while loop
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("do-while/while loop");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                switch (n)
                {
                    case 20:
                        Console.WriteLine(n);
                        break;
                    case 30:
                    case 31:
                    case 32:
                    case 33:
                    case 34:
                    case 35:
                        Console.WriteLine(n);
                        break;
                    default: //if none of the cases where cut
                        // no need to do anything;
                        break;

                }

                n++;
            }
            while (n < 100);

            while (n < 200)
            {
                n++;
            }

            // methods
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("methods");
            Console.ForegroundColor = ConsoleColor.White;

            WriteWords();
            MethodWithParameters(5);
            MethodWithParametersPredefined();
            MethodWithParametersPredefined(5);
            Console.WriteLine(MethodWithFuncParameter(w => w + " functions"));


            // classes
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Classes");
            Console.ForegroundColor = ConsoleColor.White;

            var person2 = new Person("Steve", "Smith");
            Console.WriteLine(person2.FullName);
            var helloStatement = person2.SayHello();
            Console.WriteLine(helloStatement);

            var person3 = new Person
            {
                FirstName = "Farid",
                LastName = "Seifi"
            };

            Console.WriteLine(person3.FullName);

            // exceptions

            try
            {
                Person? person = null;
                helloStatement = person.SayHello();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception intentionally thrown here. Object is null");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // do something else
            }

            try
            {
                // null conditional operator
                // this statement helloStatement = person?.SayHello(); will only call SayHello() if person is not null
                Person? person = null;
                helloStatement = person?.SayHello();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception intentionally thrown here. Object is null");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // do something else
            }

            // playing with objects
            Console.WriteLine("Playing with objects");

            Person p = new();

            Person d = p;

            PlayWithObjects(p);

            Console.WriteLine(p.Age);
            Console.WriteLine(d.Age);

            StructPerson sp = new();

            StructPerson sd = sp;

            sd.Age = 7;

            PlayWithStructs(sp);

            Console.WriteLine(sp.Age);
            Console.WriteLine(sd.Age);

            StructPerson sp2 = new("a", "b");
            Console.WriteLine(sp2.FirstName);

            Console.WriteLine(string.Join(",", WordsList));

            AddWord(WordsList);

            Console.WriteLine("word added");

            Console.WriteLine(string.Join(",", WordsList));

            // playing with ints

            n = 32;

            Console.WriteLine("playing with ints");
            Console.WriteLine(n);
            PlayWithInts(n);
            Console.WriteLine(n);

            Console.WriteLine("playing with ints");

            Int32 int32 = 32;
            Console.WriteLine(int32);
            PlayWithInt32(int32);
            Console.WriteLine(int32);

            Int32 int32New = new Int32();
            int32New = 32;
            Console.WriteLine(int32New);
            PlayWithInt32(int32New);
            Console.WriteLine(int32New);

            // language integrated query
            PerformQueries();

            // lambda expressions
            PerformLambdas();

            Console.In.ReadLine();
        }

        private static void PlayWithInts(int n)
        {
            n = 100;
        }

        private static void PlayWithInt32(Int32 n)
        {
            n = 100;
        }

        private static void AddWord(IList<string> wordsList)
        {
            wordsList.Add("!!!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int WriteWords()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("method with return value");
            Console.ForegroundColor = ConsoleColor.White;

            int numberOfWords = 0;

            foreach (var word in Words)
            {
                numberOfWords++;
                Console.Write(word + " ");
            }

            Console.WriteLine();

            return numberOfWords;
        }

        /// <summary>
        /// Overloaded operator
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static int WriteWords(List<string> words)
        {
            int numberOfWords = 0;

            foreach (var word in words)
            {
                numberOfWords++;
                Console.Write(word + " ");
            }

            Console.WriteLine();

            return numberOfWords;
        }

        /// <summary>
        /// Overloaded operator
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static int Write(List<object> things)
        {
            int numberOfThings = 0;

            foreach (var thing in things)
            {
                numberOfThings++;
                Console.Write(thing.ToString() + " ");
            }

            Console.WriteLine();

            return numberOfThings;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberOfTimes"></param>
        public static void MethodWithParameters(int numberOfTimes)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("method with parameters but not return value");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < numberOfTimes; i++)
                WriteWords();
        }

        /// <summary>
        /// Note that this method has a default number. If the programmer does not pass a variable it will remain 10
        /// </summary>
        /// <param name="numberOfTimes"></param>
        public static void MethodWithParametersPredefined(int numberOfTimes = 10)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("method with predefined parameters but not return value");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < numberOfTimes; i++)
                WriteWords();
        }


        public static string MethodWithFuncParameter(Func<string, string> fun)
        {
            return fun("testing");
        }

        public static string PlayWithObjects(Person p)
        {
            p.Age = 100;
            return p.FirstName;
        }

        public static string PlayWithStructs(StructPerson p)
        {
            p.Age = 100;
            return p.FirstName;
        }


        /// <summary>
        /// 
        /// </summary>
        private static void PerformQueries()
        {

            /*
             from <range variable> in <IEnumerable<T> or IQueryable<T> Collection>
             <Standard Query Operators> <lambda expression>
             <select or groupBy operator> <result formation>
            */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("LINQ queries");
            Console.ForegroundColor = ConsoleColor.White;


            var simpleSelectEnumerable = (from w in Words select w);
            foreach (string w in simpleSelectEnumerable)
            {
                Console.WriteLine(w);
            }

            var simpleSelect = (from w in Words select w).ToList();
            WriteWords(simpleSelect);

            var selectWithLogic = (from w in Words where w.Contains("e") select w).ToList();
            WriteWords(selectWithLogic);

            var selectWithCompoundedLogic = (from w in Words where w.Contains('e') && w.Length > 4 select w).ToList();
            WriteWords(selectWithCompoundedLogic);

            var selectWithLogicAndOrderBy = (from w in Words where w.Contains('e') orderby w select w).ToList();
            WriteWords(selectWithLogicAndOrderBy);

            // notice we are only selecting the Lenght property of the Words
            var selectPropertiesOfTheObjectsBeingQueried = (from w in Words where w.Contains('e') && w.Length > 4 select w.Length).ToList();
            foreach (var result in selectPropertiesOfTheObjectsBeingQueried)
            {
                Console.WriteLine(result);
            }

            var max = (from w in Words select w.Length).Max();
            Console.WriteLine(max);

            var min = (from w in Words select w.Length).Min();
            Console.WriteLine(min);

            var sum = (from w in Words select w.Length).Sum();
            Console.WriteLine(sum);

            var average = (from w in Words select w.Length).Average();
            Console.WriteLine(average);

            var take = (from w in Words select w.Length).Take(2).ToList();
            foreach (var result in take)
            {
                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// Note, i personally perfer lambdas to linq queries but the performance is exactly the same
        /// </summary>
        private static void PerformLambdas()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lambda expressions for each of the same linq queries");
            Console.ForegroundColor = ConsoleColor.White;

            var simpleSelect = Words.ToList();
            WriteWords(simpleSelect);

            var selectWithLogic = Words.Where(w => w.Contains('e')).ToList();
            WriteWords(selectWithLogic);

            var selectWithCompoundedLogic = Words.Where(w => w.Contains('e') && w.Length > 4).ToList();
            WriteWords(selectWithCompoundedLogic);

            var selectWithLogicAndOrderBy = Words.Where(w => w.Contains('e')).OrderBy(w => w).ToList();
            WriteWords(selectWithLogicAndOrderBy);


            // notice we are only selecting the Lenght property of the Words
            var selectPropertiesOfTheObjectsBeingQueried = Words.Where(w =>
            {
                return w.Contains("e") && w.Length > 4;
            }).Select(w => w.Length).ToList();




            foreach (var result in selectPropertiesOfTheObjectsBeingQueried)
            {
                Console.WriteLine(result);
            }

            var max = Words.Select(w => w.Length).Max();
            Console.WriteLine(max);

            var min = Words.Select(w => w.Length).Min();
            Console.WriteLine(min);

            var sum = Words.Select(w => w.Length).Sum();
            Console.WriteLine(sum);

            var average = Words.Select(w => w.Length).Average();
            Console.WriteLine(average);

            var take = Words.Take(2).ToList();
            foreach (var result in take)
            {
                Console.WriteLine(result);
            }
        }
    }
}
