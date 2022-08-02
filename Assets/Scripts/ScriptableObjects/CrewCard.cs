using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Crew Card")]
public class CrewCard : ScriptableObject
{
    public string crewID;
    public string crewName;
    public string description;
    public int health;
    public int attack;
    public int crewCost;
    public Sprite crewIcon;
    public GameObject crewPrefab;
    public float moveSpeed;
    public float attackInterval;
}
