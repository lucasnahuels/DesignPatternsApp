﻿using DesignPatternsApp.Builder;

namespace DesignPatternsApp.Observer
{
    public class EmailNotifier : IObserver
    {
        private readonly User _user;

        public EmailNotifier(User user)
        {
            _user = user;
        }

        public void Update(decimal amount, string product)
        {
            Console.WriteLine($"{product}: Email Notification to {_user.Email}: A payment of {amount:C} was processed.");
        }
    }
}
