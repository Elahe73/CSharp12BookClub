﻿float[] reals = { 1.3f, 1.5f, 1.8f };
int[] wholes = Array.ConvertAll(reals, r => Convert.ToInt32(r));

Console.WriteLine(string.Join(", ", wholes));