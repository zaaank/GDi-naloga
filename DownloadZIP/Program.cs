using System.IO.Compression;
using System.Net;

WebClient webClient = new WebClient();
webClient.Headers.Add("Accept: text/html, application/xhtml+xml, /");
webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
webClient.DownloadFile(new Uri("http://datoteke.durs.gov.si/DURS_zavezanci_PO.zip"), "test250.zip");
string zipFilePath = "test250.zip";
try
{
    ZipFile.ExtractToDirectory(zipFilePath, Environment.CurrentDirectory);

}
catch
{
}