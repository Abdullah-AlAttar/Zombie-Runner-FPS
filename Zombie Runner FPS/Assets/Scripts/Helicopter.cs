using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {
    public AudioClip callSound;
    private bool called = false;
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("CallHeli") && ! called)
        {
            this.GetComponent<AudioSource>().clip = callSound;
            this.GetComponent<AudioSource>().Play();
        }
    }
}
