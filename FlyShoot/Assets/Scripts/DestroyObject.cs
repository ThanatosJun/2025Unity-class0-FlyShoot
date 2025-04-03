using UnityEngine;

namespace Test
{
    public class DestroyObject : MonoBehaviour
    {
        private bool isVisible;
        private void OnBecameVisible(){
            isVisible = true;
        }
        private void OnBecameInvisible(){
            if (isVisible) Destroy(gameObject);
        }
    }
}
