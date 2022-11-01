using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] private AudioPlayer audioPlayer;
    
    [Header("Audio Clips")]
    [SerializeField] private SoAudioClips walkAudioClips;
    [SerializeField] private SoAudioClips damageHazardAudioClips;
    [SerializeField] private SoAudioClips deathAudioClips;
    [SerializeField] private SoAudioClips damageEnemyAudioClips;

    public void PlayWalk()
    {
        audioPlayer.PlaySound(walkAudioClips, 0.3f);
    }
    public void PlayDeath()
    {
        audioPlayer.PlaySound(deathAudioClips, 0.9f);
    }
    public void PlayDamageHazard()
    {
        audioPlayer.PlaySound(damageHazardAudioClips, 0.4f);
    }
    public void PlayDamageEnemy()
    {
        audioPlayer.PlaySound(damageEnemyAudioClips, 0.4f);
    }
    public void MuteAudioSource()
    {
        audioPlayer.MuteAudioSource();
    }
}
