using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    public delegate void NavChanged(object sender, NavChangedEvent events);

    // Define a class for the event arguments
    public class NavChangedEvent : EventArgs
    {
        public int Nav { get; set; }

        public NavChangedEvent(int nav)
        {
            Nav = nav;
        }

    }

    // Define the MutualFund class as the event source
    public class MutualFund
    {
        public event NavChanged NavChanged;

        private int nav;

        public MutualFund(int initialNav)
        {
            nav = initialNav;
        }

        public int Nav
        {
            get { return nav; }
            set
            {
                nav = value;
                OnNavChanged(new NavChangedEvent(nav));
            }
        }

        protected virtual void OnNavChanged(NavChangedEvent events)
        {
            NavChanged.Invoke(this, events);
        }
    }

    // Define the MarketInsights class as the event handler
    public class MarketInsights
    {
        private Random random = new Random();

        public void VaryNav(MutualFund mutualFund)
        {
            int newNav = random.Next(0, 1001);
            mutualFund.Nav = newNav;
        }
    }

    // Define the Dashboard class as the event observer
    public class Dashboard
    {
        public void DisplayNavStatus(object sender, NavChangedEvent events)
        {
            if (events.Nav < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nav Value: " + events.Nav + " (Less than 40)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nav Value: " + events.Nav + " (Greater than or equal to 40)");
            }
            Console.ResetColor();
        }
    }

    // Main program
    class eventdriven
    {
        static void Main(string[] args)
        {
            // Create instances of the classes
            MutualFund mutualFund = new MutualFund(40);
            MarketInsights marketInsights = new MarketInsights();
            Dashboard dashboard = new Dashboard();

            // Register the event handler
            mutualFund.NavChanged += dashboard.DisplayNavStatus;

            // Change the nav value randomly and see the dashboard display the status
            for (int i = 0; i < 20; i++)
            {
                marketInsights.VaryNav(mutualFund);
                Console.WriteLine("-----");
            }
        }
    }


}
