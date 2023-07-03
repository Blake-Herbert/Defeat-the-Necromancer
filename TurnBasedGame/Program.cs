using TurnBasedGame;

Character playerCharacter = new Character("Player", 20);

playerCharacter.AddAction("Fireball", ActionRepository.Fireball);
playerCharacter.AddAction("Ice Lance", ActionRepository.LightningBolt);


Character nonplayerCharacter = new Character("NPC", 10);
nonplayerCharacter.AddAction("Swipe", ActionRepository.Swipe);

while (playerCharacter.Health > 0 && nonplayerCharacter.Health > 0)
{
	string prompt = $"{nonplayerCharacter.Name} Health: {nonplayerCharacter.Health} \n{ playerCharacter.Name}  Health: { playerCharacter.Health}";
	string[] options = { "Fireball","Lightning Bolt" };
	Menu fightMenu = new Menu(prompt, options);

	fightMenu.DisplayOptions();

	//player turn
	switch (fightMenu.Run())
	{
		case 0:
			Console.Clear();
			var playerSelectedAction = playerCharacter.Action["Fireball"];
			playerSelectedAction(playerCharacter, nonplayerCharacter);
			break;
		case 1:
			Console.Clear();
			playerSelectedAction = playerCharacter.Action["Lightning Bolt"];
			playerSelectedAction(playerCharacter, nonplayerCharacter);
			break;

		default:
			break;
	}

	//NPC turn
	Console.Clear();
	var nonplayerSelectedAction = nonplayerCharacter.Action["Swipe"];
	nonplayerSelectedAction(nonplayerCharacter, playerCharacter);


}

Console.Clear();
Console.WriteLine("Fight Over!");
if (playerCharacter.Health <= 0)
{ Console.WriteLine("You lose!"); }
else Console.WriteLine("You win!");
Console.ReadKey();


