using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientGroupDetection.Application.Repository
{
    public class PatientRepository
    {
        public int GetPatientGroupCount(int[][] Matrix)
        {
            
            for(int i = 0; i<Matrix.Length;i++)
            {
                for (int j = 0; j < Matrix.Length; i++)
                {
                    Console.WriteLine(Matrix[i][j]);
                    if(Matrix[i][j]== 1)
                    {

                    }
                }
                    
            }
            return 0;
        }
        private void CheckPatientExistance()
        {

        }
    }
}
