using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField]
    int actualHealth;
    int currentHealth;
    void Start()
    {
        SetHealth();
    }
    public void TakeDamage()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            Death();
        }
    }
    public void SetHealth()
    {
        currentHealth = actualHealth;
    }
    public void SetInvincible()
    {
        currentHealth = 1000;
    }
    void Death()
    {
        if (gameObject.CompareTag("Player"))
        {
            //Spawn Player
        }
        else
        {
            if (gameObject.CompareTag("Small")) MasterTracker.smallTankDestroyed++;
            else if (gameObject.CompareTag("Fast")) MasterTracker.fastTankDestroyed++;
            else if (gameObject.CompareTag("Big")) MasterTracker.bigTankDestroyed++;
            else if (gameObject.CompareTag("Armored")) MasterTracker.armoredTankDestroyed++;
        }
        Destroy(gameObject);
    }
}