<h1>OOP Principles in Unity – A Practical Guide with C# 🎮</h1>
Overview
This project is built in Unity and demonstrates Object-Oriented Programming (OOP) principles using C# scripts. Each OOP concept (Encapsulation, Abstraction, Inheritance, and Polymorphism) is explained through practical examples in the Unity Editor, helping developers understand how to apply OOP in real-world Unity game development.

OOP Concepts Covered
1. Encapsulation 🔒
Definition: Encapsulation restricts direct access to data and ensures that it is modified through well-defined methods.

Example in Unity:

The Player class has private health variables with public methods to update them.

Prevents direct modifications and ensures controlled access.

csharp
Copy
Edit
public class Player : MonoBehaviour
{
    private int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player Health: " + health);
    }
}
2. Abstraction 🎭
Definition: Abstraction hides complex details and provides a simple interface for interacting with objects.

Example in Unity:

The Weapon class defines an abstract method Attack(), which is implemented differently in Gun and Sword subclasses.

csharp
Copy
Edit
public abstract class Weapon : MonoBehaviour
{
    public abstract void Attack();
}

public class Gun : Weapon
{
    public override void Attack()
    {
        Debug.Log("Shooting with gun!");
    }
}

public class Sword : Weapon
{
    public override void Attack()
    {
        Debug.Log("Swinging sword!");
    }
}
3. Inheritance 🧬
Definition: Inheritance allows a class to derive properties and behaviors from another class.

Example in Unity:

Enemy is a base class, and Zombie and Robot inherit from it, reusing common properties like health and movement.

csharp
Copy
Edit
public class Enemy : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Enemy Health: " + health);
    }
}

public class Zombie : Enemy
{
    void Start()
    {
        Debug.Log("Zombie spawned with " + health + " health.");
    }
}

public class Robot : Enemy
{
    void Start()
    {
        Debug.Log("Robot activated with " + health + " health.");
    }
}
4. Polymorphism 🎭🔄
Definition: Polymorphism allows methods to be overridden or used interchangeably through a common interface.

Example in Unity:

The Enemy class has a virtual method Attack(), which is overridden by Zombie and Robot classes.

csharp
Copy
Edit
public class Enemy : MonoBehaviour
{
    public virtual void Attack()
    {
        Debug.Log("Enemy attacks!");
    }
}

public class Zombie : Enemy
{
    public override void Attack()
    {
        Debug.Log("Zombie bites!");
    }
}

public class Robot : Enemy
{
    public override void Attack()
    {
        Debug.Log("Robot fires laser!");
    }
}
How to Use This Project
Clone the Repository

sh
Copy
Edit
git clone https://github.com/yourusername/OOP-Unity-Game.git
cd OOP-Unity-Game
Open in Unity

Open Unity Hub and select "Add Project".

Choose the cloned folder.

Run the Scene

Press Play in Unity to see OOP principles in action.

Modify & Experiment

Try adding new enemy types, weapons, or extending behaviors using OOP concepts.

Contributing
Feel free to fork this repository and contribute improvements! Submit a pull request if you have enhancements or new OOP examples.

License
This project is open-source under the MIT License.

📢 Follow for More Unity Projects!
🔹 GitHub: https://github.com/alokkrishali
🔹 Facebook: https://www.facebook.com/learngamestutorial
🔹 Youtube: https://www.youtube.com/@LearnGamesTutorial
🔹 Blog: https://learngamestutorial.com/

This README.md is SEO-optimized with relevant Unity, OOP, and C# keywords to help your GitHub project rank better in search results! 🚀 Let me know if you want any modifications. 😊
