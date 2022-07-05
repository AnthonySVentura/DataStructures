
Console.WriteLine(Reverse);

static String Reverse(String str)
{
    char[] charArr = str.ToCharArray();
    int size = charArr.Length;
    Stack<char> stack = new Stack<char>();

    int i;
    for (i = 0; i < size; ++i)
    {
        stack.Push(charArr[i]);
    }

    for (i = 0; i < size; ++i)
    {
        charArr[i] = (char)stack.Pop();
    }

    return String.Join(" ", charArr);
}
