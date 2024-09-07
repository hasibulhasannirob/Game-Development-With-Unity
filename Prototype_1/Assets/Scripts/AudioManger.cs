using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class AudioManger : MonoBehaviour
{
    public Sounds[] sound;

    void Awake() // Use Awake instead of Start
    {
        foreach (Sounds s in sound)
        {
            if (s.source == null)
            {
                s.source = gameObject.AddComponent<AudioSource>();
            }
            s.source.loop = s.loop;
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.playOnAwake = false;
            s.source.spatialBlend = 1f; // Adjust for 3D/2D sound
        }
    }

    public void PlaySound (string name)
    {
        foreach(Sounds s in sound)
        {
            if (s.name == name)
            {
                
                s.source.Play();
            }
        }
    }

    
}
