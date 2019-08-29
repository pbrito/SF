using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looger : MonoBehaviour
{
    
    public void Log(string s)
    {
        Debug.Log(s);
    }

    public void Log(float s)
    {
        Debug.Log(s.ToString());
    }

    public void Log(int  s)
    {
        Debug.Log(s.ToString());
    }

    public void LogError(string s)
    {
        Debug.LogError(s);
    }

    public void LogWarning(string s)
    {
        Debug.LogWarning(s);
    }
}
