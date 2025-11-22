// https://leetcode.com/problems/design-parking-system/description/

public class ParkingSystem
{
    private readonly int[] _space = new int[4];

    public ParkingSystem(int big, int medium, int small)
    {
        _space[1] = big;
        _space[2] = medium;
        _space[3] = small;
    }

    public bool AddCar(int carType)
    {
        bool canBeParked = _space[carType] > 0;

        if (canBeParked)
            _space[carType]--;

        return canBeParked;
    }
}
