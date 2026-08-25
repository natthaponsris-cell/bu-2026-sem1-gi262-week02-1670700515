using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assignment
{
    public class Assignment : MonoBehaviour
    {
        public void Start()
        {
            // AS01_RandomItemDrop();
            // AS02_NestedLoopForCreate2DMap();
            // AS03_NestedLoopForMakingWallAround();
            // AS04_AttackEnemy();
            // AS05_DynamicIterationLoop();
            // AS06_WhileLoopAndArray();
            // AS07_HealTargetAtIndex();
            // AS08_RandomPickingDialogue();
            // AS09_MultiplicationTable();
            // AS10_FindSummationFromZeroToNUsingWhileLoop();
            // AS11_SpawnEnemies();
            // StartCoroutine(AS12_CountTime());
            // AS13_SumOfNumbersInRow();
            // AS14_SumOfNumbersInColumn();
            // AS15_MakeTheTriangle();
            // AS16_MultiplicationTableOf_2_3_and_4();
            // EX_01_TicTacToeGame_TurnPlay();

        }

        #region Assignment

        [Header("AS01_RandomItemDrop")]
        public GameObject[] as01_items;

        public void AS01_RandomItemDrop()
        {
            if (as01_items == null || as01_items.Length == 0) return;

            int randomIndex = UnityEngine.Random.Range(0, as01_items.Length);
            GameObject go = as01_items[randomIndex];

            Instantiate(go);

            Debug.Log($"Got item: {go.name}");
        }

        [Header("AS02_NestedLoopForCreate2DMap")]
        public GameObject[] as02_floorTiles;
        public int as02_columns = 5;
        public int as02_rows = 5;

        public void AS02_NestedLoopForCreate2DMap()
        {
            if (as02_floorTiles == null || as02_floorTiles.Length == 0) return;

            for (int y = as02_rows - 1; y >= 0; y--)
            {
                string rowOutput = "";
                for (int x = 0; x < as02_columns; x++)
                {
                    int randomIndex = UnityEngine.Random.Range(0, as02_floorTiles.Length);
                    GameObject selectedTile = as02_floorTiles[randomIndex];

                    Instantiate(selectedTile, new Vector2(x, y), transform.rotation);

                    rowOutput += selectedTile.name;
                }
                Debug.Log(rowOutput);
            }
        }
        [Header("AS03_NestedLoopForMakingWallAround")]
        public GameObject as03_wall;
        public int as03_columns = 5;
        public int as03_rows = 5;

        public void AS03_NestedLoopForMakingWallAround()
        {
            if (as03_wall == null) return;

            for (int y = 0; y < as03_rows; y++)
            {
                for (int x = 0; x < as03_columns; x++)
                {
                    if (x == 0 || x == as03_columns - 1 || y == 0 || y == as03_rows - 1)
                    {
                        Instantiate(as03_wall, new Vector2(x, y), transform.rotation);
                    }
                }
            }
        }
        [Header("AS04_AttackEnemy")]
        public int[] as04_enemyHP;
        public int as04_damage;
        public int as04_target;

        public void AS04_AttackEnemy()
        {
            if (as04_enemyHP == null || as04_enemyHP.Length == 0) return;

            // รูปแบบที่ 1 (โจมตีตัวแรก)
            as04_enemyHP[0] -= as04_damage;
            if (as04_enemyHP[0] < 0) as04_enemyHP[0] = 0;
            Debug.Log($"FirstEnemy hp :{as04_enemyHP[0]}");

            // รูปแบบที่ 2 (โจมตีตัวสุดท้าย)
            int lastIndex = as04_enemyHP.Length - 1;
            as04_enemyHP[lastIndex] -= as04_damage;
            if (as04_enemyHP[lastIndex] < 0) as04_enemyHP[lastIndex] = 0;
            Debug.Log($"LastEnemy hp :{as04_enemyHP[lastIndex]}");

            // รูปแบบที่ 3 (โจมตีเป้าหมายที่ระบุ)
            if (as04_target >= 0 && as04_target < as04_enemyHP.Length)
            {
                as04_enemyHP[as04_target] -= as04_damage;
                if (as04_enemyHP[as04_target] < 0) as04_enemyHP[as04_target] = 0;
                Debug.Log($"TargetEnemy {as04_target} hp :{as04_enemyHP[as04_target]}");
            }
        }

        [Header("AS05_DynamicIterationLoop")]
        public int as05_n;

        public void AS05_DynamicIterationLoop()
        {
            for (int i = 0; i < as05_n; i++)
            {
                Debug.Log(i);
            }
        }

        [Header("AS06_WhileLoopAndArray")]
        public string[] as06_ironManSuitNames;

        public void AS06_WhileLoopAndArray()
        {
            if (as06_ironManSuitNames == null || as06_ironManSuitNames.Length == 0) return;

            Debug.Log("======Log by One======");
            int i = 0;
            while (i < as06_ironManSuitNames.Length)
            {
                Debug.Log(as06_ironManSuitNames[i]);
                i += 1;
            }

            Debug.Log("======Log by Two======");
            i = 0;
            while (i < as06_ironManSuitNames.Length)
            {
                Debug.Log(as06_ironManSuitNames[i]);
                i += 2;
            }
        }

        [Header("AS07_HealTargetAtIndex")]
        public int[] as07_heroHPs;
        public int as07_heal;
        public int as07_targetIndex;

        public void AS07_HealTargetAtIndex()
        {
            if (as07_heroHPs == null || as07_heroHPs.Length == 0) return;

            // รูปแบบที่ 1 (Heal ตัวแรก)
            as07_heroHPs[0] += as07_heal;
            Debug.Log($"FirstHero hp :{as07_heroHPs[0]}");

            // รูปแบบที่ 2 (Heal ตัวสุดท้าย)
            int lastIndex = as07_heroHPs.Length - 1;
            as07_heroHPs[lastIndex] += as07_heal;
            Debug.Log($"LastHero hp :{as07_heroHPs[lastIndex]}");

            // รูปแบบที่ 3 (Heal ตัวเป้าหมายที่กำหนด)
            if (as07_targetIndex >= 0 && as07_targetIndex < as07_heroHPs.Length)
            {
                as07_heroHPs[as07_targetIndex] += as07_heal;
                Debug.Log($"TargetHero {as07_targetIndex} hp :{as07_heroHPs[as07_targetIndex]}");
            }
        }

        [Header("AS08_RandomPickingDialogue")]
        public string[] as08_dialogues;

        public void AS08_RandomPickingDialogue()
        {
            if (as08_dialogues == null || as08_dialogues.Length == 0) return;

            int r = UnityEngine.Random.Range(0, as08_dialogues.Length);
            Debug.Log(as08_dialogues[r]);
        }

        [Header("AS09_MultiplicationTable")]
        public int as09_n;

        public void AS09_MultiplicationTable()
        {
            for (int i = 1; i <= 12; i++)
            {
                Debug.Log($"{as09_n}x{i}={as09_n * i}");
            }
        }

        [Header("AS10_FindSummationFromZeroToNUsingWhileLoop")]
        public int as10_n;

        public void AS10_FindSummationFromZeroToNUsingWhileLoop()
        {
            int sum = 0;
            int i = 1;

            while (i <= as10_n)
            {
                sum += i;
                i++;
            }

            Debug.Log($"ผลรวมของ n จาก 1 ถึง {as10_n} คือ {sum}");
        }

        [Header("AS11_SpawnEnemies")]
        public int[] as11_enemyHPs;
        public GameObject as11_enemyPrefab;

        public void AS11_SpawnEnemies()
        {
            if (as11_enemyHPs == null || as11_enemyPrefab == null) return;

            for (int i = 0; i < as11_enemyHPs.Length; i++)
            {
                Instantiate(as11_enemyPrefab, new Vector2(i + 1, 0), transform.rotation);
                Debug.Log($"new enemy at position x = {i + 1}");
            }
        }

        [Header("AS12_CountTime")]
        public float as12_countTime;

        public IEnumerator AS12_CountTime()
        {
            float timer = 0f;

            while (timer < as12_countTime)
            {
                timer += Time.deltaTime;
                Debug.Log($"timer : {timer:F2}");
                yield return null;
            }

            Debug.Log($"End timer : {as12_countTime}");
        }

        [Header("AS13_SumOfNumbersInRow")]
        public Grid2DInt as13_matrix;
        public int as13_row;

        public void AS13_SumOfNumbersInRow()
        {
            if (as13_matrix == null) return;

            int[,] matrix = as13_matrix.Get2DArray();
            if (matrix == null || as13_row < 0 || as13_row >= matrix.GetLength(0)) return;

            int sum = 0;
            int cols = matrix.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                sum += matrix[as13_row, col];
            }

            Debug.Log(sum);
        }

        [Header("AS14_SumOfNumbersInColumn")]
        public Grid2DInt as14_matrix;
        public int as14_column;

        public void AS14_SumOfNumbersInColumn()
        {
            if (as14_matrix == null) return;

            int[,] matrix = as14_matrix.Get2DArray();
            if (matrix == null || as14_column < 0 || as14_column >= matrix.GetLength(1)) return;

            int sum = 0;
            int rows = matrix.GetLength(0);

            for (int row = 0; row < rows; row++)
            {
                sum += matrix[row, as14_column];
            }

            Debug.Log(sum);
        }

        [Header("AS15_MakeTheTriangle")]
        public int as15_size;

        public void AS15_MakeTheTriangle()
        {
            for (int i = 1; i <= as15_size; i++)
            {
                string line = "";
                for (int j = 1; j <= i; j++)
                {
                    line += "*";
                }
                Debug.Log(line);
            }
        }

        public void AS16_MultiplicationTableOf_2_3_and_4()
        {
            for (int i = 1; i <= 12; i++)
            {
                string rowStr = "";
                for (int j = 2; j <= 4; j++)
                {
                    rowStr += $"{j} x {i} = {j * i}";
                    if (j < 4)
                    {
                        rowStr += "\t";
                    }
                }
                Debug.Log(rowStr);
            }
        }

        #endregion

        #region Extra assignment

        /*
         * จงเขียนโปรแกรมจำลองเกม TicTacToe (XO)
         * กำหนดให้มีตัวแปร board : ขนาด 3x3 เท่านั้น
         * public static string[,] board = new string[3, 3] {
         * {"", "", ""},
         * {"", "", ""},
         * {"", "", ""}
         * };
         *
         * โดย AS11_TicTacToeGame_TurnPlay จะรับ 3 ตัวแปรคือ
         * + player: ระบุว่าในตานี้เป็นของผู้เล่นฝ่ายไหน "X" หรือ "O" X
         * + row, column เป็นการระบุตำแหน่งที่ผู้เล่นตานี้เลือกจะลงใน board เช่น row=0, column=1
         * โดยที่ method นี้จะต้องพิมพ์ ตารางหลังจากใส่ค่าออกมา
         * และแสดงว่าผลลัพธ์การเล่นตานั้นเกิดอะไรขึ้น ซึ่งจะมีความเป็นไปได้ทั้งหมด 5 รูปแบบคือ
         * -> ">> X Win!" เมื่อ player "X" ลงตานี้แล้วขนะ
         * -> ">> O Win!" เมื่อ player "O" ลงตานี้แล้วขนะ
         * -> ">> Draw" เมื่อผู้เล่น X หรือ O ลงไปแล้วไม่มีผู้ชนะ
         * -> ">> Continue" เมื่อผู้เล่น X หรือ O ลงไปแล้วเกมยังไม่จบ - ไม่มีผู้ชนะ และยังเหลือช่องว่างให้ผู้เล่นอีกคนลงต่อได้
         * -> ">> Invalid move" เมื่อผู้เล่น X หรือ O เลือกลงไปในช่องที่ไม่ว่าง หรือไม่มีอยู่จริงเข่น row=1000 column=1999
         *
         * Input
         * board:
         * -------------
         * |   | X |   |
         * -------------
         * |   |   |   |
         * -------------
         * |   |   |   |
         * -------------
         * player: "X"
         * row: 0
         * column: 1
         *
         * Output
         * -------------
         * |   | X |   |
         * -------------
         * |   |   |   |
         * -------------
         * |   |   |   |
         * -------------
         * >> Continue
         *
         * Input
         * board:
         * -------------
         * |   | X |   |
         * -------------
         * |   |   |   |
         * -------------
         * |   |   |   |
         * -------------
         * Player: "O"
         * row: 1
         * col: 1
         *
         * Output:
         * -------------
         * |   | X |   |
         * -------------
         * |   | O |   |
         * -------------
         * |   |   |   |
         * -------------
         * >> Continue
         *
         * NOTE การพิมพ์ตารางให้ระวังเรื่อง space ให้ดี
         *
         * โดยหากช่องนั้นไม่ว่างให้ (Invalid input) ให้พิมพ์ออกมาว่าไม่สามารถลงในตำแหน่งที่ต้องการได้ cannot set X at 0 2 และวนกลับไปให้เซตค่าใหม่
         *
         * Input
         * board:
         * -------------
         * | X |   | O |
         * -------------
         * |   |   |   |
         * -------------
         * |   |   |   |
         * -------------
         * Player: O
         * row: 0
         * column: 2
         *
         * Output
         * -------------
         * | X |   | O |
         * -------------
         * |   |   |   |
         * -------------
         * |   |   |   |
         * -------------
         * >> Invalid move
         *
         * หลังจากการลงในแต่ละตา ระบบเกมจะต้อง check ว่า ใครเป็นฝ่ายชนะ เช่น
         *
         * Input
         * board:
         * -------------
         * | X | X |   |
         * -------------
         * | X | O |   |
         * -------------
         * | O |   |   |
         * -------------
         * player: O
         * row: 2
         * column: 0
         *
         * Output
         * -------------
         * | X | X | O |
         * -------------
         * | X | O |   |
         * -------------
         * | O |   |   |
         * -------------
         * >> O wins!
         *
         * Input
         * board:
         * -------------
         * | X |   | O |
         * -------------
         * |   |   | O |
         * -------------
         * |   |   | X |
         * -------------
         * Player: X
         * row: 2
         * column: 2
         *
         * Output
         * -------------
         * | X |   | O |
         * -------------
         * |   | X | O |
         * -------------
         * |   |   | X |
         * -------------
         * >> X wins!
         *
         * และถ้าลงจนครบทุกช่องแล้วไม่มีผู้ชนะ ให้พิมพ์ว่า Draw!
         *
         * Input
         * board:
         * -------------
         * | X | X | O |
         * -------------
         * | O | O | X |
         * -------------
         * | X |   | X |
         * -------------
         * Player: O
         * row: 2
         * column: 1
         *
         * Output
         * -------------
         * | X | X | O |
         * -------------
         * | O | O | X |
         * -------------
         * | X | O | X |
         * -------------
         * >> Draw
         *
         * Input
         * board:
         * -------------
         * | X | X | O |
         * -------------
         * | O | O | X |
         * -------------
         * | X | O |   |
         * -------------
         * Player: X
         * row: 2
         * column: 2
         *
         * Output
         * -------------
         * | X | X | O |
         * -------------
         * | O | O | X |
         * -------------
         * | X | O | X |
         * -------------
         * >> Draw
         *
         * หมายเหตุ: Unity ไม่รองรับการแสดงผล string[,] บน Inspector โดยตรง จึงใช้ class Grid2DString
         * แทน ซึ่งกรอกค่าเป็นตาราง (grid) ได้จาก Inspector เมื่อจะใช้งานเป็น 2D array จริงๆ ให้เรียก
         * ex01_board.Get2DArray()
         *
         * พารามิเตอร์:
         * - board: กระดาน Tic Tac Toe ขนาด 3x3
         * - playerTurn: ตาของผู้เล่น "X" หรือ "O"
         * - row: แถวที่ต้องการเล่น (index 0 - 2)
         * - column: คอลัมน์ที่ต้องการเล่น (index 0 - 2)
         */
        [Header("EX_01_TicTacToeGame_TurnPlay")]
        public Grid2DString ex01_board = new Grid2DString
        {
            rows = 3,
            cols = 3,
            data = new string[] {
                "X", "X", "O",
                "X", "O", "X",
                "", "", ""
            }
        };
        public string ex01_playerTurn = "O";//กรอกเป็น X พิมพ์ใหญ่หรือ O พิมพ์ใหญ่เท่านั้น
        public int ex01_row = 2;
        public int ex01_column = 0;
        public void EX_01_TicTacToeGame_TurnPlay()
        {
            var board = ex01_board.Get2DArray();
            throw new NotImplementedException();
        }
        #endregion

        private void PrintBoard(string[,] board)
        {
            StringBuilder sb = new();
            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine("-------------");
                sb.AppendLine("| " + spaceIfEmpty(board[i, 0]) + " | " + spaceIfEmpty(board[i, 1]) + " | " + spaceIfEmpty(board[i, 2]) + " |");
            }
            sb.AppendLine("-------------");
            Debug.Log(sb.ToString());
        }

        private string spaceIfEmpty(string value)
        {
            return string.IsNullOrEmpty(value) ? " " : value;
        }
    }

}
