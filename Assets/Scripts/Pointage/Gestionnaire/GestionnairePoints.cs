using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionnairePoints : MonoBehaviour
{

    [Space(10)]
[Header("Affichage Points")]
[SerializeField]
private TMP_Text _points;


[SerializeField]
private TMP_Text _pointsTotal;


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

        _points.text = _joueur.nbPoints.ToString();
        _pointsNegatifs.text = _joueur.nbPointsNeg.ToString();
        _pointsTotal.text = _joueur.total.ToString();

        if(_joueur.total >= _niveau.nbPointsAFaire){

            _gestionScenes.SceneCredit();


        }
   }
}
