using System;

namespace CuteAnimal
{
    [Flags]
    public enum Mood
    {
        Happy = 1 << 0,
        Grumpy = 2 << 1,
        IgnoringYou = 3 <<2,
        HyperActive = 4 << 3,
    }
}
