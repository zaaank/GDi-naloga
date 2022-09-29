
using System.IO.Compression;
using System.Linq;
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

List<Zavezanec> zavezanci = new List<Zavezanec>();

Zavezanec lineToObject;

var id = 0;
string[] array;
foreach (var line in lines)
{
    if (line != "")
    {
        lineToObject = new Zavezanec(id: id, status: line.Substring(0, 4), number1: line.Substring(4, 9), number2: line.Substring(13, 11), date: line.Substring(24, 11), amount: line.Substring(35, 7), companyName: line.Substring(42, 101), address: line.Substring(143, 114), rating: line.Substring(257));
        zavezanci.Add(lineToObject);
        id++;
    }
}

File.Delete(@"../../../zip/DURS_zavezanci_PO.txt");

Console.WriteLine(zavezanci);









