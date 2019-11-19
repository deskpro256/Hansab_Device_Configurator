/************************************************************************************************
Filename:	Program.cs
Author:		Microchip Technology Inc.
Compiler:	Microsoft C# 2010
Copyright © 2012 released Microchip Technology Inc.  All rights reserved.
MCHP License:
	MICROCHIP SOFTWARE NOTICE AND DISCLAIMER:  You may use this software, and any 
	derivatives created by any person or entity by or on your behalf, exclusively 
	with Microchip’s products.  Microchip and its licensors retain all ownership 
	and intellectual property rights in the accompanying software and in all 
	derivatives hereto.  
	This software and any accompanying information is for suggestion only.  It does 
	not modify Microchip’s standard warranty for its products.  You agree that you 
	are solely responsible for testing the software and determining its suitability.  
	Microchip has no obligation to modify, test, certify, or support the software.
	THIS SOFTWARE IS SUPPLIED BY MICROCHIP "AS IS".  NO WARRANTIES, WHETHER EXPRESS, 
	IMPLIED OR STATUTORY, INCLUDING, BUT NOT LIMITED TO, IMPLIED WARRANTIES OF 
	NON-INFRINGEMENT, MERCHANTABILITY, AND FITNESS FOR A PARTICULAR PURPOSE APPLY TO 
	THIS SOFTWARE, ITS INTERACTION WITH MICROCHIP’S PRODUCTS, COMBINATION WITH ANY 
	OTHER PRODUCTS, OR USE IN ANY APPLICATION. 
	IN NO EVENT, WILL MICROCHIP BE LIABLE, WHETHER IN CONTRACT, WARRANTY, TORT 
	(INCLUDING NEGLIGENCE OR BREACH OF STATUTORY DUTY), STRICT LIABILITY, INDEMNITY, 
	CONTRIBUTION, OR OTHERWISE, FOR ANY INDIRECT, SPECIAL, PUNITIVE, EXEMPLARY, 
	INCIDENTAL OR CONSEQUENTIAL LOSS, DAMAGE, FOR COST OR EXPENSE OF ANY KIND WHATSOEVER 
	RELATED TO THE SOFTWARE, HOWSOEVER CAUSED, EVEN IF MICROCHIP HAS BEEN ADVISED OF THE 
	POSSIBILITY OR THE DAMAGES ARE FORESEEABLE.  TO THE FULLEST EXTENT ALLOWABLE BY LAW, 
	MICROCHIP'S TOTAL LIABILITY ON ALL CLAIMS IN ANY WAY RELATED TO THIS SOFTWARE WILL 
	NOT EXCEED THE AMOUNT OF FEES, IF ANY, THAT YOU HAVE PAID DIRECTLY TO MICROCHIP 
	FOR THIS SOFTWARE.
	MICROCHIP PROVIDES THIS SOFTWARE CONDITIONALLY UPON YOUR ACCEPTANCE OF THESE TERMS.
Other License's:
	none
************************************************************************************************/

using System;
using System.Linq;
using System.Windows.Forms;
using SimpleIO;

namespace SimpleIO_M_CSExampleCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SimpleIOClass.InitMCP2200(0x04d8, 0x00df);
            timer1.Interval = 200;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool connStatus = SimpleIOClass.IsConnected();
            if( connStatus )
            {
                lblConnStatus.Text = "Connected";
            }
            else
            {
                lblConnStatus.Text = "NOT Connected";
            }
        }

        
    }
}
