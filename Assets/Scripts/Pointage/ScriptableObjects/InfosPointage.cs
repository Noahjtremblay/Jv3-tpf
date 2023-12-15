using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "InfosPointage", menuName = "ScriptableObjects/NiveauPoints")]
public class InfosPointage : ScriptableObject
{
    public bool poubelle;

    public int nbPoints;
    
    public int total;


     public void ResetPoints(){

       nbPoints = 0;
    
         total = 0;

    }



}
