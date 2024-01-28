using CsvHelper;
using CsvHelper.Configuration;
using Data.Models;
using System.Globalization;

namespace Data;

public class CsvManager
{
    private const string CsvPathOriginal = @"F:\Projekte\UDG.AusbildungCodeChallange\Data\CSVFiles\Artikel_original.csv";
    private const string CsvPath = @"F:\Projekte\UDG.AusbildungCodeChallange\Data\CSVFiles\Artikel.csv";

    public IEnumerable<Artikel> ReadCsvFile()
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.ToLower(),
            Delimiter = ";"
        };


        using var reader = new StreamReader(CsvPathOriginal);
        using var csv = new CsvReader(reader, config);
        var records = csv.GetRecords<Artikel>();

        return records.ToList();
    }

    public void WriteCsvFile(IEnumerable<Artikel> articles)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.ToLower(),
            Delimiter = ";"
        };


        using var writer = new StreamWriter(CsvPath);
        using var csv = new CsvWriter(writer, config);
        csv.WriteRecords(articles);
    }
}

