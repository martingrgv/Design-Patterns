// The Bridge Design Pattern is a structural design pattern that separates an abstraction from its implementation, allowing them to vary independently. This pattern is particularly useful when you have multiple dimensions of variability in your code. For example, if you need to deal with different types of objects and their platform-specific implementations, the Bridge Pattern can simplify your design and reduce the need for redundant code.

using Bridge.Abstractions;
using Bridge.Devices;
using Bridge.Interfaces;

IDevice radio = new Radio();
RemoteControl basicRemote = new BasicRemote(radio);
basicRemote.TurnOn();
basicRemote.TurnOff();

IDevice tv = new TV();
AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(tv);
advancedRemote.TurnOn();
advancedRemote.SetVolume(100);
advancedRemote.Mute();
advancedRemote.TurnOff();   