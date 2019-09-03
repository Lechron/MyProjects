using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour


{
    public Transform SpawnPoint;
    public GameObject kugla;
    public GameObject zlaKugla;
    public GameObject diamond;

    float timer=0;
    public float spawnTime = 1;

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            int rnd = Random.Range(0, 5);
            if(rnd < 3)
            {
                GameObject kuglica = Instantiate(kugla, SpawnPoint.position + new Vector3(Random.Range(-8.99f, 8.99f), 0, 0), Quaternion.identity);
            }
            if (rnd == 3)
            {
                GameObject zlaKuglica = Instantiate(zlaKugla, SpawnPoint.position + new Vector3(Random.Range(-8.99f, 8.99f), 0, 0), Quaternion.identity);
            }
            if(rnd == 4)
            {
                GameObject diamondic = Instantiate(diamond, SpawnPoint.position + new Vector3(Random.Range(-8.99f, 8.99f), 0, 0), Quaternion.identity);
            }
            
            timer = spawnTime;
        }
       
    }
}
