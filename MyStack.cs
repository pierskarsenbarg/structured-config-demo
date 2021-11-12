using System.Text.Json;
using System.Collections.Generic;
using Pulumi;
using System;
using Pulumi.AzureNative.Resources;

class MyStack : Stack
{
    public MyStack()
    {
        var config = new Config();
        var data = config.GetObject<Data>("data");

        foreach (var name in data.resourceGroupName)
        {
            var resourceGroup = new ResourceGroup($"{name}", new ResourceGroupArgs
            {
                ResourceGroupName = name
            });
        }

        // var outputkey = Output.Create(data.apikeys[0]);
        // this.SecretApiKey = outputkey;
        // this.UnsecretApiKey = Output.Unsecret(outputkey);
    }

    // [Output]
    // public Output<string> UnsecretApiKey { get; set; }
    // [Output]
    // public Output<string> SecretApiKey { get; set; }
}

public class Data
{
    public bool active { get; set; }
    public int[] nums { get; set; }
    public string[] resourceGroupName { get; set; }
}
