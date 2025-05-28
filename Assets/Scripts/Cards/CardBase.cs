using UnityEngine;

namespace GWENT.Cards
{
    public abstract class CardBase : ScriptableObject
    {
        [SerializeField] private string cardName;
        [SerializeField] private Sprite icon;
        [SerializeField][TextArea] private string description;

        public string CardName => cardName;
        public Sprite Icon => icon;
        public string Description => description;

        public abstract void Play();
    }
}