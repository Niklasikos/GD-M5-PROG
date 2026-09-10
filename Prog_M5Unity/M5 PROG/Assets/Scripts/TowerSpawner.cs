using UnityEngine;
using UnityEngine.InputSystem;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject tower;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            float x = Random.Range(0f, 1f);
            float y = Random.Range(0.5f, 1f);
            float z = Random.Range(0f, 1f);

            float posx = Random.Range(-4f, 4f);
            float posz = Random.Range(-4f, 4f);
            GameObject towerins = Instantiate(tower, new Vector3(0, 0, 0), Quaternion.identity);
            towerins.transform.position = new Vector3(posx, 0, posz);
            towerins.transform.localScale = new Vector3(x,y,z);
        }
    }
}
