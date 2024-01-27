using UnityEngine;

[CreateAssetMenu(fileName = "New Position", menuName = "Position Tracking")]
public class Position : ScriptableObject
{
    public int xPos;
    public int yPos;
    public int zPos;

    public void PrintPos()
    {
        Debug.Log(xPos, yPos, zPos);
    }
}