
namespace MapleStoryQuestHelper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextQuestInfoNum = new System.Windows.Forms.Label();
            this.InputqNum = new System.Windows.Forms.TextBox();
            this.gQuest = new System.Windows.Forms.Button();
            this.writeXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.qName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rwAdd = new System.Windows.Forms.Button();
            this.InputReward = new System.Windows.Forms.TextBox();
            this.MosnterAdd = new System.Windows.Forms.Label();
            this.MonsterAdd_1 = new System.Windows.Forms.TextBox();
            this.m_add_1 = new System.Windows.Forms.Button();
            this.NeededSet = new System.Windows.Forms.Button();
            this.m_qty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Set_MapIds = new System.Windows.Forms.Label();
            this.set_mapId = new System.Windows.Forms.TextBox();
            this.set_npcId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.instructions_ = new System.Windows.Forms.Button();
            this.r_check = new System.Windows.Forms.Button();
            this.daily_q_check = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.create_checkData = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkData = new System.Windows.Forms.TextBox();
            this.r_qty = new System.Windows.Forms.Label();
            this.r_qtyData = new System.Windows.Forms.TextBox();
            this.r_codeData = new System.Windows.Forms.TextBox();
            this.r_code = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextQuestInfoNum
            // 
            this.TextQuestInfoNum.AutoSize = true;
            this.TextQuestInfoNum.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextQuestInfoNum.Location = new System.Drawing.Point(25, 44);
            this.TextQuestInfoNum.Name = "TextQuestInfoNum";
            this.TextQuestInfoNum.Size = new System.Drawing.Size(108, 14);
            this.TextQuestInfoNum.TabIndex = 0;
            this.TextQuestInfoNum.Text = "QuestInfo Number";
            this.TextQuestInfoNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputqNum
            // 
            this.InputqNum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InputqNum.Location = new System.Drawing.Point(28, 67);
            this.InputqNum.Name = "InputqNum";
            this.InputqNum.Size = new System.Drawing.Size(100, 21);
            this.InputqNum.TabIndex = 1;
            this.InputqNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InputqNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gQuest
            // 
            this.gQuest.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gQuest.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gQuest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gQuest.Location = new System.Drawing.Point(389, 108);
            this.gQuest.Name = "gQuest";
            this.gQuest.Size = new System.Drawing.Size(127, 72);
            this.gQuest.TabIndex = 2;
            this.gQuest.Text = "Generate Xml File";
            this.gQuest.UseVisualStyleBackColor = false;
            this.gQuest.Click += new System.EventHandler(this.button1_Click);
            // 
            // writeXML
            // 
            this.writeXML.BackColor = System.Drawing.SystemColors.Info;
            this.writeXML.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.writeXML.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.writeXML.Location = new System.Drawing.Point(389, 184);
            this.writeXML.Name = "writeXML";
            this.writeXML.Size = new System.Drawing.Size(127, 77);
            this.writeXML.TabIndex = 3;
            this.writeXML.Text = "write XML";
            this.writeXML.UseVisualStyleBackColor = false;
            this.writeXML.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "QusetName";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(533, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 72);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate .JS File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // qName
            // 
            this.qName.Location = new System.Drawing.Point(28, 128);
            this.qName.Name = "qName";
            this.qName.Size = new System.Drawing.Size(148, 21);
            this.qName.TabIndex = 6;
            this.qName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(533, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 77);
            this.button2.TabIndex = 7;
            this.button2.Text = "write JS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(166, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "area";
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(169, 67);
            this.area.Name = "area";
            this.area.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.area.Size = new System.Drawing.Size(52, 21);
            this.area.TabIndex = 9;
            this.area.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.area.TextChanged += new System.EventHandler(this.area_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(335, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "reward";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rwAdd
            // 
            this.rwAdd.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rwAdd.Location = new System.Drawing.Point(424, 61);
            this.rwAdd.Name = "rwAdd";
            this.rwAdd.Size = new System.Drawing.Size(71, 31);
            this.rwAdd.TabIndex = 11;
            this.rwAdd.Text = "ADD";
            this.rwAdd.UseVisualStyleBackColor = true;
            this.rwAdd.Click += new System.EventHandler(this.rwAdd_Click);
            // 
            // InputReward
            // 
            this.InputReward.Location = new System.Drawing.Point(338, 64);
            this.InputReward.Name = "InputReward";
            this.InputReward.Size = new System.Drawing.Size(80, 21);
            this.InputReward.TabIndex = 12;
            this.InputReward.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MosnterAdd
            // 
            this.MosnterAdd.AutoSize = true;
            this.MosnterAdd.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MosnterAdd.Location = new System.Drawing.Point(499, 51);
            this.MosnterAdd.Name = "MosnterAdd";
            this.MosnterAdd.Size = new System.Drawing.Size(53, 14);
            this.MosnterAdd.TabIndex = 17;
            this.MosnterAdd.Text = "Monster";
            // 
            // MonsterAdd_1
            // 
            this.MonsterAdd_1.Location = new System.Drawing.Point(501, 72);
            this.MonsterAdd_1.Name = "MonsterAdd_1";
            this.MonsterAdd_1.Size = new System.Drawing.Size(83, 21);
            this.MonsterAdd_1.TabIndex = 18;
            // 
            // m_add_1
            // 
            this.m_add_1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_add_1.Location = new System.Drawing.Point(590, 61);
            this.m_add_1.Name = "m_add_1";
            this.m_add_1.Size = new System.Drawing.Size(70, 31);
            this.m_add_1.TabIndex = 21;
            this.m_add_1.Text = "add";
            this.m_add_1.UseVisualStyleBackColor = true;
            this.m_add_1.Click += new System.EventHandler(this.m_add_1_Click);
            // 
            // NeededSet
            // 
            this.NeededSet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeededSet.Location = new System.Drawing.Point(288, 135);
            this.NeededSet.Name = "NeededSet";
            this.NeededSet.Size = new System.Drawing.Size(95, 177);
            this.NeededSet.TabIndex = 24;
            this.NeededSet.Text = "Setting";
            this.NeededSet.UseVisualStyleBackColor = true;
            this.NeededSet.Click += new System.EventHandler(this.NeededSet_Click);
            // 
            // m_qty
            // 
            this.m_qty.Location = new System.Drawing.Point(198, 135);
            this.m_qty.Name = "m_qty";
            this.m_qty.Size = new System.Drawing.Size(84, 21);
            this.m_qty.TabIndex = 25;
            this.m_qty.TextChanged += new System.EventHandler(this.m_qty_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(196, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 26;
            this.label4.Text = "monsterQty";
            // 
            // Set_MapIds
            // 
            this.Set_MapIds.AutoSize = true;
            this.Set_MapIds.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Set_MapIds.Location = new System.Drawing.Point(198, 159);
            this.Set_MapIds.Name = "Set_MapIds";
            this.Set_MapIds.Size = new System.Drawing.Size(43, 14);
            this.Set_MapIds.TabIndex = 27;
            this.Set_MapIds.Text = "MapId";
            // 
            // set_mapId
            // 
            this.set_mapId.Location = new System.Drawing.Point(198, 174);
            this.set_mapId.Name = "set_mapId";
            this.set_mapId.Size = new System.Drawing.Size(82, 21);
            this.set_mapId.TabIndex = 28;
            // 
            // set_npcId
            // 
            this.set_npcId.Location = new System.Drawing.Point(198, 213);
            this.set_npcId.Name = "set_npcId";
            this.set_npcId.Size = new System.Drawing.Size(82, 21);
            this.set_npcId.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(198, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 30;
            this.label5.Text = "npcId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(949, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Made By. kakekuro";
            // 
            // instructions_
            // 
            this.instructions_.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.instructions_.ForeColor = System.Drawing.SystemColors.MenuText;
            this.instructions_.Location = new System.Drawing.Point(953, 479);
            this.instructions_.Name = "instructions_";
            this.instructions_.Size = new System.Drawing.Size(137, 50);
            this.instructions_.TabIndex = 32;
            this.instructions_.Text = "사용법";
            this.instructions_.UseVisualStyleBackColor = true;
            this.instructions_.Click += new System.EventHandler(this.instructions__Click);
            // 
            // r_check
            // 
            this.r_check.Location = new System.Drawing.Point(428, 29);
            this.r_check.Name = "r_check";
            this.r_check.Size = new System.Drawing.Size(67, 28);
            this.r_check.TabIndex = 33;
            this.r_check.Text = "check";
            this.r_check.UseVisualStyleBackColor = true;
            this.r_check.Click += new System.EventHandler(this.r_check_Click);
            // 
            // daily_q_check
            // 
            this.daily_q_check.AutoSize = true;
            this.daily_q_check.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.daily_q_check.Location = new System.Drawing.Point(235, 36);
            this.daily_q_check.Name = "daily_q_check";
            this.daily_q_check.Size = new System.Drawing.Size(94, 18);
            this.daily_q_check.TabIndex = 35;
            this.daily_q_check.Text = "dailyQuest";
            this.daily_q_check.UseVisualStyleBackColor = true;
            this.daily_q_check.CheckedChanged += new System.EventHandler(this.daily_q_check_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "QuestInfo.img Handle Part";
            // 
            // create_checkData
            // 
            this.create_checkData.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.create_checkData.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.create_checkData.Location = new System.Drawing.Point(389, 293);
            this.create_checkData.Name = "create_checkData";
            this.create_checkData.Size = new System.Drawing.Size(127, 86);
            this.create_checkData.TabIndex = 37;
            this.create_checkData.Text = "create Check.xml";
            this.create_checkData.UseVisualStyleBackColor = true;
            this.create_checkData.Click += new System.EventHandler(this.create_checkData_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(533, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 85);
            this.button3.TabIndex = 38;
            this.button3.Text = "write check.xml";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkData
            // 
            this.checkData.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkData.Location = new System.Drawing.Point(389, 385);
            this.checkData.Name = "checkData";
            this.checkData.Size = new System.Drawing.Size(114, 21);
            this.checkData.TabIndex = 39;
            this.checkData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.checkData.TextChanged += new System.EventHandler(this.checkData_TextChanged);
            // 
            // r_qty
            // 
            this.r_qty.AutoSize = true;
            this.r_qty.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.r_qty.Location = new System.Drawing.Point(199, 249);
            this.r_qty.Name = "r_qty";
            this.r_qty.Size = new System.Drawing.Size(65, 14);
            this.r_qty.TabIndex = 40;
            this.r_qty.Text = "rewardQty";
            // 
            // r_qtyData
            // 
            this.r_qtyData.Location = new System.Drawing.Point(201, 291);
            this.r_qtyData.Name = "r_qtyData";
            this.r_qtyData.Size = new System.Drawing.Size(81, 21);
            this.r_qtyData.TabIndex = 41;
            this.r_qtyData.TextChanged += new System.EventHandler(this.r_qtyData_TextChanged);
            // 
            // r_codeData
            // 
            this.r_codeData.Location = new System.Drawing.Point(201, 264);
            this.r_codeData.Name = "r_codeData";
            this.r_codeData.Size = new System.Drawing.Size(81, 21);
            this.r_codeData.TabIndex = 42;
            this.r_codeData.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // r_code
            // 
            this.r_code.AutoSize = true;
            this.r_code.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.r_code.Location = new System.Drawing.Point(155, 273);
            this.r_code.Name = "r_code";
            this.r_code.Size = new System.Drawing.Size(45, 14);
            this.r_code.TabIndex = 43;
            this.r_code.Text = "r_code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(155, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 44;
            this.label8.Text = "r_qty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(675, 483);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.r_code);
            this.Controls.Add(this.r_codeData);
            this.Controls.Add(this.r_qtyData);
            this.Controls.Add(this.r_qty);
            this.Controls.Add(this.checkData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.create_checkData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.daily_q_check);
            this.Controls.Add(this.r_check);
            this.Controls.Add(this.instructions_);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.set_npcId);
            this.Controls.Add(this.set_mapId);
            this.Controls.Add(this.Set_MapIds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_qty);
            this.Controls.Add(this.NeededSet);
            this.Controls.Add(this.m_add_1);
            this.Controls.Add(this.MonsterAdd_1);
            this.Controls.Add(this.MosnterAdd);
            this.Controls.Add(this.InputReward);
            this.Controls.Add(this.rwAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.qName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writeXML);
            this.Controls.Add(this.gQuest);
            this.Controls.Add(this.InputqNum);
            this.Controls.Add(this.TextQuestInfoNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "QuestHelper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextQuestInfoNum;
        private System.Windows.Forms.TextBox InputqNum;
        private System.Windows.Forms.Button gQuest;
        private System.Windows.Forms.Button writeXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox qName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rwAdd;
        private System.Windows.Forms.TextBox InputReward;
        private System.Windows.Forms.Label MosnterAdd;
        private System.Windows.Forms.TextBox MonsterAdd_1;
        private System.Windows.Forms.Button m_add_1;
        private System.Windows.Forms.Button NeededSet;
        private System.Windows.Forms.TextBox m_qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Set_MapIds;
        private System.Windows.Forms.TextBox set_mapId;
        private System.Windows.Forms.TextBox set_npcId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button instructions_;
        private System.Windows.Forms.Button r_check;
        private System.Windows.Forms.CheckBox daily_q_check;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button create_checkData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox checkData;
        private System.Windows.Forms.Label r_qty;
        private System.Windows.Forms.TextBox r_qtyData;
        private System.Windows.Forms.TextBox r_codeData;
        private System.Windows.Forms.Label r_code;
        private System.Windows.Forms.Label label8;
    }
}

