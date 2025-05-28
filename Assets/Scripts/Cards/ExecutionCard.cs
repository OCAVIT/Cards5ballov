using GWENT.Abilities;
using GWENT.Cards;
using GWENT.Interfaces;
using UnityEngine;

[CreateAssetMenu(fileName = "ExecutionCard", menuName = "GWENT/Cards/Execution")]
public class ExecutionCard : CardBase, ISpecialAbility, IExecution
{
    public SpecialAbilityType AbilityType => SpecialAbilityType.Execution;

    public void ApplyAbility()
    {
        Debug.Log($"{CardName} применяет способность: Казнь!");
    }

    public override void Play()
    {
        ApplyAbility();
    }
}