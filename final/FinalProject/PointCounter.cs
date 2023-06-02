using System;


public class PointCounter
{

    private double _points;

    public double GetPoints()
    {
        return _points;
    }

    public void CalculatePoints(int hidden, int correct, double time, int start, int end, int difficulty)
    {
        _points = ((correct * 100) /hidden) + ((1/time)*(Math.Pow(10,end-start))) + difficulty*30;
    }

}