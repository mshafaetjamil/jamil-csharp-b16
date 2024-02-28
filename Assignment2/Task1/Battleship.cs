using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1;

public class Battleship<GSpeed> : SpaceShip<GSpeed, Battleship<GSpeed>>
{
    public Battleship(GSpeed speed) : base(speed)
    {

    }
    public override Battleship<GSpeed> CloneShip() => new Battleship<GSpeed>(Speed);
}
