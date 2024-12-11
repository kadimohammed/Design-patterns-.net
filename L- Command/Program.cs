using L__Command;

Light livingRoomLight = new Light();


// creation des commandes
ICommand lightOn = new LightOnCommand(livingRoomLight);
ICommand lightOff = new LightOffCommand(livingRoomLight);


RemoteControl remote = new RemoteControl();


remote.SetCommand(lightOn);
remote.PressButton();
remote.PressUndo();

remote.SetCommand(lightOff);
remote.PressButton();
remote.PressUndo();
