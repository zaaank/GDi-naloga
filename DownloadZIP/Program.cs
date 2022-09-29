
using System.IO.Compression;
using System.Net;
using DownloadZIP;
using DownloadZIP.Data;

string zipFilePath = "FILE1.zip";
WebClient webClient = new WebClient();
try
{
    webClient.DownloadFile(new Uri("http://datoteke.durs.gov.si/DURS_zavezanci_PO.zip"), zipFilePath);
    ZipFile.ExtractToDirectory(zipFilePath, @"../../../zip");
    File.Delete("./" + zipFilePath);

    var fileReading = File.ReadAllText(@"../../../zip/DURS_zavezanci_PO.txt");

    var lines = fileReading.Split("\n"); //split by lines

    List<Zavezanec> zavezanci = new List<Zavezanec>();

    Zavezanec lineToObject;

    var id = 1;
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



    using (var database = new ZavezanciContext())
    {

        zavezanci.ForEach(element =>
        {
            Console.WriteLine(element.Id);
            database.Add(new ZavezancEntity()
            {
                Id = element.Id,
                Status = element.Status,
                Number1 = element.Number1,
                Number2 = element.Number2,
                Date = element.Date,
                Amount = element.Amount,
                CompanyName = element.CompanyName,
                Address = element.Address,
                Rating = element.Rating
            });
        });
        database.SaveChanges();

    }

}
catch
{
}

