using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_VirtualPet
{
    class VP_Functions
    {
        //Set my fields: Fields are always private. 
        //Set fields to private so only the VirtualPet class can modify them directly
        private string name;
        private int feed;
        private int boredom;
        private int thirsty;
        private int urinate;
        private int dirty;

        { 
            this.name = name;
            this.feed = feed;
            this.boredom = boredom;
            this.thirsty = thirsty;
            this.urinate = urinate; 
            this.dirty = dirty;
        }

    //Set the properties-public 
    //Still have no clue why I am still getting errors, I did the exact same thing as before. 
    public VirtualPet()
    {
        this.name = "name";
        this.feed = 0;
        this.boredom = 2;
        this.thirsty = 10;
        this.dirty = 3;
    }

    //method for stats of virtual pet
    public void MyPetStatus()

    {
        //Here is the loop to bring all the stats together and make the numbers vary based on what user pics
        //I coulfn't find a way to list them all together and make the numbers alternate. So it is done individually.

        //Loop which makes emotions increase or decrease based on users options
                public void FeedIncrease()
    {

        this.feed = feed + 7;
    }

    public void HungerDecrease()

    {

        this.hunger = hunger - 6;
    }

    public void BoredomIncrease()

    {
        this.boredom = boredom + 5;
    }

    public void BoredomDecrease()

    {
        this.boredom = boredom - 5;
    }

    public void DirtyDecrease()

    {
        this.dirty = dirty - 4;

    }

    public void DirtyIncrease()

    {
        this.dirty = dirty + -2;
    }

    public void ThirstyDecrease()

    {
        this.thirsty = thirsty - 5;
    }

    public void ThirstyIncrease()

    {
        this.thirsty = thirsty -3;
    }

    Console.WriteLine(name);
        Console.WriteLine("feed: " + feed);
        Console.WriteLine("boredom:" + boredom);
        Console.WriteLine("thirsty:" + thirsty);
        Console.WriteLine("dirty:" + dirty);

//I have no clue why I have so many errors. I thought I coved everything.






    }

}
