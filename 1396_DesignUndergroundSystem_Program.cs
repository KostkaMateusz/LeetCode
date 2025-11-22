// https://leetcode.com/problems/design-underground-system/description/

public class UndergroundSystem
{
    private readonly Dictionary<int, (string, int)> _checkedIn = [];

    private readonly Dictionary<(string, string), int[]>
        _timeBetwenStations = []; //station in station out , count , time sum


    public UndergroundSystem()
    {
    }

    public void CheckIn(int id, string stationName, int t)
    {
        _checkedIn[id] = (stationName, t);
    }

    public void CheckOut(int id, string stationName, int t)
    {
        (string, int) originStationAndTime = _checkedIn[id];

        int timeDiff = t - originStationAndTime.Item2;

        if (_timeBetwenStations.TryGetValue((originStationAndTime.Item1, stationName), out int[] timeBetwenStations))
        {
            timeBetwenStations[0] += 1;
            timeBetwenStations[1] += timeDiff;
        }
        else
        {
            _timeBetwenStations.Add((originStationAndTime.Item1, stationName), [1, timeDiff]);
        }
    }

    public double GetAverageTime(string startStation, string endStation)
    {
        int[] travelTime = _timeBetwenStations[(startStation, endStation)];

        return (double)travelTime[1] / travelTime[0];
    }
}
