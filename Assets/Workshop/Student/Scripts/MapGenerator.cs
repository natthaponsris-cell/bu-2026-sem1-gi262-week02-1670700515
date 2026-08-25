using System;
using UnityEngine;

namespace Workshop.Student
{
    public class MapGenerator : MonoBehaviour
    {
        public int columns = 10;
        public int rows = 10;

        public GameObject[] floorTiles;
        public GameObject[] wallTiles;
        public GameObject[] foodTiles;

        public string[,] saveItemMap = new string[3, 3] {
            { " ", "Soda", " "},
            { " ", " ", " "},
            { " ", " ", "Food"},
        };

        // 1. declare Players variable
        public GameObject[] playerTiles;

        // 2. declare Obstacles variable
        public GameObject[] obstacleTiles;

        // 7. declare Exit variable 
        public GameObject exitTile;

        public void Start()
        {
            // 1. random player at the position <0, 0> map
            if (playerTiles != null && playerTiles.Length > 0)
            {
                int rPlayer = UnityEngine.Random.Range(0, playerTiles.Length);
                Instantiate(playerTiles[rPlayer], new Vector2(0, 0), Quaternion.identity);
            }

            // 3. create floor (สร้างพื้นก่อน)
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    int r = UnityEngine.Random.Range(0, floorTiles.Length);
                    GameObject tile = Instantiate(floorTiles[r], new Vector2(x, y), Quaternion.identity);
                    tile.name = "Floor" + x + "_" + y;
                }
            }

            // 4. create walls (สร้างกำแพงล้อมรอบ)
            for (int y = -1; y < rows + 1; y++)
            {
                for (int x = -1; x < columns + 1; x++)
                {
                    if (x == -1 || x == columns || y == -1 || y == rows)
                    {
                        int r = UnityEngine.Random.Range(0, wallTiles.Length);
                        GameObject tile = Instantiate(wallTiles[r], new Vector2(x, y), Quaternion.identity);
                        tile.name = "Wall" + x + "_" + y;
                    }
                }
            }

            // 2. create obstacles (สร้างกำแพงกั้นแนวตั้งตรงกลาง สูงครึ่งฉาก)
            if (obstacleTiles != null && obstacleTiles.Length > 0)
            {
                int middleX = columns / 2; // ตรงกลางแกน X (ตำแหน่งที่ 5)
                int halfRows = rows / 2;   // ความสูงครึ่งฉาก (5 แถว)

                for (int y = 0; y < halfRows; y++)
                {
                    int rObstacle = UnityEngine.Random.Range(0, obstacleTiles.Length);

                    // กำหนดพิกัด Z = -1f เพื่อให้อยู่ด้านหน้าของพื้นแน่นอน
                    Vector3 spawnPos = new Vector3(middleX, y, -1f);

                    GameObject wallObj = Instantiate(obstacleTiles[rObstacle], spawnPos, Quaternion.identity);
                    wallObj.name = "CenterWall_" + middleX + "_" + y;

                    // ปรับ Order in Layer เพิ่มเป็น 5 ดันขึ้นมาเลเยอร์บนสุด
                    SpriteRenderer sr = wallObj.GetComponent<SpriteRenderer>();
                    if (sr != null)
                    {
                        sr.sortingOrder = 5;
                    }
                }
            }

            // 5. random foods
            int numberOfFoods = UnityEngine.Random.Range(1, 3);
            for (int i = 0; i < numberOfFoods; i++)
            {
                int x_Food = UnityEngine.Random.Range(0, columns);
                int y_Food = UnityEngine.Random.Range(0, rows);
                Instantiate(foodTiles[0], new Vector2(x_Food, y_Food), Quaternion.identity);
            }

            // 6. generate item along with the saveItemMap
            for (int y = 0; y < saveItemMap.GetLength(0); y++)
            {
                for (int x = 0; x < saveItemMap.GetLength(1); x++)
                {
                    string item = saveItemMap[y, x];
                    if (!string.IsNullOrEmpty(item) && item.Trim() != "")
                    {
                        foreach (var foodTile in foodTiles)
                        {
                            if (foodTile.name == item)
                            {
                                GameObject spawnedItem = Instantiate(foodTile, new Vector2(x, y), Quaternion.identity);
                                spawnedItem.name = "Food " + x + "_" + y;
                                break;
                            }
                        }
                    }
                }
            }

            // 7. place exit
            if (exitTile != null)
            {
                Vector2 exitPosition = new Vector2(columns - 1, rows - 1);
                Instantiate(exitTile, exitPosition, Quaternion.identity);
            }
        }
    }
}