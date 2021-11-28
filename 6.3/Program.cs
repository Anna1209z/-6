using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    } 
    interface IMedia
    {
       void Play();
       void Pause();
       void Stop();
    }
    interface IPlayable
    {

        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class PlayerItem: IMedia
    {
        void IMedia.Play()
        {
            
        }
        void IMedia.Pause()
        {
           
        }
        void IMedia.Stop()
        {
          
        }
    }
    class MkV
    {

    }
    class Mp3
    {
        
    }
    class Wav
    {

    }
}
