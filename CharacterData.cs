using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Characters")]
public class Character : ScriptableObject
{
    public string characterName;
    public string description;

    public Sprite artwork;

    public int strength;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int wisdom;
    public int charisma;

    public void Print()
    {
        Debug.Log(characterName + ": " + description);
    }

    public void RandomAbilities()
    {
        strength = Random.Range(1, 20);
        dexterity = Random.Range(1, 20);
        constitution = Random.Range(1, 20);
        intelligence = Random.Range(1, 20);
        wisdom = Random.Range(1, 20);
        charisma = Random.Range(1, 20);
    }
}