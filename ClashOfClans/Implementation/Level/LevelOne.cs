using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.Interface;

namespace ClashOfClans.Implementation.Level {
  class LevelOne : ILevel {
    public double IncreaseInTrainingTime() {
      return 10.0/100;
    }

    public double IncreaseInTrainingCost() {
      return 12.0/100;
    }

    public double IncreaseInAttackingRate() {
      return 11.0 / 100;
    }

    public double IncreaseInHitpoints() {
      return 5.0 / 100;
    }
  }
}
