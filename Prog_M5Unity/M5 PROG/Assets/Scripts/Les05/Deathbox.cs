using UnityEngine;

public class Deathbox : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
