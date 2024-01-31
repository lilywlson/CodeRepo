using UnityEngine;
using UnityEngine.Events;

public class CollisionHealth : MonoBehaviour
{
    public UnityEvent healthTaken;
    public int healthToGive;

    private void OnCollisionEnter2D(Collision2D other)
    {
        healthTaken.Invoke(healthToGive);
    }
}