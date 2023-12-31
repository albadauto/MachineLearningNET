﻿
// This file was auto-generated by ML.NET Model Builder. 

using SentimentsModelML;

// Create single instance of sample data from first line of dataset for model input
SentimentsModelML.ModelInput sampleData = new SentimentsModelML.ModelInput()
{
    SENTID = 2F,
    SENTDESC = @"SIMPLESMENTE IMPRESSIONANTE A SUA CAPACIDADE DE FAZER NADA",
};

// Make a single prediction on the sample data and print results
var predictionResult = SentimentsModelML.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual SENTTIPO with predicted SENTTIPO from sample data...\n\n");


Console.WriteLine($"SENTID: {2F}");
Console.WriteLine($"SENTTIPO: {@"RAIVA"}");
Console.WriteLine($"SENTDESC: {@"SIMPLESMENTE IMPRESSIONANTE A SUA CAPACIDADE DE FAZER NADA"}");


Console.WriteLine($"\n\nPredicted SENTTIPO: {predictionResult.PredictedLabel}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

