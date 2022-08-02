using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private int defaultCoin;
    [SerializeField] private CoinSystem coinUI;
    [SerializeField] private int maxHealth;
    [SerializeField] private HealthSystem healthUI;

    private int currentHealth;
    private int currentCoin;

    public void Init()
    {
        currentHealth = maxHealth;
        currentCoin = defaultCoin;
        healthUI.Init();
        healthUI.SetMaxHealth(maxHealth);
        coinUI.SetCoin(defaultCoin);
    }

    void Update()
    {
      // Debug
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GetHit(10);
        UseCoin(10);
      }
      if (Input.GetKeyDown(KeyCode.Tab))
      {
        GetCoin(2);
      }
    }

    private bool GetHit(int damage)
    {
      currentHealth -= damage;
      healthUI.SetHealth(currentHealth);
      if(currentHealth <= 0)
      {
        Die();
        return true;
      }
      return false;
    }

    private void Die()
    {
      Debug.Log("You lost");
    }
    
    public bool UseCoin(int coin)
    {
      if(coin <= currentCoin)
      {
        currentCoin -= coin;
        coinUI.SetCoin(currentCoin);
        return true;
      }
      else
      {
        Debug.Log("Not Enough Coin");
        return false;
      }
    }
    
    public void GetCoin(int coin)
    {
        currentCoin += coin;
        coinUI.SetCoin(currentCoin);
    }
}
