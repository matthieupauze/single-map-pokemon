using NAudio.Wave;
using System;
using System.IO;
namespace TP2.Commun
{
    public class PokemonMusic
    {
        private Mp3FileReader MusicReader;
        private WaveOutEvent MusicPlayer;
        public Songs CurrentSong;

        public PokemonMusic()
        {
            MusicPlayer = new WaveOutEvent();
            MusicPlayer.Volume = 0.5F;
            MusicPlayer.PlaybackStopped += WaveOut_PlaybackStopped;
            CurrentSong = Songs.None;
        }

        public void StartDefaultMusic()
        {
            if (CurrentSong != Songs.Default)
            {
                StopMusic();
                MusicReader = new Mp3FileReader(new MemoryStream(Properties.Resources._23_hyrule_castle_courtyard));
                PlayMusic();
                CurrentSong = Songs.Default;
            }
        }

        public void StartShopMusic()
        {
            if (CurrentSong != Songs.Shop)
            {
                StopMusic();
                MusicReader = new Mp3FileReader(new MemoryStream(Properties.Resources._41_potion_shop));
                PlayMusic();
                CurrentSong = Songs.Shop;
            }
        }

        public void StartBattleMusic()
        {
            if (CurrentSong != Songs.Battle)
            {
                StopMusic();
                MusicReader = new Mp3FileReader(new MemoryStream(Properties.Resources._51_horse_race));
                PlayMusic();
                CurrentSong = Songs.Battle;
            }
        }

        public void StartBestMusic()
        {
            if (CurrentSong != Songs.Best)
            {
                StopMusic();
                MusicReader = new Mp3FileReader(new MemoryStream(Properties.Resources._57_windmill_hut));
                PlayMusic();
                CurrentSong = Songs.Best;
            }
        }

        private void PlayMusic()
        {
            MusicPlayer.Dispose();
            MusicPlayer = new WaveOutEvent();
            MusicPlayer.PlaybackStopped += WaveOut_PlaybackStopped;
            MusicPlayer.Init(MusicReader);
            MusicPlayer.Play();
        }

        public void StopMusic()
        {
            MusicPlayer.Pause();
            CurrentSong = Songs.None;
        }

        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            MusicReader.Position = 0;
            MusicPlayer.Play();
        }

        public void VolumeUp()
        {
            if (MusicPlayer.Volume <= 0.9F)
            {
                MusicPlayer.Volume += 0.1F;
            }
            else
            {
                MusicPlayer.Volume = 1F;
            }
        }

        public void VolumeDown()
        {
            if (MusicPlayer.Volume >= 0.1F)
            {
                MusicPlayer.Volume -= 0.1F;
            }
            else
            {
                MusicPlayer.Volume = 0F;
            }
        }

        public enum Songs
        {
            None,
            Default,
            Shop,
            Battle,
            Best
        }

    }
}
