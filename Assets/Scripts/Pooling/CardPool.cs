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
            string info = $"Создана карта {card.CardName}; ";
            if (card is IArcher) info += "тип размещения: дальний бой; ";
            if (card is IMeleeFighter) info += "тип размещения: ближний бой; ";
            if (card is ISiegeWeapon) info += "тип размещения: осадное орудие; ";
            if (card is ISpecialAbility sa) info += $"спец. способность: {sa.AbilityType}; ";
            if (card is IPower p) info += $"очки силы: {p.PowerPoints}; ";
            if (card is IWeather) info += "карта погоды; ";
            if (card is IRare) info += "редкая карта; ";
            if (card is ILeader) info += "карта лидера; ";
            Debug.Log(info);
        }

        public List<CardBase> GetAllCards() => new(pool);
    }
}