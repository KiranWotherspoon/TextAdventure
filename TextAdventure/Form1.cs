///Made by: Brendan Moorehead and Kiran Wotherspoon
///Who knows when
///Text Adventure Game
using System;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace TextAdventure
{
    public partial class Form1 : Form
    {
        //random number generator
        Random rng = new Random();

        //scene variable
        int scene = 44;

        //boolean for scene 9
        bool rYouDead;

        //create soundplayers
        SoundPlayer windowBreak = new SoundPlayer(Properties.Resources.windowBreak);
        SoundPlayer takeOff = new SoundPlayer(Properties.Resources.takeOff);
        SoundPlayer cave = new SoundPlayer(Properties.Resources.caveSounds);
        SoundPlayer killedDeath = new SoundPlayer(Properties.Resources.headSmash);
        SoundPlayer shotGun = new SoundPlayer(Properties.Resources.shotgunBlast);
        SoundPlayer airlock = new SoundPlayer(Properties.Resources.airlockSound);
        SoundPlayer explosion = new SoundPlayer(Properties.Resources.explosionSound);
        SoundPlayer engine = new SoundPlayer(Properties.Resources.powerOn);
        SoundPlayer knock = new SoundPlayer(Properties.Resources.doorKnock);
        SoundPlayer button = new SoundPlayer(Properties.Resources.buttonPress);
        SoundPlayer gas = new SoundPlayer(Properties.Resources.gasLeak);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.M)
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 3) { scene = 1; }
                else if (scene == 4) { scene = 1; }
                else if (scene == 5) { scene = 10; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 42) { scene = 11; }
                else if (scene == 9 && rYouDead == false) { scene = 1; }
                else if (scene == 11) { scene = 17; }
                else if (scene == 12) { scene = 22; }
                else if (scene == 13) { scene = 19; }
                else if (scene == 18) { scene = 23; }
                else if (scene == 19) { scene = 26; }
                else if (scene == 20) { scene = 28; }
                else if (scene == 21) { scene = 29; }
                else if (scene == 22) { scene = 21; }
                else if (scene == 25) { scene = 31; }
                else if (scene == 26) { scene = 32; }
                else if (scene == 29) { scene = 30; }
                else if (scene == 30) { scene = 35; }
                else if (scene == 33) { scene = 41; }
                else if (scene == 34) { scene = 37; }
                else if (scene == 37) { scene = 38; }
                else if (scene == 44) { scene = 0; }
            }
            else if (e.KeyCode == Keys.B)
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 1) { scene = 5; }
                else if (scene == 2) { scene = 7; }
                else if (scene == 3) { scene = 2; }
                else if (scene == 4) { scene = 8; }
                else if (scene == 5) { scene = 9; }
                else if (scene == 7) { scene = 12; }
                else if (scene == 42) { scene = 12; }
                else if (scene == 11) { scene = 42; }
                else if (scene == 12) { scene = 42; }
                else if (scene == 13) { scene = 18; }
                else if (scene == 18) { scene = 23; }
                else if (scene == 19) { scene = 25; }
                else if (scene == 20) { scene = 27; }
                else if (scene == 21) { scene = 30; }
                else if (scene == 22) { scene = 34; }
                else if (scene == 25) { scene = 26; }
                else if (scene == 26) { scene = 33; }
                else if (scene == 29) { scene = 21; }
                else if (scene == 30) { scene = 22; }
                else if (scene == 33) { scene = 40; }
                else if (scene == 34) { scene = 36; }
                else if (scene == 37) { scene = 39; }
                else if (scene == 44) { scene = 45; }
            }
            else if (e.KeyCode == Keys.N)
            {
                if (scene == 1) { scene = 3; }
                else if (scene == 7) { scene = 13; }
                else if (scene == 42) { scene = 13; }
                else if (scene == 12) { scene = 21; }
                else if (scene == 13) { scene = 20; }
                else if (scene == 18) { scene = 24; }
                else if (scene == 30) { scene = 29; }
                else if (scene == 37) { scene = 39; }
                else if (scene == 6) { scene = 44; }
                else if (scene == 8) { scene = 44; }
                else if (scene == 9 && rYouDead == true) { scene = 44; }
                else if (scene == 10) { scene = 44; }
                else if (scene == 17) { scene = 44; }
                else if (scene == 23) { scene = 44; }
                else if (scene == 24) { scene = 44; }
                else if (scene == 27) { scene = 44; }
                else if (scene == 28) { scene = 44; }
                else if (scene == 31) { scene = 44; }
                else if (scene == 32) { scene = 44; }
                else if (scene == 35) { scene = 44; }
                else if (scene == 36) { scene = 44; }
                else if (scene == 38) { scene = 44; }
                else if (scene == 39) { scene = 44; }
                else if (scene == 40) { scene = 44; }
                else if (scene == 41) { scene = 44; }
                else if (scene == 43) { scene = 44; }
            }

            switch (scene)
            {
                case 0:
                    this.BackgroundImage = null;
                    titleLabel.Visible = false;
                    textLabel.Text = "You wake up with a ringing in your ears. As you look around, you seem to be on some kind of spaceship.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    this.BackgroundImage = (Properties.Resources.windowIcon);
                    textLabel.Text = "Peeking out the window hammers home the fact that you are not on Earth. Over the loudspeaker, a robotic sounding voice repeats “Engine Failure”.";
                    redLabel.Text = "Go explore the ship";
                    blueLabel.Text = "Go explore the planet";
                    yellowLabel.Text = "";
                    break;
                case 1:
                    this.BackgroundImage = null;
                    textLabel.Text = "Walking through the halls of your spaceship you see a map on the wall. Three rooms are lit up in red. Where do you go?";
                    redLabel.Text = "The Bridge";
                    blueLabel.Text = "The Medical Bay";
                    yellowLabel.Text = "The Engine Room";
                    break;
                case 2:
                    this.BackgroundImage = (Properties.Resources.guyIcon);
                    airlock.Play();
                    textLabel.Text = "Making your way to the airlock, you see a spacesuit hanging on the wall.";
                    redLabel.Text = "Continue through the airlock";
                    blueLabel.Text = "Put on the spacesuit";
                    yellowLabel.Text = "";
                    break;
                case 3:
                    this.BackgroundImage = null;
                    textLabel.Text = "As you enter the engine room you notice there is a big empty slot on the engine.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    textLabel.Text = "Checking the manual that is conveniently laying right beside the engine, you find out that it is missing the quadraceptor core unit.";
                    redLabel.Text = "Continue to explore the ship.";
                    blueLabel.Text = "Leave the ship to look for the missing part.";
                    yellowLabel.Text = "";
                    break;
                case 4:
                    this.BackgroundImage = null;
                    textLabel.Text = "You walk into the bridge to see a huge console filled with too many buttons to count.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    textLabel.Text = "On closer inspection one button on the main console stands out to you. It's labeled distress beacon.";
                    redLabel.Text = "Leave the bridge and continue to explore the ship.";
                    blueLabel.Text = "Press the button.";
                    yellowLabel.Text = "";
                    break;
                case 5:
                    this.BackgroundImage = (Properties.Resources.gasIcon);
                    gas.Play();
                    textLabel.Text = "As soon as you enter the medical bay, you notice a pungent odor. In the corner of the room, you spot a vial leaking a green gas.";
                    redLabel.Text = "Walk closer to get a better look at it.";
                    blueLabel.Text = "Immediately cover your mouth and nose.";
                    yellowLabel.Text = "";
                    break;
                case 6:
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    textLabel.Text = "As soon as you step outside, you notice a lack of oxygen. Unable to breath, you mutter your last words.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    textLabel.Text = "“Aw shucks, I really should’ve worn that spacesuit”.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 7:
                    this.BackgroundImage = null;
                    textLabel.Text = "You step outside of your spaceship. Three landmarks stand out to you.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2500);
                    textLabel.Text = "A dark cave";
                    Refresh();
                    Thread.Sleep(1500);
                    textLabel.Text += ", a lush forest";
                    Refresh();
                    Thread.Sleep(1500);
                    textLabel.Text += ", and ruins of an old town.";
                    Refresh();
                    Thread.Sleep(1500);
                    textLabel.Text += " Where do you go?";
                    Refresh();
                    Thread.Sleep(500);
                    redLabel.Text = "The cave.";
                    blueLabel.Text = "The forest.";
                    yellowLabel.Text = "The ruins.";
                    break;
                case 8:
                    int randNum = rng.Next(1, 11);
                    this.BackgroundImage = null;
                    button.Play();
                    if (randNum >= 7)
                    {
                        textLabel.Text = "You wait for a very long time.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        yellowLabel.Text = "";
                        Refresh();
                        Thread.Sleep(1000);
                        this.BackgroundImage = (Properties.Resources.skullIcon);
                        textLabel.Text = "Eventually the only food left are meat products, and as a vegan, you are physically incapable of consuming the nutritious goodness packed inside a single strip of bacon. ";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        yellowLabel.Text = "";
                        Refresh();
                        Thread.Sleep(4000);
                        textLabel.Text = "You starve to death.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        yellowLabel.Text = "Return to main menu";
                    }
                    else if (randNum >= 2)
                    {
                        textLabel.Text = "You wait for a very long time.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        yellowLabel.Text = "";
                        Refresh();
                        Thread.Sleep(1000);
                        textLabel.Text = "Suddenly you hear a sound. Looking out the window you see a terrifying spaceship flying over head.It lauches a rocket...headed straight for you! ";
                        Refresh();
                        Thread.Sleep(4000);
                        this.BackgroundImage = (Properties.Resources.skullIcon);
                        explosion.Play();
                        textLabel.Text = "Your ship explodes in a ball of fire! As you burn, it comes to your attention how similar roast human and rotisserie chicken are in smell.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        yellowLabel.Text = "Return to main menu";
                    }
                    else
                    {
                        textLabel.Text = "You wait for a very long time.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        yellowLabel.Text = "";
                        Refresh();
                        Thread.Sleep(1000);
                        textLabel.Text = "After what seems like for ever, a ship lands beside you! You've been saved!";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        yellowLabel.Text = "Return to main menu";
                    }
                    break;
                case 9:
                    int randNumb = rng.Next(1, 3);
                    this.BackgroundImage = (Properties.Resources.gasIcon);
                    if (randNumb == 1)
                    {
                        textLabel.Text = "You cover your mouth and nose as fast as you can and sprint out of the medical bay.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        yellowLabel.Text = "";
                        Refresh();
                        Thread.Sleep(3000);
                        textLabel.Text = "Lucky for you, it doesn't seem you breathed in too much of the gas.";
                        redLabel.Text = "Continue.";
                        blueLabel.Text = "";
                        yellowLabel.Text = "";
                        rYouDead = false;
                    }
                    else if (randNumb == 2)
                    {
                        textLabel.Text = "You cover your mouth and nose as fast as you can and sprint out of the medical bay.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        yellowLabel.Text = "";
                        Refresh();
                        Thread.Sleep(3000);
                        this.BackgroundImage = (Properties.Resources.skullIcon);
                        textLabel.Text = "Unfortunately, your heavy mouth breathing caused you to ingest a lethal dose of the unknown substance. You pass away, puffer in hand.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        yellowLabel.Text = "Return to main menu";
                        rYouDead = true;
                    }
                    break;
                case 10:
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    textLabel.Text = "You walk further in the medical bay without worrying about the gas. Sure it burns your throat and makes your eyes water, but what doesn’t nowadays? You die in a matter of minutes.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 11:
                    this.BackgroundImage = (Properties.Resources.caveIcon);
                    textLabel.Text = "As you walk into the cave, you notice the entrance is littered with bones, some of them humanoid.";
                    redLabel.Text = "Continue into the cave.";
                    blueLabel.Text = "Turn back.";
                    yellowLabel.Text = "";
                    break;
                case 12:
                    this.BackgroundImage = null;
                    textLabel.Text = "You see two paths leading into the forest.";
                    redLabel.Text = "Take the left path.";
                    blueLabel.Text = "Go back the way you came.";
                    yellowLabel.Text = "Take the right path.";
                    break;
                case 13:
                    this.BackgroundImage = null;
                    textLabel.Text = "As you arrive at the ruins, 3 buildings stand out to you.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2500);
                    textLabel.Text = "The remains of a huge mansion";
                    Refresh();
                    Thread.Sleep(1500);
                    textLabel.Text += ", what looks like a storefront";
                    Refresh();
                    Thread.Sleep(1500);
                    textLabel.Text += ", and a big block-like structure.";
                    Refresh();
                    Thread.Sleep(500);
                    redLabel.Text = "Get a closer look at the mansion.";
                    blueLabel.Text = "Enter the remains of the storefront.";
                    yellowLabel.Text = "Enter the big block-like building.";
                    break;
                case 17:
                    this.BackgroundImage = null;
                    cave.Play();
                    textLabel.Text = "As you continue deeper into the cave you run into a sticky wall. As you try to pull yourself away, it comes to your attention that you are stuck.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    cave.Stop();
                    killedDeath.Play();                    
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    textLabel.Text = "A massive spider approaches and proceeds to eat you whole.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 18:
                    this.BackgroundImage = null;
                    textLabel.Text = "Walking into the store, a faded sign informs you it used to be an antique shop. On a labeled shelf are three parts that look and sound like they could be from an engine.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(4000);
                    textLabel.Text = "You are only strong enough to carry one. Which do you take?";
                    Refresh();
                    Thread.Sleep(500);
                    redLabel.Text = "Infrared Tesseract Dispenser";
                    blueLabel.Text = "Thermal Sync Key";
                    yellowLabel.Text = "Quadraceptor Core Unit";
                    break;
                case 19:
                    this.BackgroundImage = null;
                    textLabel.Text = "The mansion is twice the size of the other buildings inside the ruins, and in pretty good shape too.";
                    redLabel.Text = "Try the front door.";
                    blueLabel.Text = "Look for another way in.";
                    yellowLabel.Text = "";
                    break;
                case 20:
                    this.BackgroundImage = null;
                    textLabel.Text = "Turns out this building is a jail! Most of the cells inside seem to be intact. In fact, a large alien is sitting in one!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(4000);
                    textLabel.Text = "He looks up as you walk in. He asks you to let him out, motioning to a key on a nearby table.";
                    redLabel.Text = "Let him out.";
                    blueLabel.Text = "Leave him, he's probably there for a reason.";
                    yellowLabel.Text = "";
                    break;
                case 21:
                    this.BackgroundImage = null;
                    textLabel.Text = "You come across two paths. Which do you choose?";
                    redLabel.Text = "The left path.";
                    blueLabel.Text = "The right path.";
                    yellowLabel.Text = "";
                    break;
                case 22:
                    this.BackgroundImage = null;
                    textLabel.Text = "After trekking through the forest, you come across an old broken-down shack.";
                    redLabel.Text = "Go back the way you came.";
                    blueLabel.Text = "Enter the shack.";
                    yellowLabel.Text = "";
                    break;
                case 23:
                    textLabel.Text = "You make it safely back to your ship with the thermal sync key. As you put it into the engine";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1000);
                    textLabel.Text += ".";
                    Refresh();
                    Thread.Sleep(100);
                    textLabel.Text += ".";
                    Refresh();
                    Thread.Sleep(100);
                    textLabel.Text += ".";
                    Refresh();
                    Thread.Sleep(100);
                    explosion.Play();
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    textLabel.Text += ". it explodes in your face, charing you to a crisp.";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 24:
                    this.BackgroundImage = null;
                    textLabel.Text = "You make it safely back to your ship with the quadraceptor core unit.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    engine.Play();
                    textLabel.Text = "As you put it into the engine, a green light flashes. You head to the ships controls and successfully fly back home.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 25:
                    this.BackgroundImage = null;
                    textLabel.Text = "You look around the back of the house and notice a window and a backdoor.";
                    redLabel.Text = "Enter through the window";
                    blueLabel.Text = "Enter through the door";
                    yellowLabel.Text = "";
                    break;
                case 26:
                    this.BackgroundImage = null;
                    textLabel.Text = "The door is locked.";
                    redLabel.Text = "Knock on the door.";
                    blueLabel.Text = "Knock down the door.";
                    yellowLabel.Text = "";
                    break;
                case 27:
                    this.BackgroundImage = null;
                    textLabel.Text = "You let the alien out of his cage. He thanks you, but complains about being hungry.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    killedDeath.Play();
                    textLabel.Text = "He says that you’ll make a fine meal and pulls seasoning out of his pocket. You make for a wonderful meal, but not a very good space explorer.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 28:
                    this.BackgroundImage = null;
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    killedDeath.Play();                    
                    textLabel.Text = "You decide to leave the alien in his cage. However, as you turn around, a large rock impacts the back of your head, thrown from the prison cell. You die immediately.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 29:
                    this.BackgroundImage = null;
                    textLabel.Text = "Trekking through the forest, you get a sense that you’ve passed by this place many times.";
                    redLabel.Text = "Turn around";
                    blueLabel.Text = "Keep going";
                    yellowLabel.Text = "";
                    break;
                case 30:
                    this.BackgroundImage = null;
                    textLabel.Text = "You feel completely lost.";
                    redLabel.Text = "Turn around";
                    blueLabel.Text = "Make your own path through the trees";
                    yellowLabel.Text = "Keep going";
                    break;
                case 31:
                    this.BackgroundImage = null;
                    windowBreak.Play();
                    textLabel.Text = "You break the glass with a rock and climb inside. As you turn around, you look right down the barrel of a gun.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);                    ;
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    textLabel.Text = "The alien holding it pulls the trigger and blows you right back out that window. Back at home, your family receives a bill for window repair.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    shotGun.Play();                    
                    break;
                case 32:
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    knock.Play();
                    textLabel.Text = "An alien answers the door and looks you up and down while licking his lips. “I was just about to get some lunch.” You make for a wonderful human stew.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 33:
                    this.BackgroundImage = null;
                    textLabel.Text = "Inside the mansion you see an alien cowering in fear under a table. What do you do?";
                    redLabel.Text = "Ask politely for a way off the planet";
                    blueLabel.Text = "Demand for a way off the planet";
                    yellowLabel.Text = "";
                    break;
                case 34:
                    this.BackgroundImage = null;
                    textLabel.Text = "An old alien sits in the corner on a rocking chair. She asks what you’re doing here.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    textLabel.Text = "“Looking for a way off this planet.” you reply. She offers you her spaceship if you answer her riddle correctly.";
                    redLabel.Text = "Agree to answer the riddle";
                    blueLabel.Text = "Refuse to hear the riddle";
                    yellowLabel.Text = "";
                    break;
                case 35:
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    textLabel.Text = "You get lost deep in the forest, eventually starving to death.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 36:
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    killedDeath.Play();
                    textLabel.Text = "The old lady is taken aback that you refused her invitation. She jumps out of her chair and lunges at you. Her claws rip your spacesuit, causing you to die almost immediately.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 37:
                    this.BackgroundImage = null;
                    textLabel.Text = "She clears her throat. “What runs around a house but does not move?”";
                    redLabel.Text = "A fence";
                    blueLabel.Text = "A dog";
                    yellowLabel.Text = "The walls";
                    //riddleBox.Visible = true;
                    break;
                case 38:
                    this.BackgroundImage = null;
                    textLabel.Text = "You got her riddle correct! She grabs her keys and leads you to the spaceship out back. You drive her ship to freedom! ";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 39:
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    killedDeath.Play();                    
                    textLabel.Text = "You got it wrong! She jumps out of her chair and lunges at you. Her claws rip your spacesuit, causing you to die almost immediately.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    textLabel.Text = "As you die, you realize that 'fence' would’ve been the better answer.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 40:
                    this.BackgroundImage = null;
                    textLabel.Text = "The alien sheepishly throws you his keys and tells you the ship is in the garage. You fly his ship safely off the planet!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 41:
                    this.BackgroundImage = (Properties.Resources.skullIcon);
                    textLabel.Text = "You politely ask the alien for a way off the planet. He notices that you are a total wimp. He grabs a gun from under the table and fires it, killing you.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 42:
                    this.BackgroundImage = null;
                    textLabel.Text = "You look around and see the cave, the forest and the ruins. Which do you go to?";
                    redLabel.Text = "The cave.";
                    blueLabel.Text = "The forest.";
                    yellowLabel.Text = "The ruins.";
                    break;
                case 43:
                    this.BackgroundImage = null;
                    textLabel.Text = "You make it safely back to your ship with the infrared tesseract dispenser";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1000);
                    textLabel.Text += ".";
                    Refresh();
                    Thread.Sleep(100);
                    textLabel.Text += ".";
                    Refresh();
                    Thread.Sleep(100);
                    explosion.Play();
                    textLabel.Text += ". As you put it into the engine it explodes in your face, charing you to a crisp.";
                    yellowLabel.Text = "Return to main menu";
                    break;
                case 44:
                    this.BackgroundImage = null;
                    titleLabel.Visible = true;
                    textLabel.Text = "";
                    redLabel.Text = "New Game";
                    blueLabel.Text = "Quit Game";
                    yellowLabel.Text = "";
                    break;
                case 45:
                    this.Close();
                    break;
            }
        }
    }
}
