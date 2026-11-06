using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum ERace { Human, Orc, Elf }

public struct CharacterInfo
    {
        public string name;
        public int st;
        public int iq;
        public float mana;
        public float hp;
        public char gender;
        public ERace race;
        public int level;

    }

    CharacterInfo initializeCharacter(string name, int st, int iq, float mana,
                                         float hp, char gender, ERace race, int level)
    {
        CharacterInfo result = new CharacterInfo();

        result.name = name;
        result.st = st;
        result.iq = iq;
        result.mana = mana;
        result.hp = hp;
        result.gender = gender;
        result.race = race;
        result.level = level;

        return result;
    }

    void TakeDamage(ref CharacterInfo character)
    {
        float damage = Random.Range(2.0f, 5.0f);
        character.hp -= damage;
        Debug.Log(character.name + " tomou " + damage + " de dano");

    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
       //código antigo
        
        /*CharacterInfo cloud = new CharacterInfo();

        cloud.name = "Cloud";
        cloud.st = 10;
        cloud.iq = 10;
        cloud.mana = 8.0f;
        cloud.hp = 12.0f;
        cloud.gender = 'M';
        cloud.race = ERace.Human;
        cloud.level = 1;

        CharacterInfo tifa = new CharacterInfo();

        tifa.name = "Tifa";
        tifa.st = 11;
        tifa.iq = 9;
        tifa.mana = 5.0f;
        tifa.hp = 10.0f;
        tifa.gender = 'F';
        tifa.race = ERace.Human;
        tifa.level = 1;*/

        CharacterInfo cloud = initializeCharacter("Cloud", 10, 10, 8.0f,
                                                 12.0f, 'M', ERace.Human, 1);

        CharacterInfo tifa = initializeCharacter("tifa", 11, 9, 5.0f,
                                                10.0f, 'F', ERace.Human, 1);


        Debug.Log(cloud.hp + "Antes ");
        TakeDamage(ref cloud);
        Debug.Log(cloud.hp + " Depois");

        Debug.Log(tifa.hp + "Antes ");
        TakeDamage(ref tifa);
        Debug.Log(tifa.hp + " Depois");

        //Código antigo 

        /*float damage = Random.Range(2.0f, 5.0f);
          cloud.hp -= damage;
          Debug.Log(cloud.name + " tomou " + damage + " de dano");

          float damage2 = Random.Range(2.0f, 5.0f);
          tifa.hp -= damage2;
          Debug.Log(tifa.name + " tomou " + damage2 + " de dano");*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
