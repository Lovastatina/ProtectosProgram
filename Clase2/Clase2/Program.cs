using System;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone Redmi10 = new Smartphone();
            Redmi10.namae = "Redmi 10";

            Redmi10.net = new Network();
            Redmi10.net.tech = "GSM / HSPA / LTE";
            Redmi10.net.fourg = "1, 2, 3, 4, 5, 7, 8, 20, 28, 38, 40, 41 - International";

            Redmi10.lonch = new Launch();
            Redmi10.lonch.years = 2021;
            Redmi10.lonch.avaible = true;

            Redmi10.bud = new Body();
            Redmi10.bud.weight = 178.8f;
            Redmi10.bud.build = "Glass front (Gorilla Glass 3), plastic back, plastic frame.";
            Redmi10.bud.sim = "Dual SIM (Nano-SIM, dual stand-by)";
            Redmi10.bud.dimensions = new Dimensions();
            Redmi10.bud.dimensions.large = 160.5f;
            Redmi10.bud.dimensions.wide = 74.5f;
            Redmi10.bud.dimensions.thick = 8.3f;

            Redmi10.dis = new Display();
            Redmi10.dis.type = "Super AMOLED, 450 nits (typ), 1100 nits (peak).";
            Redmi10.dis.size = 99.8f;
            Redmi10.dis.reslarge = 1080;
            Redmi10.dis.reswide = 2040;
            Redmi10.dis.proct = "Corning Gorilla Glass 3.";

            Redmi10.plat = new Platform();
            Redmi10.plat.os = "Android 11, upgradable to Android 12, MIUI 14.";
            Redmi10.plat.CPU = "Octa-core (2x2.2 GHz Kryo 460 Gold & 6x1.7 GHz Kryo 460 Silver).";
            Redmi10.plat.GPU = "Adreno 612.";
            Redmi10.plat.chipset = "Qualcomm SDM678 Snapdragon 678 (11 nm).";

            Redmi10.memo = new MemInt();
            Redmi10.memo.memcardslot = "microSDXC (dedicated slot)";
            Redmi10.memo.ram = 6;
            Redmi10.memo.ufs = 2.2f;
            Redmi10.memo.storage = 128;

            Redmi10.main = new Maincam();
            Redmi10.main.quad1 = "48 MP, f/1.8, 26mm (wide), 1/2.0, 0.8µm, PDAF";
            Redmi10.main.quad2 = "8 MP, f/2.2, 118˚ (ultrawide), 1/4.0, 1.12µm";
            Redmi10.main.quad3 = "2 MP, f/2.4, (macro)";
            Redmi10.main.quad4 = "2 MP, f/2.4, (depth)";
            Redmi10.main.feat = "LED flash, HDR, panorama.";
            Redmi10.main.vidquality = 1080;
            Redmi10.main.vidframes = 60;

            Redmi10.self = new SelfCam();
            Redmi10.self.single = "13 MP, f/2.5, (wide), 1/3.06'', 1.12µm.";
            Redmi10.self.features = "HDR.";
            Redmi10.self.vidfps = 30;
            Redmi10.self.vidqual = 1080;

            Redmi10.sound = new Sound();
            Redmi10.sound.loudspeak = true;
            Redmi10.sound.jack = true;

            Redmi10.Com = new Comms();
            Redmi10.Com.wlan = "Wi-Fi 802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct";
            Redmi10.Com.blue = 5;
            Redmi10.Com.nfc = false;
            Redmi10.Com.infrared = true;
            Redmi10.Com.radio = "FM radio, recording";
            Redmi10.Com.usb = "USB Type - C 2.0";

            Redmi10.feat = new Features();
            Redmi10.feat.accel = true;
            Redmi10.feat.compass = true;
            Redmi10.feat.Finger = true;
            Redmi10.feat.gyro = true;

            Redmi10.bat = new Battery();
            Redmi10.bat.thype = "Li-Po 5000 mAh";
            Redmi10.bat.chargeto100 = 74;
            Redmi10.bat.removable = false;

            Redmi10.misc = new Misc();
            Redmi10.misc.color = "Shadow Black (Onyx Gray), Frost White (Pebble White), Aqua Green (Lake Green)";
            Redmi10.misc.mod = "M2101K7AI, M2101K7AG";
            Redmi10.misc.sarh = 1.09f;
            Redmi10.misc.sarb = 1.09f;
            Redmi10.misc.sareuh = 0.59f;
            Redmi10.misc.sareub = 0.97f;
            Redmi10.misc.cost = 249.99f;
















        }
    }
}
