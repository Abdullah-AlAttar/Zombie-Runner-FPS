using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class Helicopter : MonoBehaviour
{
    private bool isCalled = false;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();

    }

    public void OnDispatchHelicopter()
    {
        Debug.Log("HIHI");
        rigidBody.velocity = new Vector3(0,0,50f);
        isCalled= true;
    }
}
