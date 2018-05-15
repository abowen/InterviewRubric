using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewRubric.Shared.Enums
{
    public static class Enum<T>
    {
        public static IEnumerable<T> GetEnums()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
