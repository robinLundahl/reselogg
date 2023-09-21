namespace ResemålApp;
class Resemål
{
    public string StartDatum;
    public string SlutDatum;
    public string Destination;
    public float Avstånd;
    public float Restid;
    public string Färdmedel;
    public float ÖvrigaKostnader;

    public override string ToString()
    {
        return $" {StartDatum} - {SlutDatum}, {Destination}, {Avstånd} km, {Restid} minuter, Övriga kostnader: {ÖvrigaKostnader}";
    }
}