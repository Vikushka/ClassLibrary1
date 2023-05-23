namespace ClassLibrary1
{
    public class Class1
    {
        public class Calculation
        {
            /// <summary>
            /// рассчитывает свободные промежутки времени сотрудников
            /// </summary>
            /// <param name="startTimes"> начало </param>
            /// <param name="durations"> продолжительность </param>
            /// <param name="beginWorkingTime"> начало рабочего времени </param>
            /// <param name="endWorkingTime"> конец рабочего времени </param>
            /// <param name="consultationTime"> время на консультацию</param>
            /// <returns> список свободных временных интервалов в графике сотрудника</returns>
            public static string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime,
                TimeSpan endWorkingTime, int consultationTime)
            {
                string[] h = Rabota(beginWorkingTime, endWorkingTime, consultationTime);


                return h;
            }

            private static string[] Rabota(TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
            {
               
            }
        }
    }
}