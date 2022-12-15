System.Console.WriteLine(PrintNumbers(10, 20));
string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return end.ToString();
    }
    return (end + " " + PrintNumbers(start, --end));
}