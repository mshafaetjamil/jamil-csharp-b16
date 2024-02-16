
using Structure;

Price price = new Price(20, 10);
price.Currency = "BDT";

Price price2 = price;
price2.Amount = 30;

Console.WriteLine(price.Amount);

int x = 5;
int y = x;
y = 7;




