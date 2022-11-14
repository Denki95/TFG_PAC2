using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteZombie : MonoBehaviour
{
    public int VidaEnemigo = 20;
    public GameObject Enemigo;
    public int StatusCheck;
    public AudioSource musicaAtaque;
    public AudioSource SonidoAmbiente;


    void DañoZombie(int CantidadDaño){
        VidaEnemigo -= CantidadDaño;
    }

    void Update()
    {
        if(VidaEnemigo <= 0 && StatusCheck == 0){
            this.GetComponent<ZombieIA>().enabled = false;
            this.GetComponent<CapsuleCollider>().enabled = false;
            StatusCheck = 2;
            Enemigo.GetComponent<Animator>().Play("Z_FallingForward");
            musicaAtaque.Stop();
            SonidoAmbiente.Play();
        }    
    }
}
