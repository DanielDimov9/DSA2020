using System;

namespace Lesson5
{
   internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        private static void MinMaxElements()
        {
            // Task: Find Min and Max elements in the array
            // ============================================
            // 1. Start
            // 2. Define min, max
            // 3. Read array
            // 4. min=array[0], max=array[0]
            // 5. For each element of the array
            //      5.1. If element < min
            //          min=element
            //      5.2. If element > max
            //          max=element
            // 6. Display min, max
            // 7. End
        }

        private static void AverageOfArray()
        {
            // Task: Calculate average value of the array items
            // ================================================
            // 1. Start
            // 2. Define sum, count, avg
            // 3. Read array
            // 4. For each element of the array
            //      4.1. sum = sum + element
            //      4.2. count++
            // 5. avg = sum / count
            // 6. Display avg
            // 7. End
        }

        private static void SwapArrayItems()
        {
            // Task: Swap 2 arrays items
            // {1, 2, 3, 4 } => swap 1 and 3 => {3, 2, 1, 4}
            // =============================================
            // 1. Start
            // 2. Define temp
            // 3. Read array
            // 4. Read index1 and index2
            // 5. temp = array[index1]
            // 6. array[index1] = array[index2]
            // 7. array[index2] = temp
            // 8. End
        }

        private static void StackPush()
        {
            // Task: Add element into Stack data structure, stack is relized by array
            // ======================================================================
            // 1. Start
            // 2. Define element, isAdded
            // 3. Read new element
            // 4. isAdded = false
            // 5. For each item in array
            //      If item is empty
            //          5.1.   item = element
            //          5.2.   isAdded = true
            // 6. Return isAdded
            // 7. End
        }

        private static void StackPop()
        {
            // Task: Remove element from Stack data structure, stack is relized by array
            // {1,2,3,null,null,null} ==> 3
            // =========================================================================
            // 1. Start
            // 2. Define output
            // 3. For each item in array
            //     If item is null
            //          3.1. output = array[item index -1]
            //          3.2. array[item index -1] = null
            //          3.3. Exit foreach loop
            // 4. Return output
            // 5. End
        }

        private static void AddBinaryTreeItem()
        {
            // Task: Add element into Binary tree
            // ==================================
            // 1. Start
            // 2. Read newValue
            // 3. Define and Set CurrentNode = RootNode
            // 4. Move to CurrentNode
            //      3.1. If CurrentNode.Value > newValue
            //          3.1.1. If CurrentNode.LeftNode == null
            //              Add newValue as CurrentNode.LeftNode
            //          3.1.2. If CurrentNode.LeftNode != null
            //              CurrentNode = CurrentNode.LeftNode
            //              GO TO 3
            //      3.2. If CurrentNode.Value < newValue
            //          3.2.1. If CurrentNode.RightNode == null
            //              Add newValue as CurrentNode.LeftNode
            //          3.2.2. If CurrentNode.RightNode != null
            //              CurrentNode = CurrentNode.RightNode
            //              GO TO 3
            // 5. End
        }
    }
}

