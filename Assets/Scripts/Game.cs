using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject piedra, papel, tijera;
 
    int estado = 1;
   
    // Start is called before the first frame update
    void Start()
    {
        piedra.SetActive(false);
        papel.SetActive(false);
        tijera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch(estado)
        {
            case 1:
                piedra.SetActive(true);
                papel.SetActive(false);
                tijera.SetActive(false);
                break;

            case 2:
                piedra.SetActive(false);
                papel.SetActive(true);
                tijera.SetActive(false);
                break;

            case 3:
                piedra.SetActive(false);
                papel.SetActive(false);
                tijera.SetActive(true);
                break;
        }
        
    }

    public void piedraBtn()
    {
        estado = 1;
    }

    public void papelBtn()
    {
        estado = 2;
    }

    public void tijeraBtn()
    {
        estado = 3;
    }
}
