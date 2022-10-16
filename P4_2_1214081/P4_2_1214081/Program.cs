using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214081
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Champion
            Champion Ahri = new Champion();
            Ahri.nama = "Ahri";
            Ahri.title = "The Nine-Tailed Fox";
            Ahri.role = "Burst";
            Ahri.position = "Mid Lane";

            Champion Akali = new Champion();
            Akali.nama = "Akali";
            Akali.title = "The Rogue Assassin";
            Akali.role = "Assassin";
            Akali.position = "Mid Lane";

            Champion Akshan = new Champion();
            Akshan.nama = "Akshan";
            Akshan.title = "The Rogue Sentinel";
            Akshan.role = "Marksman sekaligus Assassin";
            Akshan.position = "Mid Lane dan Duo Lane";

            Champion Alistar = new Champion();
            Alistar.nama = "Alistar";
            Alistar.title = "The Minotaur";
            Alistar.role = "Vanguard";
            Alistar.position = "Support Lane";

            Champion Amumu = new Champion();
            Amumu.nama = "Amumu";
            Amumu.title = "The Sad Mummy";
            Amumu.role = "Vanguard";
            Amumu.position = "Jungle";

            Champion Annie = new Champion();
            Annie.nama = "Annie";
            Annie.title = "The Dark Child";
            Annie.role = "Burst";
            Annie.position = "Mid Lane dan Support Lane";

            Champion Ashe = new Champion();
            Ashe.nama = "Ashe";
            Ashe.title = "The Frost Archer";
            Ashe.role = "Marksman";
            Ashe.position = "Duo Lane";

            Champion AurelionSol = new Champion();
            AurelionSol.nama = "Aurelion Sol";
            AurelionSol.title = "The Star Forger";
            AurelionSol.role = "Battlemage";
            AurelionSol.position = "Mid Lane";

            Champion Blitzcrank = new Champion();
            Blitzcrank.nama = "Blitzcrank";
            Blitzcrank.title = "The Great Steam Golem";
            Blitzcrank.role = "Catcher";
            Blitzcrank.position = "Support Lane";

            Champion Brand = new Champion();
            Brand.nama = "Brand";
            Brand.title = "The Burning Vengeance";
            Brand.role = "Burst";
            Brand.position = "Mid Lane dan Support Lane";

            Champion Braum = new Champion();
            Braum.nama = "Braum";
            Braum.title = "The Heart of the Freljord";
            Braum.role = "Warden";
            Braum.position = "Support Lane";

            Champion Caitlyn = new Champion();
            Caitlyn.nama = "Caitlyn";
            Caitlyn.title = "The Sheriff of Piltover";
            Caitlyn.role = "Marksman";
            Caitlyn.position = "Duo Lane";

            Champion Camille = new Champion();
            Camille.nama = "Camille";
            Camille.title = "The Steel Shadow";
            Camille.role = "Diver";
            Camille.position = "Solo Lane dan Jungle";

            Champion Corki = new Champion();
            Corki.nama = "Corki";
            Corki.title = "The Daring Bombardier";
            Corki.role = "Marksman";
            Corki.position = "Mid Lane dan Duo Lane";

            Champion Darius = new Champion();
            Darius.nama = "Darius";
            Darius.title = "The Hand of Noxus";
            Darius.role = "Juggernaut";
            Darius.position = "Solo Lane";

            Champion Diana = new Champion();
            Diana.nama = "Diana";
            Diana.title = "The Scorn of the Moon";
            Diana.role = "Assassin sekaligus Diver";
            Diana.position = "Mid Lane";

            Champion DrMundo = new Champion();
            DrMundo.nama = "Dr. Mundo";
            DrMundo.title = "The Madman of Zaun";
            DrMundo.role = "Juggernaut";
            DrMundo.position = "Solo Lane dan Jungle";

            Champion Draven = new Champion();
            Draven.nama = "Draven";
            Draven.title = "The Glorious Executioner";
            Draven.role = "Marksman";
            Draven.position = "Duo Lane";

            Champion Ekko = new Champion();
            Ekko.nama = "Ekko";
            Ekko.title = "The Boy Who Shattered Time";
            Ekko.role = "Assassin";
            Ekko.position = "Mid Lane dan Jungle";

            Champion Evelynn = new Champion();
            Evelynn.nama = "Evelynn";
            Evelynn.title = "Agony's Embrace";
            Evelynn.role = "Assassin";
            Evelynn.position = "Jungle";

            Champion Ezreal = new Champion();
            Ezreal.nama = "Ezreal";
            Ezreal.title = "The Prodigal Explorer";
            Ezreal.role = "Marksman";
            Ezreal.position = "Duo Lane";

            Champion Fiora = new Champion();
            Fiora.nama = "Fiora";
            Fiora.title = "The Grand Duelist";
            Fiora.role = "Skirmisher";
            Fiora.position = "Solo Lane";

            Champion Fizz = new Champion();
            Fizz.nama = "Fizz";
            Fizz.title = "The Tidal Trickster";
            Fizz.role = "Assassin";
            Fizz.position = "Mid Lane";

            Champion Galio = new Champion();
            Galio.nama = "Galio";
            Galio.title = "The Colossus";
            Galio.role = "Z";
            Galio.position = "Mid Lane dan Support Lane";

            Champion Garen = new Champion();
            Garen.nama = "Garen";
            Garen.title = "The Might of Demacia";
            Garen.role = "Warden";
            Garen.position = "Solo Lane";

            Champion Gragas = new Champion();
            Gragas.nama = "Gragas";
            Gragas.title = "The Rabble Rouser";
            Gragas.role = "Vanguard";
            Gragas.position = "Mid Lane, Solo Lane dan Jungle";

            Champion Graves = new Champion();
            Graves.nama = "Graves";
            Graves.title = "The Outlaw";
            Graves.role = "Specialist";
            Graves.position = "Jungle dan Solo Lane";

            Champion Gwen = new Champion();
            Gwen.nama = "Gwen";
            Gwen.title = "The Hallowed Seamstress";
            Gwen.role = "Skirmisher";
            Gwen.position = "Solo Lane dan Jungle";

            Champion Irelia = new Champion();
            Irelia.nama = "Irelia";
            Irelia.title = "The Blade Dancer";
            Irelia.role = "Diver";
            Irelia.position = "Solo Lane, Mid Lane dan Jungle";

            Champion Janna = new Champion();
            Janna.nama = "Janna";
            Janna.title = "The Storm's Fury";
            Janna.role = "Enchanter";
            Janna.position = "Support Lane";

            Champion JarvanIV = new Champion();
            JarvanIV.nama = "Jarvan IV";
            JarvanIV.title = "The Exemplar of Demacia";
            JarvanIV.role = "Diver";
            JarvanIV.position = "Jungle";

            Champion Jax = new Champion();
            Jax.nama = "Jax";
            Jax.title = "Grandmaster at Arms";
            Jax.role = "Skirmisher";
            Jax.position = "Solo Lane dan Jungle";

            Champion Jayce = new Champion();
            Jayce.nama = "Jayce";
            Jayce.title = "The Defender of Tomorrow";
            Jayce.role = "Artillery";
            Jayce.position = "Solo Lane";

            Champion Jhin = new Champion();
            Jhin.nama = "Jhin";
            Jhin.title = "The Virtuoso";
            Jhin.role = "Marksman sekaligus Catcher";
            Jhin.position = "Duo Lane";

            Champion Jinx = new Champion();
            Jinx.nama = "Jinx";
            Jinx.title = "The Loose Cannon";
            Jinx.role = "Marksman";
            Jinx.position = "Duo Lane";

            Champion KaiSa = new Champion();
            KaiSa.nama = "Kai'Sa";
            KaiSa.title = "Daughter of the Void";
            KaiSa.role = "Marksman";
            KaiSa.position = "Duo Lane";

            Champion Karma = new Champion();
            Karma.nama = "Karma";
            Karma.title = "The Enlightened One";
            Karma.role = "Burst sekaligus Enchanter";
            Karma.position = "Support Lane";

            Champion Kassadin = new Champion();
            Kassadin.nama = "Kassadin";
            Kassadin.title = "The Void Walker";
            Kassadin.role = "Assassin";
            Kassadin.position = "Mid Lane";

            Champion Katarina = new Champion();
            Katarina.nama = "Katarina";
            Katarina.title = "The Sinister Blade";
            Katarina.role = "Assassin";
            Katarina.position = "Mid Lane";

            Champion Kayle = new Champion();
            Kayle.nama = "Kayle";
            Kayle.title = "The Righteous";
            Kayle.role = "Specialist";
            Kayle.position = "Solo Lane";

            Champion Kennen = new Champion();
            Kennen.nama = "Kennen";
            Kennen.title = "The Heart of the Tempest";
            Kennen.role = "Specialist";
            Kennen.position = "Solo Lane dan Mid Lane";

            Champion KhaZix = new Champion();
            KhaZix.nama = "Kha'Zix";
            KhaZix.title = "The Voidreaver";
            KhaZix.role = "Assassin";
            KhaZix.position = "Jungle";

            Champion LeeSin = new Champion();
            LeeSin.nama = "Lee Sin";
            LeeSin.title = "The Blind Monk";
            LeeSin.role = "Diver";
            LeeSin.position = "Jungle";

            Champion Leona = new Champion();
            Leona.nama = "Leona";
            Leona.title = "The Radiant Dawn";
            Leona.role = "Vanguard";
            Leona.position = "Support Lane";

            Champion Lucian = new Champion();
            Lucian.nama = "Lucian";
            Lucian.title = "The Purifier";
            Lucian.role = "Marksman";
            Lucian.position = "Duo Lane, Mid Lane dan Solo Lane";

            Champion Lulu = new Champion();
            Lulu.nama = "Lulu";
            Lulu.title = "The Fae Sorceress";
            Lulu.role = "Enchanter";
            Lulu.position = "Support Lane";

            Champion Lux = new Champion();
            Lux.nama = "Lux";
            Lux.title = "The Lady of Luminosity";
            Lux.role = "Burst sekaligus Artillery";
            Lux.position = "Support Lane";

            Champion Malphite = new Champion();
            Malphite.nama = "Malphite";
            Malphite.title = "Shard of the Monolith";
            Malphite.role = "Vanguard";
            Malphite.position = "Solo Lane dan Support Lane";

            Champion MasterYi = new Champion();
            MasterYi.nama = "Master Yi";
            MasterYi.title = "The Wuju Bladesman";
            MasterYi.role = "Skirmisher";
            MasterYi.position = "Jungle";

            Champion MissFortune = new Champion();
            MissFortune.nama = "Miss Fortune";
            MissFortune.title = "The Bounty Hunter";
            MissFortune.role = "Marksman";
            MissFortune.position = "Duo Lane";

            Champion Morgana = new Champion();
            Morgana.nama = "Morgana";
            Morgana.title = "The Fallen";
            Morgana.role = "Catcher";
            Morgana.position = "Support Lane dan Jungle";

            Champion Nami = new Champion();
            Nami.nama = "Nami";
            Nami.title = "The Tidecaller";
            Nami.role = "Enchanter";
            Nami.position = "Support Lane";

            Champion Nasus = new Champion();
            Nasus.nama = "Nasus";
            Nasus.title = "The Curator of the Sands";
            Nasus.role = "Juggernaut";
            Nasus.position = "Solo Lane dan Support Lane";

            Champion Nautilus = new Champion();
            Nautilus.nama = "Nautilus";
            Nautilus.title = "The Titan of the Depths";
            Nautilus.role = "Vanguard";
            Nautilus.position = "Support Lane dan Jungle";

            Champion NunuWillump = new Champion();
            NunuWillump.nama = "Nunu & Willump";
            NunuWillump.title = "The Boy and His Yeti";
            NunuWillump.role = "Vanguard";
            NunuWillump.position = "Jungle";

            Champion Olaf = new Champion();
            Olaf.nama = "Olaf";
            Olaf.title = "The Berserker";
            Olaf.role = "Diver";
            Olaf.position = "Jungle dan Solo Lane";

            Champion Orianna = new Champion();
            Orianna.nama = "Orianna";
            Orianna.title = "The Lady of Clockwork";
            Orianna.role = "Burst";
            Orianna.position = "Mid Lane dan Support";

            Champion Pantheon = new Champion();
            Pantheon.nama = "Pantheon";
            Pantheon.title = "The Unbreakable Spear";
            Pantheon.role = "Diver";
            Pantheon.position = "Solo Lane dan Jungle";

            Champion Pyke = new Champion();
            Pyke.nama = "Pyke";
            Pyke.title = "The Bloodharbor Ripper";
            Pyke.role = "Assassin sekaligus Catcher";
            Pyke.position = "Support Lane, Mid Lane, Solo Lane dan Jungle";

            Champion Rakan = new Champion();
            Rakan.nama = "Rakan";
            Rakan.title = "The Charmer";
            Rakan.role = "Catcher";
            Rakan.position = "Support Lane";

            Champion Rammus = new Champion();
            Rammus.nama = "Rammus";
            Rammus.title = "The Armordillo";
            Rammus.role = "Vanguard";
            Rammus.position = "Jungle";

            Champion Renekton = new Champion();
            Renekton.nama = "Renekton";
            Renekton.title = "The Butcher of the Sands";
            Renekton.role = "Diver";
            Renekton.position = "Solo Lane";

            Champion Rengar = new Champion();
            Rengar.nama = "Rengar";
            Rengar.title = "The Pridestalker";
            Rengar.role = "Assassin sekaligus Diver";
            Rengar.position = "Jungle";

            Champion Riven = new Champion();
            Riven.nama = "Riven";
            Riven.title = "The Exile";
            Riven.role = "Skirmisher";
            Riven.position = "Solo Lane dan Jungle";

            Champion Samira = new Champion();
            Samira.nama = "Samira";
            Samira.title = "The Desert Rose";
            Samira.role = "Marksman";
            Samira.position = "Duo Lane";

            Champion Senna = new Champion();
            Senna.nama = "Senna";
            Senna.title = "The Redeemer";
            Senna.role = "Marksman sekaligus Enchanter";
            Senna.position = "Support Lane dan Duo Lane";

            Champion Seraphine = new Champion();
            Seraphine.nama = "Seraphine";
            Seraphine.title = "The Starry-Eyed Songstress";
            Seraphine.role = "Burst sekaligus Enchanter";
            Seraphine.position = "Support Lane dan Mid Lane";

            Champion Sett = new Champion();
            Sett.nama = "Sett";
            Sett.title = "The Boss";
            Sett.role = "Juggernaut";
            Sett.position = "Solo Lane";

            Champion Shen = new Champion();
            Shen.nama = "Shen";
            Shen.title = "Eye of Twilight";
            Shen.role = "Warden";
            Shen.position = "Solo Lane dan Jungle";

            Champion Shyvana = new Champion();
            Shyvana.nama = "Shyvana";
            Shyvana.title = "The Half-Dragon";
            Shyvana.role = "Z";
            Shyvana.position = "Jungle";

            Champion Singed = new Champion();
            Singed.nama = "Singed";
            Singed.title = "Mad Chemist";
            Singed.role = "Juggernaut";
            Singed.position = "Solo Lane";

            Champion Sion = new Champion();
            Sion.nama = "Sion";
            Sion.title = "The Undead Juggernaut";
            Sion.role = "Vanguard";
            Sion.position = "Solo Lane dan Jungle";

            Champion Sona = new Champion();
            Sona.nama = "Sona";
            Sona.title = "The Maven of the Strings";
            Sona.role = "Enchanter";
            Sona.position = "Support Lane";

            Champion Soraka = new Champion();
            Soraka.nama = "Soraka";
            Soraka.title = "The Starchild";
            Soraka.role = "Enchanter";
            Soraka.position = "Support Lane";

            Champion Teemo = new Champion();
            Teemo.nama = "Teemo";
            Teemo.title = "The Swift Scout";
            Teemo.role = "Specialist";
            Teemo.position = "Solo Lane dan Mid Lane";

            Champion Thresh = new Champion();
            Thresh.nama = "Thresh";
            Thresh.title = "The Chain Warden";
            Thresh.role = "Catcher";
            Thresh.position = "Support Lane";

            Champion Tristana = new Champion();
            Tristana.nama = "Tristana";
            Tristana.title = "The Megling Gunner";
            Tristana.role = "Marksman";
            Tristana.position = "Duo Lane";

            Champion Tryndamere = new Champion();
            Tryndamere.nama = "Tryndamere";
            Tryndamere.title = "The Barbarian King";
            Tryndamere.role = "Skirmisher";
            Tryndamere.position = "Jungle dan Solo Lane";

            Champion TwistedFate = new Champion();
            TwistedFate.nama = "Twisted Fate";
            TwistedFate.title = "The Card Master";
            TwistedFate.role = "Burst";
            TwistedFate.position = "Mid Lane";

            Champion Varus = new Champion();
            Varus.nama = "Varus";
            Varus.title = "The Arrow of Retribution";
            Varus.role = "Marksman sekaligus Artillery";
            Varus.position = "Duo Lane";

            Champion Vayne = new Champion();
            Vayne.nama = "Vayne";
            Vayne.title = "The Night Hunter";
            Vayne.role = "Marksman";
            Vayne.position = "Duo Lane dan Solo Lane";

            Champion Veigar = new Champion();
            Veigar.nama = "Veigar";
            Veigar.title = "The Tiny Master of Evil";
            Veigar.role = "Burst";
            Veigar.position = "Mid Lane";

            Champion Vi = new Champion();
            Vi.nama = "Vi";
            Vi.title = "The Piltover Enforcer";
            Vi.role = "Diver";
            Vi.position = "Jungle";

            Champion Wukong = new Champion();
            Wukong.nama = "Wukong";
            Wukong.title = "The Monkey King";
            Wukong.role = "Diver";
            Wukong.position = "Jungle";

            Champion Xayah = new Champion();
            Xayah.nama = "Xayah";
            Xayah.title = "The Rebel";
            Xayah.role = "Marksman";
            Xayah.position = "Duo Lane";

            Champion XinZhao = new Champion();
            XinZhao.nama = "Xin Zhao";
            XinZhao.title = "The Seneschal of Demacia";
            XinZhao.role = "Diver";
            XinZhao.position = "Jungle";

            Champion Yasuo = new Champion();
            Yasuo.nama = "Yasuo";
            Yasuo.title = "The Unforgiven";
            Yasuo.role = "Skirmisher";
            Yasuo.position = "Mid Lane dan Solo Lane";

            Champion Yone = new Champion();
            Yone.nama = "Yone";
            Yone.title = "The Unforgotten";
            Yone.role = "Assassin sekaligus Skirmisher";
            Yone.position = "Mid Lane dan Solo Lane";

            Champion Yuumi = new Champion();
            Yuumi.nama = "Yuumi";
            Yuumi.title = "The Magical Cat";
            Yuumi.role = "Enchanter";
            Yuumi.position = "Support Lane";

            Champion Zed = new Champion();
            Zed.nama = "Zed";
            Zed.title = "The Master of Shadows";
            Zed.role = "Assassin";
            Zed.position = "Mid Lane";

            Champion Ziggs = new Champion();
            Ziggs.nama = "Ziggs";
            Ziggs.title = "The Hexplosives Expert";
            Ziggs.role = "Artillery";
            Ziggs.position = "Mid Lane";

            //spell champion
            Spell ahri = new Spell("Ahri", "MODERATE", "Flash dan Ignite");
            Spell akali = new Spell("Akali", "HIGH", "Flash dan Ignite");
            Spell akshan = new Spell("Akshan", "HIGH", "Flash dan Barrier");
            Spell alistar = new Spell("Alistar", "LOW", "Flash dan Ignite");
            Spell amumu = new Spell("Amumu", "LOW", "Flash dan Smite");
            Spell annie = new Spell("Annie", "LOW", "Flash dan Ignite");
            Spell ashe = new Spell("Ashe", "LOW", "Flash dan Barrier");
            Spell aurelionSol = new Spell("Aurelion Sol", "HIGH", "Flash dan Barrier");
            Spell blitzcrank = new Spell("Blitzcrank", "LOW", "Flash dan Ignite");
            Spell brand = new Spell("Brand", "LOW", "Flash dan Barrier");
            Spell braum = new Spell("Braum", "MODERATE", "Flash dan Heal");
            Spell caitlyn = new Spell("Caitlyn", "LOW", "Flash dan Barrier");
            Spell camille = new Spell("Camille", "HIGH", "Flash dan Ignite");
            Spell corki = new Spell("Corki", "MODERATE", "Flash dan Barrier");
            Spell darius = new Spell("Darius", "MODERATE", "Flash dan Ignite");
            Spell diana = new Spell("Diana", "LOW", "Flash dan Barrier");
            Spell drMundo = new Spell("Dr. Mundo", "LOW", "Flash dan Ignite");
            Spell draven = new Spell("Draven", "HIGH", "Flash dan Barrier");
            Spell ekko = new Spell("Ekko", "HIGH", "Flash dan Ignite");
            Spell evelynn = new Spell("Evelynn", "MODERATE", "Flash dan Smite");
            Spell ezreal = new Spell("Ezreal", "MODERATE", "Flash dan Barrier");
            Spell fiora = new Spell("Fiora", "HIGH", "Flash dan Ignite");
            Spell fizz = new Spell("Fizz", "MODERATE", "Flash dan Ignite");
            Spell galio = new Spell("Galio", "MODERATE", "Flash dan Ignite");
            Spell garen = new Spell("Garen", "LOW", "Flash dan Ignite");
            Spell gragas = new Spell("Gragas", "MODERATE", "Flash dan Ignite");
            Spell graves = new Spell("Graves", "MODERATE", "Flash dan Smite");
            Spell gwen = new Spell("Gwen", "MODERATE", "Flash dan Ignite");
            Spell irelia = new Spell("Irelia", "HIGH", "Flash dan Ignite");
            Spell janna = new Spell("Janna", "LOW", "Flash dan Heal");
            Spell jarvanIV = new Spell("Jarvan IV", "LOW", "Flash dan Smite");
            Spell jax = new Spell("Jax", "MODERATE", "Flash dan Ignite");
            Spell jayce = new Spell("Jayce", "HIGH", "Flash dan Barrier");
            Spell jhin = new Spell("Jhin", "MODERATE", "Flash dan Barrier");
            Spell jinx = new Spell("Jinx", "MODERATE", "Flash dan Barrier");
            Spell kaiSa = new Spell("Kai'sa", "MODERATE", "Flash dan Barrier");
            Spell karma = new Spell("Karma", "HIGH", "Flash dan Heal");
            Spell kassadin = new Spell("Kassadin", "HIGH", "Flash dan Ignite");
            Spell katarina = new Spell("Katarina", "HIGH", "Flash dan Ignite");
            Spell kayle = new Spell("Kayle", "HIGH", "Flash dan Barrier");
            Spell kennen = new Spell("Kennen", "MODERATE", "Flash dan Barrier");
            Spell khaZix = new Spell("Kha'zix", "MODERATE", "Flash dan Smite");
            Spell leeSin = new Spell("Lee Sin", "MODERATE", "Flash dan Smite");
            Spell leona = new Spell("Leona", "LOW", "Flash dan Ignite");
            Spell lucian = new Spell("Lucian", "HIGH", "Flash dan Barrier");
            Spell lulu = new Spell("Lulu", "MODERATE", "Flash dan Heal");
            Spell lux = new Spell("Lux", "LOW", "Flash dan Heal");
            Spell malphite = new Spell("Malphite", "LOW", "Flash dan Ignite");
            Spell masterYi = new Spell("Master Yi", "LOW", "Flash dan Smite");
            Spell missFortune = new Spell("Miss Fortune", "LOW", "Flash dan Barrier");
            Spell morgana = new Spell("Morgana", "LOW", "Flash dan Ignite");
            Spell nami = new Spell("Nami", "MODERATE", "Flash dan Heal");
            Spell nasus = new Spell("Nasus", "LOW", "Flash dan Ignite");
            Spell nautilus = new Spell("Nautilus", "MODERATE", "Flashdan Ignite");
            Spell nunuWillump = new Spell("Nunu & Willump ", "HIGH", "Flash dan Smite");
            Spell olaf = new Spell("Olaf", "MODERATE", "Flash dan Smite");
            Spell orianna = new Spell("Orianna", "MODERATE", "Flash dan Barrier");
            Spell pantheon = new Spell("Pantheon", "LOW", "Flash dan Ignite");
            Spell pyke = new Spell("Pyke", "MODERATE", "Flash dan Ignite");
            Spell rakan = new Spell("Rakan", "MODERATE", "Flash dan Ignite");
            Spell rammus = new Spell("Rammus", "LOW", "Flash dan Smite");
            Spell renekton = new Spell("Renekton", "HIGH", "Flash dan Ignite");
            Spell rengar = new Spell("Rengar", "MODERATE", "Flash dan Smite");
            Spell riven = new Spell("Riven", "HIGH", "Flash dan Ignite");
            Spell samira = new Spell("Samira", "HIGH", "Flash dan Exhaust");
            Spell senna = new Spell("Senna", "HIGH", "Flash dan Heal");
            Spell seraphine = new Spell("Seraphine", "LOW", "Flash dan Heal");
            Spell sett = new Spell("Sett", "LOW", "Flash dan Ignite");
            Spell shen = new Spell("Shen", "HIGH", "Flash dan Ignite");
            Spell shyvana = new Spell("Shyvana", "LOW", "Flash dan Smite");
            Spell singed = new Spell("Singed", "MODERATE", "Flash dan Ignite");
            Spell sion = new Spell("Sion", "HIGH", "Flash dan Ignite");
            Spell sona = new Spell("Sona", "LOW", "Flash dan Heal");
            Spell soraka = new Spell("Soraka", "LOW", "Flash dan Heal");
            Spell teemo = new Spell("Teemo", "LOW", "Flash dan Barrier");
            Spell thresh = new Spell("Thresh", "HIGH", "Flash dan Ignite");
            Spell tristana = new Spell("Tristana", "LOW", "Flash dan Barrier");
            Spell tryndamere = new Spell("Tryndamere", "LOW", "Flash dan Smite");
            Spell twistedFate = new Spell("Twisted Fate", "MODERATE", "Flash dan Barrier");
            Spell varus = new Spell("Varus", "MODERATE", "Flash dan Barrier");
            Spell vayne = new Spell("Vayne", "MODERATE", "Flash dan Barrier");
            Spell veigar = new Spell("Veigar", "LOW", "Flash dan Barrier");
            Spell vi = new Spell("Vi", "LOW", "Flash dan Smite");
            Spell wukong = new Spell("Wukong", "LOW", "Flash dan Smite");
            Spell xayah = new Spell("Xayah", "MODERATE", "Flash dan Barrier");
            Spell xinZhao = new Spell("Xin Zhao", "LOW", "Flash dan Smite");
            Spell yasuo = new Spell("Yasuo", "HIGH", "Flash dan Ignite");
            Spell yone = new Spell("Yone", "HIGH", "Flash dan Exhaust");
            Spell yuumi = new Spell("Yuumi", "HIGH", "Flash dan Heal");
            Spell zed = new Spell("Zed", "HIGH", "Flash dan Ignite");
            Spell ziggs = new Spell("Ziggs", "MODERATE", "Flash dan Barrier");

            var again1 = true;
            while (again1)
            {
                Console.WriteLine("");
                Console.Write("Apakan anda ingin memulai aplikasi (Y/T): ");

                var input = Console.ReadLine();
                if (input == "Y" || input == "y")
                {
                    Console.Clear();
                    again1 = false;
                }
                else if (input == "T" || input == "t")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Terimakasih telah menggunakan aplikasi ini\n");
                    again1 = false;
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\nMaaf pilihan anda tidak bisa dijalankan!!!");
                    again1 = true;
                }
            }

            var start = true;
            while (start)
            {
                Console.WriteLine("====================>MENU CHAMPION WILD RIFT<====================");

                Console.WriteLine("");

                Console.WriteLine("1.  Ahri\t\t32. Jax\t\t\t63. Rengar\r\n2.  Akali\t\t33. Jayce\t\t64. Riven\r\n3.  Akshan\t\t34. Jhin\t\t65. Samira\r\n4.  Alistar\t\t35. Jinx\t\t66. Senna\r\n5.  Amumu\t\t36. Kai'Sa\t\t67. Seraphine\r\n6.  Annie\t\t37. Karma\t\t68. Sett\r\n7.  Ashe\t\t38. Kassadin\t\t69. Shen\r\n8.  Aurelion Sol\t39. Katarina\t\t70. Shyvana\r\n9.  Blitzcrank\t\t40. Kayle\t\t71. Singed\r\n10. Brand\t\t41. Kennen\t\t72. Sion\r\n11. Braum\t\t42. Kha'Zix\t\t73. Sona\r\n12. Caitlyn\t\t43. Lee Sin\t\t74. Soraka\r\n13. Camille\t\t44. Leona\t\t75. Teemo\r\n14. Corki\t\t45. Lucian\t\t76. Thresh\r\n15. Darius\t\t46. Lulu\t\t77. Tristana\r\n16. Diana\t\t47. Lux\t\t\t78. Tryndamere\r\n17. Dr. Mundo\t\t48. Malphite\t\t79. Twisted Fate\r\n18. Draven\t\t49. Master Yi\t\t80. Varus\r\n19. Ekko\t\t50. Miss Fortune\t81. Vayne\r\n20. Evelynn\t\t51. Morgana\t\t82. Veigar\r\n21. Ezreal\t\t52. Nami\t\t83. Vi\r\n22. Fiora\t\t53. Nasus\t\t84. Wukong\r\n23. Fizz\t\t54. Nautilus\t\t85. Xayah\r\n24. Galio\t\t55. Nunu & Willump\t86. Xin Zhao\r\n25. Garen\t\t56. Olaf\t\t87. Yasuo\r\n26. Gragas\t\t57. Orianna\t\t88. Yone\r\n27. Graves\t\t58. Pantheon\t\t89. Yuumi\r\n28. Gwen\t\t59. Pyke\t\t90. Zed\r\n29. Irelia\t\t60. Rakan\t\t91. Ziggs\r\n30. Janna\t\t61. Rammus\r\n31. Jarvan IV\t\t62. Renekton");

                Console.WriteLine("");
                var again4 = true;
                while (again4)
                {
                    var again2 = true;
                    while (again2)
                    {
                        Console.WriteLine("Pilih nomor dari champion yang ingin anda lihat informasinya\n");
                        string a = Console.ReadLine();
                        if (a == "1")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Ahri.nama, Ahri.title, Ahri.role, Ahri.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", ahri.nama, ahri.kesulitan, ahri.spell);
                        }
                        else if (a == "2")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Akali.nama, Akali.title, Akali.role, Akali.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", akali.nama, akali.kesulitan, akali.spell);
                        }
                        else if (a == "3")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Akshan.nama, Akshan.title, Akshan.role, Akshan.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", akshan.nama, akshan.kesulitan, akshan.spell);
                        }
                        else if (a == "4")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Alistar.nama, Alistar.title, Alistar.role, Alistar.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", alistar.nama, alistar.kesulitan, alistar.spell);
                        }
                        else if (a == "5")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Amumu.nama, Amumu.title, Amumu.role, Amumu.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", amumu.nama, amumu.kesulitan, amumu.spell);
                        }
                        else if (a == "6")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Annie.nama, Annie.title, Annie.role, Annie.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", annie.nama, annie.kesulitan, annie.spell);
                        }
                        else if (a == "7")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Ashe.nama, Ashe.title, Ashe.role, Ashe.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", ashe.nama, ashe.kesulitan, ashe.spell);
                        }
                        else if (a == "8")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", AurelionSol.nama, AurelionSol.title, AurelionSol.role, AurelionSol.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", aurelionSol.nama, aurelionSol.kesulitan, aurelionSol.spell);
                        }
                        else if (a == "9")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Blitzcrank.nama, Blitzcrank.title, Blitzcrank.role, Blitzcrank.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", blitzcrank.nama, blitzcrank.kesulitan, blitzcrank.spell);
                        }
                        else if (a == "10")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Brand.nama, Brand.title, Brand.role, Brand.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", brand.nama, brand.kesulitan, brand.spell);
                        }
                        else if (a == "11")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Braum.nama, Braum.title, Braum.role, Braum.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", braum.nama, braum.kesulitan, braum.spell);
                        }
                        else if (a == "12")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Caitlyn.nama, Caitlyn.title, Caitlyn.role, Caitlyn.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", caitlyn.nama, caitlyn.kesulitan, caitlyn.spell);
                        }
                        else if (a == "13")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Camille.nama, Camille.title, Camille.role, Camille.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", camille.nama, camille.kesulitan, camille.spell);
                        }
                        else if (a == "14")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Corki.nama, Corki.title, Corki.role, Corki.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", corki.nama, corki.kesulitan, corki.spell);
                        }
                        else if (a == "15")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Darius.nama, Darius.title, Darius.role, Darius.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", darius.nama, darius.kesulitan, darius.spell);
                        }
                        else if (a == "16")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Diana.nama, Diana.title, Diana.role, Diana.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", diana.nama, diana.kesulitan, diana.spell);
                        }
                        else if (a == "17")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", DrMundo.nama, DrMundo.title, DrMundo.role, DrMundo.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", drMundo.nama, drMundo.kesulitan, drMundo.spell);
                        }
                        else if (a == "18")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Draven.nama, Draven.title, Draven.role, Draven.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", draven.nama, draven.kesulitan, draven.spell);
                        }
                        else if (a == "19")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Ekko.nama, Ekko.title, Ekko.role, Ekko.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", ekko.nama, ekko.kesulitan, ekko.spell);
                        }
                        else if (a == "20")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Evelynn.nama, Evelynn.title, Evelynn.role, Evelynn.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", evelynn.nama, evelynn.kesulitan, evelynn.spell);
                        }
                        else if (a == "21")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Ezreal.nama, Ezreal.title, Ezreal.role, Ezreal.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", ezreal.nama, ezreal.kesulitan, ezreal.spell);
                        }
                        else if (a == "22")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Fiora.nama, Fiora.title, Fiora.role, Fiora.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", fiora.nama, fiora.kesulitan, fiora.spell);
                        }
                        else if (a == "23")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Fizz.nama, Fizz.title, Fizz.role, Fizz.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", fizz.nama, fizz.kesulitan, fizz.spell);
                        }
                        else if (a == "24")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Galio.nama, Galio.title, Galio.role, Galio.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", galio.nama, galio.kesulitan, galio.spell);
                        }
                        else if (a == "25")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Garen.nama, Garen.title, Garen.role, Garen.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", garen.nama, garen.kesulitan, garen.spell);
                        }
                        else if (a == "26")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Gragas.nama, Gragas.title, Gragas.role, Gragas.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", gragas.nama, gragas.kesulitan, gragas.spell);
                        }
                        else if (a == "27")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Graves.nama, Graves.title, Graves.role, Graves.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", graves.nama, graves.kesulitan, graves.spell);
                        }
                        else if (a == "28")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Gwen.nama, Gwen.title, Gwen.role, Gwen.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", gwen.nama, gwen.kesulitan, gwen.spell);
                        }
                        else if (a == "29")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Irelia.nama, Irelia.title, Irelia.role, Irelia.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", irelia.nama, irelia.kesulitan, irelia.spell);
                        }
                        else if (a == "30")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Janna.nama, Janna.title, Janna.role, Janna.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", janna.nama, janna.kesulitan, janna.spell);
                        }
                        else if (a == "31")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", JarvanIV.nama, JarvanIV.title, JarvanIV.role, JarvanIV.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", jarvanIV.nama, jarvanIV.kesulitan, jarvanIV.spell);
                        }
                        else if (a == "32")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Jax.nama, Jax.title, Jax.role, Jax.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", jax.nama, jax.kesulitan, jax.spell);
                        }
                        else if (a == "33")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Jayce.nama, Jayce.title, Jayce.role, Jayce.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", jayce.nama, jayce.kesulitan, jayce.spell);
                        }
                        else if (a == "34")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Jhin.nama, Jhin.title, Jhin.role, Jhin.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", jhin.nama, jhin.kesulitan, jhin.spell);
                        }
                        else if (a == "35")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Jinx.nama, Jinx.title, Jinx.role, Jinx.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", jinx.nama, jinx.kesulitan, jinx.spell);
                        }
                        else if (a == "36")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", KaiSa.nama, KaiSa.title, KaiSa.role, KaiSa.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", kaiSa.nama, kaiSa.kesulitan, kaiSa.spell);
                        }
                        else if (a == "37")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Karma.nama, Karma.title, Karma.role, Karma.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", karma.nama, karma.kesulitan, karma.spell);
                        }
                        else if (a == "38")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Kassadin.nama, Kassadin.title, Kassadin.role, Kassadin.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", kassadin.nama, kassadin.kesulitan, kassadin.spell);
                        }
                        else if (a == "39")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Katarina.nama, Katarina.title, Katarina.role, Katarina.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", katarina.nama, katarina.kesulitan, katarina.spell);
                        }
                        else if (a == "40")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Kayle.nama, Kayle.title, Kayle.role, Kayle.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", kayle.nama, kayle.kesulitan, kayle.spell);
                        }
                        else if (a == "41")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Kennen.nama, Kennen.title, Kennen.role, Kennen.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", kennen.nama, kennen.kesulitan, kennen.spell);
                        }
                        else if (a == "42")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", KhaZix.nama, KhaZix.title, KhaZix.role, KhaZix.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", khaZix.nama, khaZix.kesulitan, khaZix.spell);
                        }
                        else if (a == "43")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", LeeSin.nama, LeeSin.title, LeeSin.role, LeeSin.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", leeSin.nama, leeSin.kesulitan, leeSin.spell);
                        }
                        else if (a == "44")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Leona.nama, Leona.title, Leona.role, Leona.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", leona.nama, leona.kesulitan, leona.spell);
                        }
                        else if (a == "45")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Lucian.nama, Lucian.title, Lucian.role, Lucian.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", lucian.nama, lucian.kesulitan, lucian.spell);
                        }
                        else if (a == "46")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Lulu.nama, Lulu.title, Lulu.role, Lulu.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", lulu.nama, lulu.kesulitan, lulu.spell);
                        }
                        else if (a == "47")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Lux.nama, Lux.title, Lux.role, Lux.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", lux.nama, lux.kesulitan, lux.spell);
                        }
                        else if (a == "48")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Malphite.nama, Malphite.title, Malphite.role, Malphite.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", malphite.nama, malphite.kesulitan, malphite.spell);
                        }
                        else if (a == "49")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", MasterYi.nama, MasterYi.title, MasterYi.role, MasterYi.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", masterYi.nama, masterYi.kesulitan, masterYi.spell);
                        }
                        else if (a == "50")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", MissFortune.nama, MissFortune.title, MissFortune.role, MissFortune.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", missFortune.nama, missFortune.kesulitan, missFortune.spell);
                        }
                        else if (a == "51")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Morgana.nama, Morgana.title, Morgana.role, Morgana.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", morgana.nama, morgana.kesulitan, morgana.spell);
                        }
                        else if (a == "52")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Nami.nama, Nami.title, Nami.role, Nami.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", nami.nama, nami.kesulitan, nami.spell);
                        }
                        else if (a == "53")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Nasus.nama, Nasus.title, Nasus.role, Nasus.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", nasus.nama, nasus.kesulitan, nasus.spell);
                        }
                        else if (a == "54")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Nautilus.nama, Nautilus.title, Nautilus.role, Nautilus.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", nautilus.nama, nautilus.kesulitan, nautilus.spell);
                        }
                        else if (a == "55")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", NunuWillump.nama, NunuWillump.title, NunuWillump.role, NunuWillump.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", nunuWillump.nama, nunuWillump.kesulitan, nunuWillump.spell);
                        }
                        else if (a == "56")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Olaf.nama, Olaf.title, Olaf.role, Olaf.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", olaf.nama, olaf.kesulitan, olaf.spell);
                        }
                        else if (a == "57")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Orianna.nama, Orianna.title, Orianna.role, Orianna.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", orianna.nama, orianna.kesulitan, orianna.spell);
                        }
                        else if (a == "58")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Pantheon.nama, Pantheon.title, Pantheon.role, Pantheon.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", pantheon.nama, pantheon.kesulitan, pantheon.spell);
                        }
                        else if (a == "59")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Pyke.nama, Pyke.title, Pyke.role, Pyke.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", pyke.nama, pyke.kesulitan, pyke.spell);
                        }
                        else if (a == "60")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Rakan.nama, Rakan.title, Rakan.role, Rakan.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", rakan.nama, rakan.kesulitan, rakan.spell);
                        }
                        else if (a == "61")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Rammus.nama, Rammus.title, Rammus.role, Rammus.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", rammus.nama, rammus.kesulitan, rammus.spell);
                        }
                        else if (a == "62")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Renekton.nama, Renekton.title, Renekton.role, Renekton.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", renekton.nama, renekton.kesulitan, renekton.spell);
                        }
                        else if (a == "63")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Rengar.nama, Rengar.title, Rengar.role, Rengar.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", rengar.nama, rengar.kesulitan, rengar.spell);
                        }
                        else if (a == "64")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Riven.nama, Riven.title, Riven.role, Riven.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", riven.nama, riven.kesulitan, riven.spell);
                        }
                        else if (a == "65")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Samira.nama, Samira.title, Samira.role, Samira.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", samira.nama, samira.kesulitan, samira.spell);
                        }
                        else if (a == "66")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Senna.nama, Senna.title, Senna.role, Senna.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", senna.nama, senna.kesulitan, senna.spell);
                        }
                        else if (a == "67")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Seraphine.nama, Seraphine.title, Seraphine.role, Seraphine.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", seraphine.nama, seraphine.kesulitan, seraphine.spell);
                        }
                        else if (a == "68")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Sett.nama, Sett.title, Sett.role, Sett.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", sett.nama, sett.kesulitan, sett.spell);
                        }
                        else if (a == "69")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Shen.nama, Shen.title, Shen.role, Shen.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", shen.nama, shen.kesulitan, shen.spell);
                        }
                        else if (a == "70")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Shyvana.nama, Shyvana.title, Shyvana.role, Shyvana.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", shyvana.nama, shyvana.kesulitan, shyvana.spell);
                        }
                        else if (a == "71")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Singed.nama, Singed.title, Singed.role, Singed.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", singed.nama, singed.kesulitan, singed.spell);
                        }
                        else if (a == "72")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Sion.nama, Sion.title, Sion.role, Sion.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", singed.nama, singed.kesulitan, singed.spell);
                        }
                        else if (a == "73")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Sona.nama, Sona.title, Sona.role, Sona.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", sona.nama, sona.kesulitan, sona.spell);
                        }
                        else if (a == "74")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Soraka.nama, Soraka.title, Soraka.role, Soraka.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", soraka.nama, soraka.kesulitan, soraka.spell);
                        }
                        else if (a == "75")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Teemo.nama, Teemo.title, Teemo.role, Teemo.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", teemo.nama, teemo.kesulitan, teemo.spell);
                        }
                        else if (a == "76")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Thresh.nama, Thresh.title, Thresh.role, Thresh.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", thresh.nama, thresh.kesulitan, thresh.spell);
                        }
                        else if (a == "77")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Tristana.nama, Tristana.title, Tristana.role, Tristana.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", tristana.nama, tristana.kesulitan, tristana.spell);
                        }
                        else if (a == "78")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Tryndamere.nama, Tryndamere.title, Tryndamere.role, Tryndamere.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", tryndamere.nama, tryndamere.kesulitan, tryndamere.spell);
                        }
                        else if (a == "79")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", TwistedFate.nama, TwistedFate.title, TwistedFate.role, TwistedFate.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", twistedFate.nama, twistedFate.kesulitan, twistedFate.spell);
                        }
                        else if (a == "80")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Varus.nama, Varus.title, Varus.role, Varus.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", varus.nama, varus.kesulitan, varus.spell);
                        }
                        else if (a == "81")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Vayne.nama, Vayne.title, Vayne.role, Vayne.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", vayne.nama, vayne.kesulitan, vayne.spell);
                        }
                        else if (a == "82")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Veigar.nama, Veigar.title, Veigar.role, Veigar.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", veigar.nama, veigar.kesulitan, veigar.spell);
                        }
                        else if (a == "83")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Vi.nama, Vi.title, Vi.role, Vi.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", vi.nama, vi.kesulitan, vi.spell);
                        }
                        else if (a == "84")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Wukong.nama, Wukong.title, Wukong.role, Wukong.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", wukong.nama, wukong.kesulitan, wukong.spell);
                        }
                        else if (a == "85")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Xayah.nama, Xayah.title, Xayah.role, Xayah.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", xayah.nama, xayah.kesulitan, xayah.spell);
                        }
                        else if (a == "86")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", XinZhao.nama, XinZhao.title, XinZhao.role, XinZhao.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", xinZhao.nama, xinZhao.kesulitan, xinZhao.spell);
                        }
                        else if (a == "87")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Yasuo.nama, Yasuo.title, Yasuo.role, Yasuo.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", yasuo.nama, yasuo.kesulitan, yasuo.spell);
                        }
                        else if (a == "88")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Yone.nama, Yone.title, Yone.role, Yone.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", yone.nama, yone.kesulitan, yone.spell);
                        }
                        else if (a == "89")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Yuumi.nama, Yuumi.title, Yuumi.role, Yuumi.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", yuumi.nama, yuumi.kesulitan, yuumi.spell);
                        }
                        else if (a == "90")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Zed.nama, Zed.title, Zed.role, Zed.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", zed.nama, zed.kesulitan, zed.spell);
                        }
                        else if (a == "91")
                        {
                            again2 = false;
                            again4 = false;
                            Console.WriteLine("\n{0} atau juga dikenal sebagai \"{1}\" adalah champion dengan role {2} dan biasanya bermain di posisi {3}", Ziggs.nama, Ziggs.title, Ziggs.role, Ziggs.position);
                            Console.WriteLine("\n{0} adalah champion dengan tingkat kesulitan \"{1}\" dan saat bermain disarankan menggunakan summoner spells {2}\n", ziggs.nama, ziggs.kesulitan, ziggs.spell);
                        }
                        else
                        {
                            again2 = true;
                            again4 = true;
                            Console.WriteLine("\nMaaf pilihan anda tidak bisa dijalankan!!!\n");
                        }
                    }
                
                    var again3 = true;
                    while (again3)
                    {
                        Console.WriteLine("");
                        Console.Write("Apakan anda ingin mengulangi lagi? (Y/T): ");

                        var input = Console.ReadLine();
                        if (input == "T" || input == "t")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Terimakasih telah menggunakan aplikasi ini\n");
                            again3 = false;
                            start = false;
                        }
                        else if (input == "Y" || input == "y")
                        {
                            Console.Clear();
                            again3 = false;
                            start = true;
                        }
                        else
                        {
                            Console.WriteLine("\nMaaf pilihan anda tidak bisa dijalankan!!!");
                            again3 = true;
                        }
                    }
                }
            }
            
        }
    }
}
