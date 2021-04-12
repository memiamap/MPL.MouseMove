using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MPL.MouseMove
{
    /// <summary>
    /// A class that defines the main form for the application.
    /// </summary>
    internal partial class MainForm : Form
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        internal MainForm()
        {
            InitializeComponent();
            Initialise();
        }

        #endregion

        #region Declarations
        #region _Members_
        private MouseMoveService _service;
        private MouseMoveSettings _serviceSettings;

        #endregion
        #endregion

        #region Methods
        #region _Private_
        private void Display()
        {
            if (InvokeRequired)
                _ = Invoke(new MethodInvoker(delegate () { Display(); }));
            else
            {
                bool isRunning = GetIsRunning();

                FileMenu_Start.Enabled = !isRunning;
                FileMenu_Stop.Enabled = isRunning;
                ToolsMenu_Options.Enabled = !isRunning;
                StartStopButton.Text = isRunning ? "Stop" : "Start";
            }
        }

        private void DoExit()
        {
            Close();
        }

        private void DoStart()
        {
            if (!GetIsRunning())
            {
                _service = new MouseMoveService(_serviceSettings.DelayMS);
                _service.Start();
            }

            Display();
        }

        private void DoShowOptions()
        {
            OptionsForm optionsForm;

            optionsForm = new OptionsForm(_serviceSettings);
            if (optionsForm.ShowDialog(this) == DialogResult.OK)
                _serviceSettings.SaveSettings();
        }

        private void DoStop()
        {
            if (GetIsRunning())
                _service.Stop();

            Display();
        }

        private void DoStartStop()
        {
            if (GetIsRunning())
                DoStop();
            else
                DoStart();
        }

        private void DoVisitLink()
        {
            Process.Start(Link.Text);
        }

        private bool GetIsRunning()
        {
            return _service != null && _service.IsRunning;
        }

        private void Initialise()
        {
            // Objects
            _serviceSettings = MouseMoveSettings.FromSavedSettings();

            // Events
            FormClosing += Form_FormClosing;
            Load += Form_Load;
            FileMenu_Exit.Click += FileMenu_Exit_Click;
            FileMenu_Start.Click += FileMenu_Start_Click;
            FileMenu_Stop.Click += FileMenu_Stop_Click;
            Link.LinkClicked += Link_LinkClicked;
            StartStopButton.Click += StartStopButton_Click;
            ToolsMenu_Options.Click += ToolsMenu_Options_Click;
        }

        #endregion
        #endregion

        #region Event Handlers
        #region _Button Events_
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            DoStartStop();
        }

        #endregion
        #region _Form Events_
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DoStop();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Display();
        }

        #endregion
        #region _LinkLabel Events_
        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoVisitLink();
        }

        #endregion
        #region _ToolStripMenuItem Events_
        private void FileMenu_Exit_Click(object sender, EventArgs e)
        {
            DoExit();
        }

        private void FileMenu_Start_Click(object sender, EventArgs e)
        {
            DoStart();
        }

        private void FileMenu_Stop_Click(object sender, EventArgs e)
        {
            DoStop();
        }

        private void ToolsMenu_Options_Click(object sender, EventArgs e)
        {
            DoShowOptions();
        }

        #endregion
        #endregion
    }
}