using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1;

public abstract class SpaceShip<GSpeed,GReturn> where GReturn : SpaceShip <GSpeed, GReturn>
{
    public GSpeed Speed { get; set; }
    public abstract GReturn CloneShip();

    public SpaceShip(GSpeed speed) => Speed = speed;
}
