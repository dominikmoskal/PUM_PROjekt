using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Vector3 direction;
    public float gravity = -50f;
    public float strength = 80f; 
    private SpriteRenderer spriteRenderer;

    public BirdSkin birdSkin;
    public Sprite[] sprites;
    public int spriteIndex; 
    public int skinIndex = 0;
    public GameObject button;


    private void Start()
    {

        button.SetActive(false);
        InvokeRepeating(nameof(AnimateSprite),0.15f,0.15f);
    }
    private void AnimateSprite()
    {
      
        //skinIndex = 0;
        spriteIndex++;
        if(spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];//birdSkin.tablica_obrazow[skinIndex, spriteIndex];
    }

    public void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength*3/2;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength*3/2;
            }
        }

        direction.y += gravity *6 * Time.deltaTime;
        transform.position += direction *5* Time.deltaTime;
    }

    public void Pause()
    {
        Time.timeScale = GameSettings.czas;
        SceneManager.LoadScene("MainScene");
    }
    private void Awake()
    {   
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Point")
        {
            FindObjectOfType<GameSettings>().IncreaseScore();
        } 
        else 
            if(other.gameObject.tag == "Stick")
            {
                button.SetActive(true);
                Handheld.Vibrate();
                FindObjectOfType<GameSettings>().EndGame();
            }
    }


}
