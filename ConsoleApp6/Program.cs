    {
        CheckPoint(2.2, -6); 
        CheckPoint(5.3, 3);  
        CheckPoint(-0.8, -4); 
    }

    static void CheckPoint(double x, double y)
    {
        if (x > 0 && y < 0)
        {
            Console.WriteLine($"Точка ({x}, {y}) лежит в четвертой четверти.");
        }
        else
        {
            Console.WriteLine($"Точка ({x}, {y}) не лежит в четвертой четверти.");
        }
    }
