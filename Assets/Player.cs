using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public Button PlayArea1;
    public Text text1;

    public Button PlayArea2;
    public Text text2;

    public Button PlayArea3;
    public Text text3;

    public Button PlayArea4;
    public Text text4;

    public Button PlayArea5;
    public Text text5;

    public Button PlayArea6;
    public Text text6;

    public Button PlayArea7;
    public Text text7;

    public Button PlayArea8;
    public Text text8;

    public Button PlayArea9;
    public Text text9;

    public Button ResetBtn;
    public GameObject ResetObj;

    public Text xScoreTxt;
    public int xScore;
    public Text oScoreTxt;
    public int oScore;

    public GameObject x123;
    public GameObject x159;
    public GameObject x147;
    public GameObject x258;
    public GameObject x369;
    public GameObject x357;
    public GameObject x456;
    public GameObject x789;

    public GameObject o123;
    public GameObject o159;
    public GameObject o147;
    public GameObject o258;
    public GameObject o369;
    public GameObject o357;
    public GameObject o456;
    public GameObject o789;

    public static bool gameOver;

    public bool isXTurn;
	// Use this for initialization
	void Start () {
        isXTurn = true;
        gameOver = false;
        xScore = 0;
        oScore = 0;
    }
	
	// Update is called once per frame
	void Update () {

        xScoreTxt.text = "" + xScore;
        oScoreTxt.text = "" + oScore;

        //No Winner
        if(text1.text != "" && text2.text != "" && text3.text != "" && text4.text != "" && text5.text != "" &&
            text6.text != "" && text7.text != "" && text8.text != "" && text9.text != "")
        {
            ResetObj.SetActive(true);
        }

        //X WIN
        if (text1.text=="X" && text2.text=="X" && text3.text=="X")
        {
            ResetObj.SetActive(true);
            x123.gameObject.SetActive(true);
            XScored();
            gameOver = true;
        }
        if (text1.text == "X" && text5.text == "X" && text9.text == "X")
        {
            ResetObj.SetActive(true);
            x159.gameObject.SetActive(true);
            XScored();
            gameOver = true;
        }
        if (text1.text == "X" && text4.text == "X" && text7.text == "X")
        {
            ResetObj.SetActive(true);
            x147.gameObject.SetActive(true);
            XScored();
            gameOver = true;
        }
        if (text2.text == "X" && text5.text == "X" && text8.text == "X")
        {
            ResetObj.SetActive(true);
            x258.gameObject.SetActive(true);
            XScored();
            gameOver = true;
        }
        if (text3.text == "X" && text6.text == "X" && text9.text == "X")
        {
            ResetObj.SetActive(true);
            x369.gameObject.SetActive(true);
            XScored();
            gameOver = true;
        }
        if (text3.text == "X" && text5.text == "X" && text7.text == "X")
        {
            ResetObj.SetActive(true);
            x357.gameObject.SetActive(true);
            XScored();
            gameOver = true;
        }
        if (text4.text == "X" && text5.text == "X" && text6.text == "X")
        {
            ResetObj.SetActive(true);
            x456.gameObject.SetActive(true);
            XScored();
            gameOver = true;
        }
        if (text7.text == "X" && text8.text == "X" && text9.text == "X")
        {
            ResetObj.SetActive(true);
            x789.gameObject.SetActive(true);
            XScored();
            gameOver = true;
        }

        //O WIN
        if (text1.text == "O" && text2.text == "O" && text3.text == "O")
        {
            ResetObj.SetActive(true);
            o123.gameObject.SetActive(true);
            OScored();
            gameOver = true;
        }
        if (text1.text == "O" && text5.text == "O" && text9.text == "O")
        {
            ResetObj.SetActive(true);
            o159.gameObject.SetActive(true);
            OScored();
            gameOver = true;
        }
        if (text1.text == "O" && text4.text == "O" && text7.text == "O")
        {
            ResetObj.SetActive(true);
            o147.gameObject.SetActive(true);
            OScored();
            gameOver = true;
        }
        if (text2.text == "O" && text5.text == "O" && text8.text == "O")
        {
            ResetObj.SetActive(true);
            o258.gameObject.SetActive(true);
            OScored();
            gameOver = true;
        }
        if (text3.text == "O" && text6.text == "O" && text9.text == "O")
        {
            ResetObj.SetActive(true);
            o369.gameObject.SetActive(true);
            OScored();
            gameOver = true;
        }
        if (text3.text == "O" && text5.text == "O" && text7.text == "O")
        {
            ResetObj.SetActive(true);
            o357.gameObject.SetActive(true);
            OScored();
            gameOver = true;
        }
        if (text4.text == "O" && text5.text == "O" && text6.text == "O")
        {
            ResetObj.SetActive(true);
            o456.gameObject.SetActive(true);
            OScored();
            gameOver = true;
        }
        if (text7.text == "O" && text8.text == "O" && text9.text == "O")
        {
            ResetObj.SetActive(true);
            o789.gameObject.SetActive(true);
            OScored();
            gameOver = true;
        }
    }

    public void XScored()
    {
        if (gameOver == false)
        {
            xScoreTxt.text = "" + xScore++;
        }
    }
    public void OScored()
    {
        if (gameOver == false)
        {
            oScoreTxt.text = "" + oScore++;
        }
    }

    public void Play1()
    {
        if (text1.text=="" && gameOver==false)
        {
            if (isXTurn == true)
            {
                text1.color = new Color(62f/255f, 1f, 0f);
                text1.text = "X";
                isXTurn = false;
            }
            else
            {
                text1.color = new Color(1f, 132f / 255f, 0f);
                text1.text = "O";
                isXTurn = true;
            }
        }
    }

    public void Play2()
    {
        if (text2.text == "" && gameOver == false)
        {
            if (isXTurn == true)
            {
                text2.color = new Color(62f / 255f, 1f, 0f);
                text2.text = "X";
                isXTurn = false;
            }
            else
            {
                text2.color = new Color(1f, 132f / 255f, 0f);
                text2.text = "O";
                isXTurn = true;
            }
        }
    }

    public void Play3()
    {
        if (text3.text == "" && gameOver == false)
        {
            if (isXTurn == true)
            {
                text3.color = new Color(62f / 255f, 1f, 0f);
                text3.text = "X";
                isXTurn = false;
            }
            else
            {
                text3.color = new Color(1f, 132f / 255f, 0f);
                text3.text = "O";
                isXTurn = true;
            }
        }
    }

    public void Play4()
    {
        if (text4.text == "" && gameOver == false)
        {
            if (isXTurn == true)
            {
                text4.color = new Color(62f / 255f, 1f, 0f);
                text4.text = "X";
                isXTurn = false;
            }
            else
            {
                text4.color = new Color(1f, 132f / 255f, 0f);
                text4.text = "O";
                isXTurn = true;
            }
        }
    }

    public void Play5()
    {
        if (text5.text == "" && gameOver == false)
        {
            if (isXTurn == true)
            {
                text5.color = new Color(62f / 255f, 1f, 0f);
                text5.text = "X";
                isXTurn = false;
            }
            else
            {
                text5.color = new Color(1f, 132f / 255f, 0f);
                text5.text = "O";
                isXTurn = true;
            }
        }
    }

    public void Play6()
    {
        if (text6.text == "" && gameOver == false)
        {
            if (isXTurn == true)
            {
                text6.color = new Color(62f / 255f, 1f, 0f);
                text6.text = "X";
                isXTurn = false;
            }
            else
            {
                text6.color = new Color(1f, 132f / 255f, 0f);
                text6.text = "O";
                isXTurn = true;
            }
        }
    }

    public void Play7()
    {
        if (text7.text == "" && gameOver == false)
        {
            if (isXTurn == true)
            {
                text7.color = new Color(62f / 255f, 1f, 0f);
                text7.text = "X";
                isXTurn = false;
            }
            else
            {
                text7.color = new Color(1f, 132f / 255f, 0f);
                text7.text = "O";
                isXTurn = true;
            }
        }
    }

    public void Play8()
    {
        if (text8.text == "" && gameOver == false)
        {
            if (isXTurn == true)
            {
                text8.color = new Color(62f / 255f, 1f, 0f);
                text8.text = "X";
                isXTurn = false;
            }
            else
            {
                text8.color = new Color(1f, 132f/255f, 0f);
                text8.text = "O";
                isXTurn = true;
            }
        }
    }

    public void Play9()
    {
        if (text9.text == "" && gameOver == false)
        { 
            if (isXTurn == true)
            {
                text9.color = new Color(62f / 255f, 1f, 0f);
                text9.text = "X";
                isXTurn = false;
            }
            else
            {
                text9.color = new Color(1f, 132f/255f, 0f);
                text9.text = "O";
                isXTurn = true;
            }
        }
    }

    public void Reset()
    {
        ResetObj.SetActive(false);
        isXTurn = true;
        gameOver = false;

        text1.text = "";
        text2.text = "";
        text3.text = "";
        text4.text = "";
        text5.text = "";
        text6.text = "";
        text7.text = "";
        text8.text = "";
        text9.text = "";

        x123.gameObject.SetActive(false);
        x159.gameObject.SetActive(false);
        x147.gameObject.SetActive(false);
        x258.gameObject.SetActive(false);
        x369.gameObject.SetActive(false);
        x357.gameObject.SetActive(false);
        x456.gameObject.SetActive(false);
        x789.gameObject.SetActive(false);

        o123.gameObject.SetActive(false);
        o159.gameObject.SetActive(false);
        o147.gameObject.SetActive(false);
        o258.gameObject.SetActive(false);
        o369.gameObject.SetActive(false);
        o357.gameObject.SetActive(false);
        o456.gameObject.SetActive(false);
        o789.gameObject.SetActive(false);
    }
}
