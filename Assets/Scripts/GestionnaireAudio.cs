using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{
    public AudioMixer _audioMixer;

    public void VolumeAmbiance(Slider volume){
        _audioMixer.SetFloat("Ambiance", volume.value);
    }
}
