using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    class RepeatedDNASequences
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            const int SEQUENCE_LENGTH = 10;
            var lstToReturn = new List<string>();
            
            if (String.IsNullOrEmpty(s))
            {
                return lstToReturn;
            }

            var dnaSequences = new Dictionary<string, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!(i + SEQUENCE_LENGTH > s.Length))
                {
                    var currentSequence = s.Substring(i, SEQUENCE_LENGTH);

                    if (dnaSequences.ContainsKey(currentSequence))
                    {
                        dnaSequences[currentSequence] = dnaSequences[currentSequence] + 1;
                    }
                    else
                    {
                        dnaSequences.Add(currentSequence, 1);
                    }
                }
            }

            foreach (var item in dnaSequences)
            {
                if (item.Value > 1)
                {
                    lstToReturn.Add(item.Key);
                }
            }

            return lstToReturn;
        }
    }
}
