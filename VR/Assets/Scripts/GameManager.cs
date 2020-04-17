using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("喇叭控制器")]
    public AudioSource aud;

    [Header("箱的動畫控制器")]
    public Animator anibox;

    [Header("開箱音效")]
    public AudioClip soundOpen;

    private int countBox; //看到箱子的次數

    public void LookBox()
    {
        countBox++;
        if (countBox == 1)
        {
            aud.PlayOneShot(soundOpen, 5);
        }
        else if (countBox == 2)
        {
            aud.PlayOneShot(soundOpen, 4.5f);
            anibox.SetTrigger("開箱觸發器");
        }
    }
}

