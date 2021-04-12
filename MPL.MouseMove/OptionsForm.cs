using System;
using System.Windows.Forms;

namespace MPL.MouseMove
{
    /// <summary>
    /// A class that defines an options form for the application.
    /// </summary>
    internal partial class OptionsForm : Form
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of the class with the specified parameters.
        /// </summary>
        internal OptionsForm(MouseMoveSettings settings)
        {
            Settings = settings;

            InitializeComponent();
            Initialise();
        }

        #endregion

        #region Methods
        #region _Private_
        private void Display()
        {
            OkButton.Enabled = GetIsDirty();
        }

        private void DoCancel()
        {
            bool canClose = true;

            if (GetIsDirty())
            {
                DialogResult result;

                result = MessageBox.Show(this, "You have made unsaved changes to the settings.\r\n\r\nDo you want to save the changes before closing?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    canClose = false;
                    DoOK();
                }
                else if (result == DialogResult.Cancel)
                    canClose = false;
            }

            if (canClose)
                DoClose(DialogResult.Cancel);
        }

        private void DoClose(DialogResult result)
        {
            DialogResult = result;
            Close();
        }

        private void DoOK()
        {
            SaveData();
            DoClose(DialogResult.OK);
        }

        private bool GetIsDirty()
        {
            return (int)DelayMS.Value != Settings.DelayMS;
        }

        private void Initialise()
        {
            // Events
            Load += Form_Load;
            CancelChangesButton.Click += CancelChangesButton_Click;
            DelayMS.KeyUp += DelayMS_KeyUp;
            DelayMS.ValueChanged += DelayMS_ValueChanged;
            OkButton.Click += OkButton_Click;
        }

        private void LoadData()
        {
            DelayMS.Value = Settings.DelayMS;
        }

        private void SaveData()
        {
            Settings.DelayMS = (int)DelayMS.Value;
        }

        #endregion
        #endregion

        #region Event Handlers
        #region _Button Events_
        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            DoCancel();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DoOK();
        }

        #endregion
        #region _Form Events_
        private void Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion
        #region _NumericUpDown Events_
        private void DelayMS_KeyUp(object sender, KeyEventArgs e)
        {
            Display();
        }

        private void DelayMS_ValueChanged(object sender, EventArgs e)
        {
            Display();
        }

        #endregion
        #endregion

        #region Properties
        /// <summary>
        /// Gets the settings.
        /// </summary>
        internal MouseMoveSettings Settings { get; }

        #endregion
    }
}