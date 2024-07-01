public class Program
{
    public static void Main()
    {
        long number = 700;
        string result = NumberToPersianWords.NumberToPersianWords.Convert(number);

        long number1 = 999999;
        string result1 = NumberToPersianWords.NumberToPersianWords.Convert(number1);

        long number2 = 0;
        string result2 = NumberToPersianWords.NumberToPersianWords.Convert(number2);

        long number3 = 387;
        string result3 = NumberToPersianWords.NumberToPersianWords.Convert(number3);

        long number4 = 2;
        string result4 = NumberToPersianWords.NumberToPersianWords.Convert(number4);

        long number5 = 70000000000;
        string result5 = NumberToPersianWords.NumberToPersianWords.Convert(number5);

        long number6 = 14;
        string result6 = NumberToPersianWords.NumberToPersianWords.Convert(number6);

        long number7 = 0005;
        string result7 = NumberToPersianWords.NumberToPersianWords.Convert(number7);


        Console.WriteLine(result);
    }
}