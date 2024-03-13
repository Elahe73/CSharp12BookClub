// The solution, if we want to write 012, is to assign the iteration variable to a local
// variable that’s scoped inside the loop:

Action[] actions = new Action[3];

for (int i = 0; i < 3; i++)
{
    int loopScopedi = i;
    actions[i] = () => Console.Write(loopScopedi);
}

Console.ReadLine();

foreach (Action a in actions) a();     // 012