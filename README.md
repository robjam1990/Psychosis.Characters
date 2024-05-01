# Psychosis.Characters

This module contains the character classes for the Psychosis game.

## Character

The `Character` class is the base class for all characters in the game. It contains the following properties:

- `class_name`: The character's class.
- `race`: The character's species.
- `gender`: The character's reproductive biologics.
- `alignment`: The character's moral compass.
- `background`: The character's backstory.
- `skills`: A dictionary of skills that the character knows, with the skill name as the key and the skill level as the value.
- `quests`: A dictionary of quests that the character is currently on, with the quest name as the key and the quest status as the value.
- `gold`: The character's gold.
- `equipment`: A dictionary of items that the character has equipped, with the item slot as the key and the item as the value.
- `location`: The character's current location in the game world.
- `faction`: The character's faction.
- `inventory`: A list of items that the character is carrying.
- `status`: A list of status effects that are affecting the character.
- `level`: The character's level.
- `experience`: The character's experience points.
- `max_experience`: The character's maximum experience points.
- `health`: The character's current health.
- `max_health`: The character's maximum health.
- `attack`: The character's attack power.
- `defense`: The character's defense power.
- `speed`: The character's speed.
- `skills`: A list of skills that the character knows.
- `status`: A list of status effects that are affecting the character.


## Usage

To create a new character, you can use the `Character` class like this:

```python
from Psychosis.Characters import Character

character = Character(
	class_name)
```

	You can then access the character's properties like this:
	```python
	print(character.class_name)
	```

		You can also modify the character's properties like this:
		```python
		character.class_name = 'Warrior'
		```