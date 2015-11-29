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
            label5hp.Text = "hp" + cheater.Hp.ToString();
            label5mana.Text = "mana" + cheater.Mana.ToString();
            label5arm.Text = "arm" + cheater.Armor.ToString();
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
            Anlabel5hp.Text = "hp" + cheater1.Hp.ToString();
            Anlabel5mana.Text = "mana" + cheater1.Mana.ToString();
            Anlabel5arm.Text = "arm" + cheater1.Armor.ToString();

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
            progressBar17.Maximum = cheater.Hp;
            progressBar18.Maximum = cheater1.Hp;
            progressBar19.Maximum = cheater.Mana;
            progressBar20.Maximum = cheater1.Mana;
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
            if (invoker.Hp > 500)
            {
                invoker.Hp = 500;
            }
            if (invoker1.Hp > 500)
            {
                invoker1.Hp = 500;
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
            if (sisadmin.Hp > 500)
            {
                sisadmin.Hp = 500;
            }
            if (sisadmin1.Hp > 500)
            {
                sisadmin1.Hp = 500;
            }
            if (Ninjos.Hp > 500)
            {
                Ninjos.Hp = 500;
            }
            if (Ninjos1.Hp > 500)
            {
                Ninjos1.Hp = 500;
            }
            if (Ninjos.Hp < 0)
            {
                Ninjos.Hp = 0;
            }
            if (Ninjos1.Hp < 0)
            {
                Ninjos1.Hp = 0;
            }
            if (cheater.Hp < 0)
            {
                cheater.Hp = 0;
            }
            if (cheater1.Hp < 0)
            {
                cheater1.Hp = 0;
            }
            if (cheater.Hp > 500)
            {
                cheater.Hp = 500;
            }
            if (cheater1.Hp > 500)
            {
                cheater1.Hp = 500;
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
            progressBar17.Value = cheater.Hp;
            progressBar18.Value = cheater1.Hp;
            progressBar19.Value = cheater.Mana;
            progressBar20.Value = cheater1.Mana;
        }
        Character titan = new Titan(500, 300, 15, 30, 0);
        Character sisadmin = new siskadmin(250, 500, 5, 20, 0);
        Character invoker = new invoker(350, 200, 500, 20, 0);
        Character Ninjos = new Ninjos(300, 400, 3, 100, 0.1);
        Character cheater = new cheater(99999, 99999, 99999, 9999999, 9999999999);
        Character titan1 = new Titan(500, 300, 15, 30, 0);
        Character sisadmin1 = new siskadmin(250, 500, 5, 20, 0);
        Character invoker1 = new invoker(350, 200, 500, 20, 0);
        Character Ninjos1 = new Ninjos(300, 400, 3, 100, 0.1);
        Character cheater1 = new cheater(99999, 99999, 99999, 9999999, 9999999999);
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
            listBox1.Items.Add(invoker.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(sisadmin.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(Ninjos.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(cheater.Skill1(targets));
            LableUpdate();
            ProgresBarUpdate();
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

    }
}
