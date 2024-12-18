// Adds behavior or responsibilities to objects dynamically.

using Decorator.Decorators.User;
using Decorator.Interfaces;
using Decorator.Models.Users;

IUser basicUser;
IUser adminUser;
IUser bannedAdminUser;

basicUser = new BasicUser("Ivan40");
Console.WriteLine(basicUser.GetUserInfo());

adminUser = new GrantAdminRightsDecorator(basicUser);
Console.WriteLine(adminUser.GetUserInfo());

bannedAdminUser = new BanUserDecorator(adminUser);

var bannedUserDecorator = bannedAdminUser as BanUserDecorator;
bannedUserDecorator?.BanUser();

Console.WriteLine(bannedAdminUser.GetUserInfo());

