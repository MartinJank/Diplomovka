using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckButtonValue : MonoBehaviour
{    
    [SerializeField] private TextMeshProUGUI btn1;
    [SerializeField] private TextMeshProUGUI btn2;
    [SerializeField] private TextMeshProUGUI btn3;
    [SerializeField] private TextMeshProUGUI payed;
    [SerializeField] private TextMeshProUGUI price;
    [SerializeField] private TextMeshProUGUI currentMoney;
    [SerializeField] private TextMeshProUGUI result;
    private int[] numbers = { 20, 50, 100, 200, 500 };

    public void Check()
    {

        int randomIndex = Random.Range(0, 4);

        int payedAmount = numbers[randomIndex];
        int priceAmount = Random.Range(0, payedAmount);

        if (int.Parse(payed.text) - int.Parse(price.text) == int.Parse(result.text))
        {
            payed.text = "" + payedAmount;
            price.text = "" + priceAmount;
            GameControl.control.money += 2;
            GameControl.control.money += GameControl.control.levelOfEarning;
            currentMoney.text = "Money: " + GameControl.control.money;

            btn1.text = "" + Random.Range(0, int.Parse(payed.text));
            btn2.text = "" + Random.Range(0, int.Parse(payed.text));
            btn3.text = "" + Random.Range(0, int.Parse(payed.text));

            int randombtn = Random.Range(0, 2);
            if (randombtn == 0)
            {
                btn1.text = "" + (int.Parse(payed.text) - int.Parse(price.text));
            }
            if (randombtn == 1)
            {
                btn2.text = "" + (int.Parse(payed.text) - int.Parse(price.text));
            }
            if (randombtn == 2)
            {
                btn3.text = "" + (int.Parse(payed.text) - int.Parse(price.text));
            }

        } 
        else
        {
            payed.text = "" + payedAmount;
            price.text = "" + priceAmount;
            --GameControl.control.money;
            currentMoney.text = "Money: " + GameControl.control.money;

            btn1.text = "" + Random.Range(0, int.Parse(payed.text));
            btn2.text = "" + Random.Range(0, int.Parse(payed.text));
            btn3.text = "" + Random.Range(0, int.Parse(payed.text));

            int randombtn = Random.Range(0, 2);
            if (randombtn == 0)
            {
                btn1.text = "" + (int.Parse(payed.text) - int.Parse(price.text));
            }
            if (randombtn == 1)
            {
                btn2.text = "" + (int.Parse(payed.text) - int.Parse(price.text));
            }
            if (randombtn == 2)
            {
                btn3.text = "" + (int.Parse(payed.text) - int.Parse(price.text));
            }
        }

    }
}
