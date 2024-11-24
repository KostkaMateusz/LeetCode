var sol = new Solution();

ListPrinter.PrintNestedList(sol.Generate(1));
ListPrinter.PrintNestedList(sol.Generate(2));
ListPrinter.PrintNestedList(sol.Generate(3));
ListPrinter.PrintNestedList(sol.Generate(4));
ListPrinter.PrintNestedList(sol.Generate(5));

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> pascalTriangle = [];

        pascalTriangle.Add([1]);
        pascalTriangle.Add([1, 1]);
        
        
        for (int i = 2; i < numRows; i++)
        {
            pascalTriangle.Add([]);

            for (int elements = 0; elements <= i; elements++)
            {
                if (elements == 0)
                {
                    pascalTriangle[i].Add(1);
                }
                else if (elements == i)
                {
                    pascalTriangle[i].Add(1);
                }
                else
                {
                    int prevElement = pascalTriangle[i - 1][elements - 1];
                    int nextElement = pascalTriangle[i - 1][elements];

                    pascalTriangle[i].Add(prevElement + nextElement);
                }
            }
        }
        
        return pascalTriangle[..numRows];
    }
}


public static class ListPrinter
{
    public static void PrintNestedList(IList<IList<int>> nestedList)
    {
        if (nestedList == null)
        {
            Console.WriteLine("List is null");
            return;
        }

        if (!nestedList.Any())
        {
            Console.WriteLine("[]");
            return;
        }

        Console.WriteLine("[");
        for (int i = 0; i < nestedList.Count; i++)
        {
            var innerList = nestedList[i];
            Console.Write("  [");

            if (innerList != null)
            {
                Console.Write(string.Join(", ", innerList));
            }
            else
            {
                Console.Write("null");
            }

            Console.Write("]");

            // Add comma if not the last element
            if (i < nestedList.Count - 1)
            {
                Console.Write(",");
            }

            Console.WriteLine();
        }

        Console.WriteLine("]");
    }
}