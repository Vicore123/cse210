public class SwimmingActivity : Activity {
    public int Laps { get; set; }

    public SwimmingActivity(DateTime date, int duration, int laps) : base(date, duration) {
        Laps = laps;
    }

    public override double GetDistance() {
        return Laps * 50 / 1000.0;
    }

    public override double GetSpeed() {
        return GetDistance() / _duration * 60;
    }

    public override double GetPace() {
        return _duration / GetDistance();
    }
}
