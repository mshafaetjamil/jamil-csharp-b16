using Static_Class;

Printer.PrintMessage("Hello World");
Person.Serial = 1;
Person p1 = new Person();
p1.Name = "Jamil";

Person.Serial = 2;
Person p2 =new Person();
p2.Name = "HuHa";


p1.PrintMessage();
p2.PrintMessage();
