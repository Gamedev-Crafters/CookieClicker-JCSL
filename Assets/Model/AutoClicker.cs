namespace Model
{
    public class AutoClicker
    {
        public int autoClick { get; set; }

        private float _autoClickTargetTime;
        private float _timePassed;

        public AutoClicker(float autoClickTargetTime)
        {
            _autoClickTargetTime = autoClickTargetTime;
        }

        public void UpdateTime(float deltaTime)
        {
            _timePassed += deltaTime;

            if (_timePassed >= _autoClickTargetTime)
            {
                float autoClicksAmount = _timePassed / _autoClickTargetTime;
                autoClick += (int)autoClicksAmount;
            }
        }
    }
}