namespace Algorithms.Arrays
{
    public static class PermutationProblem
    {
        /// <summary>
        /// Check Permutation: Given two strings, write a method to decide
        /// if one is a permutation of the other
        /// </summary>
        public static bool IsPermutation(string a, string b)
        {
            if (a == null || b == null)
                return false;

            if (a.Length != b.Length)
                return false;

            int[] characters = new int[256];

            for (int i = 0; i < a.Length; i++)
            {
                characters[a[i]]++;
                characters[b[i]]--;
            }

            for (int i = 0; i < 256; i++)
            {
                if (characters[i] != 0)
                    return false;
            }

            return true;
        }
    }
}
