using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButtons : MonoBehaviour
{
    AudioSource voiceAudio;

    // Start is called before the first frame update
    void Start()
    {
        voiceAudio = this.GetComponent<AudioSource>();
        voiceAudio.Stop();
    }

    /// - Sound Buttons - ///
    public void SoundButton_Play()
    {
        voiceAudio.Play();
    }
}
