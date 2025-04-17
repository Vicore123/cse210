public class CyclingActivity : Activity {
    public double _speed { get; set; }

    public CyclingActivity(DateTime date, int duration, double speed) : base(date, duration) {
        _speed = speed;
    }

    public override double GetDistance() {
        return _speed * _duration / 60;
    }
    public override double GetSpeed() {
        return _speed;
    }
    public override double GetPace() {
        return 60 / _speed;
    }
}
