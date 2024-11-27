![Title]([https://github.com/AkarshGuptaa/ShadowSprint/blob/main/Assets/Sprites/title.png])

This is a 2D platformer game built in Unity that allows the player to move horizontally, jump, and perform wall jumps. The game integrates smooth movement mechanics, animations, and interactive physics using Unity's `Rigidbody2D` and `Animator`.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Controls](#controls)
- [Installation](#installation)
- [Gameplay](#gameplay)
- [Development](#development)
- [License](#license)
- [Contributing](#contributing)

## Introduction

This 2D platformer game features smooth, responsive movement mechanics where players can navigate levels by running, jumping, and wall jumping. The game also has proper animation handling for player actions like running and jumping. The goal is to traverse the platformer environment while avoiding obstacles and mastering the player's movement capabilities.

## Features

- **2D Player Movement**: Includes horizontal movement with left-right orientation flipping.
- **Jumping**: Players can jump while grounded and perform wall jumps when against a wall.
- **Wall Jump Mechanics**: Allows players to stick to walls and jump off them strategically.
- **Animation Integration**: Seamless animation for running, jumping, and idle states.
- **Ground and Wall Detection**: Raycast-based detection for ground and walls, ensuring accurate physics and movement responses.

## Controls

- **Move Left/Right**: `A/D` or `Left/Right Arrow` keys
- **Jump**: `Space`
- **Wall Jump**: Jump while against a wall

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/YourRepository.git
   ```
2. Open the project in Unity:
   - Make sure Unity is installed.
   - Use Unity Hub to open the project.

3. Build and run the game:
   - Select the target platform (Windows, MacOS, etc.) and hit **Build and Run**.

## Gameplay

- **Objective**: Navigate through levels using your movement abilities. Use wall jumps to access hard-to-reach areas, avoid obstacles, and complete the level.
- **Mechanics**: 
   - The player can move left or right, and the character’s sprite will flip accordingly.
   - Players can jump while grounded or execute wall jumps when in contact with a wall.
   - Wall jumping involves sticking to the wall and jumping in the opposite direction with varied force depending on input.

## Development

### Key Code Breakdown

The player movement is handled by the `PlayerMovement` script. Here’s a brief overview:

- **Horizontal Movement**: Controlled via `Input.GetAxis("Horizontal")` to get the player's left-right movement.
- **Jumping**: The `Jump()` function handles both regular jumps and wall jumps based on the player's state.
- **Ground/Wall Detection**: Using `Physics2D.BoxCast`, the script checks if the player is grounded or touching a wall to determine if jumps are allowed.
  
### Requirements

- Unity 2021.3 or higher
- Visual Studio or any other preferred code editor for development

### Folder Structure

- `Assets/`: Contains game assets, scripts, and prefabs.
- `Scripts/`: Includes the `PlayerMovement` script, responsible for handling player controls.
- `Scenes/`: Includes game levels and main menus.

## License

This project is licensed under the GNU General Public License v3.0. See [LICENSE](LICENSE) for more details.

## Contributing

Contributions are welcome! If you'd like to add new features, fix bugs, or improve the code, feel free to fork the repository and submit a pull request. For significant changes, please open an issue first to discuss what you'd like to contribute.
