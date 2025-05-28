using GWENT.Cards;
using GWENT.Interfaces;
using UnityEngine;

[CreateAssetMenu(fileName = "BlueStripesArcherCard", menuName = "GWENT/Cards/Blue Stripes Archer")]
public class BlueStripesArcherCard : CardBase, IArcher, IPower
{
    [SerializeField] private int powerPoints = 5;
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