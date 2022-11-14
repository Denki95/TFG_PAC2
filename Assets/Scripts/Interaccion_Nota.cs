using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Interaccion_Nota : MonoBehaviour
{

        //Clases Script
    public float Distancia;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Nota;
    public GameObject Flecha;
    public AudioSource SonidoPapel;
    public GameObject ExtraCross;

    void Update()
    {
        //Cogemos distancia del script player_casting para aplicarlo a la  nota
        Distancia = Player_Casting.DistanceFromTarget;
    }

    void OnMouseOver(){
        //Con la distancia establecida se muestran los mensajes de texto
        if(Distancia <= 3){
            ExtraCross.SetActive(true);
            ActionDisplay.SetActive (true);
            ActionText.SetActive (true);
        }
        //Acciones activadas al apretar el boton
        if(Input.GetButtonDown("Action")){
            if (Distancia <= 3){
                this.GetComponent<BoxCollider>().enabled = false;
                Nota.GetComponent<MeshRenderer>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                SonidoPapel.Play();
                Flecha.SetActive(false);
            }
        }
    }

    void OnMouseExit(){
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
