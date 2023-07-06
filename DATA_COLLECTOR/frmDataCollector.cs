using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace DATA_COLLECTOR
{
    public partial class frmDataCollector : Form
    {
        #region 전역
        private ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);  // Logger 선언
        #endregion

        public frmDataCollector()
        {
            InitializeComponent();
        }

        #region Form Event

        /// <summary>
        /// Form Load Event
        /// Form Loading 시 Control 초기 속성 Setting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDataCollector_Load(object sender, EventArgs e)
        {
            log.Info("---------------- Start App ----------------");

            // Richtextbox 속성 값 Setting
            rtbLogging.BackColor = System.Drawing.Color.White;
            rtbLogging.BorderStyle = BorderStyle.None;
            rtbLogging.HideSelection = false;
            rtbLogging.ReadOnly = true;
            rtbLogging.Text = "";
            rtbLogging.WordWrap = false;
            rtbLogging.Font = new Font(FontFamily.GenericMonospace, 9);

        }

        /// <summary>
        /// TextBox Log 입력 후 Enter Key로 입력 시 TextBox 입력 값 Logging
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxLog_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fnclogging(tboxLog.Text);
            }
        }

        /// <summary>
        /// Logging Button Click 시 TextBox 입력 값 Logging
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogging_Click(object sender, EventArgs e)
        {
            fnclogging(tboxLog.Text);
        }

        #endregion


        #region Inner Function

        /// <summary>
        /// Radio Button에 선택 된 Level과 log4net setting 값을 기준으로 Logging 하는 부분
        /// </summary>
        /// <param name="strLoggingData"></param>
        private void fnclogging(string strLoggingData)
        {
            if (rdoInfo.Checked)
            {
                log.Info(strLoggingData);
            }
            else if (rdoDebug.Checked)
            {
                log.Debug(strLoggingData);
            }
            else if (rdoWarn.Checked)
            {
                log.Warn(strLoggingData);
            }
            else if (rdoError.Checked)
            {
                log.Error(strLoggingData);
            }
            else if (rdoFatal.Checked)
            {
                log.Fatal(strLoggingData);
            }
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
