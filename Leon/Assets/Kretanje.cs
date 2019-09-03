using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kretanje : MonoBehaviour
{
    public float speed = 20;
    bool ubrzaj = false;
    float timerBrzine=5;

    void Update()
    {
        
        if(ubrzaj == true)
        {
            speed = 30;
            timerBrzine -= Time.deltaTime;
            if(timerBrzine <= 0)
            {
                ubrzaj = false;
            }
        }

        if(ubrzaj == false)
        {
            speed = 20;
            timerBrzine = 5;
        }

        if(Input.GetKey(KeyCode.A) && transform.position.x >=-8)
        {
            transform.position -= new Vector3(speed, 0, 0)*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 8)
        {
            transform.position -= new Vector3(-speed, 0, 0) * Time.deltaTime;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Diamond")
        {
            ubrzaj = true;
            Destroy(other.gameObject);
        }
    }
}
