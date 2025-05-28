using GWENT.Cards;
using GWENT.Interfaces;
using UnityEngine;

[CreateAssetMenu(fileName = "FogCard", menuName = "GWENT/Cards/Fog")]
public class FogCard : CardBase, IWeather
{
    public void ApplyWeatherEffect()
    {
        Debug.Log($"{CardName} применяет погодный эффект: Мгла!");
    }

    public override void Play()
    {
        ApplyWeatherEffect();
    }
}