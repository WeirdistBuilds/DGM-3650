using UnityEngine;

public class ChartChanger : MonoBehaviour
{
    public ChartObject MyChart;
    public PatientObject MyPatient;
    public InfectionObject MyInfection;
    public TimeObject InGameTime;
    public float ChartInterval = 14400;
    public float NextChartTime = 0;
    public int ChartNumber = 0;
    public bool PlayerCanChart;
    public bool CanAutoChart;

    void Start()
    {
        ClearCharts(MyChart);
        
        // MyChart.Charts[ChartNumber] = ScriptableObject.CreateInstance<ChartTimeObject>() as ChartTimeObject;
        MyChart.Name = MyPatient.Name;
        MyChart.Age = MyPatient.Age.ToString();
        MyChart.Weight = MyPatient.Weight.ToString();
        MyChart.Allergies = MyPatient.Allergies;
        MyChart.History = MyPatient.History;
        MyChart.HomeMeds = MyPatient.HomeMeds;
        MyChart.Notes = MyPatient.Notes;

        //MyChart.Charts[ChartNumber].TimeCharted = (InGameTime.Hour % 24).ToString("00") + (InGameTime.Minute % 60).ToString("00");
        MyChart.Charts[ChartNumber].TimeCharted = "0700";
        MyChart.Charts[ChartNumber].Temp = MyInfection.TempStart.ToString("0.0");
        MyChart.Charts[ChartNumber].HR = MyInfection.HRStart.ToString("0");
        MyChart.Charts[ChartNumber].RR = MyInfection.RRStart.ToString("0");
        MyChart.Charts[ChartNumber].BPS = MyInfection.BPSStart.ToString("0");
        MyChart.Charts[ChartNumber].BPD = MyInfection.BPDStart.ToString("0");
        MyChart.Charts[ChartNumber].O2Sat = MyInfection.O2SatStart.ToString("0") + "% on RA";
        MyChart.Charts[ChartNumber].WBC = MyInfection.WBCStart.ToString("0");
        MyChart.Charts[ChartNumber].Lactic = MyInfection.LacticStart.ToString("0");
        NextChartTime = ChartInterval;
        PlayerCanChart = true;
        CanAutoChart = true;
    }

    void Update()
    {
        if (InGameTime.SecondsPassed > NextChartTime && CanAutoChart)
        {
            CanAutoChart = false;
            Chart();
            ChartNumber += 1;
            Debug.Log("Charting " + ChartNumber.ToString() + " at " + InGameTime.SecondsPassed.ToString());
            NextChartTime += ChartInterval;
            Debug.Log("Next auto chart is index " + ChartNumber.ToString() + " at " + NextChartTime.ToString());
            PlayerCanChart = true;
        }
        else 
        {
            CanAutoChart = true;
        }
    }

    public void Chart()
    {
        MyChart.Charts[ChartNumber].TimeCharted = (InGameTime.Hour % 24).ToString("00") + (InGameTime.Minute % 60).ToString("00");
        MyChart.Charts[ChartNumber].Temp = MyPatient.Temperature.ToString("0.0");
        MyChart.Charts[ChartNumber].HR = MyPatient.HR.ToString("0");
        MyChart.Charts[ChartNumber].RR = MyPatient.RR.ToString("0");
        MyChart.Charts[ChartNumber].BPS = MyPatient.BPS.ToString("0");
        MyChart.Charts[ChartNumber].BPD = MyPatient.BPD.ToString("0");
        MyChart.Charts[ChartNumber].O2Sat = MyPatient.O2Sat.ToString("0") + "% on RA";
        MyChart.Charts[ChartNumber].WBC = MyPatient.WBC.ToString("0");
        MyChart.Charts[ChartNumber].Lactic = MyPatient.Lactic.ToString("0");
    }

    public void PlayerCharter()
    {
        if (PlayerCanChart)
        {
            CanAutoChart = false;
            ChartNumber += 1;
            Debug.Log("Charting " + ChartNumber.ToString() + " at " + InGameTime.SecondsPassed.ToString());
            Debug.Log("Next auto chart is index " + ChartNumber.ToString() + " at " + NextChartTime.ToString());
            Chart();
            PlayerCanChart = false;
        }
        CanAutoChart = true;
    }

    public void ClearCharts(ChartObject obj)
    {
        Debug.Log("Clear Chart");
        for(int i = 0; i < obj.Charts.Length; i++)
        {
            obj.Charts[i].TimeCharted = "";
            obj.Charts[i].Temp = "";
            obj.Charts[i].HR = "";
            obj.Charts[i].RR = "";
            obj.Charts[i].BPS = "";
            obj.Charts[i].BPD = "";
            obj.Charts[i].O2Sat = "";
            obj.Charts[i].WBC = "";
            obj.Charts[i].Lactic = "";
        }
        ChartNumber = 0;
    }
}
