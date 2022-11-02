// See https://aka.ms/new-console-template for more information

Prodotto prodotto1 = new Prodotto();
prodotto1.SetNome("Ipad");
prodotto1.SetDescrizione("Nuovo ipad");
prodotto1.SetPrezzo(349.99);
prodotto1.SetIva(22);
Console.WriteLine(prodotto1.GetCodice());
Console.WriteLine(prodotto1.GetNome());
Console.WriteLine(prodotto1.GetDescrizione());
Console.WriteLine(prodotto1.GetPrezzo());
Console.WriteLine(prodotto1.GetIva());
Console.WriteLine(prodotto1.GetPrezzoIva());
Console.WriteLine(prodotto1.GetNomeEsteso());

public class Prodotto
{
    private int codice;
    private string nome;
    private string descrizione;
    private double prezzo;
    private int iva;

    public Prodotto()
    {
        Random random = new Random();
        codice = random.Next(1, 1230587);
    }

    public int GetCodice()
    {
        return codice;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public string GetNome()
    {
        return nome;
    }
    public void SetDescrizione(string descrizione)
    {
        this.descrizione = descrizione;
    }
    public string GetDescrizione()
    {
        return descrizione;
    }
    public void SetPrezzo(double prezzo)
    {
        this.prezzo = prezzo;
    }
    public double GetPrezzo()
    {
        return prezzo;
    }
    public void SetIva(int iva)
    {
        this.iva = iva;
    }
    public int GetIva()
    {
        return iva;
    }
    public double GetPrezzoIva()
    {
        return prezzo + (prezzo / 100 * iva);
    }
    public string GetNomeEsteso()
    {
        return codice + " " + nome;
    }
}