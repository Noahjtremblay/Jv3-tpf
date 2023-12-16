using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetsPoubelle : MonoBehaviour
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
        
        if(other.transform.tag == "Poubelle"){ 



       

        Destroy(gameObject); //détruit le déchet pour qu'il ne soit plus visible dans l'environnement


        }

    }
}
