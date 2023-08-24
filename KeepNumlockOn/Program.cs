using WindowsInput;
using WindowsInput.Native;

var inputSimulator = new InputSimulator();

Console.WriteLine("NumLock will be kept on. Press Ctrl+C stop the program...");
while (true)
{
    bool isNumLockOn = Console.NumberLock;

    if (!isNumLockOn)
    {
        inputSimulator.Keyboard.KeyPress(VirtualKeyCode.NUMLOCK);
        Console.WriteLine("Num Lock has been turned on.");
    }
    else
    {
        // Console.WriteLine("Num Lock is already on.");
    }

    Thread.Sleep(500); // Wait until the next iteration
}
