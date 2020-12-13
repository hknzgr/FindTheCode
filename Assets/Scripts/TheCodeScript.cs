using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheCodeScript : MonoBehaviour
{
    public Text Num1, Num2, Num3, Num4;
    public Text CorrectPlaceText;
    public Text CorrectDigitText;
    public Text LastTryText;
    public Text Number;
    public GameObject CongratsPanel;
    int CorrectPlace;
    int CorrectDigit;
    int TheNumber;
    int[] TheDigits = new int[4];

    void Start()
    {
        CreateNumber();
        Number.text = TheDigits[0].ToString() + TheDigits[1].ToString() + TheDigits[2].ToString() + TheDigits[3].ToString();
        
    }

    void CreateNumber()
    {
        for (int i = 0; i < 4; i++)
        {
            TheNumber = Random.Range(0, 9);
            if (TheDigits[0]!=TheNumber && TheDigits[1] != TheNumber && TheDigits[2] != TheNumber && TheDigits[3] != TheNumber)
            {
                TheDigits[i] = TheNumber;
            }
 
        }
    }
        

    public void Cyript()
    {
        CorrectDigit = 0;
        CorrectPlace = 0;
        if (Num1.text==TheDigits[0].ToString())
        {
            CorrectDigit++;
            CorrectPlace++;
        }else if (Num1.text == TheDigits[1].ToString() || Num1.text == TheDigits[2].ToString() || Num1.text == TheDigits[3].ToString())
        {
            CorrectDigit++;
        }

        if (Num2.text == TheDigits[1].ToString())
        {
            CorrectDigit++;
            CorrectPlace++;
        }
        else if (Num2.text == TheDigits[0].ToString() || Num2.text == TheDigits[2].ToString() || Num2.text == TheDigits[3].ToString())
        {
            CorrectDigit++;
        }

        if (Num3.text == TheDigits[2].ToString())
        {
            CorrectDigit++;
            CorrectPlace++;
        }
        else if (Num3.text == TheDigits[0].ToString() || Num3.text == TheDigits[1].ToString() || Num3.text == TheDigits[3].ToString())
        {
            CorrectDigit++;
        }

        if (Num4.text == TheDigits[3].ToString())
        {
            CorrectDigit++;
            CorrectPlace++;
        }
        else if (Num4.text == TheDigits[0].ToString() || Num4.text == TheDigits[1].ToString() || Num4.text == TheDigits[2].ToString())
        {
            CorrectDigit++;
        }

        CorrectDigitText.text = "Correct Digits: " + CorrectDigit.ToString();
        CorrectPlaceText.text = "Correct Places: " + CorrectPlace.ToString();
        LastTryText.text = "Last Try: " + Num1.text + Num2.text + Num3.text + Num4.text ;
        DigitButtonsScript.counter = 0;
        CodeControl();
    }

    
    void CodeControl()
    {
        if (CorrectDigit==4 && CorrectPlace==4)
        {
            CongratsPanel.SetActive(true);
            CongratsPanel.transform.GetChild(0).GetComponent<Text>().text = Number.text;
        }
    }

    public void NewCode()
    {
        DigitButtonsScript.counter = 0;
        Num1.text = "";
        Num2.text = "";
        Num3.text = "";
        Num4.text = "";
        CorrectDigitText.text = "";
        CorrectPlaceText.text = "";
        LastTryText.text = "";
        CongratsPanel.SetActive(false);
        Start();
    }

}
