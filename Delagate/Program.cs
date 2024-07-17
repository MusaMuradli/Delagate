

using Delagate;

CustomList<byte> list = new CustomList<byte>();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);
list.Add(7);
list.Add(8);
list.Add(9);
list.Add(10);

//Console.WriteLine(list.Find(t=>t%5==0));
//List<byte> result = list.FindAll(t => t > 3);

//foreach(byte item in result)
//{
//    Console.WriteLine(  item);
//}

list.RemoveAll(t => t > 3&&t<7);

foreach (var item in list)
{
    Console.WriteLine(  item);
}