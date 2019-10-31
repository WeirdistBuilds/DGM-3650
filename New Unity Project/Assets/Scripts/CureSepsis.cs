using UnityEngine;

public class CureSepsis : MonoBehaviour
{
    public PatientObject MyPatient;

    public void Cure()
    {
        MyPatient.InfectionActive = false;
    }
}
