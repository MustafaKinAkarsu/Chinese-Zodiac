using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
public class Keyboard : MonoBehaviour
{

    public TMP_InputField inputField;
    private List<int> inputPasswordList = new List<int>();
    public List<int> yearList = new List<int>();
    public Image animalImage;
    public Sprite[] animalImages;
    int addedval_;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void InsertChar(string c)
    {
        if(inputField.text.Length >= 4)
        {
            return;
        }
        inputField.text += c;
        Debug.Log(inputField.text);
    }
    
    public void DeleteChar()
    {
        if(inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }
    }
    public void Submit()
    {
        addedval_ = int.Parse(inputField.text);
        inputPasswordList.Add(addedval_);
        DisplayImage();
    }
    public int ChineseAnimal(int year)
    {
        int substract = year - 1900;
        int divided = substract % 12;
        int number = divided + 1;
        return number;
    }
    public void DisplayImage()
    {
        Debug.Log("Display girdi");
        foreach (int item in inputPasswordList)
        {
            Debug.Log("Display for girdi");
            int amount = ChineseAnimal(item);
            
            Debug.Log("Amount = " + amount);
            switch (amount)
            {
                case 1:
                    animalImage.sprite = animalImages[0];
                    break;
                case 2:
                    animalImage.sprite = animalImages[1];
                    break;
                case 3:
                    animalImage.sprite = animalImages[2];
                    break;
                case 4:
                    animalImage.sprite = animalImages[3];
                    break;
                case 5:
                    animalImage.sprite = animalImages[4];
                    break;
                case 6:
                    animalImage.sprite = animalImages[5];
                    break;
                case 7:
                    animalImage.sprite = animalImages[6];
                    break;
                case 8:
                    animalImage.sprite = animalImages[7];
                    break;
                case 9:
                    animalImage.sprite = animalImages[8];
                    break;
                case 10:
                    animalImage.sprite = animalImages[9];
                    break;
                case 11:
                    animalImage.sprite = animalImages[10];
                    break;
                case 12:
                    animalImage.sprite = animalImages[11];
                    break;
            }
                
            /*if (item == 1981 || item == 1993 || item == 2005 || item == 2017)
            {

            }
            else if(item == 1982 || item == 1994 || item == 2006 || item == 2018)
            {

            }
            else if (item == 1983 || item == 1995 || item == 2007 || item == 2019)
            {

            }
            else if (item == 1984 || item == 1996 || item == 2008 || item == 2020)
            {

            }
            else if (item == 1985 || item == 1997 || item == 2009 || item == 2021)
            {

            }
            else if (item == 1986 || item == 1998 || item == 2010 || item == 2022)
            {

            }
            else if (item == 1987 || item == 1999 || item == 2011 || item == 2023)
            {

            }
            else if (item == 1988 || item == 2000 || item == 2012 || item == 2024)
            {

            }
            else if (item == 1989 || item == 2001|| item == 2013 || item == 2025)
            {

            }
            else if (item == 1990 || item == 2002 || item == 2014 || item == 2018)
            {

            }
            else if (item == 1991 || item == 2003 || item == 2015 || item == 2018)
            {

            }
            else if (item == 1992 || item == 2004 || item == 2016 || item == 2018)
            {

            }*/
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
