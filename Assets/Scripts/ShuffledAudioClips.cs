using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ShuffledAudioClips : MonoBehaviour {

    public AudioClip[] clips;

    AudioSource source;

    void Awake() {
        source = GetComponent<AudioSource>();
    }

    public void Play() {
        source.Stop();
        source.clip = clips[Random.Range(0, clips.Length)];
        source.Play();
    }
}
