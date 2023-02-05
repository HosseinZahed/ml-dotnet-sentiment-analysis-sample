// See https://aka.ms/new-console-template for more information
using SentimentAnalysisML;

Console.WriteLine("-- Sentiment Analysis with ML.NET --");

//Load sample data
var sampleData = new SentimentModel.ModelInput()
{
    Text = @"@VirginAmerica 2-hour delay is not acceptable!",
    //Text = @"@VirginAmerica that was a great offer for Christmas holidays",
    //Text = @"@VirginAmerica nothing competitive from the other options",
};

//Load model and predict output
var mupltipleOutputs = SentimentModel.PredictAllLabels(sampleData);

Console.WriteLine($"Text: {sampleData.Text}");
foreach (var item in mupltipleOutputs)
{    
    Console.WriteLine($"Label: {item.Key} -> Score: {item.Value}");
}

