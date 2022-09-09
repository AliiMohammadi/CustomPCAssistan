using System.Media;
using System;
using System.IO;
using System.Linq;

public class AudioPlayer
{
    /// <summary>
    /// تابع مجاز برای پخش صدا
    /// </summary>
    /// <param name="stream">صدا که میتونه از سورس برنامه باشه</param>
    public static void Play(Stream stream)
    {
        SoundPlayer sound = new SoundPlayer(stream);
        sound.Play();
    }
    /// <summary>
    /// تابع مجاز برای پخش صدا
    /// </summary>
    /// <param name="stream">صدا که میتونه از سورس برنامه باشه</param>
    public static void Play(string audiopath)
    {
        SoundPlayer sound = new SoundPlayer(audiopath);
        sound.Play();
    }
}
