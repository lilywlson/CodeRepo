using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour
{
    public Character character; 
    public Text nameText;
    public Text descriptionText;

    public void Start()
    {
        nameText.text = character.characterName;
        descriptionText.text = character.description;
    }
}