using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.NI4882;

namespace TestEquipment
{
    #region INTERFACES
    interface IPowerSupply
    {
        int On();
        int Off();
        int SetVoltage();
        int SetCurrent();
        double? ReadVoltage();
        double? ReadCurrent();
    }
    #endregion
    #region TEST EQUIPMENT BASE CLASS
    public class TestEquipment
    {
        #region PROPERTIES
        /* PROPERTIES */
        /// <summary>
        /// Gets or sets the Test Equipment Description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; protected set; }
        #endregion
        #region CONSTRUCTORS
        /* CONSTRUCTORS */
        public TestEquipment(string description = null)
        {
            this.Description = description;
        }
        #endregion
    }
    #endregion
    public abstract class GPIB_Controller : TestEquipment
    {
        #region METHODS
        /* METHODS */
        public abstract void Write(string command);
        public abstract string Read();
        #endregion
    }

    public class NationalInstrumentsGPIB : GPIB_Controller
    {
        #region PROPERTIES
        /* PROPERTIES */
        protected NationalInstruments.NI4882.Device Instrument { get; set; }
        #endregion

    }
}