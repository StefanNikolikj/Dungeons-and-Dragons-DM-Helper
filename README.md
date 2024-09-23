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

![image](https://github.com/user-attachments/assets/36b46251-4dce-4252-b548-fc398c71cf0c)
- The initiative list: is the list to the left of the form. This list displays all of the current characters that are a part of this combat. From here any character can be selected for their statistics and actions to be shown on the right of the form, additionally multiple characters can be selected for actions that would effect more than one character.
- Roll Initiatives of Selected Combatants: Randomly assigns the initiatives of the selected characters, this process works with a function that returns a randomly generated number after adding the bonuses for each individual combatant accordingly.
- Manually Input Initiative of a Combatant: opens the SetInitiative form, which allows the user to manually input the initiative of the selected character.
- Add new Combatant button: opens the NewCombatant form, which allows the user to create a new combatant and determine their statistics. Upon completing this process the new character will appear at the bottom of the initiative list to the left.
- Remove Combatant button: deletes the selected character from the initiative list to the left.
- Roll Saving Throw: opens the SavingThrow form, which allows the user to roll saving throw for one or more selected characters from the initiative list.
- Make an Attack button: opens the MakeAnAttack form which allows the user to make attacks for the selected character, this will allow the user to make one or multiple attacks on another character or characters, and calculate the damage if needed.
- Display Combatant section: this section has all of the statistics and actions for the individual selected character, which can be operated from if the selected character is taking his turn in combat.
- Name: This displays the name of the character.
- Proficiency Bonus: This displays the character's proficiency bonus, which is an already added bonus to some of the actions the character can take.
- Passive Perception: This displays the character's passive perception, which can determine if the character can see another character that is using stealth (according to their stealth roll). The passive perception is calculated automatically as 10 + perception modifier.
- Total HP: This displays the maximum amount of hit points a character can have. A character cannot be healed above his maximum hp however there are actions which allow character to gain temporary hp. Whenever a character with temporary hp takes damage the amount is first subtracted from his temporary hp.
- AC: This displays the Armor Class of the character. Whenever somebody chose this character as a target of an attack, the attack roll must be greater than the target's hp.
- Current HP: This displays the current hit points of the character both as a number and in the health bar bellow the number. Whenever a non-player character reaches 0 hp they die instantly.
- Stats: This section displays the individual statistics of each character.
- Saving Throws: This sections displays the bonuses for each possible saving throw the character can make.
- Speeds: This sections displays the possible distance the character can travel during his turn in combat.
- Resistances, Immunities and Vulnerabilities: This sections display the types of damage the character will react differently to. If the character takes damage from the type of damage he is resistent to, the damage will be halved. The character cannot take any damage from a type he is immune to. If the character takes damage from the type of damage he is vulnerable to, the damage will be doubled.
- Weapons/Attacks list: is a list that has all of the possible attacks the character can make during their action. The attacks are saved as the name of the weapon the character is using to attack (examples: longsword, longbow, claw, bite).
- Add new Weapon/Attack: opens the AddWeapon form which allows the user to input a new attack with bonuses and amount of damage it would deal when it hits.
- Remove weapon/attack: removes selected weapon from the list.
#
- NewCombatant.cs
Whenever a new character is being created, this form will open which will allow the user to input all of the necessary statistics for the character.

![image](https://github.com/user-attachments/assets/3fe7d7e2-e620-4b05-9d6e-1b69cc7cfdca)
- Stats: in this sector the user can input the statistics of the character, from which the modifiers for their bonuses will be determined.
- HP and AC: in this sector the user can input the maximum hp and the AC of the character.
- Proficiencies: in this sector the user can input the proficiency bonus of the character, as well as select which saving throw the character is proficient in.
- Resistances, Immunities and Vulnerabilities: in this sector the user can input the resistances, immunities and vulnerabilities of the character.
- Speeds: in this sector the user can input the movement speeds of the character.
#
- SetHP.cs and SetInitiative.cs
Both of these are simple forms used to set a custom number of hit points or initiative value to any character by the user if needed.

![image](https://github.com/user-attachments/assets/fecdb54a-9bd3-4906-835b-4691762cf368)
#
- AddWeapon.cs
This form is used to create a new attack for a character. The name was chosen because in the official statics for NPCs, their attacks are usually marked by the name of the weapon.

![image](https://github.com/user-attachments/assets/1759fdaa-4afb-47f6-9a05-b816b824d236)
- Damage Modifier: optional additional modifier that is added to both the attack and the damage. Regardless of this field the attack will have determined modifiers coming from either strenght or dexterity.
- Weapon Type: in this field the user can select which statistic the character uses for this attack.
- Damage Dice: in this field the user can select which type of dice the weapon uses for damage, how many of them and which type of damage the attack does. Each attack can have multiple types of damage, and the damage is written in the format of [number of dice]d[sides of die] [type of damage], with a + between the different types of damage (for example: 2d6 slashing + 2d4 poison damage).
#
- MakeAnAttack.cs
This form will open when a creature is making an attack, from here the user has options to make multiple attacks if the character would have that option.

![image](https://github.com/user-attachments/assets/f8ffe064-5d78-4e41-ae87-0dd3aed56f6f)
- Choose who to Attack and Enter the number of attacks: in these two the user can select both towards which character the attacks are aimed at as well as the number of attacks towards that character.
- Advantage and Disadvantage: These can be individually selected when applicable. Advantage on rolls means that the die is rolled twice and the greater number is taken. Disadvantage on rolls means that the die is rolled twice and the lower number is taken.
- Attack Roll: in this sector the user will be able to see the outcome of the attacks done, whether they hit or not and the damage they dealt. If the attacks hits the damage is automatically done to the target.
#
- SavingThrow.cs
 This form will open when the user needs to roll a saving throw, saving throws can have one or multiple targets in which case all targets will roll individually. If damage is included in the saving throw, the dice for the attack roll should be included in the format [number of dice rolled]d[sides of the dice] (for example 3d6 for 3 6 sided dice).

![image](https://github.com/user-attachments/assets/2201ad4a-f6f1-45a5-8827-cf972cf69186)
- Choose the type of Saving Throw: allows you to choose what type of the saving throw the previously selected characters will roll.
- Enter Save DC: is where the user can input the Difficulty Class of the saving throw. The selected characters will then have to roll and if the roll with modifiers is lower than the DC the characters will be effected.
- Roll Damage: this sector can be activated by choosing to roll for damage as well.
- Enter the Dice to be rolled: in this field the user can input the damage of the effect the characters are rolling to save against. The damage is inputted in the format [number of dice]d[sides of dice] for example 8d6.
- Does the attack deal half damage when saved: some effects may deal half damage even when saved. If this is not checked then the characters that succeeded on the roll will not take any damage.
#
