namespace Tiveria.Common.XConsole
{
    public static class Output 
    {
        public static string PromptSign { get; set; } = " > ";

        public static void Write<T>(System.ConsoleColor fgCol, T s)
        {
            System.Console.ForegroundColor = fgCol;
            System.Console.Write(s);
            System.Console.ResetColor();
        }

        public static void Write<T>(System.ConsoleColor fgCol, System.ConsoleColor bgCol, T s)
        {
            System.Console.ForegroundColor = fgCol;
            System.Console.BackgroundColor = bgCol;
            System.Console.Write(s);
            System.Console.ResetColor();
        }

        public static void WriteLine<T>(System.ConsoleColor fgCol, T s)
        {
            System.Console.ForegroundColor = fgCol;
            System.Console.WriteLine(s);
            System.Console.ResetColor();
        }

        public static void WriteLine<T>(System.ConsoleColor fgCol, System.ConsoleColor bgCol, T s)
        {
            System.Console.ForegroundColor = fgCol;
            System.Console.BackgroundColor = bgCol;
            System.Console.WriteLine(s);
            System.Console.ResetColor();
        }

        public static void WriteAt<T>(int x, int y, T s) 
        {
            System.Console.SetCursorPosition(x, y);
            System.Console.Write(s);
        }

        public static void WriteAt<T>(int x, int y, System.ConsoleColor fgCol, T s)
        {
            System.Console.SetCursorPosition(x, y);
            System.Console.ForegroundColor = fgCol;
            System.Console.Write(s);
            System.Console.ResetColor();
        }

        public static void WriteAt<T>(int x, int y, System.ConsoleColor fgCol, System.ConsoleColor bgCol, T s)
        {
            System.Console.SetCursorPosition(x, y);
            System.Console.ForegroundColor = fgCol;
            System.Console.BackgroundColor = bgCol;
            System.Console.Write(s);
            System.Console.ResetColor();
        }

        public static void DisplayPrompt(string format, params object[] args)
        {
            format = format.Trim() + PromptSign;
            System.Console.Write(format, args);
        }

        public static void DisplayPrompt(string text)
        {
            text = text.Trim() + PromptSign;
            System.Console.Write(text);
        }
    }
}
