using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour, IHealthBar
{
    [SerializeField]
    private Slider slider;
    private HealthBarPresenter _healthBarPresenter;

    [SerializeField]
    private Button damageButton;
    
    public void Initialize(IPlayer player)
    {
        _healthBarPresenter = new HealthBarPresenter(player, this);
        damageButton.onClick.AddListener(() => _healthBarPresenter.DamageButtonClicked());
    }

    public void UpdateSliderValue(float value)
    {
        slider.value = value;
    }
}
