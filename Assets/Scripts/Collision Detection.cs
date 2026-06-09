using System.Runtime.CompilerServices;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("obstacle"))
        {
            FindAnyObjectByType<GameManager>().GameOver();
        }
    }
}
