using System.Collections.Generic;
using UnityEngine;

public class Soundtrack : MonoBehaviour {

    static public Soundtrack instance { get; private set; }

    [Range(0f, 1f)]
    public float volume;

    List<AudioSource> chords = new List<AudioSource>();
    List<AudioSource> playedChords = new List<AudioSource>();

    void Awake() {
        if (instance != null)
            Destroy(gameObject);
        else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        if (instance == this) {
            foreach (Transform child in transform) {
                chords.Add(child.GetComponent<AudioSource>());
                child.GetComponent<AudioSource>().volume = volume;
            }
        }
    }

    void Start() {
        PlayNewChord();
    }

    void Update() {
        if (ShouldPlayNewChord())
            PlayNewChord();
    }

    bool ShouldPlayNewChord() {
        return playedChords[0].time > 3f * playedChords[0].clip.length / 4f;
    }

    void PlayNewChord() {
        int nextChord = Random.Range(0, chords.Count);
        playedChords.Insert(0, chords[nextChord]);
        chords.RemoveAt(nextChord);
        playedChords[0].Play();

        if (chords.Count == 0)
            RetrieveChords();
    }

    void RetrieveChords() {
        while (playedChords.Count > 1) {
            chords.Add(playedChords[1]);
            playedChords.RemoveAt(1);
        }
    }
}
