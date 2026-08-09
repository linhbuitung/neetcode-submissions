public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var times = position
            .Select((pos, i) => (pos, spe: speed[i]))
            .OrderByDescending(c => c.pos)
            .Select(c => (float)(target - c.pos) / c.spe)
            .ToList();

        int fleets = 0;
        float lastTime = 0;

        foreach (var t in times)
        {
            if (t > lastTime)
            {
                fleets++;
                lastTime = t;
            }
        }

        return fleets;
    }
}
