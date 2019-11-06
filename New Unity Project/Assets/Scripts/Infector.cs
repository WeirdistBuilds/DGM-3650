using UnityEngine;

public class Infector : MonoBehaviour
{
    public PatientObject MyPatient;
    public TimeObject InGameTime;
    public float TimeToICU = 28800;
    public float SecondsAtCure;
    public float HealSubtract;
    public float ModifiedCureSecond;
    public bool beenHealed;

    void Start()
    {
        MyPatient.InfectionCurrent = 0;
    }
    
    void Update()
    {
        InfectionGrowth();
    }

    public void InfectionGrowth()
    {
        if (MyPatient.InfectionCurrent >= 0)
        {
            if (MyPatient.InfectionActive)
            {
                MyPatient.InfectionCurrent = ((100 * MyPatient.InfectionRate * Mathf.Pow(10, InGameTime.SecondsPassed / TimeToICU) - 100) / 9);
            }
            else
            {
                if(!beenHealed)
                {
                    SecondsAtCure = InGameTime.SecondsPassed;
                    beenHealed = true;
                }

                HealSubtract = (InGameTime.SecondsPassed - SecondsAtCure) * 2;
                ModifiedCureSecond = InGameTime.SecondsPassed - HealSubtract;


                MyPatient.InfectionCurrent = (100 * Mathf.Pow(10, ModifiedCureSecond / TimeToICU) - 100) / 9;
            }
        }
    }
}