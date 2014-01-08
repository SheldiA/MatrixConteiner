using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMatrix
{
    class TMatrix
    {
        private double[,] matrix;
        public int size;
        public TMatrix(int size)
        {
            matrix = new double[size,size];
            this.size = size;
            FillMatrix();
        }

        public double this[int i,int j]
        {
            get
            {
                if (i < size && j < size)
                    return matrix[i, j];
                else
                    throw new IndexOutOfRangeException("Index should be less than " + size);
            }
            set
            {
                if (i < size && j < size)
                    matrix[i, j] = value;
                else
                    throw new IndexOutOfRangeException("Index should be less than " + size);
            }
        }

        public void Transpose()
        {
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < i; ++j)
                    Swap(ref matrix[i,j],ref matrix[j,i]);
        }

        public static TMatrix operator *(TMatrix a,TMatrix b)
        {
            TMatrix result = null;
            if (a.size == b.size)
            {
                result = new TMatrix(a.size);
                for (int i = 0; i < result.size; ++i)
                    for (int j = 0; j < result.size; ++j)
                    {
                        result[i, j] = 0;
                        for (int r = 0; r < result.size; ++r)
                            result[i, j] += a[i, r] * b[r, j];
                    }
            }
            return result;
        }

        private void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        private void FillMatrix()
        {
            Random random = new Random();
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    matrix[i, j] = random.Next(0,10);
        }
    }
}
