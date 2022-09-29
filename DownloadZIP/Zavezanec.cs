using System;
namespace DownloadZIP
{
    public class Zavezanec
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string CompanyName { get; set; }
        public string Address{ get; set; }
        public int Rating { get; set; }

        public Zavezanec
        (int id, string status, string number1, string number2, string date, string amount, string companyName, string address, string rating)
        {
            Id = id;
            Status = status;
            Number1 = int.Parse(number1);
            Number2 = int.Parse(number2);
            if (DateTime.TryParse(date, out DateTime nDate))
            {
                Date = nDate;
            }
            Amount = int.Parse(amount);
            CompanyName = companyName;
            Address = address;
            Rating = int.Parse(rating);

        }
    }
}

