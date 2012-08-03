using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the first few notes of the song, "Mary Had A Little Lamb".
            Note[] Mary = 
            {
                new Note(Tone.B3, Duration.QUARTER),
                new Note(Tone.A3, Duration.QUARTER),
                new Note(Tone.G3, Duration.QUARTER),
                new Note(Tone.A3, Duration.QUARTER),
                new Note(Tone.B3, Duration.QUARTER),
                new Note(Tone.B3, Duration.QUARTER),
                new Note(Tone.B3, Duration.HALF),
                new Note(Tone.A3, Duration.QUARTER),
                new Note(Tone.A3, Duration.QUARTER),
                new Note(Tone.A3, Duration.HALF),
                new Note(Tone.B3, Duration.QUARTER),
                new Note(Tone.D4, Duration.QUARTER),
                new Note(Tone.D4, Duration.HALF)
            };

            Note[] AnonymousVerse = 
            {
                new Note(Tone.Fsharp3_Gflat3, Duration.QUARTER),
                new Note(Tone.Fsharp3_Gflat3, Duration.QUARTER),
                new Note(Tone.Fsharp3_Gflat3, Duration.QUARTER),
                new Note(Tone.Fsharp3_Gflat3, Duration.QUARTER),

                new Note(Tone.G3, Duration.QUARTER),
                new Note(Tone.G3, Duration.QUARTER),
                new Note(Tone.G3, Duration.EIGHTH),
                new Note(Tone.Fsharp3_Gflat3, Duration.EIGHTH),

                new Note(Tone.G3, Duration.EIGHTH),
                new Note(Tone.Fsharp3_Gflat3, Duration.EIGHTH),
                new Note(Tone.G3, Duration.EIGHTH),
                new Note(Tone.Fsharp3_Gflat3, Duration.EIGHTH),

                new Note(Tone.E3, Duration.WHOLE)
            };

            Note[] AnonymousChorus = 
            {
                new Note(Tone.E3, Duration.EIGHTH),
                new Note(Tone.E3, Duration.EIGHTH),
                new Note(Tone.REST, Duration.EIGHTH),
                new Note(Tone.D3, Duration.EIGHTH),

                new Note(Tone.E3, Duration.EIGHTH),
                new Note(Tone.E3, Duration.EIGHTH),
                new Note(Tone.REST, Duration.EIGHTH),
                new Note(Tone.D3, Duration.EIGHTH),

                new Note(Tone.E3, Duration.EIGHTH),
                new Note(Tone.E3, Duration.EIGHTH),
                new Note(Tone.REST, Duration.EIGHTH),
                new Note(Tone.D3, Duration.EIGHTH),
                new Note(Tone.E3, Duration.EIGHTH),
                new Note(Tone.D3, Duration.EIGHTH),
                new Note(Tone.E3, Duration.EIGHTH),
                new Note(Tone.D3, Duration.EIGHTH)
            };

            Note[] CanonD = 
            {
                new Note(Tone.D3, Duration.WHOLE),
                new Note(Tone.A2, Duration.WHOLE),
                new Note(Tone.B2, Duration.WHOLE),
                new Note(Tone.Fsharp2_Gflat2, Duration.WHOLE),
                new Note(Tone.G2, Duration.WHOLE),
                new Note(Tone.D3, Duration.WHOLE),
                new Note(Tone.G2, Duration.WHOLE),
                new Note(Tone.A2, Duration.WHOLE)
            };

            Note[] Yankee = 
            {
                new Note(Tone.C4, Duration.QUARTER),
                new Note(Tone.C4, Duration.QUARTER),
                new Note(Tone.D4, Duration.QUARTER),
                new Note(Tone.E4, Duration.QUARTER),
                new Note(Tone.C4, Duration.QUARTER),
                new Note(Tone.E4, Duration.QUARTER),
                new Note(Tone.D4, Duration.HALF),
                
                new Note(Tone.C4, Duration.QUARTER),
                new Note(Tone.C4, Duration.QUARTER),
                new Note(Tone.D4, Duration.QUARTER),
                new Note(Tone.E4, Duration.QUARTER),
                new Note(Tone.C4, Duration.HALF),
                new Note(Tone.B3, Duration.QUARTER)
            };

            //Play(AnonymousVerse);
            //Play(AnonymousChorus);

            Play(Yankee);
        }

        /// <summary>
        /// Play the notes in a song.
        /// </summary>
        /// <param name="tune"></param>
        protected static void Play(Note[] tune)
        {
            foreach (Note n in tune)
            {
                if (n.NoteTone == Tone.REST)
                    Thread.Sleep((int)n.NoteDuration);
                else
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }

        /// <summary>
        /// Define the frequencies of notes in an octave, as well as silence (rest).
        /// </summary>
        /// 
        protected enum Tone
        {
            REST = 0,
            D1 = 37,
            Dsharp1_Eflat1 = 39,
            E1 = 41,
            F1 = 44,
            Fsharp1_Gflat1 = 46,
            G1 = 49,
            Gsharp1_Aflat1 = 52,
            A1 = 55,
            Asharp1_Bflat1 = 58,
            B1 = 62,
            C2 = 65,
            Csharp2_Dflat2 = 69,
            D2 = 73,
            Dsharp2_Eflat2 = 78,
            E2 = 82,
            F2 = 87,
            Fsharp2_Gflat2 = 93,
            G2 = 98,
            Gsharp2_Aflat2 = 104,
            A2 = 110,
            Asharp2_Bflat2 = 117,
            B2 = 123,
            C3 = 131,
            Csharp3_Dflat3 = 139,
            D3 = 147,
            Dsharp3_Eflat3 = 156,
            E3 = 165,
            F3 = 175,
            Fsharp3_Gflat3 = 185,
            G3 = 196,
            Gsharp3_Aflat3 = 208,
            A3 = 220,
            Asharp3_Bflat3 = 233,
            B3 = 247,
            C4 = 262,
            Csharp4_Dflat4 = 277,
            D4 = 294,
            Dsharp4_Eflat4 = 311,
            E4 = 330,
            F4 = 349,
            Fsharp4_Gflat4 = 370,
            G4 = 392,
            Gsharp4_Aflat4 = 415,
            A4 = 440,
            Asharp4_Bflat4 = 466,
            B4 = 494,
            C5 = 523,
            Csharp5_Dflat5 = 554,
            D5 = 587,
            Dsharp5_Eflat5 = 622,
            E5 = 659,
            F5 = 698,
            Fsharp5_Gflat5 = 740,
            G5 = 784,
            Gsharp5_Aflat5 = 831,
            A5 = 880,
            Asharp5_Bflat5 = 932,
            B5 = 988,
            C6 = 1047,
            Csharp6_Dflat6 = 1109,
            D6 = 1175,
            Dsharp6_Eflat6 = 1245,
            E6 = 1319,
            F6 = 1397,
            Fsharp6_Gflat6 = 1480,
            G6 = 1568,
            Gsharp6_Aflat6 = 1661,
            A6 = 1760,
            Asharp6_Bflat6 = 1865,
            B6 = 1976,
            C7 = 2093,
            Csharp7_Dflat7 = 2217,
            D7 = 2349,
            Dsharp7_Eflat7 = 2489,
            E7 = 2637,
            F7 = 2794,
            Fsharp7_Gflat7 = 2960,
            G7 = 3136,
            Gsharp7_Aflat7 = 3322,
            A7 = 3520,
            Asharp7_Bflat7 = 3729
        }

        /// <summary>
        /// Define the duration of a note in units of milliseconds.
        /// </summary>
        protected enum Duration
        {
            WHOLE = 1600,
            HALF = WHOLE / 2,
            QUARTER = HALF / 2,
            EIGHTH = QUARTER / 2,
            SIXTEENTH = EIGHTH / 2,
        }

        /// <summary>
        /// Define a note as a frequency (tone) and the amount of time (duration) the note plays.
        /// </summary>
        protected class Note
        {
            // Define a constructor to create a specific note.
            public Note(Tone frequency, Duration time)
            {
                NoteTone = frequency;
                NoteDuration = time;
            }

            // Define properties to return the note's tone and duration.
            public Tone NoteTone { get; private set; }
            public Duration NoteDuration { get; private set; }
        }
    }
}