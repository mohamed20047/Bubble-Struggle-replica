using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    public Chain chainParent;

    private void OnTriggerEnter2D(Collider2D other)
    {
        chainParent.isFired = false;

        if (other.CompareTag("Ball"))
        {
            other.GetComponent<Ball>().Split();
        }
    }
}
