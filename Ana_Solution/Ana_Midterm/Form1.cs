/*Ana Mendes
 * Midterm - Spring 2018
 * 
 * anamendes23@gmail.com
 * 
 * May 10, 2018
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ana_AnimalLib;


namespace Ana_Midterm
{
    public partial class Form1 : Form
    {
        //List to hold IAnimals
        List<IAnimal> animals = new List<IAnimal>();
        //string to hold objects names
        string[] names = new string[10];
        public Form1()
        {
            InitializeComponent();
        }
        //******************************************FORM LOAD****************************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            //Instanciate Animal objects
            Eagle vulture = new Eagle(15, "Animal_Pictures/Vulture.jpg", "Animal_Sounds/vulture.wav", rand.Next(1000, 10000).ToString());
            Lion youngerLion = new Lion(300, "Animal_Pictures/Lion.jpg", "Animal_Sounds/hippo2.wav", rand.Next(1000, 10000).ToString());
            Elephant zebra = new Elephant(1000, "Animal_Pictures/Zebra.jpg", "Animal_Sounds/zebra5.wav", rand.Next(1000, 10000).ToString());
            Tiger tiger = new Tiger(670, "Animal_Pictures/Tiger.jpg", "Animal_Sounds/tiger.wav", rand.Next(1000, 10000).ToString());
            Eagle canari = new Eagle(0.05d, "Animal_Pictures/Canari.jpg", "Animal_Sounds/canary.wav", rand.Next(1000, 10000).ToString());
            Whale whale = new Whale(9000, "Animal_Pictures/Whale.jpg", "Animal_Sounds/whale.wav", rand.Next(1000, 10000).ToString());
            Eagle mockingbird = new Eagle(0.1d, "Animal_Pictures/Canari.jpg", "Animal_Sounds/mockingbird.wav", rand.Next(1000, 10000).ToString());
            Elephant elephant = new Elephant(12000, "Animal_Pictures/Elephant.jpg", "Animal_Sounds/elephant.wav", rand.Next(1000, 10000).ToString());
            Lion lion = new Lion(420, "Animal_Pictures/Lion.jpg", "Animal_Sounds/dolphin3.wav", rand.Next(1000, 10000).ToString());
            Tiger youngerTiger = new Tiger(550, "Animal_Pictures/Tiger.jpg", "Animal_Sounds/tiger.wav", rand.Next(1000, 10000).ToString());
            Whale youngerWhale = new Whale(10000, "Animal_Pictures/Whale.jpg", "Animal_Sounds/whale.wav", rand.Next(1000, 10000).ToString());
            //add to list
            animals.Add(vulture);
            animals.Add(youngerLion);
            animals.Add(zebra);
            animals.Add(tiger);
            animals.Add(canari);
            animals.Add(whale);
            animals.Add(mockingbird);
            animals.Add(elephant);
            animals.Add(lion);
            animals.Add(youngerTiger);
            animals.Add(youngerWhale);
            //put names in array
            names = new string[11] { "vulture", "younger lion", "zebra", "tiger", "canari","whale","mockingbird","elephant","lion","younger tiger", "younger whale"};
        }
        //******************************************METHODS******************************************************************
        private Animal GetAnimalById(string id)
        {
            foreach (Animal animal in animals)
            {
                if (animal.ID == id)
                    return animal;
            }
            //if animal is not found, return null
            return null;
        }

        private void DisplayAnimals(List<IAnimal> a)
        {
            //clear listview
            listView1.Items.Clear();
            //string to hold type of consumption for animal
            string consumption;
            //lvi to hold rows
            ListViewItem lvi = new ListViewItem();
            //index for names array
            int i = 0;

            foreach (Animal animal in a)
            {
                //conditions for consumption type
                if (animal.IsCarnivore())
                    consumption = "Carnivore";
                else if (animal.IsHerbivore())
                    consumption = "Herbivore";
                else
                    consumption = "Omnivore";
                //string to hold columns in row
                string[] item = { animal.GetType().Name, names[i], animal.Weight.ToString("f2"), animal.ID, consumption, animal.SoundFile };
                //crete row with string[] item
                lvi = new ListViewItem(item);
                //add to listview
                listView1.Items.Add(lvi);
                //control names index
                i++;
                if (i > names.Length)
                    i = 0;
            }
        }
        //******************************************EVENTS*******************************************************************
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayAnimals(animals);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0 )
            {
                //get index from selecteditem in listview
                int index = listView1.SelectedIndices[0];
                //get animal from list using index
                Animal selectedAnimal = (Animal)animals[index];
                //get file path to display image in picturebox
                pictureBox1.Image = selectedAnimal.GetPicture();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //call method to play sound
                selectedAnimal.Voice();
            }
        }
    }
}
