public class RunningActivity : Activity {
    private double _distance { get; set; }

    public RunningActivity(DateTime date, int duration, double distance) : base(date, duration) {
        _distance = distance;
    }

    public override double GetDistance() {
        return _distance;
    }

    public override double GetSpeed() {
        return GetDistance() / _duration * 60;
    }

    public override double GetPace() {
        return _duration / GetDistance();
    }
}
