using UnityEngine;

public class HealthBarHUD : MonoBehaviour
{
    public void AddHealth()
    {
        PlayerStats.Instance.AddHealth();
    }

    public void Heal(float health)
    {
        PlayerStats.Instance.Heal(health);
    }

    public void Hurt(float dmg)
    {
        Debug.Log(PlayerStats.Instance);
        PlayerStats.Instance.TakeDamage(dmg);
    }
}
