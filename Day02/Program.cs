using static System.Console;
using Day02;
/*
var myArray = Arrays.InitArraysInt(new int[] { 10, 20, 30, 40, 50 });

var boys = Arrays.InitArraysString(new[] { "asep", "budi", "charlie" });

var arrRandom = Arrays.InitRandomArray(10);

Arrays.DisplayArrayInt(myArray);
WriteLine();
Arrays.DisplayArrayString(boys);

WriteLine();
var total = Arrays.SumAllElement(myArray);
Write($"Total :{total}");

WriteLine();
Arrays.DisplayArrayInt(arrRandom);
var largest = Arrays.FindLargestElement(arrRandom);
var indexOfLargest = Arrays.FindIndexLargest(arrRandom);
WriteLine($"Largest : {largest}");
WriteLine($"Index of Largest : {indexOfLargest}");
WriteLine();
Array.Sort(arrRandom);
WriteLine($"Found at index : {Array.BinarySearch(arrRandom, 25)}");
Arrays.DisplayArrayInt(arrRandom);
Array.Reverse(arrRandom);
WriteLine();

ReadLine();*/







/** QUIZ SOLUTION */

int[] n = { 15, 2, 30, 12, 10, 5 };
//No.1
/*WriteLine("Before Random Position");
Arrays.DisplayArrayInt(n);
WriteLine();
var randomArr = QuizSolution.RandomPosition(n);
WriteLine("After Random Position");
Arrays.DisplayArrayInt(randomArr);

WriteLine();
*/
//No.2
/*WriteLine("Before Shift Array");
Arrays.DisplayArrayInt(n);
var shiftArray = QuizSolution.ShiftArray(n);

WriteLine();
WriteLine("After Shift Array");
Arrays.DisplayArrayInt(shiftArray);
*/

// No 3
/*WriteLine("Array sebelum rotasi 3x");
Arrays.DisplayArrayInt(n);
var Rotate = QuizSolution.Rotate(n);
Console.WriteLine();
*/

//No. 4
/*WriteLine("Rotate Kanan 3x");
Arrays.DisplayArrayInt(n);
var RightRotate = QuizSolution.RightRotate(n);
Console.WriteLine();
*/

//No. 5
/*int[] m = { 5, 2, 30, 12, 10, 5, 2, 10, 5 };
Arrays.DisplayArrayInt(m);
Console.WriteLine();
var SumAngka = QuizSolution.SumAngka(m);
*/
//No. 7
/*int[] o = { 1, 2, 3, 2, 7, 7, 1, 6, 3, 4, 5, 2, 6, 8, 9 };
Arrays.DisplayArrayInt(o);
Console.WriteLine();
var Duplicate = QuizSolution.DuplicateArray(o);
Arrays.DisplayArrayInt(Duplicate);*/



//Matrix
/*Matrix.InitMatrix();
var myMatrix = Matrix.FillRandomMatrix(5, 5);
Matrix.DisplayMatrix(myMatrix);
WriteLine();
var matrixDiagonal = Matrix.MatrixDiagonal(5, 5);
Matrix.DisplayMatrix(matrixDiagonal);*/

/*var SumMatrixDiagonal = Matrix.SumMatrixDiagonal(5, 5);
Matrix.DisplayMatrix(SumMatrixDiagonal);
Console.WriteLine();
*/
//No 11
/*var Matrix7 = Matrix.soal11(7, 7);
Matrix.DisplayMatrix(Matrix7);
Console.WriteLine();
*/
var EmptyMid = Matrix.EmptyMidMatrix(7,7);
Matrix.DisplayMatrix(EmptyMid);
Console.WriteLine();



ReadLine();
