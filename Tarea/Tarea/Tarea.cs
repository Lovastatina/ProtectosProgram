using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Tarea
    {
        static void Main(string[] args)
        {
            Cancion Vampira = new Cancion();
            Vampira.bpm = 90;
            Vampira.dura = 204;
            Vampira.anio = 1996;
            Vampira.compas = new Compas();
            Vampira.compas.numerador = 4;
            Vampira.compas.denominador = 4;

            Cancion Waltzno2 = new Cancion();
            Waltzno2.bpm = 180;
            Waltzno2.dura = 223;
            Waltzno2.anio = 2020;
            Waltzno2.compas = new Compas();
            Waltzno2.compas.numerador = 2;
            Waltzno2.compas.denominador = 3;

            Cancion CorazondeOro = new Cancion();
            CorazondeOro.bpm = 112;
            CorazondeOro.dura = 227;
            CorazondeOro.anio = 1998;
            CorazondeOro.compas = new Compas();
            CorazondeOro.compas.numerador = 4;
            CorazondeOro.compas.denominador = 4;

            Cancion CincoCuartos = new Cancion();
            CincoCuartos.bpm = 96;
            CincoCuartos.dura = 162;
            CincoCuartos.anio = 2001;
            CincoCuartos.compas = new Compas();
            CincoCuartos.compas.numerador = 5;
            CincoCuartos.compas.denominador = 4;

            Cancion OloraGas = new Cancion();
            OloraGas.bpm = 101;
            OloraGas.dura = 222;
            OloraGas.anio = 1997;
            OloraGas.compas = new Compas();
            OloraGas.compas.numerador = 6;
            OloraGas.compas.denominador = 8;

            //-----------------------------------------------------------------------------------------------------------------------

            Album ParaTerminar = new Album();
            ParaTerminar.anio = 1988;
            ParaTerminar.collab = 0;
            ParaTerminar.duracion = 2240;
            ParaTerminar.num = 8;

            Album MMFOOD = new Album();
            MMFOOD.anio = 2004;
            MMFOOD.collab = 4;
            MMFOOD.duracion = 2934;
            MMFOOD.num = 15;

            Album Formidable = new Album();
            Formidable.anio = 2014;
            Formidable.collab = 0;
            Formidable.duracion = 2391;
            Formidable.num = 11;

            Album EverydayRobots = new Album();
            EverydayRobots.anio = 2014;
            EverydayRobots.collab = 3;
            EverydayRobots.duracion = 2801;
            EverydayRobots.num = 12;

            Album UGK = new Album();
            UGK.anio = 2006;
            UGK.collab = 22;
            UGK.duracion = 7740;
            UGK.num = 29;

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            Artista SantiagoTavella = new Artista();
            SantiagoTavella.albums = 4;
            SantiagoTavella.singep = 8;
            SantiagoTavella.aniodebt = 1984;
            SantiagoTavella.edad = 62;

            Artista MattMaltese = new Artista();
            MattMaltese.albums = 4;
            MattMaltese.singep = 27;
            MattMaltese.aniodebt = 2015;
            MattMaltese.edad = 25;

            Artista DavePorter = new Artista();
            DavePorter.albums = 8;
            DavePorter.singep = 3;
            DavePorter.aniodebt = 2000;
            DavePorter.edad = 44;

            Artista JoseJose = new Artista();
            JoseJose.albums = 31;
            JoseJose.singep = 1;
            JoseJose.aniodebt = 1967;
            JoseJose.edad = 71;

            Artista KittyKallen = new Artista();
            KittyKallen.albums =6;
            KittyKallen.singep= 50;
            KittyKallen.aniodebt = 1942;
            KittyKallen.edad = 94;

               


            




        }
    }
}
