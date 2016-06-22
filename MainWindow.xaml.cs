using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CharacterSheet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CharacterObject.CharStats charStats = new CharacterObject.CharStats();
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();

            StatsGrid.DataContext = charStats;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            charStats.Strength = charStats.Strength.RollCharacterStats();
            charStats.Dexterity = charStats.Dexterity.RollCharacterStats();
            charStats.Constitution = charStats.Constitution.RollCharacterStats();
            charStats.Intelligence = charStats.Intelligence.RollCharacterStats();
            charStats.Wisdom = charStats.Wisdom.RollCharacterStats();
            charStats.Charisma = charStats.Charisma.RollCharacterStats();
        }
    }

    public static class ExtensionMethods
    {
        static Random rnd = new Random();

        public static string RollCharacterStats(this string obj)
        {
            List<int> Rolls = DiceRoller.Dice.dieroll(6, 4, rnd, true);
            int total = 0;
            Rolls.Sort();

            foreach (int roll in Rolls)
            {
                if (Rolls.IndexOf(roll) > 0)
                {
                    total += roll;
                }
                //MessageBox.Show(roll.ToString());
            }
            return total.ToString();
        }
    }
}
