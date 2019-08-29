using System.Collections;
using System.Collections.Generic;
using ScriptableFramework;
using UnityEngine;

public class RaiserAppEvent : MonoBehaviour
{

    public AppEvent appEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void raise()
    {
    appEvent.RaiseEvent();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
