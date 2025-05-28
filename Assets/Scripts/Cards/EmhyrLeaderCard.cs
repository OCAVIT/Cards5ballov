using GWENT.Cards;
using GWENT.Interfaces;
using UnityEngine;

[CreateAssetMenu(fileName = "EmhyrLeaderCard", menuName = "GWENT/Cards/Emhyr Leader")]
public class EmhyrLeaderCard : CardBase, ILeader, ISiegeWeapon, IRare
{
    public void UseUltimate()
    {
        Debug.Log($"{CardName} ���������� ���������: ����� �����!");
    }

    public override void Play()
    {
        Debug.Log($"{CardName} �������� ��� �����.");
        UseUltimate();
    }
}