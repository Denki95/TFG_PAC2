using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CogerArma : MonoBehaviour
{

    //Clases Script
    public float Distancia;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Pistola_Suelo;
    public GameObject Pistola_Personaje;
    public GameObject Flecha;
    public GameObject ExtraCross;
    public GameObject Activador_Ataque;
    public GameObject MunicionHUD;

    void Update()
    {
        //Cogemos distancia del script player_casting para aplicarlo a la puerta
        Distancia = Player_Casting.DistanceFromTarget;

    }

    //Creamos void para activar la animacion de la puerta con el raton sobre ella
    void OnMouseOver(){
        //Con la distancia establecida se muestran los mensajes de texto
        if(Distancia <= 3){
            ExtraCross.SetActive(true);
            ActionText.GetComponent<TextMeshProUGUI>().text ="Agafar arma";
            ActionDisplay.SetActive (true);
            ActionText.SetActive (true);
        }
        //Acciones activadas al apretar el boton
        if(Input.GetButtonDown("Action")){
            if (Distancia <= 3){
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                Pistola_Suelo.SetActive(false);
                Pistola_Personaje.SetActive(true);
                ExtraCross.SetActive(false);
                Activador_Ataque.SetActive(true);
                MunicionHUD.SetActive(true);
            }
        }
    }
    //Al retirar raton de la puerta desaparecen los mensajes de texto
    void OnMouseExit(){
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
