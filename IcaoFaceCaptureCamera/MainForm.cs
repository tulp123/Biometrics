using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Devices;
using Neurotec.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcaoFaceCaptureCamera
{
    public partial class MainForm : Form
    {
        #region Private fields
        
        private NBiometricClient _biometricClient;
        private NSubject _subject ;
        private NFace _face;
        private NFace _segmentedFace;
        private NDeviceManager _deviceManager;

        private Dictionary<string, NFace> capturedFaces = new Dictionary<string, NFace>();
        
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainFormLoadAsync(object sender, EventArgs e)
        {
            _biometricClient = new NBiometricClient
            {
                BiometricTypes = NBiometricType.Face,
                UseDeviceManager = true,
                FacesCheckIcaoCompliance = true,
                FacesQualityThreshold = byte.Parse("0"),
            };

            await _biometricClient.InitializeAsync();

            if (!DesignMode)
            {
                try
                {
                    nViewZoomSlider1.View = fvPreview;
                    lblStatus.Text = string.Empty;
                    _deviceManager = _biometricClient.DeviceManager;
                    saveImageDialog.Filter = NImages.GetSaveFileFilterString();
                    UpdateCameraList();
                }
                catch (Exception ex)
                {
                    Utils.ShowException(ex);
                }
            }
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_biometricClient != null)
                _biometricClient.Cancel();
        }

        private void UpdateCameraList()
        {
            cbCameras.BeginUpdate();
            try
            {
                cbCameras.Items.Clear();
                foreach (NDevice device in _deviceManager.Devices)
                {
                    cbCameras.Items.Add(device);
                }

                if (_biometricClient.FaceCaptureDevice != null &&  cbCameras.Items.Count > 0)
                {
                    cbCameras.SelectedIndex = cbCameras.Items.IndexOf(_biometricClient.FaceCaptureDevice);
                }
            }
            finally
            {
                cbCameras.EndUpdate();
            }
        }

        private void EnableControls(bool capturing)
        {
            bool hasTemplate = !capturing && _subject != null && _subject.Status == NBiometricStatus.Ok;
            btnSaveImage.Enabled = hasTemplate;
            btnSaveTemplate.Enabled = hasTemplate;
            btnStart.Enabled = !capturing;
            btnRefreshList.Enabled = !capturing;
            btnStop.Enabled = capturing;
            cbCameras.Enabled = !capturing;
            btnForce.Enabled = capturing;
        }

        private void OnCapturingCompleted(NBiometricTask task)
        {
            var status = task.Status;
            if (task.Error != null)
                Utils.ShowException(task.Error);
            if (status == NBiometricStatus.Ok)
            {
                _segmentedFace = _subject.Faces[1];
                fvPreview.Face = _segmentedFace;
                icaoWarningView.Face = _segmentedFace;
                fvFront.Face = _segmentedFace;
                fvLeftRoll.Face = _segmentedFace;
                fvRightRoll.Face = _segmentedFace;
                fvLeftYaw.Face = _segmentedFace;
                fvRightYaw.Face = _segmentedFace;
                fvDownPitch.Face = _segmentedFace;
                fvUpPitch.Face = _segmentedFace;
            }

            lblStatus.Text = status.ToString();
            lblStatus.ForeColor = status == NBiometricStatus.Ok ? Color.Green : Color.Red;
            EnableControls(false);
        }

        private void BtnRefreshListClick(object sender, EventArgs e)
        {
            UpdateCameraList();
        }

        private void cbCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            _biometricClient.FaceCaptureDevice = cbCameras.SelectedItem as NCamera;
        }

        private async void BtnStartClickAsync(object sender, EventArgs e)
        {
            if (capturedFaces.Count == 7)
            {
                MessageBox.Show("All Faces captured.");
                return;
            }

            if (_biometricClient.FaceCaptureDevice == null)
            {
                MessageBox.Show(@"Please select camera from the list");
                return;
            }

            // Set face capture from stream
            _face = new NFace { CaptureOptions = NBiometricCaptureOptions.Stream };
            _subject = new NSubject();
            _subject.Faces.Add(_face);
            fvPreview.Face = _face;
            icaoWarningView.Face = _face;

            _biometricClient.FacesCheckIcaoCompliance = true;

            var task = _biometricClient.CreateTask(NBiometricOperations.Capture | NBiometricOperations.Segment | NBiometricOperations.CreateTemplate, _subject);
            /*var task = _biometricClient.CreateTask(NBiometricOperations.Capture | NBiometricOperations.Segment, _subject);*/
             lblStatus.Text = string.Empty;
            EnableControls(true);
            try
            {
                var performedTask = await _biometricClient.PerformTaskAsync(task);
                OnCapturingCompleted(performedTask);
            }
            catch (Exception ex)
            {
                Utils.ShowException(ex);
                lblStatus.Text = string.Empty;
                EnableControls(false);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _biometricClient.Cancel();
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            _biometricClient.Force();
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            if (saveTemplateDialog.ShowDialog() == DialogResult.OK)
            {
                var tmp = _subject.GetTemplateBuffer().ToArray();
                File.WriteAllBytes(saveTemplateDialog.FileName, _subject.GetTemplateBuffer().ToArray());
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                _segmentedFace.Image.Save(saveImageDialog.FileName);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fvPreview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbFaceTypes_Enter(object sender, EventArgs e)
        {

        }

        private void fvUpPitch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nViewZoomSlider1_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}