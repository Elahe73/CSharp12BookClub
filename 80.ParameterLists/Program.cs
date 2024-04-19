var point3d = new Point3D(2, 3, 4);

Console.ReadKey();

record Point(double X, double Y);

record Point3D(double X, double Y, double Z) : Point(X, Y);