using System.IO.Compression;
using System.Net;

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