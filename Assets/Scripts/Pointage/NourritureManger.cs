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

            _infosPoints.nbPoints += 1;
            
            _audioSource.Play();

             Destroy(gameObject);
         }

        
    }

    void OnCollisionEnter(Collision other){


        if(other.transform.tag == "MainCamera"){ 

            _infosPoints.nbPoints += 1;
            

            // _audioSource.clip = _sonGagnePoints;
           // _audioSource.Play();

            Destroy(gameObject);


        }


    }
}
