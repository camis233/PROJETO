using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int myNumber;
        float myDecimal;
        double myDouble = 1.5;
        bool myBool;
        string myString;
        char myChar;

        myNumber = 10;


        string characterName = "Josezinho do Gral";
        int characterHitPoint = 10;
        float jumpHeight = 1.75f;
        int characterStregth = 50;
        char characterSex = 'm';
        bool isHurt = false;

        int temp = characterHitPoint + characterStregth;

        Debug.Log(temp.ToString());
    }
}
