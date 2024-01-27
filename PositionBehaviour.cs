using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    void Update()
    {
        playerPos.xPos = gameObject.transform.position.x;
        playerPos.yPos = gameObject.transform.position.y;
        playerPos.zPos = gameObject.transform.position.z;
    }
}