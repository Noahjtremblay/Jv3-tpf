using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EveGestionnaireAudio : MonoBehaviour
{

[SerializeField] private AudioMixer _audioMixer;

   public void AjusterVolumeMusique(float volume){


    _audioMixer.SetFloat("VolumeMusique", volume);

   }

   public void AjusterVolumeEffets(float volume){

    _audioMixer.SetFloat("VolumeEffets", volume);
   }
   
}