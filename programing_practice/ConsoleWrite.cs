// See https://aka.ms/new-console-template for more information

using singleton;

Console.WriteLine("Hello, World!");

#region test for CSingleton1
var instance1 = CSingleton1.Instance;
var instance2 = CSingleton1.Instance;
var instance3 = CSingleton1.Instance;

if (instance1 == instance2 && instance2 == instance3)
{
    Console.WriteLine("instances are same");
}
else
{
    Console.WriteLine("instances are not same");
}

// test1
instance1.PublicString1 = "string1";
Console.WriteLine(instance2.PublicString1);
Console.WriteLine(instance2.PublicString1);

// test2
instance1.PublicString2 = "string2";
instance2.PublicString2 = "string3";
Console.WriteLine(instance3.PublicString2);
#endregion

#region test for CSingleton2
var cSingleton2Instance1 = CSingleton2.Instance;
var cSingleton2Instance2 = CSingleton2.Instance;
var cSingleton2Instance3 = CSingleton2.Instance;

if (cSingleton2Instance1 == cSingleton2Instance2 && cSingleton2Instance2 == cSingleton2Instance3)
{
    Console.WriteLine("instances are same");
}
else
{
    Console.WriteLine("instances are not same");
}
#endregion