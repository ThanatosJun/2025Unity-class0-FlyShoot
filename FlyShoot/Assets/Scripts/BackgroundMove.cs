using UnityEngine;

namespace Test
{
    public class BackgroundMove : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(0, 10)]
        private float speed = 3.5f;
        private void Update()
        {
            Move();
        }
        private void Move()
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}

