string[] orderIds = new string [8];

orderIds [0] = "B123";
orderIds [1] = "C234";
orderIds [2] = "A345";
orderIds [3] = "C15";
orderIds [4] = "B177";
orderIds [5] = "G3003";
orderIds [6] = "C235";
orderIds [7] = "B179";

Console.WriteLine("Here are the sorted orderIds:");

Array.Sort(orderIds);

 foreach (string orderId in orderIds)
{
    Console.WriteLine(orderId);
}

int total = orderIds.Length;

Console.WriteLine($"There are {total} IDs in total!");