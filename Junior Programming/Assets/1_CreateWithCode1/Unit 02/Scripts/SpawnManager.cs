using UnityEngine;

namespace Unit_02.Scripts {
    public class SpawnManager : MonoBehaviour {
        public GameObject[] animalPrefabs;
        private float spawnRangeX = 20;
        private float spawnPosZ = 20;
        private float startDelay = 2;
        private float spawnInterval = 1.5f;

        // Start is called before the first frame update
        void Start() {
            InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, spawnInterval);
        }

        // Update is called once per frame
        void Update() {
        }

        void SpawnRandomAnimal() {
            var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            var animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        
    }
}