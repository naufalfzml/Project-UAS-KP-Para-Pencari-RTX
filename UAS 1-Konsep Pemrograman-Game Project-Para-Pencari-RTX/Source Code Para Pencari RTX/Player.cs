using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public DataKarakter karakterDB;

    public Text namaKarakter;
    public SpriteRenderer gambarKarakter;
    private int pilihan = 0;
    // Start is called before the first frame update
    void Start()
    {
         if(!PlayerPrefs.HasKey("pilihan"))
        {
            pilihan = 0;
        }

        else
        {
            Load();
        }
        UpdateKarakter(pilihan);
    }

    private void UpdateKarakter (int pilihan)
    {
        Karakter karakter = karakterDB.GetKarakter(pilihan);
        gambarKarakter.sprite = karakter.karakterSprite;
    }

    private void Load()
    {
        pilihan = PlayerPrefs.GetInt("pilihan");
    }
}