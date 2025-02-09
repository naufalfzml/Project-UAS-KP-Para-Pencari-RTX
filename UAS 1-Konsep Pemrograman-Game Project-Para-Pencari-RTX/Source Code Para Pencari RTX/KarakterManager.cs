using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KarakterManager : MonoBehaviour
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

    public void NextOption()
    {
        pilihan++;

        if(pilihan >= karakterDB.JumlahKarakter)
        {
            pilihan = 0;
        }
        UpdateKarakter(pilihan);
        Save();
    }
    
    public void BackOption()
    {
        pilihan--;

        if(pilihan < 0)
        {
            pilihan = karakterDB.JumlahKarakter - 1;
        }
        UpdateKarakter(pilihan);
        Save();
    }

    private void UpdateKarakter (int pilihan)
    {
        Karakter karakter = karakterDB.GetKarakter(pilihan);
        gambarKarakter.sprite = karakter.karakterSprite;
        namaKarakter.text = karakter.namaKarakter;
    }

    private void Load()
    {
        pilihan = PlayerPrefs.GetInt("pilihan");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("pilihan", pilihan);
    }

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
