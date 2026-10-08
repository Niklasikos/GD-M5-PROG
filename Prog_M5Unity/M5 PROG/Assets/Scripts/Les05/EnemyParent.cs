using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    protected float speed = 5f;
    protected int Hp = 100;

    protected Animator animator;
    protected CapsuleCollider capsuleCollider;

    protected void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        animator = GetComponent<Animator>();
    }

    protected virtual void Update() // virtual zodat de children het changen ukunnen
    {
        transform.position += Vector3.right * (speed * Time.deltaTime);

    }

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Damage"))
        {
            TakeDamage();
        }

    }

    protected private void Death()
    {
        capsuleCollider.enabled = false;
        animator.SetTrigger("Death");
        Destroy(gameObject, 3f);
    }

    protected private void TakeDamage()
    {
        Hp -= 20;
        if (Hp <= 0)
        {
            Death();
        }
    }
}
