using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Turn on the lamp");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TurnLightOn()
    {
        Debug.log("Turn the radio off");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
