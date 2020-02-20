namespace LeetCode.Problems
{
    class SubdomainVisitCount
    {
        public System.Collections.Generic.IList<string> SubdomainVisits(string[] cpdomains)
        {
            if (cpdomains.Length == 0)
            {
                return cpdomains;
            }

            var visits = new System.Collections.Generic.List<string>();
            System.Collections.Generic.Dictionary<string, int> subdomainCount = new System.Collections.Generic.Dictionary<string, int>();

            foreach (var item in cpdomains)
            {
                string[] domainData = item.Split(" ");
                string[] domainParts = domainData[1].Split(".");
                int domainCount = int.Parse(domainData[0]);
                string currentDomain = "";

                for (int i = domainParts.Length - 1; i >= 0; i--)
                {
                    currentDomain = domainParts[i] + (i < domainParts.Length - 1 ? "." : "") + currentDomain;

                    if (subdomainCount.ContainsKey(currentDomain))
                    {
                        subdomainCount[currentDomain] = subdomainCount[currentDomain] + domainCount;
                    }
                    else
                    {
                        subdomainCount.Add(currentDomain, domainCount);
                    }
                }
            }

            foreach (var item in subdomainCount)
            {
                visits.Add($"{item.Value} {item.Key}");
            }

            return visits;
        }
    }
}
