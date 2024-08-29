using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Implementing the interface means we have to call on the custom methods that were made in it!
public class SampleLampScript : MonoBehaviour, SampleIInteractable
{
    //This variable stores a GameObject
    public GameObject LightSource;

    //This is the contents of the custom method
    void SampleIInteractable.Interact()
    {
        //Calls the LightSwitch method when it is activated
        LightSwitch();
        print("TRIGGER FIRED!!!");
    }

    //Custom method created for light switching on and off
    void LightSwitch()
    {
        //if the light is not on
        if(LightSource.active == false)
        {
            //turn it on
            LightSource.SetActive(true);
        }
        else // else if it is on
        {
            //turn it off
            LightSource.SetActive(false);
        }
    }
}
