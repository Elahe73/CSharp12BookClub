Console.WriteLine(AverageCelsiusTemperature(Season.Spring, true));
Console.ReadLine();

int AverageCelsiusTemperature(Season season, bool daytime) =>
  (season, daytime) switch
  {
      (Season.Spring, true) => 20,
      (Season.Spring, false) => 16,
      (Season.Summer, true) => 27,
      (Season.Summer, false) => 22,
      (Season.Fall, true) => 18,
      (Season.Fall, false) => 12,
      (Season.Winter, true) => 10,
      (Season.Winter, false) => -2,
      _ => throw new Exception("Unexpected combination")
  };

enum Season { Spring, Summer, Fall, Winter };