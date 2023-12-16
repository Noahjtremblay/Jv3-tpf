using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacPoubelle : MonoBehaviour
{
  [SerializeField]
    private InfosPointage _infosPoints;

    private AudioSource _audioSource;
    [SerializeField] private AudioClip _sonGagnePoints;


[SerializeField]
private GameObject _bac;




    // Start is called before the first frame update
    void Start()
    {
         _audioSource = GetComponent<AudioSource>();

         
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter(Collider other){


if(other.CompareTag("ObjetsPoubelle")){ 

            _infosPoints.nbPoints += 2; //quand le joueur touche le bac le scriptable object de point est augmenté de 1
            //le scriptable object de poubelle revient à false
             //L'update de points total

             _audioSource.clip = _sonGagnePoints;
            _audioSource.Play();



    }
}
}
