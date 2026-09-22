using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    public SpriteRenderer introImage;
    public Sprite[] introSprites;

    public float changeTime = 2.5f;

    private int currentIndex = 0;
    private float timer = 0f;

    void Start()
    {
        introImage.sprite = introSprites[0];
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeTime)
        {
            timer = 0f;

            if (currentIndex < introSprites.Length - 1)
            {
                currentIndex++;
                introImage.sprite = introSprites[currentIndex];
            }
            else
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}