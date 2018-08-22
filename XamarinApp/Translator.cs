using System.Text;

namespace XamarinApp
{
    public static class Translator
    {
        public static string ToNumber(string raw)
        {
            if (string.IsNullOrEmpty(raw)) return string.Empty;
            else raw = raw.ToUpperInvariant();

            var newRaw = new StringBuilder();
            foreach (var c in raw)
            {
                if (" -0123456789".Contains(c.ToString())) newRaw.Append(c);
                else
                {
                    var number = CharToNumber(c);
                    if (number.HasValue) newRaw.Append(number);
                }
            }

            return newRaw.ToString();
        }

        private static int? CharToNumber(char c)
        {
            if ("ABC".Contains(c.ToString())) return 2;
            if ("DEF".Contains(c.ToString())) return 3;
            if ("GHI".Contains(c.ToString())) return 4;
            if ("JKL".Contains(c.ToString())) return 5;
            if ("MNO".Contains(c.ToString())) return 6;
            if ("PQRS".Contains(c.ToString())) return 7;
            if ("TUV".Contains(c.ToString())) return 8;
            if ("WXYZ".Contains(c.ToString())) return 9;
            return null;
        }
    }
}