namespace P04AplikacjaZawodnicy.Core.Repositories
{
    partial class ModelBazyDanychDataContext
    {
    }

    partial class Zawodnik
    {
        public string ImieNazwiskoKraj => Imie + " " + Nazwisko + " " + Kraj;
    }

}