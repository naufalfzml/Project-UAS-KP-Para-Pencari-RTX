using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

[CreateAssetMenu]
public class DataKarakter : ScriptableObject
{
    public Karakter[] karakter;

    public int JumlahKarakter
    {
        get
        {
            return karakter.Length;
        }
    }

    public Karakter GetKarakter(int index)
    {
        return karakter[index];
    }
}
