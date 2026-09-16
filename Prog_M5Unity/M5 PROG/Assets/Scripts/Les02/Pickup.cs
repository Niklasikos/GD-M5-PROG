using System;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public static event Action<int> ScoreAdd;
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            System.Random random = new System.Random();
            int points = random.Next(10, 50);
            ScoreAdd?.Invoke(points);
            Destroy(gameObject);
        }
    }
}
