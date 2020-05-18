using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.Interface;

namespace ClashOfClans.Implementation.Level {
  class LevelTwo : ILevel {
    public double IncreaseInTrainingTime() {
      return 15.0 / 100;
    }

    public double IncreaseInTrainingCost() {
      return 20.0 / 100;
    }

    public double IncreaseInAttackingRate() {
      return 18.0 / 100;
    }

    public double IncreaseInHitpoints() {
      return 10.0 / 100;
    }
  }
}
