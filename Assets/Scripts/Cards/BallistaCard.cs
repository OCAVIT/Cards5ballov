using GWENT.Cards;
using GWENT.Interfaces;
using UnityEngine;

[CreateAssetMenu(fileName = "BallistaCard", menuName = "GWENT/Cards/Ballista")]
public class BallistaCard : CardBase, ISiegeWeapon, IPower
{
    [SerializeField] private int powerPoints = 6;
    public int PowerPoints => powerPoints;

    public void ApplyPower()
    {
        Debug.Log($"{CardName} добавляет {PowerPoints} очков силы.");
    }

    public override void Play()
    {
        ApplyPower();
    }
}