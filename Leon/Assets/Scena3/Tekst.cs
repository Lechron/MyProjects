using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tekst : MonoBehaviour

{

    public int ball;
    public Text kugel;
    public GameManager2 manager;
    bool smanjiTimer = false;
        
    private void Start()
    {
        kugel.text = ball + "";

    }

    private void Update()
    {
        if(ball % 10 == 0 && ball != 0 && smanjiTimer == false)
        {
            manager.spawnTime -= 0.1f;
            smanjiTimer = true;
        }
        if(ball%10 != 0)
        {
            smanjiTimer = false;
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "DobraKugla")
        {
            Debug.Log("TRIGGeR");
            ball += 1;
            kugel.text = ball + "";     
            Destroy(other.gameObject);
        }
    }


}
