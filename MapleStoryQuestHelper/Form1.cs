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
        private int r_num = 0;
        string[] rewardEntry = new string[10];

        // monster Data
        private int m_num = 0;
        string[] monsterEntry = new string[10];

        // set detail questInfo Data
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
           
            // Monster Data Add
            for (int i = 0; i < m_num; i++)
            {
                XMLwriter.WriteLine($"<string name = \"{i}\" value = #b#o{monsterEntry[i]}##k을 #r{MonsterQty}#k명 퇴치하고 #b#m{mapCode}:##k의 #b#p{NPC}:##k에게 가자");
            }
            XMLwriter.WriteLine($"<string name = \"{m_num + 1}\" value = #b#p{NPC}");
            XMLwriter.WriteLine($"<string name = \"demandSummary\" value = \"#questorder1##o{monsterEntry[0]}# #a{InputqNum.Text}#\n/>");
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

            rewardEntry[r_num++] = InputReward.Text;

            MessageBox.Show("Add Sucess");
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

            monsterEntry[m_num++] = MonsterAdd_1.Text;

            MessageBox.Show("SuccessFully Add Monster");
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

        private void instructions__Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1. 퀘스트 넘버와 이름을 모두 작성 한 뒤에 CreateXmlFile, Create .Js File 버튼을 눌러주세요.\n\n");
            sb.Append("2. 해당 area 번호를 작성 해주세요.\n\n");
            sb.Append("3. reward를 모두 작성 해주세요.\n\n");
            sb.Append("4. Monster 1,2,3 코드를 모두 작성  한 뒤에 Add 버튼을 모두 눌러주세요.\n\n");
            sb.Append("5. MonsterQty, MapId, NpcId 를 모두 작성한뒤 Setting 버튼을 눌러주세요.\n\n");
            sb.Append("6. writeXml, WriteJs 버튼을 눌러주세요.");

            string instructions = sb.ToString();
            MessageBox.Show(instructions);
            return;
        }

        private void r_check_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < r_num; i++)
            {
                sb.Append("rewardEntry[" + i + "] = ");
                sb.Append(rewardEntry[i] + "\n");
            }
            
            MessageBox.Show(sb.ToString() + "\n" + "r_num : " + r_num);
        }

        private void area_TextChanged(object sender, EventArgs e)
        {
            area.MaxLength = 4;
        }
    }
}
