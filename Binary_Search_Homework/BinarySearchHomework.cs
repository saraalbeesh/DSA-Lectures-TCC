using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            while(start<=end)
            {
                int mid1 = start + (end - start) / 3;
                int mid2 = end - (end - start) / 3;
                if (arr[mid1] ==key) 
                    return mid1;    
                if (arr[mid2] ==key)
                    return mid2;
                if (key < arr[mid1])
                    end=mid1-1;
                else if(key > arr[mid2])    
                    start=mid2+1;
                else
                {
                    start=mid1+1;
                    end=mid2-1;   
                }
            }
            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TOD: this methods is for getting the first accurence of the key and the last accurance
            if (start > end)
                return 0;
            int mid=start+(end-start) / 2;
            if (arr[mid] ==key)
            {
                if(is_first)
                {
                    if (mid == 0 || arr[mid-1]!=key)
                    {
                        return mid;
                    }    
                    else
                    {
                        return BinarySearchForCalculatingRepeated(arr, key, is_first, start, mid-1);  
                    }
                }
                else
                {
                    if(mid==arr.Length+1|| arr[mid-1]!=key)
                    {
                        return mid;

                    }
                    else
                    {
                        return BinarySearchForCalculatingRepeated(arr, key, is_first, mid + 1,end);
                    }
                }
            }
            else if (arr[mid] <key)
            {
                return BinarySearchForCalculatingRepeated(arr, key, is_first, mid + 1, end);
            }
            else
            {
                return BinarySearchForCalculatingRepeated(arr, key, is_first, start, mid - 1);
            }
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            int isfirst=BinarySearchForCalculatingRepeated(arr,key,true,0,arr.Length-1);
            if(isfirst==-1)  
                return isfirst;
            int islast = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);
            int counter = islast - isfirst + 1;
            return counter;
        }
    }
}
