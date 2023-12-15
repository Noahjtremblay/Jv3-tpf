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


if(other.CompareTag("ObjetsPoubelle") && _infosPoints.poubelle == true){ 

            _infosPoints.nbPoints += 1; //quand le joueur touche le bac le scriptable object de point est augmenté de 1
            _infosPoints.poubelle = false; //le scriptable object de poubelle revient à false
            _infosPoints.total = _infosPoints.nbPoints; //L'update de points total

             _audioSource.clip = _sonGagnePoints;
            _audioSource.Play();



    }
}
}
