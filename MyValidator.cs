
using Executable;

public class Validator:Person
{
    public bool ValidatorUsername(string username)
    {
        if (username.Length > 1)
        {
            return true;
        }
        return false;
    }
    public bool ValidatorName(string name)
    {
        if (name.Length >1)
        {
            return true;
            //Console.WriteLine("include your name properly");
        }
        return false;
    }
    public bool ValidatorSurname(string surname)
    {
        if (surname.Length > 1)
        {
            return true;
        }
        return false;
    }
    public bool ValidatorPasswor(string password)
    {
        if (password.Length > 7)
        {
            return true;
            
        }
        return false;
    }
    public bool ValidatorAge(int age)
    {
        if (age > 0)
        {
            return true;
          
        }
        return false;
    }
    public bool ValidatorBirthDay(int birthday)
    {
        if (birthday > 1970)
        {
            return true;
          
        }
        return false;
    }

}

