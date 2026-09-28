using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
    private string name;
    public int Energy{get; private set;}
    private Mood moodStatus;
    private Feed feedStatus;
    private Random random;

    private Cat()
        {
         random = new Random();
        }
    public Cat(string name,int energy, Mood moodStatus, Feed feedStatus) : this()
        {
            this.name = name;
            Energy = energy;
            this.moodStatus = moodStatus;
            this.feedStatus = feedStatus;
        }

    public Cat(string name) : this()
        {
            this.name = name;
            Energy = random.Next(1,21);
            moodStatus = (Mood) random.Next(4);
            feedStatus = (Feed) random.Next(5);
            
        }



    
    }
    
}