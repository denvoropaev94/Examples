string text = "Сегодня мы углубимся в тему и выделим 4 основных группы методов,"
+ "а также будем использовать их на практике." 
+ "И познакомимся с новыми языковыми конструкциями, в частности, циклом.";

string Replace(string text, char OldValue, char NewValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue)
        {
            result += NewValue;
        }
        else
        {
            result += text[i];
        }

    }
    return result;
}

string newtext = Replace(text, ' ', '|');
Console.WriteLine(newtext);
Console.WriteLine();
newtext = Replace(newtext, 'и', 'И');
Console.WriteLine(newtext);