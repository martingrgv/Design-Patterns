// Creates families of related or dependent objects without specifying their concrete classes. 

using AbstractFactory;
using AbstractFactory.Factories.UIFactory;
using AbstractFactory.Interfaces;

IUIFactory uiFactory;
uiFactory = new WindowsUIFactory();

var application = new Application(uiFactory);
application.Render();
