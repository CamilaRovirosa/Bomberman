using UnityEngine;
using UnityEngine.Tilemaps;

public class BombsSpawner : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject bombPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Vector3 worlPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cell =tilemap.WorldToCell(worlPos);
            Vector3 cellCenterPos= tilemap.GetCellCenterWorld(cell);

            Instantiate(bombPrefab, cellCenterPos, Quaternion.identity);
        }
    }
}
