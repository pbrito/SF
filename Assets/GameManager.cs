using System.Collections;
using System.Collections.Generic;
using Pixelplacement;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class GameManager : Singleton<MonoBehaviour>
{
    // Start is called before the first frame update
    void Start()
    {
        Addressables.LoadSceneAsync("SceneA");


    }

    public void LoadSceneB()
    {
        
        Addressables.LoadSceneAsync("SceneB");
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
