using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayFlapToRestart : MonoBehaviour
{
    public GameObject flapToRestart;
    public float delay= 1f;
    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("EnableFlapToRestart",delay);
    }

    void EnableFlapToRestart(){
        flapToRestart.SetActive(true);
    }
}
