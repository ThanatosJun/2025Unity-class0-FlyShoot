using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Test{
    public class FighterControl : MonoBehaviour
    {
        [SerializeField, Header("移度速度"), Range(0, 10)]
        private float speed = 3.5f;
        [Header("戰鬥機上中下圖片")]
        [SerializeField] private Sprite spriteUp;
        [SerializeField] private Sprite spriteMiddle;
        [SerializeField] private Sprite spriteDown; 

        private SpriteRenderer spr;
        private Rigidbody2D rig2D;

        private void Awake()
        {
            spr = GetComponent<SpriteRenderer>();
            rig2D = GetComponent<Rigidbody2D>();
        }
        void Update()
        {
            Move();
        }

        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            rig2D.velocity = new Vector2(h, v) * speed;

            if(v > 0) spr.sprite = spriteUp;
            else if (v < 0) spr.sprite = spriteMiddle;
            else spr.sprite = spriteDown;
        }
    }
}