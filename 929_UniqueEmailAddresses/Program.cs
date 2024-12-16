// https://leetcode.com/problems/unique-email-addresses/


using System.Text;

var sol = new Solution();

sol.NumUniqueEmails([
    "test.email+alex@leetcode.com", "test.email@leetcode.com"
]);
// sol.NumUniqueEmails([
//     "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"
// ]);


public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        var uniqueEmails = new HashSet<string>();

        for (var i = 0; i < emails.Length; i++)
        {
            var mailBuilder = new StringBuilder();
            var currentEmail = emails[i];

            int j = 0;
            while (j < currentEmail.Length)
            {
                var currentChar = currentEmail[j];

                if (currentChar == '+')
                {
                    while (currentChar != '@')
                    {
                        j++;
                        currentChar = currentEmail[j];
                    }
                }

                if (currentChar == '@')
                {
                    break;
                }

                if (currentChar != '.')
                {
                    mailBuilder.Append(currentChar);
                }

                j++;
            }

            mailBuilder.Append(currentEmail[j..^1]);

            uniqueEmails.Add(mailBuilder.ToString());
        }

        return uniqueEmails.Count;
    }
}