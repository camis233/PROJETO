using UnityEngine;

public class Atividade : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        /*{int INVNTARIO = Random.Range(0, 17);
        
        string[] INVENTARIO = { "Espada Longa de Aço", "Escudo de Carvalho", "Poção de Cura Maior", "Elixir de Mana", "Pergaminho de Bola de Fogo", "Rações de Viagem", "Tocha", "Corda de Cânhamo (10m)", "Gazuas de Ladrão", "Anel de Prata Antigo", "Mapa do Reino", "Saco de Moedas de Ouro", "Adaga Envenenada", "Amuleto de Proteção", "Pena de Fênix", "Cajado de Fogo" };
        string Armadilha = ("Armadilha");
        string[] EspadaQuebrada = ("Espada quebrou!");
        string EscudoQuebrado = ("Escudo Quebrou");



        for (int i = 0; i < INVENTARIO.Length; i++)
        {
            if (INVENTARIO[i] == "Espada quebrou!") ;
            {
                Debug.Log(EspadaQuebrada)
            }
            if else (INVENTARIO[i] == "")
        }*/

    //Correção do professor
    void Start()
        {
            string[] inventory = { "Espada Longa de Aço", "Escudo de Carvalho", "Poção de Cura Maior", "Elixir de Mana", "Pergaminho de Bola de Fogo", "Rações de Viagem", "Tocha", "Corda de Cânhamo (10m)", "Gazuas de Ladrão", "Anel de Prata Antigo", "Mapa do Reino", "Saco de Moedas de Ouro", "Adaga Envenenada", "Amuleto de Proteção", "Pena de Fênix", "Cajado de Fogo" };


            int randomindex = Random.Range(0, inventory.Length);
            string trapChange = (Random.Range(0, 2) % 2) == 0 ? "Espada Quebrada" : "Escudo Quebrado";

            for (int i = 0; int < inventory.Length; i++)
            {
                if (inventory[i] == "Espada Quebrada")
                {
                    Debug.Log("o index: " + i + "foi substituido por Espada Quebrada");
                    break;
                }
                else if (inventory[i] == "Escudo Quebrado")
                {
                    Debug.Log("o index: " + i + "foi substituido por Escudo Quebrado");
                    break;
                }
            }


// Update is called once per frame
void Update()
    {
       
}
