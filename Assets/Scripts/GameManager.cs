using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 
    void Awake() { instance = this; }
    
    public Player player;
    public CrewSlotSystem crewSlotSystem;

    void Start()
    {
        player.Init();
    } 
}
