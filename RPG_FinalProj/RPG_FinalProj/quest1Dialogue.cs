using RPG_FinalProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Trial1_Movement_Classes_COMPROGPROJ
{
    internal class quest1Dialogue
    {
        Random random = new Random();
        private readonly questTracking QT;

        public int[] Jura1 = { 0, 0 };
        public bool Crest1 = false;
        public int Crest2 = 0;
        public int Crest3 = 0;
        public int[] Crest4 = { 0, 0, 0, 0, 0 };

        public string currentQuest = "";
        public string currentObjective = "";
        public bool questongoing = false;
        public string[] Prologue, merchant, JuraSQ1, CrestSQ1, CrestSQ2, CrestSQ3, CrestSQ4, DeimosSQ1, DeimosSQ2, DeimosSQ3, DeimosSQ4, MainQuest, FirstTimes, Bosses, Mobs;
        string[] Pro1 = {
            "Once vanquished by the valiant hero, the malevolent Demon King and Queen rise anew, shattering the fragile peace that had settled over the realm of Grimwastes. Their awakening heralds a dark resurgence, casting a long shadow over lands once deemed safe.",
            "Whispers of dread spread like wildfire, tales of their return echo through every corner of the realm. Those who remember the horrors of their previous reign tremble in fear, haunted by memories of the darkness they wrought.Whispers of dread spread like wildfire, tales of their return echo through every corner of the realm. Those who remember the horrors of their previous reign tremble in fear, haunted by memories of the darkness they wrought.",
            "The skies darken as storm clouds gather, mirroring the turmoil within the hearts of mortals. Fear grips the populace, and uncertainty gnaws at the foundations of civilization. The Demon King and Queen, their thirst for power unquenched, now turn their malevolent gaze upon reclaiming what was once theirs.",
            "And now, it falls to us to confront this ancient evil. Will you flee and cower in fear, or will you rise to the challenge and restore peace to humanity? The choice is yours."};
        public int pro;
        string[] merchant1 = {
            "Greetings, Traveler, how may I help you today?",
            "Welcome traveler, need something today? ",
            "You look like you need some equipment, how may I serve you today?"};

        string[] juraSQ1 = {
            "Traveler I am in need of dire help, the monsters outside the village are running rampant,\r\nI need you to kill the foul beast that resides near the village.\r\n",
            "KILL: SLIMES 5\r\nKILL WOLVES 5\r\n",
            "Thank you traveler the village will be in peace once more"};
        public int JSQ1;
        string[] crestSQ1 = {
        "Oh, traveler, I beseech thee! In dire need am I of a rare herb found within a cave in the western reaches of Jura Forest, to save my son.",
        "Go to the cave west of jura and get the plant in need for the cure",
        "Thou hast my eternal gratitude, noble traveler, for finding the herd."};

        string[] crestSQ2 = {
        "Pray thee, noble traveler, vanquish the foul ogre that hath slain mine brother, and a fitting reward shall be thine.",
        "KILL: OGRE 1",
        "Thou hast my gratitude, valiant traveler. May mine brother's soul now find peace."};

        string[] crestSQ3 = {
        "Oh, traveler, slay the goblins that roam the forest, that other adventurers may safely journey to the city of Crestfall.",
        "KILL: GOBLINS 5",
        "Thank thee, dear traveler. I shall be forever in thy debt."};

        string[] crestSQ4 = {
        "Thou hast decreed it so, to rid both Jura and Deimos of their foul creatures. Yet, mayhaps in thy quest for eradication, mercy and discernment should guide thy hand, lest thou become that which thou seeketh to vanquish.",
        "KILL ONE OF EVERY MONSTER IN JURA AND DEIMOS",
        "Well done traveler . . ."};
        public int CSQ1 = 0, CSQ2 = 0, CSQ3 = 0, CSQ4 = 0;
        string[] deimosSQ1 = {
        "Traveler. This place reeks of madness. Slay these ungodly creations, and I shall reward you.",
        "KILL: 5 Undead",
        "Thank you traveler, As promised here’s your reward."};

        string[] deimosSQ2 = {
        "Traveler, These lands are plagued by demon spawn. Slay them all, and a reward shall be yours.",
        "KILL: 3 Skeleton\r\nKILL: 2 Werewolves\r\n",
        "Alas, you’ve come back here’s your reward."};

        string[] deimosSQ3 = {
        "Traveler... Cleanse this place of vile creatures, and I shall reward you.",
        "KILL: 3 Werewolves\r\nKILL: 3 Gargoyles\r\n",
        "Ah traveler, Thankyou for cleansing these vile creatures. Here's your reward."};

        string[] deimosSQ4 = {
        "Ah, traveler... There exists a forsaken place, its treasure shrouded in legend. None who enter return. If you dare to seek it and bring me the treasure, a worthy reward shall be yours. Many have tried but none have lived to tell the tale. Will you face the unknown?",
        "KILL: Treasure and easter egg",
        "Oh traveler, so you’ve come back as a reward. I'll give you the rewards,  and you can have the treasure and the things that you found, and have a goodluck on your adventure."};
        public int DSQ1 = 0, DSQ2 = 0, DSQ3 = 0, DSQ4 = 0;
        string[] mainQuest = {
        "Ah, an awakened soul. Caught in the clutches of fate, just as we were. You ventured too close, and now you find yourself ensnared by destiny's cruel hand.",
        "Vjorn: Awakened soul... or should I call you Freyn? Before you brave the Grimwastes, arm yourself well. The Grimwastes are no safe place.",
        "Warrior: Vjorn :Ah, warrior, Your resilience is matched only by your Vitality. Endure the trials ahead, for your might shall be your shield against the encroaching darkness.",
        "Mage: Vjorn:\r\nAh, seeker of arcane might. Your power can fell any foe, yet the risk is great. Tread carefully, for the path of the mage is perilous.\r\n",
        "Archer; Vjorn:\r\nAh, swift Archer. Your arrows find their mark with deadly precision, striking down any who dare to oppose you. May your speed be your salvation in the looming shadows.\r\n",
        "Vjorn: you’ve picked a good one you may now venture, All I can offer you is a farewell, and may fortune favor your journey.",
        "VJORN: Traveler, I implore thee, defeat the puissant slime that doth obstruct the path to Crestfall. No adventurer hath yet bested this foul creature, and thus the way between Jura and Crestfall remaineth sealed by its vile presence.",
        "Vanquish the powerful slime blocking the path to the city",
        "VJORN: Thy courage and strength shall be sung of in ages to come, farewell traveler.",
        "Crestfall knight: \r\nEmbark forthwith unto the realm of Deimos, where demons hold sway, and traverse the darkened forest. Yonder lies a village, a haven amidst the shadows, well-guarded and secure. Take heed as thou journeyest, for danger lurks in every shadow, and the path ahead is fraught with peril. Mayhaps this sanctuary shall offer respite from the terrors that beset thee, but be ever vigilant, for the demons' grasp reaches far and wide.\r\n",
        "FIND YOUR WAY TO DEIMOS",
        "Vjorn: Verily, traveler, it seems fate hath woven our paths together once more. I shall lend thee my blade in vanquishing the foul demons that plague Deimos. Take heed, for demonic beings doth roam freely in these accursed lands. Yet fear not, for I shall stand beside thee once more, and together, we shall smite the dark powers that beset these hallowed grounds.",
        "DEFEAT THE DEMON KING",
        "Vjorn: it is done! The demons that held dominion over these lands have met their end, and tranquility shall reign once more among the people. Peace hath returned to these hallowed grounds, and the folk may now dwell in harmony, free from the shadow of malevolence."};
        public int MQ = 0;
        string[] firstTimes = {
        "The forest of Jura unfolds before mine eyes, a realm where ancient oaks stretch their gnarled limbs towards the heavens. This sylvan haven, whispered of in legends, is both fair and perilous. 'Tis said that these woods are alive with secrets and shadows, where the old magic lingers in every leaf and bough. Let us venture forth with both awe and caution, for in the heart of Jura's green embrace, both wonder and danger abide.",
        "Behold, the humble village of Jura, where ordinary folk lead their lives amidst the comforting embrace of the forest. Though lacking in grandeur, its simplicity and warmth are like a soothing balm to weary souls. Here, the laughter of children mingles with the rustle of leaves, and the scent of home-cooked meals wafts through the air",
        "The esteemed city of Crestfall, its streets bustling with the comings and goings of those of high standing. This thriving hamlet, known for its status and prestige, stands as a beacon of prosperity amidst the untamed lands. The sounds of daily life fill the air, with merchants hawking their wares and artisans honing their craft.",
        "Enter now, traveler, into the realm of Deimos, where the shadows deepen and suffering holds sway. This desolate land, shrouded in darkness, bears witness to the darkest depths of the human soul. Here, pain is woven into the very fabric of existence, and the cries of the afflicted echo through the barren wastes."};

        string[] bosses = {
        "BOSS SLIME : ╎ꖎꖎ ꖌ╎ꖎꖎ ||𝙹 ! ! ! ",
        "BOSS DEMON QUEEN : Thou dare intrude upon my realm and slay my progeny?! Thy insolence shall be repaid in full, as my fury descends upon thee like a tempest of darkness.",
        "No… Help my thine king…",
        "BOSS DEMON KING : You insolent wretch !!! disturbing my slumber. Prepare to face the consequences of your audacity as my fury consumes you!!!",
        "I was bested by a mere mortal…",};

        string[] mobs = {
        "SLIME: (SQUISH)",
        "WOLVES: (HOWL)",
        "GOBLIN: (AGHRA) GOLD GOLD GOLD ! ! !",
        "OGRE: (ROOOOAR) WHO DISTURBS MY REST ! ! !",
        "UNDEAD: (GROANS)\r\n “I ∴╎ꖎꖎ ꖌ╎ꖎꖎ ||𝙹⚍ ⎓𝙹∷ ᒲ||  ꖌ╎リ⊣” (Ill shall put you to rest for my king)",
        "SKELETON: (RATTLE)\r\nꖎᒷℸ ̣  ℸ ̣ ⍑ᒷ∷ᒷ ʖᒷ ↸ᔑ∷ꖌリᒷᓭᓭ ( Let there be suffering)\r\n",
        "WEREWOLF: (GROWL)\r\n||𝙹⚍∷ ʖꖎ𝙹𝙹↸, ꖎᒷℸ ̣  ╎ℸ ̣  ʖᒷ ᒲ╎リᒷ ( Let thy blood be mine)\r\n",
        "GARGOYLE: (SCREECH)\r\nℸ ̣ ⍑ᒷ ʖᒷᓭℸ ̣  ↸ᒷ⎓ᒷリᓭᒷ ╎ᓭ ᒲᒷ (I se’ resilient armor of the demons)\r\n",};

        public quest1Dialogue() 
        {
            Prologue = Pro1;
            merchant = merchant1;
            JuraSQ1 = juraSQ1;
            CrestSQ1 = crestSQ1;
            CrestSQ2 = crestSQ2;
            CrestSQ3 = crestSQ3;
            CrestSQ4 = crestSQ4;
            DeimosSQ1 = deimosSQ1;
            DeimosSQ2 = deimosSQ2;
            DeimosSQ3 = deimosSQ3;
            DeimosSQ4 = deimosSQ4;
            MainQuest = mainQuest;
            FirstTimes = firstTimes;
            Bosses = bosses;
            Mobs = mobs;
            currentObjective = "";
            currentQuest = "";
            questongoing = false;
            pro = 0;
            JSQ1 = 0;
            CSQ1 = 0;
            CSQ2 = 0;
            CSQ3 = 0;
            CSQ4 = 0;
            DSQ1 = 0;
            DSQ2 = 0;
            DSQ3 = 0;
            DSQ4 = 0;
            MQ = 0;
        }
        public string Prologue1()
        {
            return Prologue[pro];
        }
        public string CMobs(int mobtype)
        {
            return Mobs[mobtype];
        }

        public string First(int map)
        {
            return FirstTimes[map];
        }

        public string Boss(int bossdialogue)
        {
            return Bosses[bossdialogue];
        }
        public string CJSQ1 ()
        {
            return JuraSQ1[JSQ1];
        }

        public string CCSQ1()
        {
            return CrestSQ1[CSQ1];
        }
        public string CCSQ2()
        {
            return CrestSQ2[CSQ2];
        }
        public string CCSQ3()
        {
            return CrestSQ3[CSQ3];
        }
        public string CCSQ4()
        {
            return CrestSQ4[CSQ4];
        }

        public string CDSQ1()
        {
            return DeimosSQ1[DSQ1];
        }
        public string CDSQ2()
        {
            return DeimosSQ2[DSQ2];
        }
        public string CDSQ3()
        {
            return DeimosSQ3[DSQ3];
        }
        public string CDSQ4()
        {
            return DeimosSQ4[DSQ4];
        }

        public string Merchant()
        {
            return merchant[random.Next(1, 4)];
        }
    }
}
