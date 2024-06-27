using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLight.Properties;

namespace TrafficLight
{

    public partial class ctrlTrafficLight : UserControl
    {
        #region Control init
        public ctrlTrafficLight()
        {
            InitializeComponent();
            _CurrentLight = enTrafficLight.Red;
        }
        public enum enTrafficLight { Red, Yellow, Green }
        private enTrafficLight _CurrentLight = enTrafficLight.Red;
        public enTrafficLight CurrentLight
        {
            get { return _CurrentLight; }
            set
            {
                _CurrentLight = value;
                switch (_CurrentLight)
                {
                    case enTrafficLight.Red:
                        pbTrafficLight.Image = Resources.red_light_red;
                        lblTimer.Text = _RedTime.ToString();
                        break;
                    case enTrafficLight.Yellow:
                        pbTrafficLight.Image = Resources.traffic_light_yellow;
                        lblTimer.Text = _YellowTime.ToString();
                        break;
                    case enTrafficLight.Green:
                        pbTrafficLight.Image = Resources.traffic_light_green;
                        lblTimer.Text = _GreenTime.ToString();
                        break;
                }
            }
        }

        private int _RedTime = 10;
        private int _YellowTime = 5;
        private int _GreenTime = 3;
        
        public int RedTime { get { return _RedTime; } set {  _RedTime = value; _UpdateTimerLable(); } }
        public int YellowTime { get { return _YellowTime; } set { _YellowTime = value; _UpdateTimerLable(); } }
        public int GreenTime {  get { return _GreenTime; } set { _GreenTime = value; _UpdateTimerLable(); } }

        void _UpdateTimerLable()
        {
            switch (_CurrentLight) {
                case enTrafficLight.Red:
                    lblTimer.Text = _RedTime.ToString();
                    break;
                case enTrafficLight.Green:
                    lblTimer.Text= _GreenTime.ToString();
                    break;
                case enTrafficLight.Yellow:
                    lblTimer.Text = _YellowTime.ToString();
                    break;
            }
        }
        #endregion

        #region Events
        public class OnTrafficColorChangeEventArgs : EventArgs
        {
            public int TrafficLightSeconds { get; }
            public enTrafficLight CurrentColor { get; }
            public OnTrafficColorChangeEventArgs(int trafficLightSeconds, enTrafficLight currentColor)
            {
                TrafficLightSeconds = trafficLightSeconds;
                CurrentColor = currentColor;
            }   
        }

        public event EventHandler<OnTrafficColorChangeEventArgs> RedOn;
        public void RaisRedOn()
        {
            RaisRedOn(new OnTrafficColorChangeEventArgs(_RedTime, _CurrentLight));
        }
        protected virtual void RaisRedOn(OnTrafficColorChangeEventArgs e)
        {
            RedOn?.Invoke(this, e);
        }



        public event EventHandler<OnTrafficColorChangeEventArgs> GreenOn;
        public void RaisGreenOn()
        {
            RaisGreenOn(new OnTrafficColorChangeEventArgs(_GreenTime, _CurrentLight));
        }
        protected virtual void RaisGreenOn(OnTrafficColorChangeEventArgs e)
        {
            GreenOn?.Invoke(this, e);
        }

        public event EventHandler<OnTrafficColorChangeEventArgs> YellowOn;
        public void RaisYellowOn()
        {
            RaisYellowOn(new OnTrafficColorChangeEventArgs(_YellowTime, _CurrentLight));
        }
        protected virtual void RaisYellowOn(OnTrafficColorChangeEventArgs e)
        {
            YellowOn?.Invoke(this, e);
        }

        #endregion
        public int GetCurrentTime()
        {
            switch(_CurrentLight)
            {
                case enTrafficLight.Red:
                    return _RedTime;
                case enTrafficLight.Green:
                    return _GreenTime;
                case enTrafficLight.Yellow:
                    return _YellowTime;
                default:
                    return _RedTime;
            }

        }
        int _Counter { get; set; }
        public void Start()
        {
            _Counter = GetCurrentTime();
            timer1.Enabled = true;
        }
        void _ChangeTrafficLight()
        {
            switch (_CurrentLight) 
            {
                case enTrafficLight.Red:
                    CurrentLight = enTrafficLight.Green;
                    _Counter = _GreenTime;
                    RaisGreenOn();
                    break;
                case enTrafficLight.Green:
                    CurrentLight = enTrafficLight.Yellow;
                    _Counter = _YellowTime;
                    RaisYellowOn();
                    break;
                case enTrafficLight.Yellow:
                    CurrentLight = enTrafficLight.Red;
                    _Counter = _RedTime;
                    RaisRedOn();
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = _Counter.ToString();
            if (_Counter > 0)
            {
                _Counter--;
            }
            else
                _ChangeTrafficLight();
        }
    }
}
