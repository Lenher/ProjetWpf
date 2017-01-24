using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngine
{
    public class Session
    {
        private Player player;
        private int totalScore;
        private int currentGame = 1;
        private Game game;
        public List<List<int>> Numbers { get; private set; }

        public Session(Player player)
        {
            this.player = player;
            this.totalScore = 0;
            Numbers = new List<List<int>>();
        }

        public void ChooseAFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    JsonSerializer jSer = new JsonSerializer();
                   using (StreamReader sReader = File.OpenText(openFileDialog1.FileName))
                    {
                        this.Numbers = (List<List<int>>) jSer.Deserialize(sReader, typeof(List<List<int>>));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        public bool Play()
        {
            return true;
        }
    }
}
