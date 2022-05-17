using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntaxDemo
{
    internal class Person
    {
        /// <summary>
        /// Property backer
        /// </summary>
        private string _firstName;

        /// <summary>
        /// 
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public int Age
        {
            get;
            set;
        } = 11;

        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public Person()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string SayHello()
        {
            return "Hi there. My name is " + FullName;
        }

        public override string ToString()
        {
            return "hello";
        }
    }
}
