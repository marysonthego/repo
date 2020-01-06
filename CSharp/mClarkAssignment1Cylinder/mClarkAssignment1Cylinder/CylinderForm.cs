﻿/// Class Name: mClarkAssignment1Cylinder.CylinderForm
/// Class Description: CylinderForm is the presentation layer of the Cylinder class. 
/// It contains the constructor for
/// the CylinderForm class and the event handlers for the controls on the form.
/// Developer Name: Mary Clark
/// Date Created: 9/9/2018
/// Date Last Modified: 9/9/2018
///
using System;
using System.Windows.Forms;

namespace mClarkAssignment1Cylinder
{
    public partial class CylinderForm : Form
    {
        /// 
        /// Class constructor for CylinderForm class.
        /// 
        public CylinderForm()
        {
            InitializeComponent();
        }
        ///
        /// Autogenerated method. Load the form.
        /// 
        private void CylinderForm_Load(object sender, EventArgs e)
        {

        }
        /// 
        /// Placeholder for the event handler invoked when the 
        /// user enters invalid data in the MaskedTextBox tboxRadiusMask
        /// 
        private void TboxRadiusMask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }
        /// 
        /// Placeholder for the event handler invoked when the 
        /// user enters invalid data in the MaskedTextBox tboxHeightMask
        /// 
        private void TboxHeightMask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        /// 
        /// Event handler for the btnArea control.
        /// When btnArea receives a click event:
        /// Convert the values in tboxRadiusMask and tboxHeightMask
        /// from strings to integers.
        /// Instantiate a new Cylinder object.
        /// Call myCylinder.CalcArea with 
        /// the radius and height expressed as integers.
        /// Populate the lblResult control on the Cylinder form
        /// with the result returned by myCylinder.CalcArea.
        /// 
        private void BtnArea_Click(object sender, EventArgs e)
        {
            Cylinder myCylinder = new Cylinder();
            lblResult.Text = myCylinder.CalcArea(Convert.ToInt32(tboxRadiusMask.Text), Convert.ToInt32(tboxHeightMask.Text)).ToString();

        }
        /// 
        /// Event handler for the btnVolume control.
        /// When btnVolume receives a click event:
        /// Convert the values in tboxRadiusMask and tboxHeightMask
        /// from strings to integers.
        /// Instantiate a new Cylinder object.
        /// Call myCylinder.CalcVolume with 
        /// the radius and height expressed as integers.
        /// Populate the lblResult control on the Cylinder form
        /// with the result returned by myCylinder.CalcVolume.
        /// 
        private void BtnVolume_Click(object sender, EventArgs e)
        {
            Cylinder myCylinder = new Cylinder();
            lblResult.Text = myCylinder.CalcVolume(Convert.ToInt32(tboxRadiusMask.Text), Convert.ToInt32(tboxHeightMask.Text)).ToString();

        }
        /// 
        /// btnExit event handler.
        /// Terminate the program.
        /// 
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
