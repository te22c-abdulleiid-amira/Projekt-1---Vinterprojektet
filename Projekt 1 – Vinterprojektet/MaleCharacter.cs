using System;

namespace Projekt_1___Vinterprojektet;

public class MaleCharacter : Character
{
    // base låter en subklass få tillgång till basklassens version av en metod.
    public MaleCharacter(string name) : base(name, 120, 5)
    {
    }
}
