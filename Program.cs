class Program {
    static void Main() {
        Console.Write("input Pascal’s triangle row number: ");
        string input = Console.ReadLine();
        int numrow;

        while (!int.TryParse(input, out numrow) || numrow < 0)
     {
            Console.WriteLine("Invalid Pascal's triangle row number.");
            Console.Write("input Pascal’s triangle row number: ");
            input = Console.ReadLine();
     }
         PrintPascalsTriangle(numrow);
    }
    static void PrintPascalsTriangle(int numrow) {
        for (int row = 0; row <= numrow; row++) {
            for (int col = 0; col <= row; col++)
        {
            int coefficient = CalculateCoefficient(row, col);
            Console.Write(coefficient + " ");
        }
            Console.WriteLine();
        }
    }
    static int CalculateCoefficient(int i, int j) {
        if (j == 0 || j == i)
            return 1;
        return CalculateCoefficient(i - 1, j - 1) + CalculateCoefficient(i - 1, j);
    }
}
