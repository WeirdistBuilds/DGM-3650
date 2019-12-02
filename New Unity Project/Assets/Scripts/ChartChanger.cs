using UnityEngine;

public class ChartChanger : MonoBehaviour
{
    public ChartObject MyChart;
    public PatientObject MyPatient;
    public InfectionObject MyInfection;
    public TimeObject InGameTime;
    public float ChartInterval = 14400;
    public float NextChartTime;
    public int ChartNumber;

    void Start()
    {
        ClearCharts(MyChart);
        
        MyChart.Name = MyPatient.Name;
        MyChart.Age = Random.Range(MyInfection.AgeMin, MyInfection.AgeMax).ToString("00");
        MyChart.Weight = Random.Range(MyInfection.WeightMin, MyInfection.WeightMax).ToString("00");
        MyChart.Allergies = MyPatient.Allergies;
        MyChart.History = MyPatient.History;
        MyChart.HomeMeds = MyPatient.HomeMeds;
        MyChart.Notes = MyPatient.Notes;
    }

    void LateUpdate()
    {
        if (InGameTime.SecondsPassed > NextChartTime && MyChart.Charts[ChartNumber].TimeCharted == null)
        {
            Chart(ChartNumber);
            ChartNumber += 1;
            NextChartTime += ChartInterval;
        }
    }

    private void Chart(int i)
    {
        Debug.Log("Charting at position " + i);
        MyChart.Charts[i].TimeCharted = (InGameTime.Hour % 24).ToString("00") + (InGameTime.Minute % 60).ToString("00");
        MyChart.Charts[i].Temp = MyPatient.Temperature.ToString("0.0");
        MyChart.Charts[i].HR = MyPatient.HR.ToString("0");
        MyChart.Charts[i].RR = MyPatient.RR.ToString("0");
        MyChart.Charts[i].BPS = MyPatient.BPS.ToString("0");
        MyChart.Charts[i].BPD = MyPatient.BPD.ToString("0");
        MyChart.Charts[i].O2Sat = MyPatient.O2Sat.ToString("0") + "% on RA";
        MyChart.Charts[i].WBC = MyPatient.WBC.ToString("0");
        MyChart.Charts[i].Lactic = MyPatient.Lactic.ToString("0");
        MyChart.Charts[i].EWS = EWSCalc(MyPatient).ToString();
        MyChart.Charts[i].qSepsisScore = QSepsisCalc(MyPatient).ToString();
        Debug.Log("Next chart at position " + ChartNumber);
    }

    public void PlayerCharter()
    {
        if (MyChart.Charts[ChartNumber].TimeCharted == null)
        {
            Chart(ChartNumber);
            ChartNumber += 1;
        }
    }

    private void ClearCharts(ChartObject obj)
    {
        for(int i = 0; i < obj.Charts.Length; i++)
        {
            obj.Charts[i].TimeCharted = null;
            obj.Charts[i].Temp = null;
            obj.Charts[i].HR = null;
            obj.Charts[i].RR = null;
            obj.Charts[i].BPS = null;
            obj.Charts[i].BPD = null;
            obj.Charts[i].O2Sat = null;
            obj.Charts[i].WBC = null;
            obj.Charts[i].Lactic = null;
        }
        ChartNumber = 0;
        NextChartTime = 0;
    }

    private int EWSCalc(PatientObject MyPatient)
    {
        int calc = 0;
        //calculation here
        return calc;
    }
    
    private int QSepsisCalc(PatientObject MyPatient)
    {
        int calc = 0;
        
        if (MyPatient.RR >= 22)
        {
            calc++;
        }

        if (MyPatient.BPS <= 100)
        {
            calc++;
        }

        if (MyPatient.InfectionCurrent <= 50)
        {
            calc++;
        }
        
        return calc;
    }
    
}
