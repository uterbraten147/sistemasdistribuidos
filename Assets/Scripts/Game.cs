using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject piedra, papel, tijera;
    public Text ObjetoElegido, timer;
    public float TotalTime = 50f;
    float currentTime=0.0f;
    int randomState = 0;
    int estado = 0;
    bool gameOver = false;
   
    // Start is called before the first frame update
    void Start()
    {
        piedra.SetActive(false);
        papel.SetActive(false);
        tijera.SetActive(false);
        currentTime = TotalTime;
        randomState = Random.Range(1, 4);
        Debug.Log(randomState);
    }

    // Update is called once per frame
    void Update()
    {


        
        currentTime -=  Time.deltaTime;
        timer.text = currentTime.ToString("0");



       /* while (!gameOver)
        {*/
            switch (estado)
            {
                case 0:
                    ObjetoElegido.text = "Elige una opcion";

                    break;
                case 1:
                    piedra.SetActive(true);
                    papel.SetActive(false);
                    tijera.SetActive(false);

                    ObjetoElegido.text = "Escogiste Piedra!!";
                    break;

                case 2:
                    piedra.SetActive(false);
                    papel.SetActive(true);
                    tijera.SetActive(false);
                    ObjetoElegido.text = "Escogiste Papel!!";
                    break;

                case 3:
                    piedra.SetActive(false);
                    papel.SetActive(false);
                    tijera.SetActive(true);

                    ObjetoElegido.text = "Escogiste Tijeras!!";
                    break;
            }

        //}
        
        
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
