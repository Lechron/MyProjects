using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUCANJE : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject metak;
    public float brzinaMetka;
  

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            GameObject metakCopy = Instantiate(metak, spawnPoint.position, spawnPoint.rotation);
            metakCopy.GetComponent<Rigidbody>().velocity += spawnPoint.TransformDirection(new Vector3(0, 0, brzinaMetka));
        }
    }
}
