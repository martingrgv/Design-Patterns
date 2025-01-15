// The Proxy Design Pattern is a structural design pattern that provides a surrogate or placeholder for another object to control access to it.
// A proxy acts as an intermediary between the client and the target object, adding an additional level of control, such as security, lazy initialization, caching, logging, or other functionality.

using Proxy.Models;
using Proxy.Proxies;

var bankServer = new BankServer(10_000);

var atm = new ATMProxy(bankServer);

string pin = "0000";
atm.Authenticate(pin);

atm.CheckBalance();
atm.Withdraw(1000);

atm.CheckBalance();
