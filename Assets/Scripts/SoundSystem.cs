using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    public static SoundSystem instance;

    private void Awake(){
        if (SoundSystem.instance==null){
            SoundSystem.instance=this;
        }else if (SoundSystem.instance!=this){
            Destroy(gameObject);
        }
    }


    private void OnDestroy(){
        if(SoundSystem.instance==this){
            SoundSystem.instance=null;
        }
    }
}
