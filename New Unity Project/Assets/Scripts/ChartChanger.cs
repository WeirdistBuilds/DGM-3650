using UnityEngine;

public class ChartChanger : MonoBehaviour
{
    public ChartObject MyChart;
    public PatientObject MyPatient;
    public InfectionObject MyInfection;
    public TimeObject InGameTime;
    public float ChartInterval = 14400;
    public float NextChartTime;
    public int ChartNumber = 0;
    public bool PlayerCanChart = false;

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
        Chart();
        ChartNumber += 1;
        NextChartTime = ChartInterval;
        PlayerCanChart = true;
    }

    void LateUpdate()
    {
        if(InGameTime.SecondsPassed > NextChartTime)
        {
            AutoCharter();
        }
    }

    public void Chart()
    {
        MyChart.Charts[ChartNumber].TimeCharted = (InGameTime.Hour % 24).ToString("00") + (InGameTime.Minute % 60).ToString("00");
        MyChart.Charts[ChartNumber].Temp = MyInfection.TempStart.ToString("0.0");
        MyChart.Charts[ChartNumber].HR = MyInfection.HRStart.ToString("0");
        MyChart.Charts[ChartNumber].RR = MyInfection.RRStart.ToString("0");
        MyChart.Charts[ChartNumber].BPS = MyInfection.BPSStart.ToString("0");
        MyChart.Charts[ChartNumber].BPD = MyInfection.BPDStart.ToString("0");
        MyChart.Charts[ChartNumber].O2Sat = MyInfection.O2SatStart.ToString("0") + "% on RA";
        MyChart.Charts[ChartNumber].WBC = MyInfection.WBCStart.ToString("0");
        MyChart.Charts[ChartNumber].Lactic = MyInfection.LacticStart.ToString("0");
    }

    public void AutoCharter()
    {
        Chart();
        NextChartTime += ChartInterval;
        ChartNumber += 1;
        PlayerCanChart = true;
    }

    public void PlayerCharter()
    {
        if (PlayerCanChart)
        {
            Chart();
            NextChartTime += ChartInterval;
            ChartNumber += 1;
            PlayerCanChart = false;
        }        
    }

    public void ClearCharts(ChartObject obj)
    {
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
    }
}
