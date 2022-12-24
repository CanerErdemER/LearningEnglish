using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class discover_manager : MonoBehaviour
{
    [SerializeField]
    GameObject letterpref;
    [SerializeField]
    Transform letterholder;
    [SerializeField]
    AudioClip[] lettersounds;
    string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "v", "z" };
    int numbersofletter;


    private void Start()
    {
        sortletter();
        
    }
    void sortletter()
    {
        for (int i = 0; i < letters.Length; i++)
        {
            GameObject letterobject = Instantiate(letterpref, letterpref.transform.position, Quaternion.identity);

            letterobject.transform.GetChild(0).GetComponent<Text>().text = letters[i];

            letterobject.transform.SetParent(letterholder);


            letterholder.localPosition = new Vector3(470, 0, 0);

            
        }
        
    }
    IEnumerator showlettersRoutine()
    {
        while (numbersofletter < lettersounds.Length)
        {
            //letterholder.GetChild(numbersofletter).GetComponent<CanvasGroup>().DOFade(1, 0.5f);
            //letterholder.GetChild(numbersofletter).GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
            letterholder.GetChild(numbersofletter).GetComponent<AudioSource>().clip = lettersounds[numbersofletter];


            yield return
            numbersofletter++;
            
        }
    }




}
