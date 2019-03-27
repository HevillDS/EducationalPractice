using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    class Program
    {
        private static Band GetDisturbed()
        {
            Band Disturbed = new Band();
            Disturbed.Country = USA;
            Disturbed.StartYear = 1994;
            Disturbed.Lanuage = english;
            Disturbed.Instruments = Vocal, BackVocal, SoloGuitar, RhythmGuitar, BassGuitar, Percussio;
            Disturbed.Genres = new Genres
            {
               MainGenre = Metal;
               Subgenres = alternativeMetal, nuMetal, heavyMetal, hardRock;
            }
            Disturbed.Members = new Members
            {
                Leader = DavidDraiman;
                Others = DanDonegan, JohnMoyer, MikeWengren;

            }
            return Disturbed;
            }

        private static Band GetSlipknot()
        {
            Band Slipknot = new Band();
            Slipknot.Country = USA;
            Slipknot.StartYear = 1995;
            Slipknot.Lanuage = english;
            Slipknot.Instruments = Vocal, BackVocal, SoloGuitar, RhythmGuitar, BassGuitar, Percussio, DJmixer, KeyboardInstrument;
            Slipknot.Genres = new Genres
            {
               MainGenre = Metal;
               Subgenres = alternativeMetal, nuMetal, grooveMetal;
            }
            Slipknot.Members = new Members
            {
                Leader = CoreyTaylor;
                Others = MickThompson, JamesRoot, ShawnCrahan, ChrisFehn, AlessandroVenturella, JayWeinberg, SidWyilson, CraigJones;

            }
            return Slipknot;
        }

        private static Band GetBringMeTheHorizon()
        {
            Band BringMeTheHorizon = new Band();
            BringMeTheHorizon.Country = UK;
            BringMeTheHorizon.StartYear = 2004;
            BringMeTheHorizon.Lanuage = english;
            BringMeTheHorizon.Instruments = Vocal, BackVocal, SoloGuitar, RhythmGuitar, BassGuitar, Percussio, KeyboardInstrument;
            BringMeTheHorizon.Genres = new Genres
            {
               MainGenre = Metalcore;
               Subgenres = alternativeRock, popMetal, grooveMetal;
            }
            BringMeTheHorizon.Members = new Members
            {
                Leader = OliverSykes;
                Others = LiMalia, MattNicolls, MattKin, JordanFish;

            }
            return BringMeTheHorizon;
        }
    }
}
