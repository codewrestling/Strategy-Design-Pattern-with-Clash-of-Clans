using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.AbstractClass;
using ClashOfClans.Implementation.Level;
using ClashOfClans.Implementation.Movement;
using ClashOfClans.Interface;

namespace ClashOfClans.Implementation.Troop {
  class Giant : Troops {
    public Giant(ILevel level) {
      movement = new GroundMovement();
      attackType = new PunchAttack();
      this.level = level;
    }

    public Giant() {
      movement = new GroundMovement();
      attackType = new PunchAttack();
      level = new LevelOne();
    }
    public override double TrainingTime() {
      return 4 + 4 * level.IncreaseInTrainingTime();
    }

    public override double TrainingCost() {
      return 120 + 120 * level.IncreaseInTrainingCost();
    }

    public override double Hitpoints() {
      return 2000 + 2000 * level.IncreaseInHitpoints();
    }

    public override void Display() {
      Console.WriteLine("I am Giant");
    }

    public override void Attack() {
      attackType.Attack();
      movement.Move();
      double attackRate = 120.0 + 120.0 * level.IncreaseInAttackingRate();
      Console.WriteLine("I am gonna damage " + attackRate);
    }
  }
}
