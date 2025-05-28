namespace GWENT.Interfaces
{
    public interface IPower
    {
        int PowerPoints { get; }
        void ApplyPower();
    }
}