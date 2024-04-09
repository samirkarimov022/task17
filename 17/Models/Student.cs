using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task17.Interface;

namespace task17.Models
{
    internal class Student : ICodeAchademy
    {
        public static int count=1;
        public int Id;  
        public string _name;
        public string _surname;
        public string CodeEmail {  get; set; }

        public string Name 
        {
            get 
            {
                return _name; 
            }
            set
            {
                if (Checkname(value)&&value.Length>=3&&value.Length<=10)
                {
                    _name = value;
                }
                else { Console.WriteLine("duzgunn girin"); }
            }
        }
        public string Surname 
        {
            get 
            {
                return _surname;
            }
            set 
            {
                if (Checkname(value)&& value.Length >= 3 && value.Length <= 15)
                {
                    _name = value;
                }
                else { Console.WriteLine("duzgunn girin"); }
            }
        }
        public Student(string name,string surname) 
        {
           Name = name;
            Surname = surname;
            Id = count++;
        }


        string ICodeAchademy.CodeEmail => throw new NotImplementedException();

     

        public void GenerateEmail()
        {

           string email = $"{_name.ToLower()}.{_surname.ToLower()}{Id}@code.edu.az";
            CodeEmail = email;
        }

       public static bool Checkname(string name)
        {
            for (int i = 0; i < count; i++) 
            {
                if (!char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
