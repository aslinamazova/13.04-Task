using System;
using System.ComponentModel.DataAnnotations;
namespace Executable
{
	public class Person
	{
		public string username { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
		public string password { get; set; }
        public int age { get; set; }
		public int birthday { get; set; }
    }
}

