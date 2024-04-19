Point p1 = new Point(3, 3);
Point p2 = p1 with { Y = 4 };

Test t1 = new Test(1, 2, 3, 4, 5, 6, 7, 8);
Test t2 = t1 with { A = 10, C = 30 };

record Point(double X, double Y);

record Test(int A, int B, int C, int D, int E, int F, int G, int H);