using UnityEngine;
using UnityEngine.Events;

public class CollisionDamage : MonoBehaviour
{
    public UnityEvent dmgTaken;
    public int damage;

    private void OnCollisionEnter2D(Collision2D other)
    {
        dmgTaken.Invoke(damage);
    }
}