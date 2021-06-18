using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;
using static System.Threading.Thread;
using static System.Int32;
using System.Runtime;

namespace Fighting_Fantasy
{
    class Program
    {
        private static string playerName;

        static void Main(string[] args)
        {
            TitleScreen();
            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.settings.setMode("loop", true);
            myplayer.URL = "C:\\Fighting Fantasy\\FF1 Battle theme.mp3";
            myplayer.controls.play();
            TurnOne();
        }

        public static void TurnOne()
        {
            Console.WriteLine("Rilgashaan cackles loudly as he conjures up a protective barrier of ice shards to spiral around him");
            Sleep(1000);
            Console.WriteLine("You twirl your sword in one hand as the pages in your magic tome flicker with might. Select your action!");
            Sleep(1000);
            Console.WriteLine(@"Go in for a killing pierce with your blade (1) 
Slash at Rilgashaan with your sword (2)
Conjure up a volley of fire balls (3)
Call forth a powerful lighting strike (4)
Launch a flurry of freezing ice spears (5)
Summon a ferociously destructive tornado (6)
Unleash the rest of your magic power in a magical super nova burst (7)");
            string turnOne = Console.ReadLine();
            if (turnOne == "3")
            {
                Console.WriteLine("You conjure up a volley of fire balls that melt all the ice shards leaving Rilgashaan vulnerable!");
                Console.WriteLine(@"   )
  ) \
 / ) (
 \(_)/ ");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                TurnTwo();
            }
            else if (turnOne == "1")
            {
                Console.WriteLine("You rush forward going in for a stab only to get knocked away by the ice shards");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnOne == "2")
            {
                Console.WriteLine("You leap forward going in for a slash only to get knocked back by the ice shards");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnOne == "4")
            {
                Console.WriteLine("You call forth a powerful crackle of lighting but the protective ice shards nullify the spell");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnOne == "5")
            {
                Console.WriteLine("You launch a flurry of ice spears that shatter against the protective ice shards");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnOne == "6")
            {
                Console.WriteLine("You summon a destructive tornado but the breeze does little except break up the ice shards a small amount");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnOne == "7")
            {
                Console.WriteLine("You channel all of your magic power into a powerful super nova that shatters the ice shards completely!...but leaves you completely exhausted and struggling to stand");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Sleep(2000);
                TurnOne();
            }
        }

        public static void TurnTwo()
        {
            Console.Clear();
            Console.WriteLine("Rilgashaan: Hah...you're not going down without a fight eh? So be it!");
            Sleep(1000);
            Console.WriteLine("Rilgashaan twirls his staff as a whirlwind swirls around him. Select your Action!");
            Sleep(1000);
            Console.WriteLine(@"Go in for a killing pierce with your blade (1) 
Slash at Rilgashaan with your sword (2)
Call forth a powerful lighting strike (4)
Launch a flurry of freezing ice spears (5)
Summon a ferociously destructive tornado (6)
Unleash the rest of your magic power in a magical super nova burst (7)");
            string turnTwo = Console.ReadLine();
            if (turnTwo == "4")
            {
                Console.WriteLine("You call forth a powerful lighting strike by loudly slamming your tome shut, the bolt of lighting hits Rilgashaan head on breaking his control of the whirlwind and leaving him vulnerable again!");
                Console.WriteLine(@"      '\ `\`
         _\ _\
         `\ \
          _\_\
          `\\
            \\
        -.'.`\.'.-");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                TurnThree();
            }
            else if (turnTwo == "1")
            {
                Console.WriteLine("You charge forward to stab but the strong wind knocks you back");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnTwo == "2")
            {
                Console.WriteLine("You leap forward for a slash only to get knocked back by the wind");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnTwo == "5")
            {
                Console.WriteLine("You launch several ice spears forward only to have them knocked aside by the wind");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnTwo == "6")
            {
                Console.WriteLine("You attempt to summon your own tornado but the stronger whirlwind absorbs it making it even more powerful pushing you back");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnTwo == "7")
            {
                Console.WriteLine("You channel all of your magic power into a powerful super nova that breaks the whirlwind apart!...but leaves you completely exhausted and struggling to stand");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Sleep(2000);
                TurnTwo();
            }
        }

        public static void TurnThree()
        {
            Console.Clear();
            Console.WriteLine("Rilgashaan: How dare scum like you hit me! You'll pay for that!!!");
            Sleep(1000);
            Console.WriteLine("Rilgashaan points his staff towards you as several fire balls appear and start heading straight for you. Select your action!");
            Sleep(1000);
            Console.WriteLine(@"Go in for a killing pierce with your blade (1) 
Slash at Rilgashaan with your sword (2)
Launch a flurry of freezing ice spears (5)
Summon a ferociously destructive tornado (6)
Unleash the rest of your magic power in a magical super nova burst (7)");
            string turnThree = Console.ReadLine();
            if (turnThree == "6")
            {
                Console.WriteLine("You pirouette and summon a powerful tornado knocking the fire balls aside even hitting Rilgashaan with a few of his own projectiles");
                Console.WriteLine(@"   ((  '####@@!!$$    ))
       `#####@@!$$`  ))
    (('####@!!$:
   ((  ,####@!!$:   ))
       .###@!!$:
       `##@@!$:
        `#@!!$
  !@#    `#@!$:       @#$
   #$     `#@!$:       !@!
            '@!$:
        '`\   '!$: /`'
           '\  '!: / '
             '\ : /''
  -.'-/\\\-.'//.-'/:`\.'-....'.'-=_\\
' -.' -.\\'-.'//.-'.`-.'_\\-.'.-\'.-//");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                TurnFour();
            }
            else if (turnThree == "1")
            {
                Console.WriteLine("You dart forward and stab the first fireball destroying it but the rest of them smash and burst against your body knocking you down");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnThree == "2")
            {
                Console.WriteLine("You leap forward and slash down the first few fire balls but there are too many coming too fast and you soon get pelted by the rest knocking you to the ground");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnThree == "5")
            {
                Console.WriteLine("You launch forth a flurry of ice spears but the fire balls melt them in an instant and soon collide with your body knocking you down");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnThree == "7")
            {
                Console.WriteLine("You channel all of your magic power into a powerful super nova that obliterates all of the fire balls before they can reach you!...but leaves you completely exhausted and struggling to stand");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Sleep(2000);
                TurnThree();
            }
        }

        public static void TurnFour()
        {
            Console.Clear();
            Console.WriteLine("Rilgashaan: You are trying my patience! Anymore resistance and I'll be forced to unleash my true power!");
            Sleep(1000);
            Console.WriteLine("Crackles of lighting dance around Rilgashaan getting faster and faster as he prepares to smite you with a lighting bolt of his own. Select your action!");
            Sleep(1000);
            Console.WriteLine(@"Go in for a killing pierce with your blade (1) 
Slash at Rilgashaan with your sword (2)
Launch a flurry of freezing ice spears (5)
Unleash the rest of your magic power in a magical super nova burst (7)");
            string turnFour = Console.ReadLine();
            if (turnFour == "5")
            {
                Console.WriteLine("You launch forth a flurry of ice spears breaking Rilgashaans focus and causing him to direct his bolts at the ice spears instead to defend himself");
                Console.WriteLine(@"                     *  .  *
                   . _\/ \/_ .
                    \  \ /  /             .      .
      ..    ..    -==>: X :<==-           _\/  \/_
      '\    /'      / _/ \_ \              _\/\/_
        \\//       '  /\ /\  '         _\_\_\/\/_/_/_
   _.__\\\///__._    *  '  *            / /_/\/\_\ \
    '  ///\\\  '                           _/\/\_
        //\\                               /\  /\
      ./    \.                            '      '
      ''    '' ");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                TurnFive();
            }
            else if (turnFour == "1")
            {
                Console.WriteLine("You rush forward attempting to stab Rilgashaan but the lighting strike is summoned before you can reach him striking you down");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnFour == "2")
            {
                Console.WriteLine("You leap forward to slash at your foe but the lighting stike zaps you out of the sky causing you to plummet to the ground");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnFour == "7")
            {
                Console.WriteLine("You channel all of your magic power into a powerful super nova that deflects the lighting strike!...but leaves you completely exhausted and struggling to stand");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Sleep(2000);
                TurnFour();
            }
        }

        public static void TurnFive()
        {
            Console.Clear();
            Console.WriteLine("Rilgashaan: ENOUGH I won't tolerate your foolish heroism anymore! If you're so powerful try and break my impenetrable wizard ward!!!");
            Sleep(1000);
            Console.WriteLine("Rilgashaan slams his staff down as a eerie orb surrounds and protects him. You're so close you can't fail now!");
            Sleep(1000);
            Console.WriteLine(@"Go in for a killing pierce with your blade (1) 
Slash at Rilgashaan with your sword (2)
Unleash the rest of your magic power in a magical super nova burst (7)");
            string turnFive = Console.ReadLine();
            if (turnFive == "7")
            {
                Console.WriteLine("You channel all of your magic power into a powerful super nova that completey shatters Rilgashaans magic barrier into tiny pieces!");
                Console.WriteLine(@"                               ________________
                          ____/ (  (    )   )  \___
                         /( (  (  )   _    ))  )   )\
                       ((     (   )(    )  )   (   )  )
                     ((/  ( _(   )   (   _) ) (  () )  )
                    ( (  ( (_)   ((    (   )  .((_ ) .  )_
                   ( (  )    (      (  )    )   ) . ) (   )
                  (  (   (  (   ) (  _  ( _) ).  ) . ) ) ( )
                  ( (  (   ) (  )   (  ))     ) _)(   )  )  )
                 ( (  ( \ ) (    (_  ( ) ( )  )   ) )  )) ( )
                  (  (   (  (   (_ ( ) ( _    )  ) (  )  )   )
                 ( (  ( (  (  )     (_  )  ) )  _)   ) _( ( )
                  ((  (   )(    (     _    )   _) _(_ (  (_ )
                   (_((__(_(__(( ( ( |  ) ) ) )_))__))_)___)
                   ((__)        \\||lll|l||///          \_))
                            (   /(/ (  )  ) )\   )
                          (    ( ( ( | | ) ) )\   )
                           (   /(| / ( )) ) ) )) )
                         (     ( ((((_(|)_)))))     )
                          (      ||\(|(|)|/||     )
                        (        |(||(||)||||        )
                          (     //|/l|||)|\\ \     )
                        (/ / //  /|//||||\\  \ \  \ _)");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Spell.mp3";
                myplayer.controls.play();
                Sleep(5000);
                TurnSix();
            }
            else if (turnFive == "1")
            {
                Console.WriteLine("You charge forward and attempt to break through the barrier with a stab but your sword bounces off in a blast knocking you back");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else if (turnFive == "2")
            {
                Console.WriteLine("You leap forward and bring your sword down on the barrier but a magical blast knocks you down");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Sleep(2000);
                TurnFive();
            }
        }

        public static void TurnSix()
        {
            Console.Clear();
            Console.WriteLine("Rilgashaan staggers down onto one knee groaning loudly as he clutches his staff tightly, you soon join him having to use your sword to hold yourself up completely exhausted from all the spellcasting");
            Sleep(1000);
            Console.WriteLine("Rilgashaan: N-No...I-I can't lose h-here! N-Not to the likes of y-you!! This is a short lived victory for you! Any moment now I'll be back on my feet ready to obliterate you!");
            Sleep(1000);
            Console.WriteLine("You realise this is your only chance to fully weaken the wizard before moving in for the killing blow before it's too late.");
            Sleep(1000);
            Console.WriteLine(@"Go in for a killing pierce with your blade (1) 
Slash at Rilgashaan with your sword (2)");
            string turnSix = Console.ReadLine();
            if (turnSix == "2")
            {
                Console.WriteLine("You lunge at Rilgashaan giving a brutal slash at his weakened body forcing him to hold up his staff to defend himself, the strength of your slash breaks the staff in two");
                Console.WriteLine(@"         />_________________________________
[########[]_________________________________>
         \>");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Hit.mp3";
                myplayer.controls.play();
                Sleep(5000);
                TurnSeven();
            }
            if (turnSix == "1")
            {
                Console.WriteLine("You run forwards at Rilgashaan determined to land the killing blow now but alas this was your final mistake as Rilgashaan swings his staff at you knocking you back");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Miss.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Defeat();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Sleep(2000);
                TurnSix();
            }
        }

        public static void TurnSeven()
        {
            Console.Clear();
            Console.WriteLine("Rilgashaan roars loudly in anger as he clutches his broken staff staring at you with a face of hatred");
            Sleep(1000);
            Console.WriteLine("Rilgashaan: Y-You d-dare s-strike me down? You think you have courage to truly end me?");
            Sleep(1000);
            Console.WriteLine("This is it! End it now! Kill the wizard once and for all!");
            Sleep(1000);
            Console.WriteLine("Go in for a killing pierce with your blade (1)");
            string turnSeven = Console.ReadLine();
            if (turnSeven == "1")
            {
                Console.WriteLine("You plunge your blade into Rilgashaans heart finally slaying the evil wizard");
                Console.WriteLine(@"         />_________________________________
[########[]_________________________________>
         \>");
                WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                myplayer.URL = "C:\\Fighting Fantasy\\Hit.mp3";
                myplayer.controls.play();
                Sleep(5000);
                Ending();
                
            }
            else
            {
                Console.WriteLine("Invalid input");
                Sleep(2000);
                TurnSeven();
            }
        }

        public static void Ending()
        {
            Console.Clear();
            Console.WriteLine("The dying wizard roars loudly as a blinding flash consumes his body and he slowly turns to glass before completely shattering into millions of pieces");
            Sleep(1000);
            Console.WriteLine("Rilgashaan had finally been defeated once and for all");
            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = "C:\\Fighting Fantasy\\Victory.mp3";
            myplayer.controls.play();
            Console.WriteLine("The day was saved and countless celebrations would be held in your name for your heroic deeds");
            Sleep(1000);
            Console.WriteLine("Alas as the first banquet and celebration began there was outcry as the fabled hero was nowhere to be found");
            Sleep(1000);
            Console.WriteLine("For the fabled hero was already travelling in search of another villain to slay....");
            Console.WriteLine(@" ____________________________________________________________  
/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/  
 ._. ___________.__             ___________           .___ ._. 
 | | \__    ___/|  |__   ____   \_   _____/ ____    __| _/ | | 
 |_|   |    |   |  |  \_/ __ \   |    __)_ /    \  / __ |  |_| 
 |-|   |    |   |   Y  \  ___/   |        \   |  \/ /_/ |  |-| 
 | |   |____|   |___|  /\___  > /_______  /___|  /\____ |  | | 
 |_|                 \/     \/          \/     \/      \/  |_| 
  ____________________________________________________________  
/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/  ");
            Sleep(15000);
        }

        public static void Defeat()
        {
            Console.Clear();
            Console.WriteLine("Rilgashaan cackles loudly as he walks up to you and knocks you down in one fell swoop");
            Console.WriteLine("Rilgashaan: FOOL!!! You really thought you stood a chance against me, The Fearsome Wizard Rilgashaan? AHAHAHAHA");
            Console.WriteLine("Everything begins to fade to black...");
            Console.WriteLine(@"  ________                        ________                     
 /  _____/_____    _____   ____   \_____  \___  __ ___________ 
/   \  ___\__  \  /     \_/ __ \   /   |   \  \/ // __ \_  __ \
\    \_\  \/ __ \|  Y Y  \  ___/  /    |    \   /\  ___/|  | \/
 \______  (____  /__|_|  /\___  > \_______  /\_/  \___  >__|   
        \/     \/      \/     \/          \/          \/       ");
            Sleep(10000);
        }

        public static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Mighty warrior " + playerName + " You have come in our time of need, slay the fearsome wizard Rilgashaan in the throne room ahead before he kills our king!");
            Sleep(1000);
            Console.WriteLine(playerName + " Enters the throne room and inside is Rilgashaan laughing maniacally before turning to face you");
            Sleep(1000);
            Console.WriteLine("Rilgashaan: So the feeble warrior " + playerName + " has come to stop me? HA I'd like to see you try and defeat me");
            Sleep(1000);
            Console.WriteLine("You draw your sword and your magic spell tome as you prepare to defeat Rilgashaan once and for all!");
            Sleep(7000);
            Console.Clear();
        }

        public static void TitleScreen()
        {
            Console.Clear();
                Console.WriteLine(@" __________________________________________________________________________________________________________________
/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/
 ._. ___________.__       .__     __  .__                 ___________              __                         ._.  
 | | \_   _____/|__| ____ |  |___/  |_|__| ____    ____   \_   _____/____    _____/  |______    _________.__. | |  
 |_|  |    __)  |  |/ ___\|  |  \   __\  |/    \  / ___\   |    __) \__  \  /    \   __\__  \  /  ___<   |  | |_|  
 |-|  |     \   |  / /_/  >   Y  \  | |  |   |  \/ /_/  >  |     \   / __ \|   |  \  |  / __ \_\___ \ \___  | |-|  
 | |  \___  /   |__\___  /|___|  /__| |__|___|  /\___  /   \___  /  (____  /___|  /__| (____  /____  >/ ____| | |  
 |_|      \/      /_____/      \/             \//_____/        \/        \/     \/          \/     \/ \/      |_|  
  __________________________________________________________________________________________________________________
/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/_____/  ");
                Console.WriteLine("Greetings fabled warrior of legend, enlighten us on your name");
            playerName = Console.ReadLine();
            Sleep(2000);
            Console.WriteLine(@"Begin your quest (1)
Return to your peaceful slumber...(2)");
            string playerChoice = Console.ReadLine();
            if (playerChoice == "1")
            {
                Console.WriteLine("And so begins another quest for the mighty warrior " + playerName);
                Intro();
            }
            else if (playerChoice == "2")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
