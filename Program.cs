using System;
using System.Collections.Generic;

// Интерфейс для частей дома
interface IPart
{
    void Build();
}

// Интерфейс для рабочих
interface IWorker
{
    void Work(House house);
}

// Классы для частей дома
class Basement : IPart
{
    public void Build()
    {
        Console.WriteLine("Building the basement.");
    }
}

class Walls : IPart
{
    public void Build()
    {
        Console.WriteLine("Building the walls.");
    }
}

class Door : IPart
{
    public void Build()
    {
        Console.WriteLine("Installing the door.");
    }
}

class Window : IPart
{
    public void Build()
    {
        Console.WriteLine("Installing a window.");
    }
}

class Roof : IPart
{
    public void Build()
    {
        Console.WriteLine("Building the roof.");
    }
}

// Класс для дома
class House
{
    private List<IPart> parts = new List<IPart>();

    public void AddPart(IPart part)
    {
        parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("The house is built. Here is the structure:");
        foreach (var part in parts)
        {
            part.Build();
        }
    }
}

// Классы для рабочих
class Worker : IWorker
{
    public void Work(House house)
    {
        Console.WriteLine("Worker is working...");
    }
}

class TeamLeader : IWorker
{
    public void Work(House house)
    {
        Console.WriteLine("Team leader is inspecting the work.");
    }
}

// Класс для бригады строителей
class Team
{
    private List<IWorker> workers = new List<IWorker>();

    public void AddWorker(IWorker worker)
    {
        workers.Add(worker);
    }

    public void Work(House house)
    {
        Console.WriteLine("Construction of the house begins.");
        foreach (var worker in workers)
        {
            worker.Work(house);
        }
    }
}

class Program
{
    static void Main()
    {
        House house = new House();
        Team team = new Team();

        // Добавляем строителей в бригаду
        team.AddWorker(new Worker());
        team.AddWorker(new Worker());
        team.AddWorker(new Worker());
        team.AddWorker(new TeamLeader());

        // Строим дом
        team.Work(house);

        // Показываем результат
        house.Show();

        Console.ReadLine();
    }
}

