System.Console.WriteLine(PrintNumbers(4, 8));

int PrintNumbers(int start, int end)
{
    int result = 0;
    if (start > end)
    {
        return result;
    }
    return (result += start + PrintNumbers(++start, end));
}