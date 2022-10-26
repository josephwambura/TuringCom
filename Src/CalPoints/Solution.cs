//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


class Solution
{
    public int CalPoints(string[]? ops)
    {
        var opsList = new List<string>();
        var value = 0;

        foreach (var item in ops)
        {

            if (item.Equals("+"))
            {

                var index = int.Parse(opsList[opsList.Count - 1]) + int.Parse(opsList[opsList.Count - 2]);
                opsList.Add(index.ToString());

                value = 0;

                foreach (var val in opsList)
                {
                    value += int.Parse(val);
                }

            }
            else if (item.Equals("D"))
            {

                var index = int.Parse(opsList[opsList.Count - 1]) * 2;
                opsList.Add(index.ToString());

                value = 0;

                foreach (var val in opsList)
                {
                    value += int.Parse(val);
                }

            }
            else if (item.Equals("C"))
            {

                opsList.RemoveAt(opsList.Count - 1);

                value = 0;

                foreach (var val in opsList)
                {
                    value += int.Parse(val);
                }

            }
            else
            {
                //An integer was added
                opsList.Add(item);

                foreach (var val in opsList)
                {
                    value += int.Parse(val);
                }
            }

        }

        return value;
    }
}