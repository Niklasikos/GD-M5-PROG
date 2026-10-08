using System.Collections;
using UnityEngine;

public class Elf : EnemyParent
{
    [SerializeField] private float speedElf = 3f;
    [SerializeField] private int HpElf = 60;

    private Renderer elfRenderer;

    void Awake()
    {
        speed = speedElf;
        Hp = HpElf;
        elfRenderer = GetComponentInChildren<Renderer>();
        StartCoroutine(Invisible());        
    }

    private IEnumerator Invisible()
    {
        yield return new WaitForSeconds(3f);
        elfRenderer.enabled = false;
        capsuleCollider.enabled = false;
        yield return new WaitForSeconds(0.5f);
        elfRenderer.enabled = true;
        capsuleCollider.enabled = true;
        StartCoroutine(Invisible());
        yield return null;
    }
}

