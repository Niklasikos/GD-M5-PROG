using System.Collections;
using UnityEngine;

public class Elf : EnemyParent
{
    [SerializeField] private float speedElf = 3f;
    [SerializeField] private int HpElf = 60;
    private Animator animator;
    private Renderer renderer;
    private CapsuleCollider capsuleCollider;
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        renderer = GetComponentInChildren<Renderer>();
        animator = GetComponent<Animator>();
        speed = speedElf;
        Hp = HpElf;
        StartCoroutine(Invisible());
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

    private IEnumerator Invisible()
    {
        yield return new WaitForSeconds(3f);
        renderer.enabled = false;
        capsuleCollider.enabled = false;
        yield return new WaitForSeconds(0.5f);
        renderer.enabled = true;
        capsuleCollider.enabled = true;
        StartCoroutine(Invisible());
        yield return null;
    }
}

