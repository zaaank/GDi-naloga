using System.IO.Compression;
using System.Net;
using System.Net.NetworkInformation;
using DownloadZIP;
using Newtonsoft.Json.Linq;

string zipFilePath = "FILE1.zip";
WebClient webClient = new WebClient();
try
{
    webClient.DownloadFile(new Uri("http://datoteke.durs.gov.si/DURS_zavezanci_PO.zip"), zipFilePath);
    ZipFile.ExtractToDirectory(zipFilePath, @"../../../zip");
    File.Delete("./" + zipFilePath);
}
catch
{
}

var fileReading = File.ReadAllText(@"../../../zip/DURS_zavezanci_PO.txt");

var lines = fileReading.Split("\n"); //split by lines

Zavezanec[] zavezanci;

Zavezanec lineToObject;

foreach (var line in lines)
{
    lineToObject = new Zavezanec(id: 0, status: "sad", number1: "gh", number2: "gh", date: "gh", amount: "gh", companyName: "gh", address: "gh", rating: "gh");
}

//Console.WriteLine(fileReading);









