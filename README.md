# 1-2-term-project

# 🧪 Crazy Scientist (Unity Tutorial Game)

This is a Unity 2D action game project created by following a YouTube tutorial.  
The purpose of this repository is to document my learning experience with Unity and C# scripting.

---

## 📚 Tutorial Reference

This project is based on a Unity tutorial video from YouTube (link unavailable).  
I followed the tutorial to understand the basics of Unity game development, including movement, shooting, enemy AI, and modular scripting.

⚠️ No original functionality was added. This project is **for educational purposes only**.

---

## 🎮 Game Summary

Crazy Scientist is a 2D shooting game where the player must survive waves of enemies using projectile attacks.  
The game contains basic mechanics such as health systems, collision handling, scoring, and sound.

---

## 📂 Script Structure

The project is modularized into several script categories for clarity and maintainability:

### 🧨 Enemy Scripts
- **Enemy.cs** – Controls enemy behavior and base logic
- **EnemyDamageArea.cs** – Detects and processes attack collisions with the player
- **EnemyHealth.cs** – Manages enemy hit points and reactions
- **EnemySpawner.cs** – Spawns enemies at predefined locations in the scene

### 🎮 Gameplay Scripts
- **CameraFollow.cs** – Makes the camera follow the player smoothly
- **Collector.cs** – Destroys tagged objects on collision (e.g., projectiles, pickups)
- **GameplayController.cs** – Increases score when enemies are defeated
- **SoundManager.cs** – Handles all in-game sound effects

### 🧩 Helper Script
- **TagManager.cs** – Centralized tag definitions for GameObjects and animations  
  Allows easy access to tags like `"ENEMY"`, `"PLAYER"`, etc., across multiple scripts

### 🕹️ Player Scripts
- **PlayerAnimation.cs** – Manages transitions between player animations
- **PlayerHealth.cs** – Controls player health, damage, and death behavior
- **PlayerMovement.cs** – Handles character movement input
- **PlayerShootingManager.cs** – Controls player shooting mechanics

---

## 🧠 Why This is Here

Although I am no longer actively pursuing game development, this repository is preserved as a snapshot of my Unity learning journey.  
It reflects the way I used tutorials to explore structured C# scripting and object-oriented design inside Unity.

