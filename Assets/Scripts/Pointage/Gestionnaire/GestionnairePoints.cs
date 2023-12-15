using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionnairePoints : MonoBehaviour
{
    [Header("Scriptable Object")]


[SerializeField]
private InfosPointage _infosPoints;


[Space(10)]
[Header("Affichage Points")]
[SerializeField]
private TMP_Text _points;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AffichagePoints();
    }

   void AffichagePoints(){

        _points.text = _infosPoints.nbPoints.ToString();
        

        }
   }

