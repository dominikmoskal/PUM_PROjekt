using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 direction;
    public float gravity = -50f;
    public float strength = 80f; 
    private SpriteRenderer spriteRenderer;

    public Sprite[] sprites;
    public int spriteIndex; //




    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite),0.15f,0.15f);
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
                FindObjectOfType<GameSettings>().EndGame();
            }
    }


}
