// The Mediator Pattern is a behavioral design pattern that facilitates communication between components (called "colleagues") by centralizing their interactions through a mediator object.

using Mediator.Interfaces;
using Mediator.Models;

IChatRoom chatRoom = new ChatRoom();

IUser user = new User("User");
IUser user2 = new User("User2");

user.Id = 1;
user2.Id = 2;

chatRoom.RegisterUser(user);
chatRoom.RegisterUser(user2);

chatRoom.SendMessage("Hello, User2!", 2);
