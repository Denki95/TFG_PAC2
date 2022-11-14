using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.UI;
using TMPro;

public class A_Inicio001 : MonoBehaviour
{
    //Variables para hacer intro
    public GameObject Jugador;
    public GameObject FadeScreenIn;
    public GameObject TextBox;


    void Start()
    {
        //Desactivamos controles primera persona y comenzamos escena
     Jugador.GetComponent<FirstPersonController>().enabled = false;
     StartCoroutine(ScenePlayer());   
    }

    IEnumerator ScenePlayer(){
        //Degradado de pantalla
        yield return new WaitForSeconds (1.5f);
        FadeScreenIn.SetActive(false);

        //Iniciamos texto escena inicio en la textbox
        TextBox.GetComponent<TextMeshProUGUI>().text="Deu meu... He de sortir d'aquí";
        TextBox.SetActive(true);

        yield return new WaitForSeconds (2);
        
        //vaciamos textbox
        TextBox.GetComponent<TextMeshProUGUI>().text="";
        TextBox.SetActive(false);

        //activamos controles primera persona
        Jugador.GetComponent<FirstPersonController>().enabled = true;
    }


}
