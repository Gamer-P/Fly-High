using UnityEngine;   

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float bounce;
    [SerializeField] private float rotationSpeed = 5f;

    private float targetAngle;

    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, bounce) * Time.deltaTime, ForceMode2D.Impulse);
            FindAnyObjectByType<GameManager>().SoundEffect();
        }

        if (rb.linearVelocity.y > 0.1f)
        {
            targetAngle = 30f;

        }
        else
        {
            targetAngle = -60f;
        }

        float currentAngle = transform.eulerAngles.z;
        float newAngle = Mathf.LerpAngle(currentAngle, targetAngle, rotationSpeed * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0f, 0f, newAngle);
    }
}
