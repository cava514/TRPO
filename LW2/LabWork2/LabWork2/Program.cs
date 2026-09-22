using System.Text.RegularExpressions;
public class Program
{
    double Power(double a, int n)
    {
        if (n == 0) return 1;
        if (n == 1) return a;
        return a * Power(a, n - 1);
    }

    bool CorrectIsPassword(string password)
    {
        Regex regex = new("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\\p{P}\\p{S}])[A-Za-z\\d\\p{P}\\p{S}]{8,30}$");
        if (regex.IsMatch(password)) return true;
        return false;
    }
}
