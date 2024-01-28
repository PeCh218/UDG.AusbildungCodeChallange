using Data;

var csvReader = new CSVReader();


var artikel = csvReader.ReadCsvFile();


foreach (var item in artikel)
{
    Console.WriteLine(item.Artikelname);
}
