// See https://aka.ms/new-console-template for more information

using EventHandling;
using project;
using singleton;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;

//#region test for CSingleton1
//var instance1 = CSingleton1.Instance;
//var instance2 = CSingleton1.Instance;
//var instance3 = CSingleton1.Instance;

//if (instance1 == instance2 && instance2 == instance3)
//{
//    Console.WriteLine("instances are same");
//}
//else
//{
//    Console.WriteLine("instances are not same");
//}

//// test1
//instance1.PublicString1 = "string1";
//Console.WriteLine(instance2.PublicString1);
//Console.WriteLine(instance2.PublicString1);

//// test2
//instance1.PublicString2 = "string2";
//instance2.PublicString2 = "string3";
//Console.WriteLine(instance3.PublicString2);
//#endregion

//#region test for CSingleton2
//var cSingleton2Instance1 = CSingleton2.Instance;
//var cSingleton2Instance2 = CSingleton2.Instance;
//var cSingleton2Instance3 = CSingleton2.Instance;sakaiyoshidkirannkinngu 

//if (cSingleton2Instance1 == cSingleton2Instance2 && cSingleton2Instance2 == cSingleton2Instance3)
//{
//    Console.WriteLine("instances are same");
//}
//else
//{
//    Console.WriteLine("instances are not same");
//}
//#endregion

//#region test for Event1
//var publiser1 = new EventPublisher1();
//var subscrive1 = new EventSubscriber1();

//// イベントの購読に追加
//publiser1.MyEvent1 += subscrive1.MyEventHandlerInside;

//// イベントの発行
//publiser1.RaiseEvent("Hello World");

//#endregion

//#region test for Event2
//var publiser2 = new EventPublisher2();
//publiser2.TemperatureChanged += Thermostat_TemperatureChanged;

//publiser2.CurrentTemperature = 25.0;
//publiser2.CurrentTemperature = 28.0;

//Console.WriteLine("Press any key to exit...");


//static void Thermostat_TemperatureChanged(object sender, EventSubscriber2 e)
//{
//    Console.WriteLine($"Temperature changed from {e.OldTemperature} to {e.NewTemperature}");
//}

//#endregion

//#region test for Event3
//EventPublisher3 eventPublisher3 = new EventPublisher3();
//EventSubscriber3 eventSubscriber3 = new EventSubscriber3(eventPublisher3);

//// イベントの発火
//eventPublisher3.RaiseStandardEvent();
//eventPublisher3.RaiseCustomEvent("Hello Sakai");


//#endregion

//#region test for Async proccesing1

//// try async meshod1
//await AsyncProcessing1.SayHelloAsync();

//// try async meshod2
//var helloSakaiString = await AsyncProcessing1.GetMessageAsync();
//Console.WriteLine(helloSakaiString);

//// try async meshod3
//Task<string> taskString1 = AsyncProcessing1.GetMessageAsync("satou", 1000);
//string taskString2 = await AsyncProcessing1.GetMessageAsync("matui", 10000);
//Task<string> taskString3 = AsyncProcessing1.GetMessageAsync("takahashi", 5000);

//string[] taskStrings = await Task.WhenAll(taskString1, taskString3);

//foreach (string result in taskStrings)
//{
//    Console.Write(result + "\n");
//}

//try
//{
//    string url = "https://e-words.jp/w/%E3%82%A4%E3%83%86%E3%83%AC%E3%83%BC%E3%82%BF.html";
//    string content = await AsyncProcessing1.GetMessageAsync();

//    Console.WriteLine(content);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

//#endregion

//#region test for OutMethod

//var outMethod = new OutMethod();
//int resultMax, resultMin;

//outMethod.GetMAxMin(5, 3, out resultMax, out resultMin);
//outMethod.GetMAxMin(7, 1, out int a, out int b);

//Console.WriteLine(resultMax);
//Console.WriteLine(resultMin);
//Console.WriteLine(a);
//Console.WriteLine(b);

//#endregion

//#region test for Iterator1

//var iterator1 = new Iterator1();

//foreach (var item in iterator1.GetStrings())
//{
//    Console.WriteLine(item);
//}

//using (var enumerator = iterator1.GetStrings2())
//{
//    while (enumerator.MoveNext())
//    {
//        Console.WriteLine(enumerator.Current);
//    }
//}

//#endregion

#region test for Linq1

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var linq1 = new Linq1();

var numbers1 = linq1.QueryWhere1(numbers);
var numbers2 = linq1.QueryMapping1(numbers);
var numbers3 = linq1.QueryTake1(numbers);
var numbersBool1 = linq1.QueryAny1(numbers);

linq1.Write(numbers);
Console.WriteLine();
linq1.Write(numbers1);
Console.WriteLine();
linq1.Write(numbers2);
Console.WriteLine();
linq1.Write(numbers3);
Console.WriteLine();
Console.WriteLine(numbersBool1);

#endregion