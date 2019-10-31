using UnityEngine;

public class HTCReducer : MonoBehaviour
{
    public PatientObject MyPatient;
    public TimeObject InGameTime;

    public void DoHungerReduced()
    {
        MyPatient.TimeLastFood = InGameTime.SecondsPassed;
    }

    public void DoThirstReduced()
    {
        MyPatient.TimeLastWater = InGameTime.SecondsPassed;
    }

    public void DoDiscomfortReduced()
    {
        MyPatient.TimeLastComfort = InGameTime.SecondsPassed;
    }
}