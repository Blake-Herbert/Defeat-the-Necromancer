using TurnBasedGame;




Character playerCharacter = new Character("Player", 20);

playerCharacter.AddAction("Fireball", ActionRepository.Fireball);
playerCharacter.AddAction("Ice Lance", ActionRepository.IceLance);

Character nonplayerCharacter = new Character("NPC", 10);

while(playerCharacter.Health > 0 && nonplayerCharacter.Health > 0)
{
	string prompt = nonplayerCharacter.Name + " Health: " + nonplayerCharacter.Health + "\nPlayer Health: " + playerCharacter.Health;
	string[] options = { "Fireball", "Secondary Attack" };
	Menu fightMenu = new Menu(prompt, options);

	fightMenu.DisplayOptions();
	switch (fightMenu.Run())
	{
		case 0:
			var selectedSpell = playerCharacter.Spells["Fireball"];
			selectedSpell(playerCharacter, nonplayerCharacter);
			break;
		case 1:
			selectedSpell = playerCharacter.Spells["Ice Lance"];
			break;

		default:
			break;
	}
}

Console.Clear();
Console.WriteLine("Fight Over!");
Console.ReadKey();


