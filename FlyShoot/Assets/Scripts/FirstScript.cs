using UnityEngine;
namespace Test
{
    public class FirstScript : MonoBehaviour
    {
        #region Event
        private void Awake()
        {
            print("Wake up event");
        }
        private void Start()
        {
            print("Start event");
        }

        // private void Update()
        // {
        //     print("Update event");
        // }
        #endregion
    }
}