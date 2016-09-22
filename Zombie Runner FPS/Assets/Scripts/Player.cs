using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Transform playerSpawnPoints;
    public bool reSpawn = false;
    public GameObject landingAreaPrefab;
    private Transform[] spawnPoints;
    private bool lastToggle = false;
    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }
  

    void Update()
    {
        if (lastToggle != reSpawn)
        {
           Respawn();
            reSpawn = false;
        }
        else
        {
            lastToggle = reSpawn;
        }
    }
    private void Respawn()
    {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].transform.position;
    }
    void OnMakeInitalHeliCall()
    {
        Invoke("DropFlare",3f);
    }
  
    void DropFlare()
    {
        Instantiate(landingAreaPrefab,this.transform.position,this.transform.rotation);
    }
}
