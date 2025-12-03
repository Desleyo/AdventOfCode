namespace Day1_1;

class Program
{
    private static string[] _input = File.ReadAllLines("input.txt");
    private static int _dial = 50;

    static void Main(string[] args)
    {
        int count = 0;

        foreach (var line in _input)
        {
            string dir = line[..1];
            int steps = int.Parse(line[1..]);

            _dial = dir == "R" ? _dial + steps : _dial - steps;

            while (_dial < 0 || _dial > 99)
            {
                if (_dial < 0)
                {
                    _dial = 100 + _dial;
                }
                else if (_dial > 99)
                {
                    _dial = -1 + (_dial - 99);
                }
            }

            if (_dial == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}