namespace CarParkingManager
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            this.label_now = new System.Windows.Forms.Label();
            this.groupBox_parkingManager = new System.Windows.Forms.GroupBox();
            this.button_outParking = new System.Windows.Forms.Button();
            this.button_inParking = new System.Windows.Forms.Button();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.textBox_carnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_driverName = new System.Windows.Forms.Label();
            this.textBox_parkingSpot = new System.Windows.Forms.TextBox();
            this.label_carNumber = new System.Windows.Forms.Label();
            this.label_parkingSpot = new System.Windows.Forms.Label();
            this.groupBox_parkingArea = new System.Windows.Forms.GroupBox();
            this.button_selectAll = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.textBox_parkingSpotArea = new System.Windows.Forms.TextBox();
            this.button_select = new System.Windows.Forms.Button();
            this.label_parkingSpotArea = new System.Windows.Forms.Label();
            this.groupBox_showParking = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_log = new System.Windows.Forms.GroupBox();
            this.listBox_log = new System.Windows.Forms.ListBox();
            this.groupBox_parkingManager.SuspendLayout();
            this.groupBox_parkingArea.SuspendLayout();
            this.groupBox_showParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_now
            // 
            this.timer_now.Enabled = true;
            this.timer_now.Interval = 1000;
            this.timer_now.Tick += new System.EventHandler(this.timer_now_Tick);
            // 
            // label_now
            // 
            this.label_now.AutoSize = true;
            this.label_now.Location = new System.Drawing.Point(20, 519);
            this.label_now.Name = "label_now";
            this.label_now.Size = new System.Drawing.Size(0, 12);
            this.label_now.TabIndex = 0;
            // 
            // groupBox_parkingManager
            // 
            this.groupBox_parkingManager.Controls.Add(this.button_outParking);
            this.groupBox_parkingManager.Controls.Add(this.button_inParking);
            this.groupBox_parkingManager.Controls.Add(this.textBox_phoneNumber);
            this.groupBox_parkingManager.Controls.Add(this.textBox_driverName);
            this.groupBox_parkingManager.Controls.Add(this.textBox_carnumber);
            this.groupBox_parkingManager.Controls.Add(this.label4);
            this.groupBox_parkingManager.Controls.Add(this.label_driverName);
            this.groupBox_parkingManager.Controls.Add(this.textBox_parkingSpot);
            this.groupBox_parkingManager.Controls.Add(this.label_carNumber);
            this.groupBox_parkingManager.Controls.Add(this.label_parkingSpot);
            this.groupBox_parkingManager.Location = new System.Drawing.Point(12, 12);
            this.groupBox_parkingManager.Name = "groupBox_parkingManager";
            this.groupBox_parkingManager.Size = new System.Drawing.Size(372, 108);
            this.groupBox_parkingManager.TabIndex = 1;
            this.groupBox_parkingManager.TabStop = false;
            this.groupBox_parkingManager.Text = "주차 및 출차";
            // 
            // button_outParking
            // 
            this.button_outParking.Location = new System.Drawing.Point(312, 66);
            this.button_outParking.Name = "button_outParking";
            this.button_outParking.Size = new System.Drawing.Size(47, 23);
            this.button_outParking.TabIndex = 9;
            this.button_outParking.Text = "출차";
            this.button_outParking.UseVisualStyleBackColor = true;
            // 
            // button_inParking
            // 
            this.button_inParking.Location = new System.Drawing.Point(312, 30);
            this.button_inParking.Name = "button_inParking";
            this.button_inParking.Size = new System.Drawing.Size(47, 23);
            this.button_inParking.TabIndex = 8;
            this.button_inParking.Text = "주차";
            this.button_inParking.UseVisualStyleBackColor = true;
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(212, 66);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(94, 21);
            this.textBox_phoneNumber.TabIndex = 7;
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(65, 66);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(94, 21);
            this.textBox_driverName.TabIndex = 6;
            // 
            // textBox_carnumber
            // 
            this.textBox_carnumber.Location = new System.Drawing.Point(212, 32);
            this.textBox_carnumber.Name = "textBox_carnumber";
            this.textBox_carnumber.Size = new System.Drawing.Size(94, 21);
            this.textBox_carnumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "연락처";
            // 
            // label_driverName
            // 
            this.label_driverName.AutoSize = true;
            this.label_driverName.Location = new System.Drawing.Point(6, 69);
            this.label_driverName.Name = "label_driverName";
            this.label_driverName.Size = new System.Drawing.Size(53, 12);
            this.label_driverName.TabIndex = 3;
            this.label_driverName.Text = "운전자명";
            // 
            // textBox_parkingSpot
            // 
            this.textBox_parkingSpot.Location = new System.Drawing.Point(65, 30);
            this.textBox_parkingSpot.Name = "textBox_parkingSpot";
            this.textBox_parkingSpot.Size = new System.Drawing.Size(94, 21);
            this.textBox_parkingSpot.TabIndex = 2;
            // 
            // label_carNumber
            // 
            this.label_carNumber.AutoSize = true;
            this.label_carNumber.Location = new System.Drawing.Point(165, 35);
            this.label_carNumber.Name = "label_carNumber";
            this.label_carNumber.Size = new System.Drawing.Size(41, 12);
            this.label_carNumber.TabIndex = 1;
            this.label_carNumber.Text = "차번호";
            // 
            // label_parkingSpot
            // 
            this.label_parkingSpot.AutoSize = true;
            this.label_parkingSpot.Location = new System.Drawing.Point(6, 34);
            this.label_parkingSpot.Name = "label_parkingSpot";
            this.label_parkingSpot.Size = new System.Drawing.Size(53, 12);
            this.label_parkingSpot.TabIndex = 0;
            this.label_parkingSpot.Text = "공간번호";
            // 
            // groupBox_parkingArea
            // 
            this.groupBox_parkingArea.Controls.Add(this.button_selectAll);
            this.groupBox_parkingArea.Controls.Add(this.button_delete);
            this.groupBox_parkingArea.Controls.Add(this.button_insert);
            this.groupBox_parkingArea.Controls.Add(this.textBox_parkingSpotArea);
            this.groupBox_parkingArea.Controls.Add(this.button_select);
            this.groupBox_parkingArea.Controls.Add(this.label_parkingSpotArea);
            this.groupBox_parkingArea.Location = new System.Drawing.Point(390, 12);
            this.groupBox_parkingArea.Name = "groupBox_parkingArea";
            this.groupBox_parkingArea.Size = new System.Drawing.Size(398, 108);
            this.groupBox_parkingArea.TabIndex = 2;
            this.groupBox_parkingArea.TabStop = false;
            this.groupBox_parkingArea.Text = "주차 공간 관리 및 조회";
            // 
            // button_selectAll
            // 
            this.button_selectAll.Location = new System.Drawing.Point(308, 64);
            this.button_selectAll.Name = "button_selectAll";
            this.button_selectAll.Size = new System.Drawing.Size(47, 23);
            this.button_selectAll.TabIndex = 13;
            this.button_selectAll.Text = "갱신";
            this.button_selectAll.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(235, 64);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(47, 23);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(308, 24);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(47, 23);
            this.button_insert.TabIndex = 11;
            this.button_insert.Text = "추가";
            this.button_insert.UseVisualStyleBackColor = true;
            // 
            // textBox_parkingSpotArea
            // 
            this.textBox_parkingSpotArea.Location = new System.Drawing.Point(108, 20);
            this.textBox_parkingSpotArea.Name = "textBox_parkingSpotArea";
            this.textBox_parkingSpotArea.Size = new System.Drawing.Size(80, 21);
            this.textBox_parkingSpotArea.TabIndex = 10;
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(235, 25);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(47, 23);
            this.button_select.TabIndex = 10;
            this.button_select.Text = "조회";
            this.button_select.UseVisualStyleBackColor = true;
            // 
            // label_parkingSpotArea
            // 
            this.label_parkingSpotArea.AutoSize = true;
            this.label_parkingSpotArea.Location = new System.Drawing.Point(17, 25);
            this.label_parkingSpotArea.Name = "label_parkingSpotArea";
            this.label_parkingSpotArea.Size = new System.Drawing.Size(85, 12);
            this.label_parkingSpotArea.TabIndex = 10;
            this.label_parkingSpotArea.Text = "주차 공간 번호";
            // 
            // groupBox_showParking
            // 
            this.groupBox_showParking.Controls.Add(this.dataGridView1);
            this.groupBox_showParking.Location = new System.Drawing.Point(12, 126);
            this.groupBox_showParking.Name = "groupBox_showParking";
            this.groupBox_showParking.Size = new System.Drawing.Size(774, 227);
            this.groupBox_showParking.TabIndex = 2;
            this.groupBox_showParking.TabStop = false;
            this.groupBox_showParking.Text = "주차 공간 현황";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(762, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox_log
            // 
            this.groupBox_log.Controls.Add(this.listBox_log);
            this.groupBox_log.Location = new System.Drawing.Point(14, 359);
            this.groupBox_log.Name = "groupBox_log";
            this.groupBox_log.Size = new System.Drawing.Size(774, 148);
            this.groupBox_log.TabIndex = 3;
            this.groupBox_log.TabStop = false;
            this.groupBox_log.Text = "로그";
            // 
            // listBox_log
            // 
            this.listBox_log.FormattingEnabled = true;
            this.listBox_log.ItemHeight = 12;
            this.listBox_log.Location = new System.Drawing.Point(8, 20);
            this.listBox_log.Name = "listBox_log";
            this.listBox_log.Size = new System.Drawing.Size(760, 124);
            this.listBox_log.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.groupBox_log);
            this.Controls.Add(this.groupBox_showParking);
            this.Controls.Add(this.groupBox_parkingArea);
            this.Controls.Add(this.groupBox_parkingManager);
            this.Controls.Add(this.label_now);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주차 관리 프로그램";
            this.groupBox_parkingManager.ResumeLayout(false);
            this.groupBox_parkingManager.PerformLayout();
            this.groupBox_parkingArea.ResumeLayout(false);
            this.groupBox_parkingArea.PerformLayout();
            this.groupBox_showParking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_log.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_now;
        private System.Windows.Forms.Label label_now;
        private System.Windows.Forms.GroupBox groupBox_parkingManager;
        private System.Windows.Forms.GroupBox groupBox_parkingArea;
        private System.Windows.Forms.GroupBox groupBox_showParking;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_log;
        private System.Windows.Forms.ListBox listBox_log;
        private System.Windows.Forms.Button button_outParking;
        private System.Windows.Forms.Button button_inParking;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.TextBox textBox_carnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_driverName;
        private System.Windows.Forms.TextBox textBox_parkingSpot;
        private System.Windows.Forms.Label label_carNumber;
        private System.Windows.Forms.Label label_parkingSpot;
        private System.Windows.Forms.Button button_selectAll;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.TextBox textBox_parkingSpotArea;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label_parkingSpotArea;
    }
}

