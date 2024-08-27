namespace SherlockString
{
    public class Sherlock
    {
        public string SherlockChecker(string stringToEvaluate)
        {
            var allUniqueChars = stringToEvaluate.ToCharArray().Distinct().ToList();
            var allChars = stringToEvaluate.ToCharArray().ToList();
            var dictChars = new Dictionary<char, int>();

            foreach (var charInList in allUniqueChars) dictChars.Add(charInList, 0);

            foreach (var charInList in allChars) dictChars[charInList] = dictChars[charInList] + 1;

            var count = dictChars.Values.Distinct().Count(); //all.Values =5 ;   1.
            var notUniqueConstraint = CheckOccurrences(count, dictChars);


            return count == 1 || notUniqueConstraint ? "YES" : "NO";
        }

        private bool CheckOccurrences(int count, Dictionary<char, int> dictChars)
        {
            if (count != 2)
                return false;

            var refValue = 0;

            foreach (var kv in dictChars)
                if (kv.Value == dictChars.Values.First())
                {
                    refValue = kv.Value;
                    break;
                }

            var noRefPlus1 = 0;
            foreach (var kv in dictChars)
                if (kv.Value == refValue + 1)
                    noRefPlus1++;

            return noRefPlus1 == 1;
        }
    }
}
