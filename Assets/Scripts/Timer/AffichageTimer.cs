using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class AffichageTimer : MonoBehaviour
{
     [SerializeField] private InfosTimer _infosTimer;
  [SerializeField] private TMP_Text _champTexteTemps;

    public void AfficherTemps()
    {
      float temps = _infosTimer.temps;

      if(temps < 0)
      {
         temps = 0;
      }

      //Convertir le temps en secondes
      TimeSpan ts = TimeSpan.FromSeconds(temps);

      _champTexteTemps.text = string.Format("{0:00}:{1:00}:{2:00}:{3:000}",ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
    }
}
