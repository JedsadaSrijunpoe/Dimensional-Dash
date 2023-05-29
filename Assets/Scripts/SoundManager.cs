using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region Singleton Stuff
    static SoundManager instance;
    public static SoundManager Instance { get { return instance; } }

    protected virtual void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
    #endregion

    public AudioSource[] EffectsSources;
    public AudioSource MusicSource;

    public void Play(AudioClip clip)
    {
        foreach (var EffectsSource in EffectsSources)
        {
            if (!EffectsSource.isPlaying)
            {
                EffectsSource.clip = clip;
                EffectsSource.Play();
                break;
            }
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        MusicSource.clip = clip;
        MusicSource.Play();
    }
}
