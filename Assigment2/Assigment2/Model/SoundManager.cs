using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2.Model
{
    public class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            sounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory soundCategory)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Category == soundCategory).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByName(ObservableCollection<Sound> sounds, string name)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();

            sounds.Add(new Sound("thuongNhauToiBen", SoundCategory.Happy));
            sounds.Add(new Sound("yeuLaCuoi", SoundCategory.Happy));

            sounds.Add(new Sound("emLaConThuyenCoDon", SoundCategory.Sad));
            sounds.Add(new Sound("thayLong", SoundCategory.Sad));

            sounds.Add(new Sound("thuongNhauToiBen", SoundCategory.News));
            sounds.Add(new Sound("yeuLaCuoi", SoundCategory.News));

            return sounds;
        }
    }
}
