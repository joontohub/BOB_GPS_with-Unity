using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class GPSManager : MonoBehaviour
{
    
    public InputField NameInput;
    public InputField AgeInput;
    public InputField SexInput;
    public InputField PhoneInput;
    public Button SendButton;
    // Start is called before the first frame update
    public static string NameData;
    public static string AgeData;
    public static string SexData;
    public static string PhoneData;
    void Start()
    {
        StartCoroutine("test");
    }

    IEnumerator test()
    {
        yield return new WaitForSeconds(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveData()
    {
        NameData = NameInput.text;
        AgeData = AgeInput.text;
        SexData = SexInput.text;
        PhoneData = PhoneInput.text;

        Debug.Log(NameData);
        Debug.Log(AgeData);
        Debug.Log(SexData);
        Debug.Log(PhoneData);
    }
    public void CheckGPSConnect()
    {
        // if(!Input.location.isEnabledByUser)
        // {
        //     Debug.Log("User has not enable GPS");
        // }
    }
    public void ConnectToGPS()
    {
        StartCoroutine(ConnectGPSCO());
    }
    IEnumerator ConnectGPSCO()
    {
        yield return new WaitForSeconds(1);
    }
}
