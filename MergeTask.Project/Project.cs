namespace MergeTask.Project
{
    public static class Solution
    {
        #region Description
        ///<summary>
        ///Merge sort
        ///</summary>
        ///<param name="row">
        ///Row of integers
        ///</param>
        ///<param name="start">
        ///start index of row
        ///</param>
        ///<param name="end">
        ///end index of row
        ///</param>
        #endregion 
        public static void Sort(int[] row, int start, int end)
        {
            if (end - 1 > start)
            {
                int mid = (start + end) / 2;
                Sort(row, start, mid);
                Sort(row, mid, end);
                Merge(row, start, mid, end);
            }
        }
        static void Merge(int[] row, int start, int mid, int end)
        {
            int startPointer = 0;
            int midPointer = 0;
            int[] leftRow = row[start..mid];
            int[] rightRow = row[mid..end];
            for (int i = start; i < end; i++)
            {
                if (startPointer < mid - start && midPointer < end - mid)
                {
                    if (leftRow[startPointer] < rightRow[midPointer])
                    {
                        row[i] = leftRow[startPointer++];
                    }
                    else
                    {
                        row[i] = rightRow[midPointer++];
                    }
                }
                else if (startPointer >= mid - start)
                {
                    row[i] = rightRow[midPointer++];
                }
                else 
                {
                    row[i] = leftRow[startPointer++];
                }
            }
        }
    }
}