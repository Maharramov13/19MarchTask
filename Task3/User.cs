using System.Diagnostics.Contracts;

class User
{
    public string UserName;
    public string password;
    public User(string UserName, string password)
    
    {
        if (UserName.Length >= 8 && password.Length >= 8 && ContainsDigit(password) && ContainsTolower(password) && ContainsUpperCase(password))
        {
            this.UserName = UserName;
            this.password = password;
        }
        else
        {
            System.Console.WriteLine("Ad ve ya sifre duzgun deyil.");
        }

    }

    public bool ContainsUpperCase(string str)
    {
        foreach (char c in str)
        {
            if (char.IsUpper(c))
            {
                return true;
            }
        }
        return false;
    }

    public bool ContainsTolower(string str)
    {
        foreach (char c in str)
        {
            if (char.IsLower(c))
            {
                return true;
            }
        }
        return false;
    }
    public bool ContainsDigit(string str)
    {
        foreach (char c in str)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }

}

