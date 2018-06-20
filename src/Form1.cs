using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamelUp.DiceApp
{
    public partial class Form1 : Form
    {
        readonly Random Random;
        List<CamelColor> AvailableColors;
        List<CamelRoll> RolledDice;

        public Form1()
        {
            Random = new Random((int)DateTime.Now.Ticks);
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            NextRound();
        }

        void btnRoll_Click(object sender, EventArgs e)
        {
            Roll();
            Player.URL = "res\\dice.mp3";
            Player.Ctlcontrols.play();
        }

        void btnNextRound_Click(object sender, EventArgs e)
        {
            NextRound();
        }

        void Roll()
        {
            var nextIndex = Random.Next(0, AvailableColors.Count() - 1);
            var nextColor = AvailableColors[nextIndex];
            AvailableColors.RemoveAt(nextIndex);
            var roll = new CamelRoll(
                color: nextColor,
                value: Random.Next(1, 4));
            DisplayRoll(roll);
            RolledDice.Add(roll);
            DisplayRolls(RolledDice);

            if (AvailableColors.Count() == 0)
                EndRound();
        }

        void NextRound()
        {
            AvailableColors = new List<CamelColor>
            {
                CamelColor.Blue,
                CamelColor.Yellow,
                CamelColor.White,
                CamelColor.Green,
                CamelColor.Orange
            };
            
            btnRoll.Enabled = true;
            btnNextRound.Enabled = false;

           lblCurrentRoll.BackColor = Color.
            lblCurrentRoll.Text = "?";
            RolledDice = new List<CamelRoll>();
            DisplayRolls(RolledDice);
        }

        void EndRound()
        {
            btnRoll.Enabled = false;
            btnNextRound.Enabled = true;
        }

        void DisplayRolls(List<CamelRoll> rolls)
        {
            lstCurrentRolls.Items.Clear();
            foreach (var roll in rolls)
                lstCurrentRolls.Items.Add(roll);
        }

        void DisplayRoll(CamelRoll roll)
        {
            lblCurrentRoll.Text = roll.Value.ToString();
            switch (roll.Color)
            {
                case CamelColor.Blue:
                    lblCurrentRoll.BackColor = Color.Blue;
                    lblCurrentRoll.ForeColor = Color.White;
                    break;

                case CamelColor.Yellow:
                    lblCurrentRoll.BackColor = Color.Yellow;
                    lblCurrentRoll.ForeColor = Color.Black;
                    break;

                case CamelColor.White:
                    lblCurrentRoll.BackColor = Color.White;
                    lblCurrentRoll.ForeColor = Color.Black;
                    break;

                case CamelColor.Green:
                    lblCurrentRoll.BackColor = Color.Green;
                    lblCurrentRoll.ForeColor = Color.White;
                    break;

                case CamelColor.Orange:
                    lblCurrentRoll.BackColor = Color.Orange;
                    lblCurrentRoll.ForeColor = Color.White;
                    break;
            }
        }
    }

    public class CamelRoll
    {
        public readonly CamelColor Color;
        public readonly int Value;

        public CamelRoll(CamelColor color, int value)
        {
            Color = color;
            Value = value;
        }

        public override string ToString()
            => $"{Color} - {Value}";
    }

    public enum CamelColor
    {
        Blue,
        Yellow,
        White,
        Green,
        Orange
    }
}
