using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Interface {
  interface ILevel {
    double IncreaseInTrainingTime();
    double IncreaseInTrainingCost();
    double IncreaseInAttackingRate();
    double IncreaseInHitpoints();
  }
}
