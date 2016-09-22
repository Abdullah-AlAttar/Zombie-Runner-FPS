using UnityEngine;
using System.Collections;

public class ClearArea : MonoBehaviour {
    public float timeSinceLastTrigger = 0f;

    private bool foundClearArea = false;
    void Update()
    {
        timeSinceLastTrigger += Time.deltaTime;
        if(timeSinceLastTrigger>2f&&Time.realtimeSinceStartup>20f&&!foundClearArea)
        {
            Debug.Log("SENDING MASSAGE");
            SendMessageUpwards("OnFindClearArea");
            foundClearArea = true;
        }
    }
	void OnTriggerStay(Collider other)
    {
        if(other.tag!="Player")
        timeSinceLastTrigger = 0f;
    }
}
