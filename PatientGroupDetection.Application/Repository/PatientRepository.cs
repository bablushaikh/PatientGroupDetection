using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientGroupDetection.Application.Repository
{
    public class PatientRepository
    {

        List<string> patientIndexs = new List<string>() { };
        List<string> nonPatientIndexs = new List<string>() { };
        bool isElementExist = false;
        public int GetPatientGroupCount(int[][] Matrix)
        {
            int count = 0;
            for(int i = 0; i<Matrix.Length;i++)
            {
                for (int j = 0; j < Matrix.Length; j++)
                {
                    string matrixIndex=string.Concat(i,j);
                    if(!(patientIndexs.Contains(matrixIndex) || nonPatientIndexs.Contains(matrixIndex)))
                    {
                        patientIndexs.Add(matrixIndex);
                        Console.WriteLine(Matrix[i][j]);
                        if (Matrix[i][j] == 1)
                        {
                            CheckPatientExistance(i, j, Matrix);
                            count++;
                        }
                    }
                   
                }
                    
            }
            return count;
        }
        private void CheckPatientExistance(int p,int q,int[][] Matrix)
        {
            var matrixElementIndex = string.Concat(p, q + 1);
            isElementExist = isMatrixElementExist(Matrix, p, q + 1);
            if(isElementExist == true)
            {
                if (Matrix[p][q + 1] == 1)
                {
                    if (!(patientIndexs.Contains(matrixElementIndex) || nonPatientIndexs.Contains(matrixElementIndex)))
                    {
                        patientIndexs.Add(matrixElementIndex);
                        CheckPatientExistance(p, q + 1, Matrix);
                    }
                }
                else
                {
                    nonPatientIndexs.Add(matrixElementIndex);
                }
            }
            matrixElementIndex = string.Concat(p + 1, q);
            isElementExist = isMatrixElementExist(Matrix, p + 1, q);
            if(isElementExist == true)
            {
                if (Matrix[p + 1][q] == 1)
                {
                    if (!(patientIndexs.Contains(matrixElementIndex) || nonPatientIndexs.Contains(matrixElementIndex)))
                    {
                        patientIndexs.Add(matrixElementIndex);
                        CheckPatientExistance(p, q + 1, Matrix);
                    }
                }
                else
                {
                    nonPatientIndexs.Add(matrixElementIndex);
                }
            }
            
            matrixElementIndex = string.Concat(p + 1, q + 1);
            isElementExist = isMatrixElementExist(Matrix, p + 1, q + 1);
            if(isElementExist == true)
            {
                if (Matrix[p + 1][q + 1] == 1)
                {
                    if (!(patientIndexs.Contains(matrixElementIndex) || nonPatientIndexs.Contains(matrixElementIndex)))
                    {
                        patientIndexs.Add(matrixElementIndex);
                        CheckPatientExistance(p, q + 1, Matrix);
                    }
                }
                else
                {
                    nonPatientIndexs.Add(matrixElementIndex);
                }
            }
            
        }
        public bool isMatrixElementExist(int[][] Matrix, int row, int column)
        {
            if (row<Matrix.Length && column < Matrix.Length)
            {
                return true;
            }
            return false;
        }
    }
}
