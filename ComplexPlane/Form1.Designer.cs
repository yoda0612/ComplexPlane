namespace ComplexPlane
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImageShower = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MultiplyRe = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MultiplyIm = new System.Windows.Forms.TrackBar();
            this.PowerIm = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PowerRe = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.MultiplyReValue = new System.Windows.Forms.NumericUpDown();
            this.MultiplyImValue = new System.Windows.Forms.NumericUpDown();
            this.PowerImValue = new System.Windows.Forms.NumericUpDown();
            this.PowerReValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyIm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerIm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyReValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyImValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerImValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerReValue)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageShower
            // 
            resources.ApplyResources(this.ImageShower, "ImageShower");
            this.ImageShower.Name = "ImageShower";
            this.ImageShower.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MultiplyRe
            // 
            resources.ApplyResources(this.MultiplyRe, "MultiplyRe");
            this.MultiplyRe.Name = "MultiplyRe";
            this.MultiplyRe.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MultiplyRe.Scroll += new System.EventHandler(this.MultiplyRe_Scroll);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // MultiplyIm
            // 
            resources.ApplyResources(this.MultiplyIm, "MultiplyIm");
            this.MultiplyIm.Name = "MultiplyIm";
            this.MultiplyIm.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MultiplyIm.Scroll += new System.EventHandler(this.MultiplyIm_Scroll);
            // 
            // PowerIm
            // 
            resources.ApplyResources(this.PowerIm, "PowerIm");
            this.PowerIm.Name = "PowerIm";
            this.PowerIm.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PowerIm.Scroll += new System.EventHandler(this.PowerIm_Scroll);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // PowerRe
            // 
            resources.ApplyResources(this.PowerRe, "PowerRe");
            this.PowerRe.Name = "PowerRe";
            this.PowerRe.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PowerRe.Scroll += new System.EventHandler(this.PowerRe_Scroll);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // MultiplyReValue
            // 
            this.MultiplyReValue.DecimalPlaces = 3;
            this.MultiplyReValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.MultiplyReValue, "MultiplyReValue");
            this.MultiplyReValue.Name = "MultiplyReValue";
            this.MultiplyReValue.ValueChanged += new System.EventHandler(this.MultiplyReValue_ValueChanged);
            // 
            // MultiplyImValue
            // 
            this.MultiplyImValue.DecimalPlaces = 2;
            this.MultiplyImValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.MultiplyImValue, "MultiplyImValue");
            this.MultiplyImValue.Name = "MultiplyImValue";
            this.MultiplyImValue.ValueChanged += new System.EventHandler(this.MultiplyImValue_ValueChanged);
            // 
            // PowerImValue
            // 
            this.PowerImValue.DecimalPlaces = 2;
            this.PowerImValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.PowerImValue, "PowerImValue");
            this.PowerImValue.Name = "PowerImValue";
            this.PowerImValue.ValueChanged += new System.EventHandler(this.PowerImValue_ValueChanged);
            // 
            // PowerReValue
            // 
            this.PowerReValue.DecimalPlaces = 2;
            this.PowerReValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.PowerReValue, "PowerReValue");
            this.PowerReValue.Name = "PowerReValue";
            this.PowerReValue.ValueChanged += new System.EventHandler(this.PowerReValue_ValueChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PowerImValue);
            this.Controls.Add(this.PowerReValue);
            this.Controls.Add(this.MultiplyImValue);
            this.Controls.Add(this.MultiplyReValue);
            this.Controls.Add(this.PowerIm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PowerRe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MultiplyIm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MultiplyRe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageShower);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImageShower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyIm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerIm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyReValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyImValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerImValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerReValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageShower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar MultiplyRe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar MultiplyIm;
        private System.Windows.Forms.TrackBar PowerIm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar PowerRe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MultiplyReValue;
        private System.Windows.Forms.NumericUpDown MultiplyImValue;
        private System.Windows.Forms.NumericUpDown PowerImValue;
        private System.Windows.Forms.NumericUpDown PowerReValue;
    }
}

