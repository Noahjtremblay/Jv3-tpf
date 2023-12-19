using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacPoubelle : MonoBehaviour
{
  [SerializeField]
    private InfosPointage _infosPoints;

   [SerializeField] 
   private int _valeur;

   
    [SerializeField] private AudioClip _sonGagnePoints;


    [SerializeField]
    private GameObject _bac;

    [SerializeField]
    private AudioSource _audioSource;


    



    void OnTriggerEnter(Collider other){


if(other.CompareTag("ObjetsPoubelle")){ 

            _infosPoints.nbPoints += _valeur; //quand le joueur touche le bac le scriptable object de point est augmenté de 1
            //le scriptable object de poubelle revient à false
             //L'update de points total

           
            _audioSource.Play();



    }
}
}
