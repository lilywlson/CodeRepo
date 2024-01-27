using UnityEngine;
using UnityEngine.UI;

public class StatDisplay : MonoBehaviour
{
    public Stats stats; 
    public Text levelText;
    public Text healthText;
    public Text attackText;
    public Text defenseText;
    public Text speedText;

    public void Start()
    {
        levelText.text = "Level: " + stats.level;
        healthText.text = "Health: " + stats.health;
        attackText.text = "Attack: " + stats.attack;
        defenseText.text = "Defense: " + stats.defense;
        speedText.text = "Speed: " + stats.speed;
    }
}