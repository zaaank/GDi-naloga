using System.IO.Compression;
using System.Net;
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

JObject o1 = JObject.Parse(File.ReadAllText(@"../../../zip/DURS_zavezanci_PO.txt"));

Console.WriteLine(o1);