using System.Threading;

int counter = 0;

var t1 = new Thread(() => { for (int i = 0; i < 100000; i++) counter++; });
var t2 = new Thread(() => { for (int i = 0; i < 100000; i++) counter++; });

t1.Start();
t2.Start();
t1.Join();
t2.Join();

Console.WriteLine(counter);
