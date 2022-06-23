class Heroi: ISomavel
{
    int forca;
    int vida;

    public Heroi(int forca, int vida)
    {
        this.forca = forca;
        this.vida = vida;
    }

    public ISomavel soma(ISomavel b)
    {
        Heroi bHeroi = ((Heroi)b);
        return new Heroi(this.forca + bHeroi.forca, this.vida + bHeroi.vida);
    }

    public override string ToString()
    {
        return $"Vida: {this.vida}, Forca: {this.forca}";
    }
}