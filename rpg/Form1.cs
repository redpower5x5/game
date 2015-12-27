using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg
{
    public partial class Form1 : Form
    {
        void LableUpdate()
        {
            if (titan1.Hp > 500)
            {
                titan1.Hp = 500;
            }
            label1hp.Text = "hp" + titan.Hp.ToString();
            label1mana.Text = "mana" + titan.Mana.ToString();
            label1arm.Text = "arm" + titan.Armor.ToString();
            label2hp.Text = "hp" + invoker.Hp.ToString();
            label2mana.Text = "mana" + invoker.Mana.ToString();
            label2arm.Text = "arm" + invoker.Armor.ToString();
            label3hp.Text = "hp" + sisadmin.Hp.ToString();
            label3mana.Text = "mana" + sisadmin.Mana.ToString();
            label3arm.Text = "arm" + sisadmin.Armor.ToString();
            label4hp.Text = "hp" + Ninjos.Hp.ToString();
            label4arm.Text = "arm" + Ninjos.Armor.ToString();
            label4mana.Text = "mana" + Ninjos.Mana.ToString();
            Anlabel1hp.Text = "hp" + titan1.Hp.ToString();
            Anlabel1mana.Text = "mana" + titan1.Mana.ToString();
            Anlabel1arm.Text = "arm" + titan1.Armor.ToString();
            Anlabel2hp.Text = "hp" + invoker1.Hp.ToString();
            Anlabel2mana.Text = "mana" + invoker1.Mana.ToString();
            Anlabel2arm.Text = "arm" + invoker1.Armor.ToString();
            Anlabel3hp.Text = "hp" + sisadmin1.Hp.ToString();
            Anlabel3mana.Text = "mana" + sisadmin1.Mana.ToString();
            Anlabel3arm.Text = "arm" + sisadmin1.Armor.ToString();
            Anlabel4hp.Text = "hp" + Ninjos1.Hp.ToString();
            Anlabel4arm.Text = "arm" + Ninjos1.Armor.ToString();
            Anlabel4mana.Text = "mana" + Ninjos1.Mana.ToString();
            

        }
        private void ProgressBarSet()
        {
            progressBar1.Maximum = titan1.Hp;
            progressBar2.Maximum = titan1.Mana;
            progressBar3.Maximum = titan.Hp;
            progressBar4.Maximum = titan.Mana;
            progressBar5.Maximum = invoker1.Hp;
            progressBar6.Maximum = invoker.Hp;
            progressBar7.Maximum = invoker.Mana;
            progressBar8.Maximum = invoker1.Mana;
            progressBar9.Maximum = sisadmin.Hp;
            progressBar10.Maximum = sisadmin1.Hp;
            progressBar11.Maximum = sisadmin.Mana;
            progressBar12.Maximum = sisadmin1.Mana;
            progressBar13.Maximum = Ninjos.Hp;
            progressBar14.Maximum = Ninjos1.Hp;
            progressBar15.Maximum = Ninjos1.Mana;
            progressBar16.Maximum = Ninjos.Mana;
           
        }
        private void ProgresBarUpdate()
        {
            if(titan1.Hp > 500)
            {
                titan1.Hp = 500;
            }
            if (titan.Hp > 500)
            {
                titan.Hp = 500;
            }
            if (titan1.Hp < 0)
            {
                titan1.Hp = 0;
            }
            if (titan.Hp < 0)
            {
                titan.Hp = 0;
            }
            if (invoker.Hp > 350)
            {
                invoker.Hp = 350;
            }
            if (invoker1.Hp > 350)
            {
                invoker1.Hp = 350;
            }
            if (invoker.Hp < 0)
            {
                invoker.Hp = 0;
            }
            if (invoker1.Hp < 0)
            {
                invoker1.Hp = 0;
            }
            if (sisadmin.Hp < 0)
            {
                sisadmin.Hp = 0;
            }
            if (sisadmin1.Hp < 0)
            {
                sisadmin1.Hp = 0;
            }
            if (sisadmin.Hp > 250)
            {
                sisadmin.Hp = 250;
            }
            if (sisadmin1.Hp > 250)
            {
                sisadmin1.Hp = 250;
            }
            if (Ninjos.Hp > 300)
            {
                Ninjos.Hp = 300;
            }
            if (Ninjos1.Hp > 300)
            {
                Ninjos1.Hp = 300;
            }
            if (Ninjos.Hp < 0)
            {
                Ninjos.Hp = 0;
            }
            if (Ninjos1.Hp < 0)
            {
                Ninjos1.Hp = 0;
            }
            
            progressBar1.Value = titan1.Hp;
            progressBar3.Value = titan.Hp;
            progressBar2.Value = titan1.Mana;
            progressBar4.Value = titan.Mana;
            progressBar5.Value = invoker1.Hp;
            progressBar6.Value = invoker.Hp;
            progressBar7.Value = invoker.Mana;
            progressBar8.Value = invoker1.Mana;
            progressBar9.Value = sisadmin.Hp;
            progressBar10.Value = sisadmin1.Hp;
            progressBar11.Value = sisadmin.Mana;
            progressBar12.Value = sisadmin1.Mana;
            progressBar13.Value = Ninjos.Hp;
            progressBar14.Value = Ninjos1.Hp;
            progressBar15.Value = Ninjos1.Mana;
            progressBar16.Value = Ninjos.Mana;
            
        }
        
        Character titan = new Titan(500, 300, 15, 30, 0);
        Character sisadmin = new siskadmin(250, 500, 5, 20, 0);
        Character invoker = new invoker(350, 200, 0, 200, 0);
        Character Ninjos = new Ninjos(300, 400, 3, 100, 0.1);
        
        Character titan1 = new Titan(500, 300, 15, 30, 0);
        Character sisadmin1 = new siskadmin(250, 500, 5, 20, 0);
        Character invoker1 = new invoker(350, 200, 0, 20, 0);
        Character Ninjos1 = new Ninjos(300, 400, 3, 100, 0.1);
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(titan.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            targets.Add(Ninjos1);
            targets.Add(invoker);
            targets.Add(invoker1);
            
            targets.Add(sisadmin1);
            listBox1.Items.Add(invoker.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button1.Visible = false;
            button3.Visible = true;
            button7.Visible = true;
            button12.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button11.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            button6.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ProgressBarSet();
            LableUpdate();
            ProgresBarUpdate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(Ninjos.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button1.Visible = true;
            button2.Visible = false;
            button6.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button11.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(sisadmin1);
            listBox1.Items.Add(Ninjos.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button1.Visible = true;
            button2.Visible = false;
            button6.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button11.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(Ninjos1);
            listBox1.Items.Add(Ninjos.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button1.Visible = true;
            button2.Visible = false;
            button6.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button11.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(invoker1);
            listBox1.Items.Add(Ninjos.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button1.Visible = true;
            button2.Visible = false;
            button6.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button11.Visible = true;
            button9.Visible = true;
            button10.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(Ninjos);
            listBox1.Items.Add(sisadmin.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button11.Visible = true;
            button3.Visible = false;
            button7.Visible = false;
            button12.Visible = false;
            button1.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan);
            listBox1.Items.Add(sisadmin.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button11.Visible = true;
            button3.Visible = false;
            button7.Visible = false;
            button12.Visible = false;
            button1.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(invoker);
            listBox1.Items.Add(sisadmin.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button11.Visible = true;
            button3.Visible = false;
            button7.Visible = false;
            button12.Visible = false;
            button1.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan);
            listBox1.Items.Add(titan.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
        }

        

        private void button15_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan);
            targets.Add(Ninjos);
            targets.Add(invoker1);
            targets.Add(invoker);

            targets.Add(sisadmin);
            listBox1.Items.Add(invoker.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            button15.Visible = false;
            button14.Visible = false;
            button1.Visible = false;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            button8.Visible = false;
            button15.Visible = false;
            button14.Visible = false;
            button13.Visible = false;
            button19.Visible = true;
            button20.Visible = true;
            button22.Visible = true;
            button21.Visible = true;
        }


        private void button19_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan);
            listBox1.Items.Add(Ninjos.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button1.Visible = true;
            button19.Visible = false;
            button20.Visible = false;
            button22.Visible = false;
            button21.Visible = false;
            button13.Visible = true;
            button15.Visible = true;
            button8.Visible = true;
            button14.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(sisadmin);
            listBox1.Items.Add(Ninjos.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button14.Visible = true;
            button19.Visible = false;
            button20.Visible = false;
            button22.Visible = false;
            button21.Visible = false;
            button13.Visible = true;
            button15.Visible = true;
            button8.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(Ninjos);
            listBox1.Items.Add(Ninjos.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button14.Visible = true;
            button19.Visible = false;
            button20.Visible = false;
            button22.Visible = false;
            button21.Visible = false;
            button13.Visible = true;
            button15.Visible = true;
            button8.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(invoker);
            listBox1.Items.Add(Ninjos.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button14.Visible = true;
            button19.Visible = false;
            button20.Visible = false;
            button22.Visible = false;
            button21.Visible = false;
            button13.Visible = true;
            button15.Visible = true;
            button8.Visible = true;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(Ninjos1);
            listBox1.Items.Add(sisadmin.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button13.Visible = true;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button1.Visible = true;
            button15.Visible = true;
            button8.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(sisadmin.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button13.Visible = true;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button14.Visible = true;
            button15.Visible = true;
            button8.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(invoker1);
            listBox1.Items.Add(sisadmin.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
            button13.Visible = true;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button14.Visible = true;
            button15.Visible = true;
            button8.Visible = true;
        }
    }
}
