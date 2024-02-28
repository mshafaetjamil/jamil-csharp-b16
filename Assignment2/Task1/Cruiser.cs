using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1;

public class Cruiser<GSpeed> : SpaceShip<GSpeed, Cruiser<GSpeed>>

{
public Cruiser(GSpeed speed) : base(speed) { }
    public override Cruiser<GSpeed> CloneShip() => new Cruiser<GSpeed>(Speed);
}
