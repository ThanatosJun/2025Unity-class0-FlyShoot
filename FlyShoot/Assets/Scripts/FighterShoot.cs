using UnityEngine;

namespace Test{

    public class FighterShoot : MonoBehaviour
    {
        [SerializeField, Header(" 子彈預製物")]
        private GameObject prefaBullet;
        [SerializeField, Header(" 子彈生成位置")]
        private Transform traSpawnPoint;
        [SerializeField, Header(" 發射音效")]
        private AudioClip soundFire;
        [SerializeField, Header(" 發射速度")]
        private Vector2 v2Speed;
        [SerializeField, Header(" 發射角度")]
        private Vector3 v3Angle;
        [SerializeField, Header(" 子彈顏色")]
        private Color colorBullet;
        [SerializeField, Header(" 子彈標籤")]
        private string tagBullet;

        protected void Shoot()
        {
            GameObject tempBullet = Instantiate(prefaBullet, traSpawnPoint.position, Quaternion.Euler(v3Angle));
            tempBullet.GetComponent<ConstantForce2D>().force = v2Speed;
            tempBullet.GetComponent<SpriteRenderer>().color = colorBullet;
            tempBullet.tag = tagBullet;
            SoundManager.instance.PlaySound(soundFire, 1);
        }
    }

}