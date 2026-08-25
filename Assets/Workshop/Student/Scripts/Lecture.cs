using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {

        void Start()
        {
            // LCT01_SyntaxArray();
            // LCT02_ArrayInitialize();
            // LCT03_SyntaxLoop();
            // LCT04_LoopAndArray();
            // LCT05_Syntax2DArray();
            // LCT06_SizeOf2DArray();
            // LCT07_SyntaxNestedLoop();
        }

        #region Lecture
        public string[] ironManSuit;
        public void LCT01_SyntaxArray()
        {
            string[] _ironManSuit = new string[2];
            _ironManSuit[0] = "Mark I";
            _ironManSuit[1] = "Mark II";

            string tonyStarkWear = _ironManSuit[0];
            Debug.Log("TonyStark Wear " + tonyStarkWear);
            Debug.Log("Room size: " + _ironManSuit.Length);

            Debug.Log(_ironManSuit[0]);
            Debug.Log(_ironManSuit[1]);

        }

        public void LCT02_ArrayInitialize()
        {
            string[] spidermanSuits = new string[] { "Classic", "Black Suit", "Iron Spider" };
            string[] batmanSuits = new string[2] { "Classic batman", "White bat" };

            Debug.Log("Room size: " + spidermanSuits.Length);
            Debug.Log(spidermanSuits[0]);
            Debug.Log(spidermanSuits[1]);
            Debug.Log(spidermanSuits[2]);

            Debug.Log("Room size: " + batmanSuits.Length);
            Debug.Log(batmanSuits[0]);
            Debug.Log(batmanSuits[1]);
            Debug.Log(batmanSuits[2]);
        }


        /*
         * จงเขียนโปรแกรมเพื่อแสดงผลลัพธ์ตามที่กำหนด โดยใช้โครงสร้างการวนซ้ำ for loop
         *
         * for loop ที่ 1:
         * - จะวนลูปทั้งหมด 10 ครั้ง โดยค่าของ i จะเริ่มต้นที่ 0 และเพิ่มขึ้นทีละ 1 จนถึงค่าน้อยกว่า 10
         * - ในแต่ละรอบของลูป จะแสดงข้อความ "<10 : " ตามด้วยค่าของ i ออกมาทาง Debug.Log
         * - ให้ใช้ Debug.Log คั่นค่า
         *
         * ก่อนเริ่ม for loop ที่ 2 ให้พิมพ์ Debug.Log("======================");
         *
         * for loop ที่ 2:
         * - จะวนลูปทั้งหมด 10 ครั้ง โดยค่าของ i จะเริ่มต้นที่ 1 และเพิ่มขึ้นทีละ 1 จนถึงค่าเท่ากับ 10
         * - ในแต่ละรอบของลูป จะแสดงข้อความ "<=10 : " ตามด้วยค่าของ i ออกมาทาง Debug.Log
         */
        public void LCT03_SyntaxLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Debug.Log("<10 : " + i);
            }
            Debug.Log("==================");
            for (int i = 0; i < 10; i++)
            {
                Debug.Log("<=10 : " + i);
            }
        }

            /*
             * จงเขียนโปรแกรมเพื่อแสดงรายชื่อชุดเกราะ Iron Man โดยใช้ Array และ for loop
             *
             * ====== Log by One incrementer ======
             * for Loop ที่ 1:
             * ค่า i เพิ่มขึ้น ที่ละ 1
             *
             * ====== Log by Two incrementer ======
             * for Loop ที่ 2:
             * ค่า i เพิ่มขึ้น ที่ละ 2
             *
             * ตัวอย่างผลลัพธ์:
             *
             * ====== Log by One incrementer ======
             * Mark I
             * Mark II
             * Mark III
             * ====== Log by Two incrementer ======
             * Mark I
             * Mark III

             *
             * พารามิเตอร์:
             * - ironManSuitNames: อาร์เรย์ของชื่อชุดเกราะ Iron Man
             */
            [Header("LCT04_LoopAndArray")]
            public string[] lct04_ironManSuitNames;
        public void LCT04_LoopAndArray()
        {
            Debug.Log("====== Log by One increment ======");
            for (int i = 0; i < lct04_ironManSuitNames.Length; i++)
            {
                Debug.Log(lct04_ironManSuitNames[i]);
            }
            Debug.Log("====== Log by Two increment ======");
            for (int i = 0; i < lct04_ironManSuitNames.Length; i += 2)
            {
                Debug.Log(lct04_ironManSuitNames[i]);
            }
        }


        /*
         * จงเขียนโปรแกรมภาษา C# เพื่อสร้างอาร์เรย์สองมิติ (2D array)
         * ชื่อ my2DArray ที่มีขนาด 3 x 3 โดยมีค่าเริ่มต้นดังนี้:
         * { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }
         *
         * ตัวอย่างผลลัพธ์:
         * 1 2 3 
         * 4 5 6 
         * 7 8 9 
         *
         * 2D Array (อาร์เรย์สองมิติ) คืออะไร
         * อาร์เรย์สองมิติ หรือ 2D Array นั้นเปรียบเสมือนตารางที่มีทั้งแถวและคอลัมน์ โดยแต่ละช่องในตารางนั้นจะเก็บข้อมูลได้หนึ่งค่า คิดง่ายๆ เหมือนกับตารางใน Excel เลยครับ
         *
         * ทำไมต้องใช้ 2D Array?
         * - จัดเก็บข้อมูลที่มีโครงสร้างเป็นตาราง: เหมาะสำหรับข้อมูลที่ต้องการจัดเรียงเป็นแถวและคอลัมน์ เช่น ตารางคะแนน, ตารางข้อมูลสินค้า, แผนที่ในเกม
         * - เข้าถึงข้อมูลได้ง่าย: สามารถเข้าถึงข้อมูลในตำแหน่งใดๆ ได้โดยตรงโดยใช้ดัชนีของแถวและคอลัมน์
         *
         * ตัวอย่างการประกาศตัวแปร 2D Array หรืออาร์เรย์ 2 มิติ
         * ยกตัวอย่าง 2D Array (อาร์เรย์ 2 มิติ) ที่มีการเก็บค่าดังนี้
         * 1 2 3 4 5
         * 1 2 3 4 5
         * 1 2 3 4 5
         *
         * จากตัวอย่าง 2D Array นี้ สามารถกล่าวได้ว่า
         * - มีขนาดในมิติที่ 1 เท่ากับ 3 หรือเราจะเรียกว่า array นี้มี 3 แถว หรือ 3 row
         * - มีขนาดในมิติที่ 2 เท่ากับ 5 หรือเราจะเรียกว่า array นี้มี 5 หลัก หรือ 5 columns
         *
         * ถ้าจะประกาศตัวแปร 2D array ขนาด 3 แถว x 5 หลัก สามารถเขียน code ได้ดังนี้
         * int[,] my2DArray = new int[3, 5];
         */
        public void LCT05_Syntax2DArray()
        {
            int[,] my2DArray = new int[3, 3]
            {//col 1 2 3
             //col 0 1 2
                  {1,2,3},
                  { 4,5,6},
                  { 7,8,9},
            };

            for (int row = 0; row < my2DArray.GetLength(0); row++)
            {
                string rowStr = "";
                for (int col = 0; col < my2DArray.GetLength(1); col++)
                {
                    rowStr += my2DArray[row, col];
                }
                Debug.Log(rowStr);
            }
        }

        /*
         * จงเขียนโปรแกรมภาษา C# เพื่อเข้าถึงขนาดของ Array สองมิติ (2D array)
         * โดยกำหนดมีตัวแปรให้ดังนี้
         *
         * public Grid2DInt lct06_my2DArray;
         *
         * เนื่องจาก Unity ไม่รองรับการแสดงผล int[,] (rectangular 2D array) บน Inspector โดยตรง
         * ตัวแปร lct06_my2DArray จึงถูกเก็บด้วย class Grid2DInt แทน ซึ่งสามารถกรอกค่าเป็นตาราง (grid)
         * ได้จากหน้า Inspector ตรงๆ เมื่อจะนำไปใช้งานเป็น 2D array จริงๆ ให้เรียก
         *
         * int[,] arr = lct06_my2DArray.Get2DArray();
         *
         * เมื่อเปรียบเทียบกับ 1D Array หรือ อาร์เรย์ 1 มิติ ซึ่งเราสามารถหาขนาดของ array โดยใช้ array.Length
         *
         * เมื่อเราทำงานกับ 2D array เราก็สามารถหาขนาดของ array ได้เช่นกัน เพียงแต่เราจะต้องระบุว่าต้องการขนาดของมิติใดโดยใช้
         *
         * function array.GetLength(0) เพื่อหาขนาดของมิติที่ 1 หรือจำนวนแถว (row)
         * และ function array.GetLength(1) เพื่อหาขนาดของมิติที่ 2 หรือจำนวนหลัก (col)
         *
         * เสร็จแล้วให้ Log ออกมาดังนี้
         * Debug.Log($"rows = {rows}");
         * Debug.Log($"cols = {cols}");
         *
         * พารามิเตอร์:
         * - lct06_my2DArray: อาร์เรย์ 2 มิติ (2D array) แก้ไขค่าได้จาก Inspector
         */
        [Header("LCT06_SizeOf2DArray")]
        public int[,] LCT062DArray;
            public Grid2DInt lct06_my2DArray = new Grid2DInt
            {
                rows = 3,
                cols = 5,
                data = new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 }
            };
            public void LCT06_SizeOf2DArray()
            { 
            int[,] my2DArray = lct06_my2DArray.Get2DArray();

            int rows = my2DArray.GetLength(0);
            int cols = my2DArray.GetLength(1);
            int size = my2DArray.Length;

            Debug.Log("rows " + rows);
            Debug.Log("cols " + cols);
            Debug.Log("size " + size);
            }

            /*
             * จงเขียนโปรแกรมภาษา C# เพื่อแสดงผลลัพธ์ดังภาพต่อไปนี้ โดยใช้ Nested loop
             * โดยกำหนดให้ มีตัวแปรดังนี้
             * 
             * public int columns = 3;
             * public int rows = 4;
             * 
             * ตัวอย่างหน้าตาของ Nested Loop
             * for (int i = 0; i < 4; i++)
             * {
             *     for (int j = 0; j < 3; j++)
             *     {
             *        
             *     }
             * }
             * 
             * ตัวอย่างการ run program:
             * 
             * Case 1
             * Column ...
             * 3
             * Row ...
             * 4
             * ***
             * ***
             * ***
             * ***
             * 
             * Case 2
             * Column ...
             * 10
             * Row ...
             * 1
             * **********
             * 
             * Case 3
             * Column ...
             * 10
             * Row ...
             * 10
             * **********
             * **********
             * **********
             * **********
             * **********
             * **********
             * **********
             * **********
             * **********
             * **********
             * 
             * Nested Loop หรือ ลูปซ้อน คือ การนำลูปหนึ่งมาซ้อนอยู่ภายในอีกหนึ่งลูป ทำให้เกิดการวนซ้ำซ้อนกันหลายชั้น ลองนึกภาพเหมือนกล่องใส่กล่องอีกทีหนึ่ง ซึ่งกล่องชั้นในจะวนซ้ำหลายรอบก่อนที่กล่องชั้นนอกจะเปลี่ยนไปหนึ่งรอบ
             * 
             * ทำไมต้องใช้ Nested Loop?
             * - จัดการข้อมูลหลายมิติ: เหมาะสำหรับข้อมูลที่จัดเรียงเป็นตาราง หรือมีโครงสร้างที่ซับซ้อน เช่น อาร์เรย์สองมิติ
             * - สร้างรูปแบบที่ซ้ำซ้อน: ใช้สร้างรูปแบบต่างๆ เช่น ตารางสูตรคูณ, รูปทรงเรขาคณิต
             * - แก้ปัญหาที่ซับซ้อน: สามารถนำไปใช้แก้ปัญหาที่ต้องทำการวนซ้ำหลายชั้น
             * 
             * ตัวอย่าง:
             * สมมติว่าเราต้องการพิมพ์ตารางสูตรคูณตั้งแต่ 1 คูณ 1 ถึง 5 คูณ 5 เราสามารถใช้ Nested Loop ได้ดังนี้:
             * 
             * for (int i = 1; i <= 5; i++) // ลูปหลัก (วนซ้ำแถว)
             * {
             *     for (int j = 1; j <= 5; j++) // ลูปซ้อน (วนซ้ำคอลัมน์)
             *     {
             *         Console.Write(i * j + " ");
             *     }
             *     Console.WriteLine();
             * }
             *
             * พารามิเตอร์:
             * - columns: จำนวนคอลัมน์ (หลัก)
             * - rows: จำนวนแถว
             */
            [Header("LCT07_SyntaxNestedLoop")]
            public int lct07_columns;
            public int lct07_rows;
            public void LCT07_SyntaxNestedLoop()
            {
                throw new System.NotImplementedException();
            }

            #endregion

        private void PrintBoard(string[,] board)
        {
            StringBuilder sb = new();
            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine("-------------");
                sb.AppendLine("| " + board[i, 0] + " | " + board[i, 1] + " | " + board[i, 2] + " |");
            }
            sb.AppendLine("-------------");
            Debug.Log(sb.ToString());
        }
    }

}
