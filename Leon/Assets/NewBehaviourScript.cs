using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int broj1 = 12;
    public int broj2 = 13;
    public GameObject bzvz;
    public Text textBroja;

    private void Update()
    {
        if(broj1 < broj2)
        {
            textBroja.text = "Broj1 je manji";
        }

        if(broj1 > broj2)
        {
            textBroja.text = "Broj1 je veći";
        }

        if(broj1 == broj2)
        {
            textBroja.text = "Broj1 je isti kao i broj2";
        }
    }

}
