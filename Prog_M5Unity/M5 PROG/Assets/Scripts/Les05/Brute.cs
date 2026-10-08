using UnityEngine;

public class Brute : EnemyParent
{
    [SerializeField] private float speedBrute = 1f;
    [SerializeField] private int HpBrute = 200;
    
    void Awake()
    {
        speed = speedBrute;
        Hp = HpBrute;
    }
}
