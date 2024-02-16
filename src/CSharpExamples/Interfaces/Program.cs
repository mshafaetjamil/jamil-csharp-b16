
using Interfaces;


void UseMachine(IMachine machine)
{
    machine.Start();
    machine.Stop();
}

UseMachine(new Oven());