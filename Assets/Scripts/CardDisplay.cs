using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public CrewCard card;
    [SerializeField] private TextMeshProUGUI cardCost;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private Image cardIcon;

    // Start is called before the first frame update
    void Start()
    {
        cardCost.text = card.crewCost.ToString();
        cardIcon.sprite = card.crewIcon;
        descriptionText.text = card.description;
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
    }
}
