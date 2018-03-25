using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeechLib;

namespace Speechspeak
{
    class Speech
    {
        public void Speak(string t)
        {
            string txt = t;
            SpVoice voice = new SpVoiceClass();
            voice.Speak(txt, SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);
        }
    } 
}
