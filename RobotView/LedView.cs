//------------------------------------------------------------------------------
// C #   I N   A C T I O N   ( C S A )
//------------------------------------------------------------------------------
// Repository:
//    $Id: LedView.cs 1162 2017-11-14 13:00:20Z chj-hslu $
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{

    /// <summary>
    /// Diese Klasse visualisiert eine LED des Roboters
    /// </summary>
    public partial class LedView : UserControl
    {

        #region members
        private Led led;
        private bool state;
        #endregion


        #region constructor & destructor
        /// <summary>
        /// Der Konstruktor initialisiert nur das Control. Erst wenn per Led-Property eine Led dieser 
        /// View zugewiesen wird, funktioniert diese Led und kann den aktuellen Zustand anzeigen.
        /// </summary>
        public LedView()
        {
            InitializeComponent();
            State = false;
        }
        #endregion

        #region properties
        /// <summary>
        /// Liefert bzw. setzt das LED-Objekt (Model).
        /// Die LedView registriert sich beim Model und wird über Änderungen per Event informiert.
        /// </summary>
        public Led Led
        {
            get { return led; }
            set
            {
                // Falls bereits ein Eventhandler registriert war => diesen zuerst beim alten Led-Objekt entfernen
                if (led != null) led.LedStateChanged -= LedStateChanged;

                // Handler beim Led-Objekt (Model) registrieren.
                led = value;
                if (led != null) this.led.LedStateChanged += LedStateChanged;
            }
        }


        /// <summary>
        /// Liefert bzw. setzt den Zustand der LED (true => ein, false => aus)
        /// </summary>
        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                pictureBox1.Image = (value ? Resource.LedOn : Resource.LedOff);
            }
        }
        #endregion


        #region methods

        delegate void UpdateHelper(bool newLedState);
        private void UpdateLed(bool newLedState)
        {
            State = newLedState;
        }


        /// <summary>
        /// Dieser Eventhandler wird aufgerufen, wenn sich der Zustand der LED (Model) verändert hat. Somit
        /// kann die View den aktuellen Zustand anzeigen.
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LedStateChanged(object sender, LedEventArgs e)
        {
            //UpdateHelper uh = new UpdateHelper(UpdateLed);
            //Invoke(uh, e.LedEnabled);

            // Prüfen ob ID von diesem Thread = ID vom GUI Thread ist
            if (InvokeRequired)
            {
                // Thread ID's sind ungleich => muss synchronisiert werden
                EventHandler<LedEventArgs> del = new EventHandler<LedEventArgs>(LedStateChanged);
                // delegate unter dem Kontext vom GUI Thread aufrufen mit den Argumenten sender, e
                Invoke(del, sender, e);
            }
            else
            {
                State = e.LedEnabled;
            }
        }
        #endregion

    }
}
