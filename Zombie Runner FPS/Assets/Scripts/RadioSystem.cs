using UnityEngine;
using System.Collections;

public class RadioSystem : MonoBehaviour
{
    public AudioClip initialHeliCall;
    public AudioClip initialCallReplay;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }
    void OnMakeInitalHeliCall()
    {
        print(this.name + " INITIAL CALL MAID");
        audioSource.clip = initialHeliCall;
        audioSource.Play();
        Invoke("InitialReplay",initialHeliCall.length + 1f);
    }
    void InitialReplay()
    {
        print("replayed");
        audioSource.clip = initialCallReplay;
        audioSource.Play();
        BroadcastMessage("OnDispatchHelicopter");
    }

}
