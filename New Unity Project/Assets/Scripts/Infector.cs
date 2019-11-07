using UnityEngine;

public class Infector : MonoBehaviour
{
    public PatientObject MyPatient;
    public InfectionObject MyInfection;
    public TimeObject InGameTime;
    public float SecondsAtCure;
    public float HealSubtract;
    public float ModifiedCureSecond;
    public bool BeenCured;

    void Start()
    {
        MyPatient.InfectionCurrent = 0;
        BeenCured = false;
    }
    
    void Update()
    {
        InfectionGrowth();
    }

    private void InfectionGrowth()
    {
        if (MyPatient.InfectionCurrent >= 0)
        {
            if (MyPatient.InfectionActive) // if the patient is still infected
            {
                if (MyPatient.InfectionCurrent < 100)
                {
                   // MyPatient.InfectionCurrent = ((100 * MyPatient.InfectionRate * Mathf.Pow(10, InGameTime.SecondsPassed / MyInfection.TimeToICU) - 100) / 9);  //exponential infection formula  
                   MyPatient.InfectionCurrent = (MyPatient.InfectionRate * (InGameTime.SecondsPassed / MyInfection.TimeToICU)) * 100; //linear infection formula
                }
                else
                {
                    MyPatient.InfectionCurrent = 100;
                }
            }
            else // if the patient has been cured
            {
                if(!BeenCured)
                {
                    SecondsAtCure = InGameTime.SecondsPassed;
                    BeenCured = true;
                }

                HealSubtract = (InGameTime.SecondsPassed - SecondsAtCure) * 2;
                ModifiedCureSecond = InGameTime.SecondsPassed - HealSubtract;
                
                if (MyPatient.InfectionCurrent > 0)
                {
                    // MyPatient.InfectionCurrent = (100 * Mathf.Pow(10, ModifiedCureSecond / MyInfection.TimeToICU) - 100) / 9; //reverse exponential infection formula
                    MyPatient.InfectionCurrent = (MyPatient.InfectionRate * (ModifiedCureSecond / MyInfection.TimeToICU)) * 100; //reverse linear infection formula
                }
                else
                {
                    MyPatient.InfectionCurrent = 0;
                }
            }
        }
    }
}