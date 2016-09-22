using UnityEngine;
using System.Collections;

public class InnerVoice : MonoBehaviour {

    public AudioClip whatHappend;
    public AudioClip goodLandingArea;

    private AudioSource audioSource;
	void Start () {
        audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = whatHappend;
        audioSource.Play();
	}
	
    void OnFindClearArea()
    {
        print(this.name + "  found clear area");
        audioSource.clip = goodLandingArea;
        audioSource.Play();
        Invoke("CallHeli",goodLandingArea.length + 1f);
    }
    void CallHeli()
    {
        SendMessageUpwards("OnMakeInitalHeliCall");
    }
}
