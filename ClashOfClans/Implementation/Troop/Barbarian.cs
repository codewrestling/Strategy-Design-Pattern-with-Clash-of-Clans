using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.AbstractClass;
using ClashOfClans.Implementation.Level;
using ClashOfClans.Implementation.Movement;
using ClashOfClans.Interface;

namespace ClashOfClans.Implementation.Troop {
  class Barbarian : Troops {
    public Barbarian() {
      movement = new GroundMovement();
      attackType = new SwordAttack();
      level = new LevelOne();
    }

    public Barbarian(ILevel level) {
      movement = new GroundMovement();
      attackType = new SwordAttack();
      this.level = level;
    }
    public override double TrainingTime() {
      return 2 + 2 * level.IncreaseInTrainingTime();
    }

    public override double TrainingCost() {
      return 100 + 100 * level.IncreaseInTrainingCost();
    }

    public override double Hitpoints() {
      return 1000 + 1000 * level.IncreaseInHitpoints();
    }

    public override void Display() {
      Console.WriteLine("I am Barbarian");
    }


    public override void Attack() {
      attackType.Attack();
      movement.Move();
      double attackRate = 100.0 + 100.0 * level.IncreaseInAttackingRate();
      Console.WriteLine("I am gonna damage " + attackRate);
    }
  }
}
