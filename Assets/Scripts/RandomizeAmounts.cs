using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomizeAmounts : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI payed;
    [SerializeField] private TextMeshProUGUI price;
    [SerializeField] private TextMeshProUGUI currentMoney;
    [SerializeField] private TMP_InputField result;
    // Start is called before the first frame update
    private int[] numbers = { 20, 50, 100, 200, 500 };

    private void Start()
    {
        int randomIndex = Random.Range(0, 4);

        int payedAmount = numbers[randomIndex];
        int priceAmount = Random.Range(0, payedAmount);

        payed.text = "" + payedAmount;
        price.text = "" + priceAmount;
    }
    public void Check()
    {

        int randomIndex = Random.Range(0, 4);

        int payedAmount = numbers[randomIndex];
        int priceAmount = Random.Range(0, payedAmount);

        Debug.Log(int.Parse(result.text));

        if (int.Parse(payed.text) - int.Parse(price.text) == int.Parse(result.text))
        {
            payed.text = "" + payedAmount;
            price.text = "" + priceAmount;
            currentMoney.text = "Money: " + ++GameControl.control.money + GameControl.control.levelOfEarning;
        }

    }
}
