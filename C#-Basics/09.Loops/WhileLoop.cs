namespace Loops.WhileLoop
{
    class WhileLp
    {
        public static void WhileLoopDemo()
        {
            Console.WriteLine("Elevator is starting...");

            // 1. The Start
            int currentFloor = 1;
            int targetFloor = 5;

            // 2. The Condition (Keep going while we haven't reached the target)
            while (currentFloor <= targetFloor)
            {
                Console.WriteLine("Ding! You are on floor: " + currentFloor);

                // 3. The Update (Move up one floor)
                // If we forget this line, we will be stuck on floor 1 forever!
                currentFloor++;
            }

            // This only runs AFTER the loop is completely finished.
            Console.WriteLine("You have arrived at the top floor. Doors opening!");

        }
    }
}