// namespace Lab3
// {
//     public abstract class Shape
//     {   
//         protected double x;
//         protected double y;


//         public Shape(double x, double y)
//         {
//             this.x = x;
//             this.y = y;
//         }

//         public void Move(double deltaX, double deltaY)
//         {
//             x += deltaX;
//             y += deltaY;
//         }

//         public abstract void Show();
//         public override string ToString()
//         {
//             return $"Shape at position: ({x}, {y})";
//         }
//     }

//     public class Line : Shape
//     {
//         private double x2, y2;

//         public Line(double x, double y, double x2, double y2) : base(x, y)
//         {
//             this.x2 = x2;
//             this.y2 = y2;
//         }

//         public override void Show()
//         {
//             Console.WriteLine($"Line from ({x}, {y}) to ({x2}, {y2})");
//         }

//         public override string ToString()
//         {
//             return $"Line: Start ({x}, {y}), End ({x2}, {y2})";
//         }
//     }

//     // Derived class Circle
//     public class Circle : Shape
//     {
//         private double radius;

//         public Circle(double x, double y, double radius) : base(x, y)
//         {
//             this.radius = radius;
//         }

//         public override void Show()
//         {
//             Console.WriteLine($"Circle with center at ({x}, {y}) and radius {radius}");
//         }

//         public override string ToString()
//         {
//             return $"Circle: Center ({x}, {y}), Radius {radius}";
//         }
//     }

//     // Derived class Rectangle
//     public class Rectangle : Shape
//     {
//         private double x2, y2; 
//         private double x3, y3; 

  
//         public Rectangle(double x, double y, double x2, double y2, double x3, double y3) : base(x, y)
//         {
//             this.x2 = x2;
//             this.y2 = y2;
//             this.x3 = x3;
//             this.y3 = y3;
//         }

//         public override void Show()
//         {
//             Console.WriteLine($"Rectangle with points ({x}, {y}), ({x2}, {y2}), ({x3}, {y3})");
//         }

//         public override string ToString()
//         {
//             return $"Rectangle: Point 1 ({x}, {y}), Point 2 ({x2}, {y2}), Point 3 ({x3}, {y3})";
//         }
//     }

//     // Derived class PolyLine
//     public class PolyLine : Shape
//     {
//         private List<(double x, double y)> points = new List<(double, double)>();

//         public PolyLine(double startX, double startY) : base(startX, startY)
//         {
//             points.Add((startX, startY));
//         }

//         public void AddPoint(double x, double y)
//         {
//             points.Add((x, y));
//         }

//         public override void Show()
//         {
//             Console.WriteLine("PolyLine points:");
//             foreach (var point in points)
//             {
//                 Console.WriteLine($"({point.x}, {point.y})");
//             }
//         }

//         public override string ToString()
//         {
//             return $"PolyLine: {points.Count} points";
//         }
//     }

//     class Ex1 {
//         public static void run(){
//             // Create a Line object
//             Line line = new Line(0, 0, 5, 5);
//             line.Show();
//             Console.WriteLine(line);
//             line.Move(2, 2);
//             line.Show();

//             // Create a Circle object
//             Circle circle = new Circle(3, 3, 10);
//             circle.Show();
//             Console.WriteLine(circle);
//             circle.Move(-1, -1);
//             circle.Show();

//             // Create a Rectangle object
//             Rectangle rect = new Rectangle(0, 0, 4, 0, 0, 6);
//             rect.Show();
//             Console.WriteLine(rect);
//             rect.Move(1, 1);
//             rect.Show();

//             // Create a PolyLine object
//             PolyLine polyline = new PolyLine(0, 0);
//             polyline.AddPoint(1, 1);
//             polyline.AddPoint(2, 2);
//             polyline.Show();
//             Console.WriteLine(polyline);
//             polyline.Move(1, 1);
//             polyline.Show();
//         }
//     }

// }