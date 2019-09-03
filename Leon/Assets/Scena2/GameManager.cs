using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject kovanica;
    public GameObject losaKovanica;
    public GameObject TrolKovanica;

    public GameObject[] dioLevela;
    public Transform[] spawnPoint;

    public int spawnNumber = 0;

    private void Start()
    {
        Stvaranje(0);
    }

    public void Stvaranje(int spawnPointNumber)
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject kovanicaDobra = Instantiate(kovanica, spawnPoint[spawnPointNumber].position + new Vector3(Random.Range(-2.4f, 2.6f), 0, Random.Range(5, -9)), spawnPoint[spawnPointNumber].rotation);
            spawnNumber++;
            int rndm = Random.Range(0, 3);

            if (rndm == 1)
            {
                GameObject losaKovanicaKopija = Instantiate(losaKovanica, spawnPoint[spawnPointNumber].position + new Vector3(Random.Range(-2.4f, 2.6f), 0, Random.Range(5, -9)), spawnPoint[spawnPointNumber].rotation);
            }

            if (rndm == 2)
            {
                GameObject TrolKovanicaKopija = Instantiate(TrolKovanica, spawnPoint[spawnPointNumber].position + new Vector3(Random.Range(-2.4f, 2.6f), 0, Random.Range(5, -9)), Quaternion.identity);
            }
        }
    }




    private void Update()
    {
        
    }
}
























//private void Update()
//{
//    if(spawnNumber<6)
//    {
//        for(int i=0; i<spawnPoint.Length;i++)
//        {
//            int rndm = Random.Range(0, 3);
//            Debug.Log(rndm);
//            if(rndm == 0)
//            {
//                GameObject kovanicaKopija = Instantiate(kovanica, spawnPoint[i].position + new Vector3(Random.Range(0, 8), 0, Random.Range(0, 8)), spawnPoint[i].rotation);
//                spawnNumber++;
//            }
//            if (rndm == 1)
//            {
//                GameObject losaKovanicaKopija = Instantiate(losaKovanica, spawnPoint[i].position + new Vector3(Random.Range(0, 8), 0, Random.Range(0, 8)), spawnPoint[i].rotation);
//            }

//            if (rndm == 2)
//            {
//                GameObject TrolKovanicaKopija = Instantiate(TrolKovanica, spawnPoint[i].position + new Vector3(Random.Range(0, 8), 0, Random.Range(0, 8)), Quaternion.identity);

//                GameObject kovanicaKopija2 = Instantiate(kovanica, spawnPoint[i].position + new Vector3(Random.Range(0, 8), 0, Random.Range(0, 8)), spawnPoint[i].rotation);
//                spawnNumber++;


//        }
//    }

//}

