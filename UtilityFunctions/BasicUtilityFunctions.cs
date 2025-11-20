namespace UtilityFunctions
{
    [Information(Description ="This class contains basic utility methods")]
    public class BasicUtilityFunctons
    {
        [Information(Description ="This method returns a welcome message")]
        public string WriteWelcomeMessage()
        {
            return "Welcome to 'BasicUtilityFunctions' class";
        }

        [Information(Description ="This method returns the sum of two integer operands")]
        public int IntegerPlusInteger(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        [Information(Description ="This method returns a concated string")]
        public string ConcatThreeStrings(string string1, string string2, string string3)
        {
            return string1 + " "+string2+" "+string3;
        }

        [Information(Description ="This method returns length of a string")]
        public int GetStringLength(string stringValue)
        {
            return stringValue.Length;
        }
    }
}