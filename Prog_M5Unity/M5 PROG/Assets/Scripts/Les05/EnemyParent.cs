using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    protected float speed = 5f;
    protected int Hp = 100;

    protected virtual void Update() // virtual zodat de children het changen ukunnen
    {
        transform.position += Vector3.right * (speed * Time.deltaTime);

    }
}
