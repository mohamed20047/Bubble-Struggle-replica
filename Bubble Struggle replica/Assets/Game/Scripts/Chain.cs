using UnityEngine;

public class Chain : MonoBehaviour
{
    public GameObject player;

    public Vector3 offset;
    public float chainSpeed = 10f;
    public bool isFired = false;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isFired = true;
        }

        if (isFired)
        {
            transform.localScale += Vector3.up * chainSpeed * Time.deltaTime;
        }
        else
        {
            transform.localScale = new Vector3(1, 0, 1);
            transform.position = player.transform.position + offset;
        }
    }
}
