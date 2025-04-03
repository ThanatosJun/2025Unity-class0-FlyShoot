using UnityEngine;

namespace Test
{
    public class DamageSystem : MonoBehaviour
    {
        [Header("音效：碰撞與爆炸")]
        [SerializeField] private AudioClip soundHit;
        [SerializeField] private AudioClip soundExplosion;
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰撞會受傷的標籤陣列")]
        private string[] tagsHit;

        private int health = 1;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Damage(collision.gameObject);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Damage(collision.gameObject);
        }

        private void Damage(GameObject hit)
        {
            for (int i = 0; i < tagsHit.Length; i++)
            {
                if (hit.CompareTag(tagsHit[i]))
                {
                    health --;
                    DestroyBullet(hit);
                }
            }
            if (health <= 0) Dead();
        }

        private void DestroyBullet(GameObject hit)
        {
            if (hit.tag.Contains("子彈")) Destroy(hit);
        }

        private void Dead()
        {
            GameObject tempExplotion = Instantiate(prefabExplosion, transform.position, Quaternion.identity);
            Destroy(tempExplotion, 0.2f);
            Destroy(gameObject);
            SoundManager.instance.PlaySound(soundExplosion, 1);
            Debug.Log("檢查 UIAndSceneManager.instance：" + UIAndSceneManager.instance);
            if (gameObject.name == "player-flyer") {
                UIAndSceneManager.instance.UpdateUIAndShow("遊戲結束");
            }
        }
    }
}
    
