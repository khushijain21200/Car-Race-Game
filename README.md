# 🚗 Car Race Game in VB.NET

Welcome to the **Car Race Game**—a dynamic and engaging racing game developed using VB.NET. This project was built to showcase key aspects of game development, including speed management, collision detection, and user interaction.

## 🎮 Game Overview

In this game, the player controls a car, navigating through a road filled with obstacles in the form of other cars. The objective is to avoid collisions and score points as you progress. The game gets progressively harder as the speed increases based on your score.

## 🛠️ Features

- **Speed Mechanics:** The game dynamically adjusts the speed based on the player's score, increasing the challenge as you progress.
- **Collision Detection:** The game ends when the player's car collides with any of the other cars.
- **Scoring System:** The score increments as you successfully dodge the other cars.
- **Responsive Controls:** Use the arrow keys to move the car left or right.
- **Replay Functionality:** After the game ends, players can easily restart the game.

## 📄 Code Explanation

### Key Components

- **Speed Adjustment:** The game speed is controlled using a `speed` variable, which increases as the score goes up, making the game more challenging.
    
  If score > 10 And score < 20 Then
      speed = 5
  End If
  If score > 20 And score < 30 Then
      speed = 6
  End If
  If score > 30 Then
      speed = 8
  End If

  
- **Collision Detection:** The game checks for collisions between the player’s car (`Car1`) and the other cars (`Car2`, `Car3`, `Car4`, `Car5`) using `Bounds.IntersectsWith`. If a collision is detected, the game ends.
  
  If (Car1.Bounds.IntersectsWith(Car2.Bounds)) Then
      Game_Over()
  End If
  

- **Game Over and Replay:** When a collision is detected, the game stops, and a "Game Over" message is displayed. The player can then choose to replay the game.

  Private Sub Game_Over()
      ' Code to handle game over and stop all timers
  End Sub
  ```

- **Obstacle Movement:** The enemy cars move down the screen at varying speeds. Once they reach the bottom, they reappear at the top in a random position.

  Private Sub Race1_Tick(sender As Object, e As EventArgs) Handles Race1.Tick
      Car2.Top += speed * 0.5
      If Car2.Top >= Me.Height Then
          score += 1
          Points.Text = "SCORE : " & score
          Car2.Top = -(CInt(Math.Ceiling(Rnd() * 80)) + Car2.Height)
          Car2.Left = CInt(Math.Ceiling(Rnd() * 10)) + 50
      End If
  End Sub


### Installation and Setup

To run the game locally:

1. **Clone the repository:**
    https://github.com/khushijain21200/Car-Race-Game.git
   
   
3. **Open the project in Visual Studio:**
   - Navigate to the project folder and open the `.vbproj` file in Visual Studio.

4. **Build and Run:**
   - Build the project and start the game by pressing `F5`.

### Controls

- **Arrow Keys:** Use the Left and Right arrow keys to move the car.

### Screenshots
![image](https://github.com/user-attachments/assets/f6aadff2-7150-4211-96ab-630fde27a31b)
![image](https://github.com/user-attachments/assets/21743fbc-6b82-4f11-ae10-681eb1a39723)
![image](https://github.com/user-attachments/assets/b3ff7a24-de77-421e-a1b3-61743b47ba98)
![image](https://github.com/user-attachments/assets/72918523-9883-436c-b542-8df739fb4ba3)
![image](https://github.com/user-attachments/assets/95310ce5-0306-4676-9ae6-c2c75418b890)
![image](https://github.com/user-attachments/assets/e93a5f9e-ff0e-4cd0-9b5e-4f16b5311f20)
![image](https://github.com/user-attachments/assets/1e0a1b6b-9188-49a4-9469-31f0f3cdb31d)




### Future Improvements

- **Enhanced Graphics:** Improving the visual quality of the game elements.
- **Sound Effects:** Adding sound effects for collisions and gameplay actions.
- **Levels:** Introducing multiple levels with increasing difficulty.

### Contributing

If you'd like to contribute to this project, feel free to fork the repository and submit a pull request.


