﻿namespace SpaDay6;

public class User
{
   public int Id { get; }
   static int nextId = 1;
   public string Username { get; set;}
   public string Email { get; set;}
   public string Password { get; set;}

   public User()
   {
      Id = nextId;
      nextId++;
   }

   public User(string username, string email, string password)
   {
      Username = username;
      Email = email;
      Password = password;
   }
}
