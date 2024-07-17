using Delagate;

CustomList<byte> list = new CustomList<byte>();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
Console.WriteLine(list.Find(3));
foreach (var item in list)
{
    Console.WriteLine(item);
}