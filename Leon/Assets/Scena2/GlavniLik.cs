using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlavniLik : MonoBehaviour
{
    public int bodovi;
    public int diamonds;
    public Text bod;
    public Text diamondsText;
    public GameManager manager;
    bool stvoreno = false;
    int brojLVLa= 0;

    private void Start()
    {
        bod.text = bodovi + "";
    }

    private void Update()
    {
        if (bodovi % 5 != 0)
        {
            stvoreno = false;
        }
        if (bodovi % 5 == 0 && bodovi != 0)
        {
            
            if (stvoreno == false)
            {
                manager.dioLevela[brojLVLa].SetActive(true);
                manager.Stvaranje(brojLVLa+1);
                stvoreno = true;
                brojLVLa++;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            bodovi += 1;
            bod.text = bodovi + "";
            manager.spawnNumber--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Diamond")
        {
            diamonds += 1;
            diamondsText.text = diamonds + "";
            Destroy(other.gameObject);
        }
    }



}



