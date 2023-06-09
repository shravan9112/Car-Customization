using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Material bodyColour;
    public TextMeshProUGUI baseText, tireText, bullText, totalText;
    public GameObject[] wheels,bullbars;
    public GameObject[] wheels2,bullbars2;
    public GameObject[] cars;
    public GameObject tireUI, barUI,mainUI;
    private int wheel,bull;
    public int number;
    private int cost,basecost,tirecost,barcost;
    private int tirecost2, barcost2, basecost2;
    private bool tires, bars;

    void Start()
    {
        wheel = bull =0;
        barcost = tirecost = tirecost2 = barcost2=100;
        tires = bars = false;
        if(number ==0)
        {
            wheels[0].SetActive(true);
            bullbars[0].SetActive(true);
            cars[0].SetActive(true);
            basecost = 1000;
        }
        else
        {
            wheels2[0].SetActive(true);
            bullbars2[0].SetActive(true);
            cars[1].SetActive(true);
            basecost2 = 2000;
        }
        UpdateCost();
    }

    void Update()
    {
        if(number ==0)
        {
            baseText.text = basecost.ToString();
            tireText.text = tirecost.ToString();
            bullText.text = barcost.ToString();
            totalText.text = cost.ToString();
        }
        else
        {
            baseText.text = basecost2.ToString();
            tireText.text = tirecost2.ToString();
            bullText.text = barcost2.ToString();
            totalText.text = cost.ToString();
        }
    }

    private void UpdateCost()
    {
        if(number ==0)
        {
            cost = basecost + tirecost + barcost;
        }
        else
        {
            cost = basecost2 + tirecost2 + barcost2;
        }
    }
    public void ChangeColour(Color C)
    {
        bodyColour.color = C;
    }

    public void ChangeCar()
    {
        cars[number].SetActive(false);
        number = number+1;
        if (number == 2)
            number = 0;
        cars[number].SetActive(true);
        if(number == 0)
        {
            basecost = 1000;
        }
        else
        {
            basecost2 = 2000;
        }
        UpdateCost();
    }

    public void ChangeWheels(int i)
    {
        if(number == 0)
        {
            wheels[wheel].SetActive(false);
            wheels[i].SetActive(true);
            wheel = i;
        }
        else
        {
            wheels2[wheel].SetActive(false);
            wheels2[i].SetActive(true);
            wheel = i;
        }    
    }

    public void ChangeBars(int i)
    {
        if(number == 0)
        {
            bullbars[bull].SetActive(false);
            bullbars[i].SetActive(true);
            bull = i;
        }
        else
        {
            bullbars2[bull].SetActive(false);
            bullbars2[i].SetActive(true);
            bull = i;
        }
    }

    public void TireMenu()
    {
        if(tires)
        {
            tireUI.SetActive(false);
            mainUI.SetActive(true);
            tires = false;
        }
        else
        {
            mainUI.SetActive(false);
            tireUI.SetActive(true);
            tires = true;
        }
    }

    public void BarMenu()
    {
        if (bars)
        {
            barUI.SetActive(false);
            mainUI.SetActive(true);
            bars = false;
        }
        else
        {
            mainUI.SetActive(false);
            barUI.SetActive(true);
            bars = true;
        }
    }

    public void W0()
    {
        ChangeWheels(0);
        if(number ==0)
        {
            tirecost = 100;
        }
        else
            tirecost2 = 100;
        UpdateCost();
    }
    public void W1()
    {
        ChangeWheels(1);
        if (number == 0)
        {
            tirecost = 200;
        }
        else
            tirecost2 = 200;
        UpdateCost();
    }
    public void W2()
    {
        ChangeWheels(2);
        if (number == 0)
        {
            tirecost = 300;
        }
        else
            tirecost2 = 300;
        UpdateCost();
    }
    public void B0()
    {
        ChangeBars(0);
        if (number == 0)
        {
            barcost = 100;
        }
        else
            barcost2 = 100;
        UpdateCost();
    }
    public void B1()
    {
        ChangeBars(1);
        if (number == 0)
        {
            barcost = 200;
        }
        else
            barcost2 = 200;
        UpdateCost();
    }
    public void B2()
    {
        ChangeBars(2);
        if (number == 0)
        {
            barcost = 300;
        }
        else
            barcost2 = 300;
        UpdateCost();
    }
}
