using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NourritureManger : MonoBehaviour
{
 [SerializeField]
    private int _valeur;

    [SerializeField]
    private InfosPointage _infosPoints;

    [SerializeField]
    private AudioSource _audioSource;
   

     void OnTriggerEnter(Collider other) {
         if(other.transform.tag == "MainCamera"){ 

            _infosPoints.nbPoints += _valeur;
            
            
            _audioSource.Play();

             Destroy(gameObject);
         }

        
    }

    
}
