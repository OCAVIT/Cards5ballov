namespace GWENT.Interfaces
{
    public enum SpecialAbilityType
    {
        None, Spy, Medic, Connection, Pretence, Twin, StrengthSurge, Execution, Berserk, Mardrem, AvengerCall,
    }

    public interface ISpecialAbility
    {
        SpecialAbilityType AbilityType { get; }
        void ApplyAbility();
    }
}