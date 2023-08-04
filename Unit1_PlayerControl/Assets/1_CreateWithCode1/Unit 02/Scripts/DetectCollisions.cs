using UnityEngine;

namespace Unit_02.Scripts {
    public class DetectCollisions : MonoBehaviour {
        private void OnTriggerEnter(Collider other) {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
}