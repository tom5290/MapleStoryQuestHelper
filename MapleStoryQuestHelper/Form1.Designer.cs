﻿
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
            this.rwAdd_2 = new System.Windows.Forms.Button();
            this.rwAdd_3 = new System.Windows.Forms.Button();
            this.InputReward2 = new System.Windows.Forms.TextBox();
            this.InputReward3 = new System.Windows.Forms.TextBox();
            this.MosnterAdd = new System.Windows.Forms.Label();
            this.MonsterAdd_1 = new System.Windows.Forms.TextBox();
            this.MonsterAdd_2 = new System.Windows.Forms.TextBox();
            this.MonsterAdd_3 = new System.Windows.Forms.TextBox();
            this.m_add_1 = new System.Windows.Forms.Button();
            this.m_add_2 = new System.Windows.Forms.Button();
            this.m_add_3 = new System.Windows.Forms.Button();
            this.NeededSet = new System.Windows.Forms.Button();
            this.m_qty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Set_MapIds = new System.Windows.Forms.Label();
            this.set_mapId = new System.Windows.Forms.TextBox();
            this.set_npcId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextQuestInfoNum
            // 
            this.TextQuestInfoNum.AutoSize = true;
            this.TextQuestInfoNum.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextQuestInfoNum.Location = new System.Drawing.Point(25, 25);
            this.TextQuestInfoNum.Name = "TextQuestInfoNum";
            this.TextQuestInfoNum.Size = new System.Drawing.Size(108, 14);
            this.TextQuestInfoNum.TabIndex = 0;
            this.TextQuestInfoNum.Text = "QuestInfo Number";
            this.TextQuestInfoNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputqNum
            // 
            this.InputqNum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InputqNum.Location = new System.Drawing.Point(33, 42);
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
            this.gQuest.Location = new System.Drawing.Point(613, 27);
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
            this.writeXML.Location = new System.Drawing.Point(613, 105);
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
            this.label1.Location = new System.Drawing.Point(25, 91);
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
            this.button1.Location = new System.Drawing.Point(746, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 72);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate .JS File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // qName
            // 
            this.qName.Location = new System.Drawing.Point(31, 111);
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
            this.button2.Location = new System.Drawing.Point(746, 105);
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
            this.label2.Location = new System.Drawing.Point(166, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "area";
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(169, 42);
            this.area.Name = "area";
            this.area.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.area.Size = new System.Drawing.Size(52, 21);
            this.area.TabIndex = 9;
            this.area.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(240, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "reward";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rwAdd
            // 
            this.rwAdd.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rwAdd.Location = new System.Drawing.Point(329, 42);
            this.rwAdd.Name = "rwAdd";
            this.rwAdd.Size = new System.Drawing.Size(71, 31);
            this.rwAdd.TabIndex = 11;
            this.rwAdd.Text = "ADD";
            this.rwAdd.UseVisualStyleBackColor = true;
            this.rwAdd.Click += new System.EventHandler(this.rwAdd_Click);
            // 
            // InputReward
            // 
            this.InputReward.Location = new System.Drawing.Point(243, 42);
            this.InputReward.Name = "InputReward";
            this.InputReward.Size = new System.Drawing.Size(80, 21);
            this.InputReward.TabIndex = 12;
            this.InputReward.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rwAdd_2
            // 
            this.rwAdd_2.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rwAdd_2.Location = new System.Drawing.Point(329, 75);
            this.rwAdd_2.Name = "rwAdd_2";
            this.rwAdd_2.Size = new System.Drawing.Size(71, 30);
            this.rwAdd_2.TabIndex = 13;
            this.rwAdd_2.Text = "ADD 1";
            this.rwAdd_2.UseVisualStyleBackColor = true;
            this.rwAdd_2.Click += new System.EventHandler(this.rwAdd_2_Click);
            // 
            // rwAdd_3
            // 
            this.rwAdd_3.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rwAdd_3.Location = new System.Drawing.Point(329, 111);
            this.rwAdd_3.Name = "rwAdd_3";
            this.rwAdd_3.Size = new System.Drawing.Size(71, 30);
            this.rwAdd_3.TabIndex = 14;
            this.rwAdd_3.Text = "ADD 2";
            this.rwAdd_3.UseVisualStyleBackColor = true;
            this.rwAdd_3.Click += new System.EventHandler(this.rwAdd_3_Click);
            // 
            // InputReward2
            // 
            this.InputReward2.Location = new System.Drawing.Point(243, 75);
            this.InputReward2.Name = "InputReward2";
            this.InputReward2.Size = new System.Drawing.Size(79, 21);
            this.InputReward2.TabIndex = 15;
            // 
            // InputReward3
            // 
            this.InputReward3.Location = new System.Drawing.Point(243, 112);
            this.InputReward3.Name = "InputReward3";
            this.InputReward3.Size = new System.Drawing.Size(78, 21);
            this.InputReward3.TabIndex = 16;
            // 
            // MosnterAdd
            // 
            this.MosnterAdd.AutoSize = true;
            this.MosnterAdd.Location = new System.Drawing.Point(414, 27);
            this.MosnterAdd.Name = "MosnterAdd";
            this.MosnterAdd.Size = new System.Drawing.Size(51, 12);
            this.MosnterAdd.TabIndex = 17;
            this.MosnterAdd.Text = "Monster";
            // 
            // MonsterAdd_1
            // 
            this.MonsterAdd_1.Location = new System.Drawing.Point(416, 42);
            this.MonsterAdd_1.Name = "MonsterAdd_1";
            this.MonsterAdd_1.Size = new System.Drawing.Size(83, 21);
            this.MonsterAdd_1.TabIndex = 18;
            // 
            // MonsterAdd_2
            // 
            this.MonsterAdd_2.Location = new System.Drawing.Point(416, 77);
            this.MonsterAdd_2.Name = "MonsterAdd_2";
            this.MonsterAdd_2.Size = new System.Drawing.Size(82, 21);
            this.MonsterAdd_2.TabIndex = 19;
            this.MonsterAdd_2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MonsterAdd_3
            // 
            this.MonsterAdd_3.Location = new System.Drawing.Point(416, 112);
            this.MonsterAdd_3.Name = "MonsterAdd_3";
            this.MonsterAdd_3.Size = new System.Drawing.Size(83, 21);
            this.MonsterAdd_3.TabIndex = 20;
            // 
            // m_add_1
            // 
            this.m_add_1.Location = new System.Drawing.Point(511, 41);
            this.m_add_1.Name = "m_add_1";
            this.m_add_1.Size = new System.Drawing.Size(70, 31);
            this.m_add_1.TabIndex = 21;
            this.m_add_1.Text = "add";
            this.m_add_1.UseVisualStyleBackColor = true;
            this.m_add_1.Click += new System.EventHandler(this.m_add_1_Click);
            // 
            // m_add_2
            // 
            this.m_add_2.Location = new System.Drawing.Point(511, 78);
            this.m_add_2.Name = "m_add_2";
            this.m_add_2.Size = new System.Drawing.Size(70, 27);
            this.m_add_2.TabIndex = 22;
            this.m_add_2.Text = "add";
            this.m_add_2.UseVisualStyleBackColor = true;
            this.m_add_2.Click += new System.EventHandler(this.m_add_2_Click);
            // 
            // m_add_3
            // 
            this.m_add_3.Location = new System.Drawing.Point(511, 113);
            this.m_add_3.Name = "m_add_3";
            this.m_add_3.Size = new System.Drawing.Size(69, 28);
            this.m_add_3.TabIndex = 23;
            this.m_add_3.Text = "add";
            this.m_add_3.UseVisualStyleBackColor = true;
            this.m_add_3.Click += new System.EventHandler(this.m_add_3_Click);
            // 
            // NeededSet
            // 
            this.NeededSet.Location = new System.Drawing.Point(518, 185);
            this.NeededSet.Name = "NeededSet";
            this.NeededSet.Size = new System.Drawing.Size(95, 123);
            this.NeededSet.TabIndex = 24;
            this.NeededSet.Text = "Setting";
            this.NeededSet.UseVisualStyleBackColor = true;
            this.NeededSet.Click += new System.EventHandler(this.NeededSet_Click);
            // 
            // m_qty
            // 
            this.m_qty.Location = new System.Drawing.Point(427, 184);
            this.m_qty.Name = "m_qty";
            this.m_qty.Size = new System.Drawing.Size(84, 21);
            this.m_qty.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "monsterQty";
            // 
            // Set_MapIds
            // 
            this.Set_MapIds.AutoSize = true;
            this.Set_MapIds.Location = new System.Drawing.Point(427, 208);
            this.Set_MapIds.Name = "Set_MapIds";
            this.Set_MapIds.Size = new System.Drawing.Size(40, 12);
            this.Set_MapIds.TabIndex = 27;
            this.Set_MapIds.Text = "MapId";
            // 
            // set_mapId
            // 
            this.set_mapId.Location = new System.Drawing.Point(429, 224);
            this.set_mapId.Name = "set_mapId";
            this.set_mapId.Size = new System.Drawing.Size(82, 21);
            this.set_mapId.TabIndex = 28;
            // 
            // set_npcId
            // 
            this.set_npcId.Location = new System.Drawing.Point(427, 270);
            this.set_npcId.Name = "set_npcId";
            this.set_npcId.Size = new System.Drawing.Size(83, 21);
            this.set_npcId.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "npcId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(751, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Made By. kakekuro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(904, 494);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.set_npcId);
            this.Controls.Add(this.set_mapId);
            this.Controls.Add(this.Set_MapIds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_qty);
            this.Controls.Add(this.NeededSet);
            this.Controls.Add(this.m_add_3);
            this.Controls.Add(this.m_add_2);
            this.Controls.Add(this.m_add_1);
            this.Controls.Add(this.MonsterAdd_3);
            this.Controls.Add(this.MonsterAdd_2);
            this.Controls.Add(this.MonsterAdd_1);
            this.Controls.Add(this.MosnterAdd);
            this.Controls.Add(this.InputReward3);
            this.Controls.Add(this.InputReward2);
            this.Controls.Add(this.rwAdd_3);
            this.Controls.Add(this.rwAdd_2);
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
        private System.Windows.Forms.Button rwAdd_2;
        private System.Windows.Forms.Button rwAdd_3;
        private System.Windows.Forms.TextBox InputReward2;
        private System.Windows.Forms.TextBox InputReward3;
        private System.Windows.Forms.Label MosnterAdd;
        private System.Windows.Forms.TextBox MonsterAdd_1;
        private System.Windows.Forms.TextBox MonsterAdd_2;
        private System.Windows.Forms.TextBox MonsterAdd_3;
        private System.Windows.Forms.Button m_add_1;
        private System.Windows.Forms.Button m_add_2;
        private System.Windows.Forms.Button m_add_3;
        private System.Windows.Forms.Button NeededSet;
        private System.Windows.Forms.TextBox m_qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Set_MapIds;
        private System.Windows.Forms.TextBox set_mapId;
        private System.Windows.Forms.TextBox set_npcId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

