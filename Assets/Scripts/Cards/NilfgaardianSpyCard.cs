using GWENT.Abilities;
using GWENT.Cards;
using GWENT.Interfaces;
using UnityEngine;

[CreateAssetMenu(fileName = "NilfgaardianSpyCard", menuName = "GWENT/Cards/Nilfgaardian Spy")]
public class NilfgaardianSpyCard : CardBase, IMeleeFighter, IPower, ISpecialAbility, ISpy
{
    [SerializeField] private int powerPoints = 1;
    public int PowerPoints => powerPoints;
    public SpecialAbilityType AbilityType => SpecialAbilityType.Spy;

    public void ApplyPower()
    {
        Debug.Log($"{CardName} добавл€ет {PowerPoints} очков силы.");
    }

    public void ApplyAbility()
    {
        Debug.Log($"{CardName} примен€ет способность: Ўпион!");
    }

    public override void Play()
    {
        ApplyPower();
        ApplyAbility();
    }
}