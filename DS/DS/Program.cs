using DS;

MIN_MAX array = new MIN_MAX(4);

array.Display();

array.Add(42);
array.Add(78);
array.Add(19);
array.Add(3);

array.Display();

Console.WriteLine("Resize the array");
array.Add(5);
array.Display();

Console.WriteLine("Remove the last (MAX) element");
array.Remove_MAX();
array.Display();

Console.WriteLine("Remove the first (MIN) element");
array.Remove_MIN();
array.Display();
