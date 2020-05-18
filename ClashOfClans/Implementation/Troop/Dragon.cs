using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.AbstractClass;
using ClashOfClans.Implementation.Level;
using ClashOfClans.Implementation.Movement;
using ClashOfClans.Interface;

namespace ClashOfClans.Implementation.Troop {
  class Dragon : Troops {
    public Dragon(ILevel level) {
      movement = new AirMovement();
      attackType = new FlameAttack();
      this.level = level;
    }

    public Dragon() {
      movement = new AirMovement();
      attackType = new FlameAttack();
      level = new LevelOne();
    }
    public override double TrainingTime() {
      return 15 + 15 * level.IncreaseInTrainingTime();
    }

    public override double TrainingCost() {
      return 200 + 200 * level.IncreaseInTrainingCost();
    }

    public override double Hitpoints() {
      return 5000 + 5000 * level.IncreaseInHitpoints();
    }

    public override void Display() {
      Console.WriteLine("I am Dragon");
    }

    public override void Attack() {
      attackType.Attack();
      movement.Move();
      double attackRate = 200.0 + 200.0 * level.IncreaseInAttackingRate();
      Console.WriteLine("I am gonna damage " + attackRate);
    }
  }
}
