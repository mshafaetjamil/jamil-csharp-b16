using StaticClass;

Printer.PrintMessage("Hello World");

Person.Serial = 1;
Person p1 = new Person();
p1.Name = "jalal uddin";

Person p2 = new Person();
p2.Name = "tareq";
Person.Serial = 2;

p1.PrintSerial();
