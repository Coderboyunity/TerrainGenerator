using UnityEngine;

public class MinecraftTerrainGenerator : MonoBehaviour
{
    public GameObject cube;
    public int width = 50;
    public int height = 50;
    public float maxHeight = 10.0f;
    public float seed = 0.0f; // Seed for the Perlin noise

    void Start()
    {
        GenerateTerrain();
    }

    void GenerateTerrain()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                float y = Mathf.PerlinNoise((seed + x) * 0.1f, (seed + z) * 0.1f) * maxHeight;

                for (int yVal = 0; yVal < Mathf.CeilToInt(y); yVal++)
                {
                    GameObject terrain = Instantiate(cube);

                    terrain.transform.position = new Vector3(x, yVal, z);
                }
            }
        }
    }
}
