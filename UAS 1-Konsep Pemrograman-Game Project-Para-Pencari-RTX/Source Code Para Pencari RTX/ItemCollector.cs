// Make sure the namespace is properly defined
namespace YourNamespace
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class ItemCollector : MonoBehaviour
    {
        [SerializeField] AudioSource suaraDapat;
        public int rtx;

        [SerializeField] private Text rtxText;

        // Use OnTriggerEnter2D to handle trigger collisions
        private void OnTriggerEnter2D(Collider2D other) 
        {
            if (other.gameObject.CompareTag("rtx"))
            {
                Destroy(other.gameObject);
                rtx++;
                rtxText.text = "RTX Collected : " + rtx;
                suaraDapat.Play();
            }
        }
    }
}
