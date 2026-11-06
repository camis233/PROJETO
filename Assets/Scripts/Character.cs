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


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CharacterInfo cloud = new CharacterInfo();

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
        tifa.level = 1;

        float damage = Random.Range(2.0f, 5.0f);
        cloud.hp -= damage;
        Debug.Log(cloud.name + " tomou " + damage + " de dano");

        float damage2 = Random.Range(2.0f, 5.0f);
        tifa.hp -= damage2;
        Debug.Log(tifa.name + " tomou " + damage2 + " de dano");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
