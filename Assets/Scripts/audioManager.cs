using UnityEngine;

public class audioManager : MonoBehaviour
{ 
    public AudioClip[] playlist;
    public AudioSource audioSource;
    private int musicIndex = 0;

    public
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = playlist[0];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            PlayNextSong();
        }
    }

    void PlayNextSong(){
        musicIndex = (musicIndex + 1) % playlist.Length;
        audioSource.clip = playlist[musicIndex];
        audioSource.Play();
    }
}
