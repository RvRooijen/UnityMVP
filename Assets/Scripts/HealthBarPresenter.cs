public class HealthBarPresenter
{
    private IPlayer _player;
    private IHealthBar _healthBar;

    private float _damagePerClick = 10;
    
    public HealthBarPresenter(IPlayer player, IHealthBar healthBar)
    {
        _healthBar = healthBar;
        _player = player;
        
        UpdateHealthBarValue();
    }
    
    public void DamageButtonClicked()
    {
        _player.Health -= _damagePerClick;
        UpdateHealthBarValue();
    }

    private void UpdateHealthBarValue()
    {
        _healthBar.UpdateSliderValue(_player.Health / _player.MaxHealth);
    }
}
