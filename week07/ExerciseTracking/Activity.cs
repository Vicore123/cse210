using System;

public abstract class Activity {
    protected DateTime _date { get; set; }
    protected int _duration { get; set; }

    public Activity(DateTime date, int duration) {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary() {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_duration} min) - " +
               $"Distance {GetDistance():F1}, Speed {GetSpeed():F1}, Pace: {GetPace():F2}";
    }
}
