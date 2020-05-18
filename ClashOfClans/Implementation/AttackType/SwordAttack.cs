using System;
using System.Collections.Generic;
using System.Text;
using ClashOfClans.Interface;

namespace ClashOfClans.Implementation {
  class SwordAttack : IAttackType {
    public void Attack() {
      Console.WriteLine("You cannot escape from my Swords.");
    }
  }
}
