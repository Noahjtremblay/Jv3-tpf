using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NourritureManger : MonoBehaviour
{
 [SerializeField]
    private int _valeur;

    [SerializeField]
    private InfosPointage _infosPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



        void OnTriggerEnter(Collider other){


            if(other.CompareTag("Player")){ 

            _infosPoints.nbPoints += 1;
            _infosPoints.total = _infosPoints.nbPoints; //L'update de points total

            // _audioSource.clip = _sonGagnePoints;
           // _audioSource.Play();

             Destroy(gameObject);


    }
}
}
