using UnityEngine;

namespace Test{
    public class FighterShootPlayer : FighterShoot
    {
        private void Update()
        {
            InputShoot();
        }

        private void InputShoot()
        {
            if(Input.GetKeyDown(KeyCode.Space)) Shoot();
        }
    }
}