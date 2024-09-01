# Dungeons and Dragons DM Helper
This application is made to aid a Dungeon Master hosting a game from the 5th edition of the tabletop role-playing game Dungeons and Dragons during combat encounters.  The primary idea behind the application is to make it easier and more coherent for the DM to keep track of the player characters and NPCs during combat. This involves the DM being able to keep track of the initiative order in the specific encounter, as well as statistics for each character.

## Explanation of the rules for the game
This paragraph will explain the basics of the game covered in the application to clarify the features of the application.
DnD has a turn based combat system which involves each character that takes part in the combat. Each character has a randomized initiative which is calculated during the game with a roll of a 20 sided die, and the addition of bonuses taken from each character's statistics.
During their turn in combat, each character has their own actions to choose from and can move on the map up to their movement speed. Each character has their own actions to choose from, but most commonly the action is used for some form of an attack or casting some spell. If the character decides to make a weapon attack, they have to roll a 20 sided dice and add the bonuses they get to the attack roll, if the attack roll is a number higher than the AC (Armor Class) of the target, the attack is successful and the character has to roll for the damage (the dice vary depending on which weapon the attacker is using) and add their bonuses to the damage. The movement speed of the specific character is included in the statistics for the character.
Some spells may effect multiple characters, spells that have an area of effect usually have a specific saving throw. Saving throws are rolled by each individual target of the effect (20 sided die plus bonuses) and if the roll is greater than the DC in the description of the spell they succeed, otherwise they fail. For all instances of the game calling for a saving throw, there is always a description regarding what happens both to those who succeed and those who fail the saving throw.

## Explanation for the forms
- CombatTracker.cs
This is the base form for the application, from here the user can keep track of the initiative order (list on the left) and individual character (on the right). Each individual character is an object of the Combatant class. There is an option to add new characters to the combat or remove certain characters, as well as an option to make an attack or make multiple characters roll a saving throw.
- NewCombatant.cs
Whenever a new character is being created, this form will open which will allow the user to input all of the necessary statistics for the character.
- SetHP.cs and SetInitiative.cs
Both of these are simple forms used to set a custom number of hit points or initiative value to any character by the user if needed.
- AddWeapon.cs
This form is used to create a new attack for a character. The name was chosen because in the official statics for NPCs, their attacks are usually marked by the name of the weapon.
- MakeAnAttack.cs
This form will open when a creature is making an attack, from here the user has options to make multiple attacks if the character would have that option.
- SavingThrow.cs
 This form will open when the user needs to roll a saving throw, saving throws can have one or multiple targets in which case all targets will roll individually. If damage is included in the saving throw, the dice for the attack roll should be included in the format [number of dice rolled]d[sides of the dice] (for example 3d6 for 3 6 sided dice).
 - DiceRoller.cs
  This is a form that would allow the user to generate a random number instead of rolling a die, this was purely added for convenience and has no effect on anything else in the active combat.
