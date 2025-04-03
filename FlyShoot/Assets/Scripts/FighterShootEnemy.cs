using UnityEngine;

namespace Test{
    public class FighterShootEnemy : FighterShoot
    {
        [SerializeField, Header("發射間隔"), Range(0, 10)]
        private float intervalShoot = 3.5f;
        private void OnBecameVisible()
        {
            InvokeRepeating("Shoot", 0, intervalShoot);
        }
    }
}
