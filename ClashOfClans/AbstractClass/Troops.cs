using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.Interface;

namespace ClashOfClans.AbstractClass {
  abstract class Troops {
    protected IAttackType attackType;
    protected IMovement movement;
    protected ILevel level;

    public int HousingSpace() {
      return 5;
    }

    public abstract void Attack();
    public abstract double TrainingTime();
    public abstract double TrainingCost();
    public abstract double Hitpoints();
    public abstract void Display();
  }
}
