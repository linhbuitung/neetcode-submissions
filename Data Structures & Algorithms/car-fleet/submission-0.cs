public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var timeArrives = position
            .Select((pos, i) => (pos, spe: speed[i]))
            .OrderBy(x => x.pos)
            .Select(x => (float)(target - x.pos) / x.spe)
            .ToList();

        var timeArriveStack = new Stack<float>(timeArrives);

        var fleetTimeArrive = timeArriveStack.Pop();
        var fleetNum = 1;
        while (timeArriveStack.Count > 0)
        {
            var peekValue = timeArriveStack.Peek();
            if (peekValue > fleetTimeArrive)
            {
                fleetTimeArrive = peekValue;
                fleetNum++;
            }

            timeArriveStack.Pop();
        }
        
        return fleetNum;
    }
}
