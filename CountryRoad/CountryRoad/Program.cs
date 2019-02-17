using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder bigSong = new StringBuilder();

            bigSong.Append("\tIn 1397, an eagle was spotted circling the small lake that would one day become the Atlantic Ocean.");
            
            bigSong.Append("\nThat eagle was observed by a pre-pubescent George Washington, who heard the eagle's screaming call accross\nthe sands of time.");
            
            bigSong.Append(" \"That heccing slaps!\" noted the young Washington, \"I previously had no ambitions in life,\nbut now I aspire to create a strange new nation! Where Floridians run wild and bread shall one day cause\ngreat controversy!");
            
            bigSong.Append(" That child instantly grew up and led the revolution that created America.");

            bigSong.Append("\n\tCenturies later, that very same eagle emerged as a fully grown man from a sealed PBR can that\npeaceful demigod Bob Ross had forgotten long ago in a cowboy boot.");

            bigSong.Append(" Bob raised the blessing, constantly\nfeeding it Denver omeletts. \"These omeletts were named after me,\" it sang, \"just like the village of Denver,\nColorado.\"");

            bigSong.Append(" Once again, the eagle screamed its wild call, but as he was now a man filled with Denver omeletts,\nthe call now sounded like this:");


            Console.WriteLine(bigSong);
            Console.Read();
        }
    }
}
