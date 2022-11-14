using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerMunicion : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        MunicionGlobal.MunicionCantidad += 7;

        gameObject.SetActive(false);
    }
}
