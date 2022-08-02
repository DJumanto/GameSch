using UnityEngine;
using TMPro;

public class CoinSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinCount;

    public void SetCoin(int coin)
    {
        coinCount.text = coin.ToString();
    }
}
