namespace Algorithms.Strings
{
    public class FiniteAutomataAlgo
    {
        private const int NO_OF_CHARS = 256;

        int getNextState(string pat, int m, int state, int x)
        {
            // If the character c is same as next character
            // in pattern,then simply increment state
            if (state < m && x == pat[state])
                return state + 1;

            // ns stores the result which is next state
            int ns, i;

            // ns finally contains the longest prefix
            // which is also suffix in "pat[0..state-1]c"

            // Start from the largest possible value
            // and stop when you find a prefix which
            // is also suffix
            for (ns = state; ns > 0; ns--)
            {
                if (pat[ns - 1] == x)
                {
                    for (i = 0; i < ns - 1; i++)
                        if (pat[i] != pat[state - ns + 1 + i])
                            break;
                    if (i == ns - 1)
                        return ns;
                }
            }

            return 0;
        }

        /* This function builds the TF table which represents4
            Finite Automata for a given pattern */
        void ComputeTF(string pat, int M, int[,] TF)
        {
            int state, x;
            for (state = 0; state <= M; ++state)
                for (x = 0; x < NO_OF_CHARS; ++x)
                    TF[state, x] = getNextState(pat, M, state, x);
        }

        /* Prints all occurrences of pat in txt */
        public int[] SearchPattern(string txt, string pat)
        {
            if (pat == null || txt == null) return new int[0];

            int m = pat.Length;
            int n = txt.Length;

            if (m == 0 || n == 0 || m > n) return new int[0];

            int[,] TF = new int[m + 1, NO_OF_CHARS];

            int[] matches = new int[n - m + 1];
            int foundCount = 0;

            ComputeTF(pat, m, TF);

            // Process txt over FA.
            int i, state = 0;
            for (i = 0; i < n; i++)
            {
                state = TF[state, txt[i]];
                if (state == m)
                {
                    matches[foundCount++] = i - m + 1;
                    //Console.WriteLine($"Pattern found at index {i - m + 1}");
                }
            }

            int[] result = new int[foundCount];
            for (i = 0; i < foundCount; i++)
            {
                result[i] = matches[i];
            }
            return result;
        }
    }
}
