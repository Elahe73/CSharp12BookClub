using System.Collections;

Console.WriteLine(Count("the quick brown fix".Split()));

int Count(IEnumerable e)
{
    int count = 0;
    foreach (object element in e)
    {
        var subCollection = element as IEnumerable;
        if (subCollection != null)
            count += Count(subCollection);
        else
            count++;
    }
    return count;
}