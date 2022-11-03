using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform destination;
    [SerializeField] private SoAudioClips teleporterAudioClips;
    [SerializeField] private AudioPlayer audioPlayer;

    public Transform GetDestination()
    {   
        audioPlayer.PlaySound(teleporterAudioClips);
        return destination;
    }
}
