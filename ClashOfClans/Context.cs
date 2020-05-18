using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.AbstractClass;

namespace ClashOfClans {
  class Context {
    private Troops troop;
    public Context(Troops troop) {
      this.troop = troop;
    }

    public void GetTroopInfo() {
      troop.Display();
      troop.TrainingTime();
      troop.TrainingCost();
      troop.Attack();
    }
  }
}
