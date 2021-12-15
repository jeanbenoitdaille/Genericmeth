    using System;
    using System.Collections.Generic;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public T[] GetFirstAndLast<T>(List<T> list) where T : class
            {
                var result = new T[2];
                result[0] = list[0];
                result[1] = list[list.Count - 1];
                return result;
            }
        }
    }