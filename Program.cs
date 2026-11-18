using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Microsoft.Rest;
using ComputerVisionFromImagesToTextConsole.Configuration;

class Program
{
    private static readonly string endpoint = AppConfiguration.azureComputerVisionBaseUrl;
    private static readonly string apiKey = AppConfiguration.azureComputerVisionApiKey;

    static async Task Main(string[] args)
    {
        var client = new ComputerVisionClient(new ApiKeyServiceClientCredentials(apiKey))
        {
            Endpoint = endpoint
        };

        string imageUrl = AppConfiguration.azureBlobStorageImageUrl;
        try
        {
            var textHeaders = await ExtractText(client, imageUrl);
            var textResult = await client.GetReadResultAsync(Guid.Parse(textHeaders.OperationLocation.Split('/').Last()));

            if (textResult.Status == OperationStatusCodes.Succeeded)
            {
                var result = textResult.AnalyzeResult.ReadResults;
                foreach (var page in result)
                {
                    foreach (var line in page.Lines)
                    {
                        Console.WriteLine(line.Text);
                    }
                }
            }
        }
        catch (ComputerVisionErrorResponseException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    static async Task<ReadHeaders> ExtractText(ComputerVisionClient client, string imageUrl)
    {
        var textHeaders = await client.ReadAsync(imageUrl, language: "en");
        string operationId = textHeaders.OperationLocation.Split('/').Last();

        ReadOperationResult results;
        do
        {
            results = await client.GetReadResultAsync(Guid.Parse(operationId));
            await Task.Delay(1000);
        }
        while (results.Status == OperationStatusCodes.Running || results.Status == OperationStatusCodes.NotStarted);

        return textHeaders;
    }
}

