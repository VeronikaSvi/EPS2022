using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputBlock : MonoBehaviour
{
    public UnityEvent onTouch;
    bool isCooldownActive = false;

    public Transform controller;

    MeshRenderer myMeshRenderer;

    public void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //ExampleAvatar == Name von Controllern in VRTK
        //if(other.name == "ExampleAvatar" && !isCooldownActive)
        if(other.transform == controller && !isCooldownActive)
        {
            onTouch.Invoke();
            StartCoroutine(disableCubeforSeconds(3));
        }
    }

    IEnumerator disableCubeforSeconds(float cooldown)
    {
        myMeshRenderer.enabled = isCooldownActive;
        isCooldownActive = true;
        yield return new WaitForSeconds(cooldown);
        myMeshRenderer.enabled = isCooldownActive;
        isCooldownActive = false;
    }
}
