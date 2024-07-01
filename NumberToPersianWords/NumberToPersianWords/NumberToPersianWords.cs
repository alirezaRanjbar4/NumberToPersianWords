namespace NumberToPersianWords
{
    public class NumberToPersianWords
    {
        private static readonly string[] Ones = {
        "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه",
        "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده"
    };

        private static readonly string[] Tens = {
        "", "", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود"
    };

        private static readonly string[] Hundreds = {
        "", "صد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد"
    };

        private static readonly Dictionary<long, string> PowersOfThousand = new Dictionary<long, string>
    {
        { 1000000000000, "تریلیون" },
        { 1000000000, "میلیارد" },
        { 1000000, "میلیون" },
        { 1000, "هزار" },
        // اضافه کردن واحدهای بزرگتر در صورت نیاز
    };

        public static string Convert(long number)
        {
            if (number == 0)
                return Ones[0];

            return ConvertToWords(number);
        }

        private static string ConvertToWords(long number)
        {
            if (number < 0)
                return "منفی " + ConvertToWords(Math.Abs(number));

            string words = "";

            if (number < 20)
            {
                words = Ones[number];
            }
            else if (number < 100)
            {
                words = Tens[number / 10];
                if ((number % 10) > 0)
                    words += " و " + Ones[number % 10];
            }
            else if (number < 1000)
            {
                words = Hundreds[number / 100];
                if ((number % 100) > 0)
                    words += " و " + ConvertToWords(number % 100);
            }
            else
            {
                foreach (var power in PowersOfThousand)
                {
                    if (number >= power.Key)
                    {
                        long baseValue = power.Key;
                        long numBaseUnits = number / baseValue;
                        long remainder = number % baseValue;

                        words = ConvertToWords(numBaseUnits) + " " + power.Value;
                        if (remainder > 0)
                            words += " و " + ConvertToWords(remainder);

                        break;
                    }
                }
            }

            return words;
        }
    }
}
