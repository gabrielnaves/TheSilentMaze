using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ShuffledAudioClips : MonoBehaviour {

    public bool playOnAwake;
    public bool loop;
    public AudioClip[] clips;

    [ViewOnly] bool playing;

    AudioSource source;

    void Awake() {
        source = GetComponent<AudioSource>();
        if (playOnAwake)
            Play(loop);
    }

    public void Play(bool loop = false) {
        this.loop = loop;
        source.Stop();
        source.clip = clips[Random.Range(0, clips.Length)];
        source.Play();
        playing = true;
    }

    void Update() {
        if (playing && !source.isPlaying) {
            if (loop) Play(loop);
            else playing = false;
        }
    }
}
