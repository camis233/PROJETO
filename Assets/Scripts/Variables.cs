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
        int tempsub = characterStregth - 1;

        /*characterHitPoint *= 2;
        characterHitPoint = characterHitPoint * 2;
        ++characterHitPoint;

         Debug.Log("valor sem operador " + characterHitPoint);
         Debug.Log("valor com operador antes " + ++characterHitPoint);*/
        //Debug.Log("valor com operador antes " + characterHitPoint++);
        //Debug.Log("valor sem alterar nada " + characterHitPoint);

        //bool eh_igual = characterHitPoint < characterStregth;

        //Para passar de ano, a media deve ser igual ou superior a 5
        //Para passar de ano a presença tem que ser maior que 75

        string catastrofeName = "Camila ";

        int catastrofeNota = 8;

        float catastrofePresenca = 80;

        bool passou_de_ano = catastrofeNota >= 5 && catastrofePresenca >= 75;

        Debug.Log(catastrofeName + "passou_de_ano? " + passou_de_ano);
    }
}
