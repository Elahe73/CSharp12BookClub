// The IsDaylightSavingTime tells you whether a given local DateTime is subject to daylight saving.
Console.WriteLine(DateTime.Now.IsDaylightSavingTime());     // True or False

// UTC times always return false:
Console.WriteLine(DateTime.UtcNow.IsDaylightSavingTime());  // Always False