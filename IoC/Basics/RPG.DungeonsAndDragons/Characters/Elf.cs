﻿using System;
using Ninject;
using RPG.Core;

namespace RPG.DungeonsAndDragons.Characters
{
    public class Elf: ICharacter
    {
        public Elf()
        {
            Blood = 1000;
        }
        [Inject]
        public IWeapon Weapon { get; set; }
        public string Name { get; set; }
        public int Blood { get; set; }
        public void Move(Direction direction)
        {
            Console.WriteLine(direction);
        }

        public void Atack(ICharacter target)
        {
            Console.Write(Name);
            Weapon.Use();
        }
    }
}
