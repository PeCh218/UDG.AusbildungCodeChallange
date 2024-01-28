using CsvHelper.Configuration.Attributes;

namespace Data.Models;

public class Artikel
{
    [Name("Hauptartikelnr")]
    public string Hauptartikelnr { get; set; }
    [Name("Artikelname")]
    public string Artikelname { get; set; }
    [Name("Hersteller")]
    public string Hersteller { get; set; }
    [Name("Beschreibung")]
    public string Beschreibung { get; set; }
    [Name("Materialangaben")]
    public string Materialangaben { get; set; }
    [Name("Geschlecht")]
    public string Geschlecht { get; set; }
    [Name("Produktart")]
    public string Produktart { get; set; }
    [Name("Ärmel")]
    public string Ärmel { get; set; }
    [Name("Bein")]
    public string? Bein { get; set; }
    [Name("Kragen")]
    public string Kragen { get; set; }
    [Name("Herstellung")]
    public string Herstellung { get; set; }
    [Name("Taschenart")]
    public string? Taschenart { get; set; }
    [Name("Grammatur")]
    public string Grammatur { get; set; }
    [Name("Material")]
    public string Material { get; set; }
    [Name("Ursprungsland")]
    public string? Ursprungsland { get; set; }
    [Name("Bildname")]
    public string Bildname { get; set; }
}
