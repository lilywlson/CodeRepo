using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Characters")]
public class Stats : ScriptableObject
{
    public int level;
    public int health;
    public int attack;
    public int defense;
    public int speed;

    public void PrintStat()
    {
        Debug.Log("Character Statistics-- Level: " + level + " Health: " + health + " Attack: " + attack + " Defense: " + defense + " Speed: " + speed);
    }

    public void RandomStats()
    {
        level = Random.Range(1, 20);
        health = Random.Range(1, 100);
        attack = Random.Range(1, 30);
        defense = Random.Range(1, 30);
        speed = Random.Range(1, 20);
    }
}