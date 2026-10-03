using UnityEngine;

public class Brute : EnemyParent
{
    [SerializeField] private float speedBrute = 1f;
    [SerializeField] private int HpBrute = 200;
    private Animator animator;
    private CapsuleCollider capsuleCollider;
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        animator = GetComponent<Animator>();
        speed = speedBrute;
        Hp = HpBrute;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Damage"))
        {
            TakeDamage();
        }
    }

    private void Death()
    {
        capsuleCollider.enabled = false;
        animator.SetTrigger("Death");
        Destroy(gameObject, 3f);
    }

    private void TakeDamage()
    {
        Hp -= 20;
        if (Hp <= 0)
        {
            Death();
        }
    }
}
