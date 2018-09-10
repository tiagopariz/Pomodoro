using System;

namespace Pomodoro.Domain.ValueObjects
{
    public class Sound
    {
        public Sound(string path)
        {
            Path = path;
        }

        public string Path { get; }

        public void Play()
        {       
            Console.Beep();
        }
    }
}