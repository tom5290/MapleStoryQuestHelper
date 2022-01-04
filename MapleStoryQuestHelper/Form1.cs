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

namespace MapleStoryQuestHelper
{
    public partial class Form1 : Form
    {

        // rewards Data
        string[] rewards = new string[3];
        // Monster Data
        string[] Monster = new string[3];
        string NPC;
        string mapCode;
        string MonsterQty;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
              
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InputqNum.MaxLength = 6; // 퀘스트 인포 Max Length 를 Limit
            // 
        }

        // Create Quest file
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\test";
            if (!File.Exists(path))
            {
                CreateXmlFile();
            }
        }


        private void CreateXmlFile()
        {
            var a = InputqNum.Text;
            string path = $"C:\\test\\{a}.xml";

            if (!File.Exists(path))
            {
                using (File.Create(path))
                {
                    MessageBox.Show("CreateFile .Xml Success!");
                }
            }
            else
            {
                MessageBox.Show("이미 해당 퀘스트 넘버가 존재합니다.");
                return;
            }
        }
        // 퀘스트 JS 작성
        private void JsWriteQuest(string path)
        {
            StreamWriter JsWriter;
            JsWriter = File.AppendText(path);
            //Script Quest Handling

            JsWriter.WriteLine("var status = -1;\n");
            JsWriter.WriteLine("function start(mode, type, selection) {\n");
            JsWriter.WriteLine("    if (mode == -1) {");
            JsWriter.WriteLine("        qm.dispose();");
            JsWriter.WriteLine("        return;\n}");
            JsWriter.WriteLine("if (mode == 0) {status ++;}");
            JsWriter.WriteLine("if (mode == 1) {status --;}");
            JsWriter.WriteLine("}\n");
            JsWriter.Close();
            MessageBox.Show("Sucessfully write JS code");
        }
        // 퀘스트 Xml 작성
        private void XmlWriteQuest(string path) 
        {
            StreamWriter XMLwriter;
            XMLwriter = File.AppendText(path);
            // Quest Handling
            XMLwriter.WriteLine($"<imgdir name=\"{InputqNum.Text}>\""); // write QuestNumber
            XMLwriter.WriteLine($"<string name = \"name\" value = \"{qName.Text}\">"); // write questName
            XMLwriter.WriteLine($"<int name=\"area\" value=\"{area.Text}\"/>"); // write area value
            XMLwriter.WriteLine("<int name=\"resignBlocked\" value=\"1\"/>");
            XMLwriter.WriteLine($"<string name = \"0\" value = #b#o{Monster[0]}##k을 #r{MonsterQty}#k명 퇴치하고 #b#m{mapCode}:##k의 #b#p{NPC}:##k에게 가자");
            XMLwriter.WriteLine($"<string name = \"1\" value = #b#o{Monster[1]}##k을 #r{MonsterQty}#k명 퇴치하고 #b#m{mapCode}:##k의 #b#p{NPC}:##k에게 가자");
            XMLwriter.WriteLine($"<string name = \"2\" value = #b#o{Monster[2]}##k을 #r{MonsterQty}#k명 퇴치하고 #b#m{mapCode}:##k의 #b#p{NPC}:##k에게 가자");
            XMLwriter.WriteLine($"<string name = \"3\" value = #b#p{NPC}");
            XMLwriter.WriteLine($"<string name = \"demandSummary\" value = \"#questorder1##o{Monster[0]}# #a{InputqNum.Text}#\n/>");
            XMLwriter.Close();
            MessageBox.Show("Sucessfully write XML code");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var a = InputqNum.Text;
            string xmlpath = $"C:\\test\\{a}.xml";
            XmlWriteQuest(xmlpath);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        // Create .js Quest
        private void button1_Click_2(object sender, EventArgs e)
        {
            var a = InputqNum.Text;
            string path2 = $"C:\\test\\{a}.js";
            if (!File.Exists(path2))
            {
                using (File.Create(path2))
                {
                    MessageBox.Show("CreateFile .js Success!");
                }
            }
            else
            {
                MessageBox.Show("이미 해당 퀘스트 넘버가 존재합니다.");
                return;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = InputqNum.Text;
            string JSpath = $"C:\\test\\{a}.js";
            JsWriteQuest(JSpath);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void rwAdd_Click(object sender, EventArgs e)
        {
            if (InputReward.TextLength < 7)
            {
                MessageBox.Show("보상 코드는 7 자리여야 합니다.");
                return;
            }

            string reward = InputReward.Text;
            rewards[0] = reward;

            MessageBox.Show("rewards[0] = " + reward);
        }

        private void rwAdd_2_Click(object sender, EventArgs e)
        {
            if (InputReward2.TextLength < 7)
            {
                MessageBox.Show("보상 코드는 7 자리여야 합니다.");
                return;
            }
            string reward = InputReward2.Text;
            rewards[1] = reward;

            MessageBox.Show("rewards[1] = " + reward);
        }

        private void rwAdd_3_Click(object sender, EventArgs e)
        {

            if (InputReward3.TextLength < 7)
            {
                MessageBox.Show("보상 코드는 7 자리여야 합니다.");
                return;
            }

            string reward = InputReward3.Text;
            rewards[2] = reward;

            MessageBox.Show("rewards[2] = " + reward);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_add_1_Click(object sender, EventArgs e)
        {

            if (MonsterAdd_1.TextLength < 7)
            {
                MessageBox.Show("몬스터 코드는 7자리 이상이여야 합니다.");
                return;
            }
            string monster = MonsterAdd_1.Text;
            Monster[0] = monster;

            MessageBox.Show("Monster[0] = " + monster);
        }

        private void m_add_2_Click(object sender, EventArgs e)
        {
            if (MonsterAdd_2.TextLength < 7)
            {
                MessageBox.Show("몬스터 코드는 7자리 이상이여야 합니다.");
                return;
            }
            string monster = MonsterAdd_2.Text;
            Monster[1] = monster;

            MessageBox.Show("Monster[1] = " + monster);
        }

        private void m_add_3_Click(object sender, EventArgs e)
        {
            if (MonsterAdd_3.TextLength < 7)
            {
                MessageBox.Show("몬스터 코드는 7자리 이상이여야 합니다.");
                return;
            }
            string monster = MonsterAdd_3.Text;
            Monster[2] = monster;

            MessageBox.Show("Monster[2] = " + monster);
        }

        private void NeededSet_Click(object sender, EventArgs e)
        {
            string qty = m_qty.Text; // Need Monster Qty Set
            string mapId = set_mapId.Text; // MapId Set
            string npcId = set_npcId.Text; // NpcId set

            mapCode = mapId;
            MonsterQty = qty;
            NPC = npcId;
        }
    }
}
