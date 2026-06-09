using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }
}
