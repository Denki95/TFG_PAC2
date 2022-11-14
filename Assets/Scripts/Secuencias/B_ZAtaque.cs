using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.UI;
using TMPro;

public class B_ZAtaque : MonoBehaviour
{
    public AudioSource GolpePuerta;
    public AudioSource MusicaPrimerAtaque;
    public GameObject TheZombie;
    public GameObject TheDoor;
    public AudioSource SonidoAmbiente;


    void OnTriggerEnter(){
        GetComponent<BoxCollider>().enabled = false;
        TheDoor.GetComponent<Animation>().Play("PuertaAbajo");
        GolpePuerta.Play();
        TheZombie.SetActive(true);
        StartCoroutine(PlayMusicaPrimerAtaque());
    }

    IEnumerator PlayMusicaPrimerAtaque(){
        yield return new WaitForSeconds(0.4f);
        SonidoAmbiente.Stop();
        MusicaPrimerAtaque.Play();
    }
}
