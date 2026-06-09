using UnityEngine;

public class GroundEffect : MonoBehaviour
{
//  Can Use Lerp also for smoothness reset.
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(-2f, transform.position.y), speed * Time.deltaTime);

        if(transform.position.x <= -2f)
        {
            transform.position = new Vector2(2f, speed * Time.deltaTime);
        }
    }
}
