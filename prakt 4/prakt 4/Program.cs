using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            int power = 3;

            int[,] result = MatrixPower(matrix, power);

            Console.WriteLine("Матрица, возведенная в степень {0}:", power);
            PrintMatrix(result);
        }

        static int[,] MatrixPower(int[,] matrix, int power)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
                    
            for (int i = 0; i < matrix.GetLength(0); i++)      
            {    
                for (int j = 0; j < matrix.GetLength(1); j++)
                {                          
                    if (i == j)                           
                    {                              
                        result[i, j] = 1;                         
                    }                          
                    else                         
                    {                              
                        result[i, j] = 0;                      
                    }                   
                }               
            }          
            
            while (power > 0)           
            {            
                if (power % 2 == 1)                
                {                
                    result = MatrixMultiply(result, matrix);                  
                }
               
                matrix = MatrixMultiply(matrix, matrix);               
                power /= 2;               
            }            
            return result;
        }
        
        static int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)       
        {        
            int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            
            for (int i = 0; i < matrix1.GetLength(0); i++)           
            {           
                for (int j = 0; j < matrix2.GetLength(1); j++)               
                {
                    result[i, j] = int.MaxValue;
                    
                    for (int k = 0; k < matrix1.GetLength(1); k++)                   
                    {                    
                        result[i, j] = Math.Min(result[i, j], matrix1[i, k] + matrix2[k, j]);                       
                    }                   
                }               
            }                  
            return result;    
        }

        static void PrintMatrix(int[,] matrix)      
        {      
            for (int i = 0; i < matrix.GetLength(0); i++)           
            {          
                for (int j = 0; j < matrix.GetLength(1); j++)             
                {               
                    Console.Write(matrix[i, j] + " ");                   
                }               
                Console.WriteLine();                
            }            
        } 
    } 
}

