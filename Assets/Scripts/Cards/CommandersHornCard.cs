using GWENT.Abilities;
using GWENT.Cards;
using GWENT.Interfaces;
using UnityEngine;

[CreateAssetMenu(fileName = "CommandersHornCard", menuName = "GWENT/Cards/Commander's Horn")]
public class CommandersHornCard : CardBase, ISpecialAbility, IStrengthSurge
{
    public SpecialAbilityType AbilityType => SpecialAbilityType.StrengthSurge;

    public void ApplyAbility()
    {
        Debug.Log($"{CardName} примен€ет способность:  омандный рог!");
    }

    public override void Play()
    {
        ApplyAbility();
    }
}