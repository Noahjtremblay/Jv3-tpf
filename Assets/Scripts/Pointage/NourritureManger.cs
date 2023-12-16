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



        void OnCollisionEnter(Collision other){


            if(other.transform.tag == "Player"){ 

            _infosPoints.nbPoints += 1;
            

            // _audioSource.clip = _sonGagnePoints;
           // _audioSource.Play();

             Destroy(gameObject);


    }
}
}
