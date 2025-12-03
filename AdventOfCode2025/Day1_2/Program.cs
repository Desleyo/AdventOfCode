namespace Day1_2;

class Program
{
    private static string[] _input = File.ReadAllLines("input.txt");
    //private static int _dial = 50;

    static void Main(string[] args)
    {
        int _dial = 50;
        int count = 0;

        foreach (var line in _input)
        {
            string dir = line[..1];
            int steps = int.Parse(line[1..]);
            
            Console.WriteLine($"Dial: {_dial}");
            Console.WriteLine(line);

            bool excluded = _dial == 0 && steps < 100;
            
            _dial = dir == "R" ? _dial + steps : _dial - steps;
            
            while (_dial < 0 || _dial > 99)
            {
                if (_dial < 0)
                {
                    _dial = 100 + _dial;

                    if (!excluded)
                    {
                        count++;
                    }
                }
                else if (_dial > 99)
                {
                    _dial = -1 + (_dial - 99);
                    count++;
                }
            }

            if (_dial == 0 && steps < 100 && dir == "L")
            {
                count++;
            }
            
            Console.WriteLine($"Count: {count}");
        }

        Console.WriteLine(count);
    }
}