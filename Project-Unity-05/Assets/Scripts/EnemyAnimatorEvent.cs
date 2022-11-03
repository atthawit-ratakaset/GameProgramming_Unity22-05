using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatorEvent : MonoBehaviour
{
    [SerializeField] private AudioPlayer audioPlayer;
    [SerializeField] private SoAudioClips walkEnemyAudioClips;

    public void PlayWalkEnemySound()
    {
        audioPlayer.PlaySound(walkEnemyAudioClips);
    }
    public void Walk()
    {
        PlayWalkEnemySound();
    }
}
