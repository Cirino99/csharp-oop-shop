// See https://aka.ms/new-console-template for more information

//Consegna esercizio
//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

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
Console.WriteLine(prodotto1.GetCodicePadLeft());

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
        codice = random.Next(1, 12345678);
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
    public string GetCodicePadLeft()
    {
        string codice = Convert.ToString(this.codice);
        while (codice.Length < 8)
        {
            codice = '0' + codice;
        }
        return codice;
    }
}