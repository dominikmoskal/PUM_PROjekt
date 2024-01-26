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
    public Sprite[] sprites;
    public int spriteIndex; 
    public int skinIndex = 0;
    public GameObject button;
    private GameObject bird0;
    private GameObject bird1;
    private GameObject bird2;
    private GameObject bird3;
    private GameObject bird4;

    public bool vibrationsEnabled = true;
    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite),0.15f,0.15f);

        bird0 = GameObject.Find("Bird0");
        bird1 = GameObject.Find("Bird1");
        bird2 = GameObject.Find("Bird2");
        bird3 = GameObject.Find("Bird3");
        bird4 = GameObject.Find("Bird4");

        skinIndex = PlayerPrefs.GetInt("skinIndex", 0);

        if(GameObject.Find("Bird"+skinIndex) != bird0) Destroy(bird0);
        if(GameObject.Find("Bird"+skinIndex) != bird1) Destroy(bird1);
        if(GameObject.Find("Bird"+skinIndex) != bird2) Destroy(bird2);
        if(GameObject.Find("Bird"+skinIndex) != bird3) Destroy(bird3);
        if(GameObject.Find("Bird"+skinIndex) != bird4) Destroy(bird4);

        button.SetActive(false);
    }   

    private void AnimateSprite()
    {
      
        spriteIndex++;
        if(spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
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
                if(PlayerPrefs.GetInt("IsVibrationEnabled") == 1)
                {
                    Handheld.Vibrate();
                }
                FindObjectOfType<GameSettings>().EndGame();
            }
    }
    


}
