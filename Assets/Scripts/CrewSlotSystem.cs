using UnityEngine;
using UnityEngine.UI;

public class CrewSlotSystem : MonoBehaviour
{
    [SerializeField] private CardDisplay[] cards;
    [SerializeField] Transform[] spawnPoints;
    
    public void SpawnCrew(int id)
    {
        if(GameManager.instance.player.UseCoin(cards[id].card.crewCost))
        {
            GameObject spawnedCrew = Instantiate(cards[id].card.crewPrefab, spawnPoints[0]);
        }   
    }
}
