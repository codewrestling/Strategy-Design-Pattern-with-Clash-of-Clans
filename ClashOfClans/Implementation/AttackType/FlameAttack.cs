using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.Interface;

namespace ClashOfClans.Implementation {
  class FlameAttack : IAttackType {
    public void Attack() {
      Console.WriteLine("I am gonna burn everything.");
    }
  }
}
