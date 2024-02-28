using Interface;

void UseMachine(IMachine machine)
{
    machine.Start();
    machine.Stop();
}

UseMachine(new Oven());
UseMachine(new WashingMaching());