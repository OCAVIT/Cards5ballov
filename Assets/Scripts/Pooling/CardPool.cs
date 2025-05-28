using System.Collections.Generic;
using UnityEngine;
using GWENT.Cards;
using GWENT.Interfaces;

namespace GWENT.Pooling
{
    public class CardPool : MonoBehaviour
    {
        public static CardPool Instance { get; private set; }

        [SerializeField] private List<CardBase> allCards;

        private readonly List<CardBase> pool = new();

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void InitializePool()
        {
            pool.Clear();
            foreach (var card in allCards)
            {
                pool.Add(card);
                LogCardInfo(card);
            }
        }

        private void LogCardInfo(CardBase card)
        {
            string info = $"������� ����� {card.CardName}; ";
            if (card is IArcher) info += "��� ����������: ������� ���; ";
            if (card is IMeleeFighter) info += "��� ����������: ������� ���; ";
            if (card is ISiegeWeapon) info += "��� ����������: ������� ������; ";
            if (card is ISpecialAbility sa) info += $"����. �����������: {sa.AbilityType}; ";
            if (card is IPower p) info += $"���� ����: {p.PowerPoints}; ";
            if (card is IWeather) info += "����� ������; ";
            if (card is IRare) info += "������ �����; ";
            if (card is ILeader) info += "����� ������; ";
            Debug.Log(info);
        }

        public List<CardBase> GetAllCards() => new(pool);
    }
}