using System.Text.RegularExpressions;

namespace LabWork2Tests
{
    public class UnitTest 
    {
        [Theory]
        [InlineData(2.00, 4)]
        public void CorrectIsPowerPositive(double a, int n)
        {
            Assert.Equal(16.000, Power(a, n));
        }

        [Theory]
        [InlineData(3.05, 5)]
        public void CorrectIsPowerNegative(double a, int n)
        {
            Assert.NotEqual(16.000, Power(a, n));
        }

        [Theory]
        [InlineData("2v5rn49vn0v")]
        public void CorrectIsPasswordPositive(string password)
        {
            Assert.Equal(true, CorrectIsPassword(password), );
        }

        [Theory]
        [InlineData("qwert123")]
        public void CorrectIsPasswordNegative(string password)
        {
            Assert.NotEqual(true, CorrectIsPassword(password));
        }

        double Power(double a, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return a;
            return Convert.ToDouble((a * Power(a, n - 1)).ToString("F3"));
        }

        bool CorrectIsPassword(string password)
        {
            Regex isCorrect = new("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\\p{P}\\p{S}])[A-Za-z\\d\\p{P}\\p{S}]{8,30}$");
            if (isCorrect.IsMatch(password)) return true;
            return false;
        }
    }
}
