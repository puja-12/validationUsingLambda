using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace validation
{
    public class ValidationusingLambda
    {
        public string FName_regex = "^[A-Z]{1}[a-z]{2,}$";
        public string LName_regex = "^[A-Z]{1}[a-z]{2,}$";
        public string MobileNumber_regex = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public string Email_regex = "^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})$";
        public string Pass_regex = "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";


        public string Firstname(string firstName) => Regex.IsMatch(firstName, FName_regex) ? "First Name is Valid!" : "First Name is not Valid!";
        public string Lastname(string lastName) => Regex.IsMatch(lastName, LName_regex) ? "Last Name is Valid!" : "Last Name is not Valid!";
        public string Email(string email) => Regex.IsMatch(email, Email_regex) ? "Email is Valid!" : "Email is not Valid!";
        public string PhoneNumber(string MobileNumber) => Regex.IsMatch(MobileNumber, MobileNumber_regex) ? "Phone Number is Valid!" : "Phone Number is not Valid!";
        public string password(string password) => Regex.IsMatch(password, Pass_regex) ? "Password is Valid!" : "Password is not Valid!";
    }
}
  
