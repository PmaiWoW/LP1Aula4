using System;

[Flags]
enum NPCPerk
{
    Stealth = 1 << 0,
    Combat = 1 << 1,
    LockPick = 1 << 2,
    Luck = 1 << 3
}