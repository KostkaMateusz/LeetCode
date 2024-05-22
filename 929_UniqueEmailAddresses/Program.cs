using System.Text;

var sol = new Solution();

// sol.NumUniqueEmails(emails : ["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"]);

// sol.NumUniqueEmails(emails : ["test.email+alex@leetcode.com", "test.email@leetcode.com"]);

sol.NumUniqueEmails(emails: ["test.email@leetcode.com"]);

public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        var uniqMails = new HashSet<string>();

        foreach (var mail in emails)
        {
            int i = 0;
            var localName = new StringBuilder();
            var firstPlusFound = false;

            for (; i < mail.Length; i++)
            {
                if (mail[i] == '@')
                    break;

                if (firstPlusFound == false)
                {
                    if (mail[i] == '.')
                        continue;

                    if (mail[i] == '+')
                    {
                        firstPlusFound = true;
                        continue;
                    }

                    localName.Append(mail[i]);
                }
            }

            localName.Append(mail[i..^1]);

            uniqMails.Add(localName.ToString());
        }

        return uniqMails.Count;
    }
}