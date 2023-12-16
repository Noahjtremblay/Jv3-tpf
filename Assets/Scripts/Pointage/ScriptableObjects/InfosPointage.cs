using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "InfosPointage", menuName = "ScriptableObjects/NiveauPoints")]
public class InfosPointage : ScriptableObject
{
    

    public int nbPoints;
    


     public void ResetPoints(){

       nbPoints = 0;
    
        

    }



}
