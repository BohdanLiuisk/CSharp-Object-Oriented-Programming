using System;

namespace Accountant
{
    enum Post
    {
        // position and number of hours worked per month
        Manager = 195,
        Developer = 200,
        Accountant = 192,
        Secretary = 192,
        Cleaner = 192
    }

    class Accountant
    {
        //a method considering whether to give the employee an award or not,
        //if the employee has worked more than 192 hours a week - give an award
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
            {
                return true;
            }
            return false;
        }
    }
}
