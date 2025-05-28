using GWENT.Cards;
using GWENT.Interfaces;
using UnityEngine;

[CreateAssetMenu(fileName = "RedanianFootSoldierCard", menuName = "GWENT/Cards/Redanian Foot Soldier")]
public class RedanianFootSoldierCard : CardBase, IMeleeFighter, IPower
{
    [SerializeField] private int powerPoints = 4;
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