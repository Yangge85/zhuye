using System;

class Program
{
    static void Main()
    {
        int clickCount = 0;

        Console.WriteLine("欢迎使用连点器！按下任意键开始连点，按 'q' 键退出。");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            // 如果按下 'q' 键，则退出循环
            if (keyInfo.Key == ConsoleKey.Q)
                break;

            // 增加点击次数
            clickCount++;

            // 显示点击次数
            Console.WriteLine($"点击次数: {clickCount}");
        }

        Console.WriteLine("感谢使用连点器！");
    }
}
