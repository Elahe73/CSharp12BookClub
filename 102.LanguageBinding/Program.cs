// Language binding occurs when a dynamic object does not implement IDynamicMetaObjectProvider:

int x = 3, y = 4;
Console.WriteLine(Mean(x, y));

static dynamic Mean(dynamic x, dynamic y) => (x + y) / 2;