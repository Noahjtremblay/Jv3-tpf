using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "InfosPointage", menuName = "SO/NiveauPoints")]
public class InfosPointage : ScriptableObject
{
   [SerializeField] 
public bool poubelle;

    public int nbPoints;
    
    public int total;

}
