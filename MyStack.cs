using System.Text.Json;
using Pulumi;
using System;

class MyStack : Stack
{
    public MyStack()
    {
        var config = new Config();
        var data = config.GetObject<Data>("data");
        Console.WriteLine(data.active);
        foreach (var num in data.nums)
        {
            Console.WriteLine(num);
        }
    }
}

public class Data
{
    public bool active { get; set; }
    public int[] nums { get; set; }
}
