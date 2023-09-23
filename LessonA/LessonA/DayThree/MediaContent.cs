using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{
    internal class MediaContent
    {//virtual methods can help override
        public virtual void StartPlayingContent()
        {
            Console.WriteLine("Start");
        }
        public virtual void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }
        public virtual void PausePlayingContent()
        {
            Console.WriteLine("Pause");
        }
        public virtual void ContinuePlayingCOntent()
        {
            Console.WriteLine("Continue");
        }
        public override string ToString()
        {
            Console.WriteLine("Media ToString");
            return "OTT";
        }
    }//End of media class
    internal class AudioContent : MediaContent
    {
        public override sealed void StartPlayingContent()
        {
            Console.WriteLine("start from Audiocontent"); //polymorphism is possible only for virtual
        }
       /* public override string ToString()
        {
            Console.WriteLine("AudioContent ToString");
            return "AudioContent";
        }*/
    }
    internal class VideoContent : AudioContent
    {
        //sealed class cant be inherited. how to prevent virtual to stop.. done by using seal along with override
        //public override void StartPlayingContent()
        
    }
//End of videocontent
//by default it is not possible override methods of the parent
//child class cannot override parents class methods
internal class MediaTester
    {
        public static void TestOne()
    {

    }
   }
}
