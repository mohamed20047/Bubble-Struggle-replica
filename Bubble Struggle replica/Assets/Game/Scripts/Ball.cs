using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startForce;
    private Rigidbody2D rb;

    public GameObject nextBall;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    public void Split()
    {
        if (nextBall)
        {
            GameObject ball1 = Instantiate(nextBall, transform.position, Quaternion.identity);
            GameObject ball2 = Instantiate(nextBall, transform.position, Quaternion.identity);

            Ball ball1Script = ball1.GetComponent<Ball>();
            Ball ball2Script = ball2.GetComponent<Ball>();

            ball1Script.startForce = new Vector2(2f, 5f);
            ball2Script.startForce = new Vector2(-2f, 5f);
        }

        Destroy(gameObject);
    }
}
