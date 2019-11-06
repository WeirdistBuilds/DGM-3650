using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTCChanger : MonoBehaviour
{
    public PatientObject MyPatient;
    public TimeObject InGameTime;
    public float TimeToStarving = 21600;
    public float TimeToDehydrated = 10800;
    public float TimeToDiscomfort = 16200;

    void Start()
    {
        MyPatient.HungerLevel = 0;
        MyPatient.ThirstLevel = 0;
        MyPatient.DiscomfortLevel = 0;
        MyPatient.TimeLastFood = 0;
        MyPatient.TimeLastWater = 0;
        MyPatient.TimeLastComfort = 0;
    }

    void Update()
    {
        HTCGrowth();
    }

    public void HTCGrowth()
    {
        if (MyPatient.HungerLevel >= 0)
        {
            MyPatient.HungerLevel = (100 * Mathf.Pow(10, (InGameTime.SecondsPassed - MyPatient.TimeLastFood) / TimeToStarving) - 100) / 9;
        }

        if (MyPatient.ThirstLevel >= 0)
        {
            MyPatient.ThirstLevel = (100 * Mathf.Pow(10, (InGameTime.SecondsPassed - MyPatient.TimeLastWater) / TimeToDehydrated) - 100) / 9;
        }

        if (MyPatient.DiscomfortLevel >= 0)
        {
            MyPatient.DiscomfortLevel = (100 * Mathf.Pow(10, (InGameTime.SecondsPassed - MyPatient.TimeLastComfort) / TimeToDiscomfort) - 100) / 9;
        }
    }
}
