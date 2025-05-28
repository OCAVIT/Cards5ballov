using GWENT.Cards;
using GWENT.Interfaces;
using UnityEngine;

[CreateAssetMenu(fileName = "FoltestLeaderCard", menuName = "GWENT/Cards/Foltest Leader")]
public class FoltestLeaderCard : CardBase, ILeader, IMeleeFighter, IRare
{
    public void UseUltimate()
    {
        Debug.Log($"{CardName} ���������� ���������: ������������ ������!");
    }

    public override void Play()
    {
        Debug.Log($"{CardName} �������� ��� �����.");
        UseUltimate();
    }
}