namespace Ricimon.FFXIV_PraeCastrum_Timer
{
    partial class PluginWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.runName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastCheckpoint = new System.Windows.Forms.Label();
            this.cutsceneTimeRemaining = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.abortRunButton = new System.Windows.Forms.Button();
            this.skipCheckpointButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.runNameStats = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.runDurationStats = new System.Windows.Forms.Label();
            this.runDurationWithoutCutscenesStats = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.runDuration = new System.Windows.Forms.Label();
            this.forceStartCastrumButton = new System.Windows.Forms.Button();
            this.forceStartPraetoriumButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Now Running:";
            // 
            // runName
            // 
            this.runName.AutoSize = true;
            this.runName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.runName.Location = new System.Drawing.Point(193, 27);
            this.runName.Name = "runName";
            this.runName.Size = new System.Drawing.Size(147, 29);
            this.runName.TabIndex = 1;
            this.runName.Text = "RUN_NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last checkpoint:";
            // 
            // lastCheckpoint
            // 
            this.lastCheckpoint.AutoSize = true;
            this.lastCheckpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.lastCheckpoint.Location = new System.Drawing.Point(147, 85);
            this.lastCheckpoint.Name = "lastCheckpoint";
            this.lastCheckpoint.Size = new System.Drawing.Size(150, 18);
            this.lastCheckpoint.TabIndex = 3;
            this.lastCheckpoint.Text = "LAST_CHECKPOINT";
            // 
            // cutsceneTimeRemaining
            // 
            this.cutsceneTimeRemaining.AutoSize = true;
            this.cutsceneTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.cutsceneTimeRemaining.Location = new System.Drawing.Point(289, 146);
            this.cutsceneTimeRemaining.Name = "cutsceneTimeRemaining";
            this.cutsceneTimeRemaining.Size = new System.Drawing.Size(333, 26);
            this.cutsceneTimeRemaining.TabIndex = 5;
            this.cutsceneTimeRemaining.Text = "CUTSCENE_TIME_REMAINING";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(23, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cutscene time remaining:";
            // 
            // abortRunButton
            // 
            this.abortRunButton.BackColor = System.Drawing.Color.Firebrick;
            this.abortRunButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.abortRunButton.Location = new System.Drawing.Point(217, 202);
            this.abortRunButton.Name = "abortRunButton";
            this.abortRunButton.Size = new System.Drawing.Size(159, 31);
            this.abortRunButton.TabIndex = 6;
            this.abortRunButton.Text = "Abort Run";
            this.abortRunButton.UseVisualStyleBackColor = false;
            this.abortRunButton.Click += new System.EventHandler(this.abortRunButton_Click);
            // 
            // skipCheckpointButton
            // 
            this.skipCheckpointButton.Location = new System.Drawing.Point(28, 202);
            this.skipCheckpointButton.Name = "skipCheckpointButton";
            this.skipCheckpointButton.Size = new System.Drawing.Size(154, 31);
            this.skipCheckpointButton.TabIndex = 7;
            this.skipCheckpointButton.Text = "Skip Checkpoint";
            this.skipCheckpointButton.UseVisualStyleBackColor = true;
            this.skipCheckpointButton.Click += new System.EventHandler(this.skipCheckpointButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label5.Location = new System.Drawing.Point(23, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Run Stats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label6.Location = new System.Drawing.Point(25, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Run Name:";
            // 
            // runNameStats
            // 
            this.runNameStats.AutoSize = true;
            this.runNameStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.runNameStats.Location = new System.Drawing.Point(114, 312);
            this.runNameStats.Name = "runNameStats";
            this.runNameStats.Size = new System.Drawing.Size(147, 18);
            this.runNameStats.TabIndex = 10;
            this.runNameStats.Text = "RUN_NAME_STATS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label7.Location = new System.Drawing.Point(25, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Run Duration:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label8.Location = new System.Drawing.Point(25, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Run Duration (no cutscenes):";
            // 
            // runDurationStats
            // 
            this.runDurationStats.AutoSize = true;
            this.runDurationStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.runDurationStats.Location = new System.Drawing.Point(130, 339);
            this.runDurationStats.Name = "runDurationStats";
            this.runDurationStats.Size = new System.Drawing.Size(181, 18);
            this.runDurationStats.TabIndex = 12;
            this.runDurationStats.Text = "RUN_DURATION_STATS";
            // 
            // runDurationWithoutCutscenesStats
            // 
            this.runDurationWithoutCutscenesStats.AutoSize = true;
            this.runDurationWithoutCutscenesStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.runDurationWithoutCutscenesStats.Location = new System.Drawing.Point(249, 366);
            this.runDurationWithoutCutscenesStats.Name = "runDurationWithoutCutscenesStats";
            this.runDurationWithoutCutscenesStats.Size = new System.Drawing.Size(360, 18);
            this.runDurationWithoutCutscenesStats.TabIndex = 14;
            this.runDurationWithoutCutscenesStats.Text = "RUN_DURATION_WITHOUT_CUTSCENES_STATS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label9.Location = new System.Drawing.Point(25, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Time elapsed:";
            // 
            // runDuration
            // 
            this.runDuration.AutoSize = true;
            this.runDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.runDuration.Location = new System.Drawing.Point(130, 112);
            this.runDuration.Name = "runDuration";
            this.runDuration.Size = new System.Drawing.Size(126, 18);
            this.runDuration.TabIndex = 16;
            this.runDuration.Text = "RUN_DURATION";
            // 
            // forceStartCastrumButton
            // 
            this.forceStartCastrumButton.Location = new System.Drawing.Point(28, 185);
            this.forceStartCastrumButton.Name = "forceStartCastrumButton";
            this.forceStartCastrumButton.Size = new System.Drawing.Size(154, 31);
            this.forceStartCastrumButton.TabIndex = 17;
            this.forceStartCastrumButton.Text = "Force Start Castrum";
            this.forceStartCastrumButton.UseVisualStyleBackColor = true;
            this.forceStartCastrumButton.Click += new System.EventHandler(this.forceStartCastrumButton_Click);
            // 
            // forceStartPraetoriumButton
            // 
            this.forceStartPraetoriumButton.Location = new System.Drawing.Point(28, 222);
            this.forceStartPraetoriumButton.Name = "forceStartPraetoriumButton";
            this.forceStartPraetoriumButton.Size = new System.Drawing.Size(171, 31);
            this.forceStartPraetoriumButton.TabIndex = 18;
            this.forceStartPraetoriumButton.Text = "Force Start Praetorium";
            this.forceStartPraetoriumButton.UseVisualStyleBackColor = true;
            this.forceStartPraetoriumButton.Click += new System.EventHandler(this.forceStartPraetoriumButton_Click);
            // 
            // PluginWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.forceStartPraetoriumButton);
            this.Controls.Add(this.forceStartCastrumButton);
            this.Controls.Add(this.runDuration);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.runDurationWithoutCutscenesStats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.runDurationStats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.runNameStats);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.skipCheckpointButton);
            this.Controls.Add(this.abortRunButton);
            this.Controls.Add(this.cutsceneTimeRemaining);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastCheckpoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.runName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PluginWindow";
            this.Size = new System.Drawing.Size(1520, 877);
            this.Load += new System.EventHandler(this.PluginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label runName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lastCheckpoint;
        private System.Windows.Forms.Label cutsceneTimeRemaining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button abortRunButton;
        private System.Windows.Forms.Button skipCheckpointButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label runNameStats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label runDurationStats;
        private System.Windows.Forms.Label runDurationWithoutCutscenesStats;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label runDuration;
        private System.Windows.Forms.Button forceStartCastrumButton;
        private System.Windows.Forms.Button forceStartPraetoriumButton;
    }
}
