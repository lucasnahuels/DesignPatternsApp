﻿namespace DesignPatternsApp.Builder
{
    /*
    The Fluent Builder design pattern is a variation of the Builder pattern.
    The Fluent Builder pattern is a powerful design pattern that enables the creation 
    of complex objects through a more readable and maintainable fluent interface
    (in this context, the term "fluent interface" refers to the builder class).
     */
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }

        private User() { }

        public class Builder
        {
            private readonly User _user = new();

            public Builder SetName(string name)
            {
                _user.Name = name;
                return this;
            }

            public Builder SetEmail(string email)
            {
                _user.Email = email;
                return this;
            }

            public Builder SetPhoneNumber(string phoneNumber)
            {
                _user.PhoneNumber = phoneNumber;
                return this;
            }

            public User Build()
            {
                // Add validation logic if needed
                if (string.IsNullOrEmpty(_user.Name))
                    throw new InvalidOperationException("Name is required.");
                if (string.IsNullOrEmpty(_user.Email))
                    throw new InvalidOperationException("Email is required.");

                return _user;
            }
        }
    }

}
