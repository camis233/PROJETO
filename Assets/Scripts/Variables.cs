using NUnit.Framework.Internal;
using System.Security.Cryptography;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    enum Itens { Espada, Escudo, Pocao, Luva, Armadura, Bota };
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

        string inventorySlot1 = "Espada";
        string inventorySlot2 = "Escudo";
        string inventorySlot3 = "Armadura";
        string inventorySlot4 = "Tocha";
        string inventorySlot5 = "Botas";
        string inventorySlot6 = "Poção de Cura";
        string inventorySlot7 = "Poção de Cura";
        string inventorySlot8 = "Luvas";

        inventorySlot1 = "Espada";
        inventorySlot2 = "Escudo";


        string[] inventorySlot = new string[10];
        inventorySlot[0] = "Fim do mundo";

        int size = inventorySlot.Length;

        //Escopo: é o limite ou contexto que define onde uma variável, função ou objeto pode ser visto e acessado no código

        {

            int temp1 = 0;
            int temp2 = 0;
            { // escopo Depois start
                int temp3 = 2;
                {
                    int temp42 = 5;
                    temp3 = 5;
                }
                //temp42 = 7;
                //temp4 = 89898;
            }

            temp1 = 1;
            temp2 = 2;
            //temp3 = 3;
            int temp4 = 2;
            int temp5 = 2;

        }

        // Criando uma condição no código com base no jogo Sonic

        int rings = 5;
        bool isJumpSuccess = true;
        bool hasShield = false;

        if(isJumpSuccess ==true) // Se o meu pulo for bem sucedido

        {
            rings += 3; // Eu ganho 3 moedas
        }
        else if(isJumpSuccess == false && hasShield == false) //porém, se meu pulo for mal sucedido
        {
            rings = 0; // Eu perco todas as moedas
        }
        else if (isJumpSuccess == false && hasShield == true)
        {
            Debug.Log("Retornou em perder anéis");
        }
        else //Se nenhuma ação for realizada a condição será que ele não está pulando
        {
            Debug.Log("Não estou pulando");

           


            //Aula, dia 18/09/2026

    Itens currentitem = Itens.Espada;
    int index = (int)currentitem;

            if (currentitem == Itens.Espada)
            {
                Debug.Log("Perosnagem usa Espada");
            }
            else if (currentitem == Itens.Escudo)
            {
                Debug.Log("Personagem usa Escudo");
            }
            else if (currentitem == Itens.Armadura)
            {
                Debug.Log("Personagem usa Armadura");
            }

            char teste = ('a');
            switch (teste)
            {
                case 'a':
                    {
                        string nomePersonagem = "Cesar";
                        Debug.Log("Personagem " + nomePersonagem + " usa Espada");
                    }
                    break;
                case 'b':
                case 'c':
                case 'd':
                    Debug.Log("Agora b, c e d possuem o mesmo código!!!");
                    break;
                case 'e':
                    Debug.Log("Personagem usa Armadura");
                    break;
                case 'f':
                    Debug.Log("Personagem usa Bota");
                    break;
                default:
                    break;
            }

            int aleatorio = Random.Range(0, 15);
            float aleatorio2 = Random.Range(0.0f, 15.0f);



            string[] inventario = { "Espada", "Escudo", "Armadura", "Luva", "Bota", "Elmo", "Pocao", "Adaga", "Kit Medico", "Livro" };


            Random.Range(0, inventario.Length);


            for (int i = 0;i < inventario.Length; i++) 
            {
              if (inventario[i]== "Armadura de Prata")
                {
                    Debug.Log("Este inventario possui um arma mítica!!!!");
                    break;
                }
                //Debug.Log(inventario[i]);
            }
           





        }

    }
}
